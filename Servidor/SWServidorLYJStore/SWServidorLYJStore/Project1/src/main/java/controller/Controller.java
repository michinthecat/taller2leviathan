package controller;

import estructural.Orden;

import estructural.Producto;

import java.util.HashMap;
import java.util.List;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;

import servicess.ServicioOrden;

@WebService
public class Controller {
    
    ServicioOrden servicio = new ServicioOrden();
    
    @WebMethod
    public boolean guardarOrden(@WebParam(name="orden") Orden orden){
        return servicio.insertar(orden);
    }
    
    
    @WebMethod
    public boolean guardarProducto(@WebParam Producto producto){
        return servicio.insertarProducto(producto);    
    }
    
    @WebMethod
    public Producto obtenerProducto(@WebParam Integer id){
        return servicio.buscarProductoPorId(id);
    }
    
    @WebMethod
    public Orden obtenerOrden(@WebParam Integer idProducto, @WebParam Integer idPedido){
        return servicio.buscarOrdenPorIds(idProducto, idPedido);
    }
    
    @WebMethod
    public void actualizarPrecioVentaProducto(@WebParam Integer idProducto, @WebParam Producto producto){
        servicio.actualizarPrecioVentaProducto(idProducto, producto);
    }
    
    @WebMethod
    public void actualizarCatntidadOrden(@WebParam Integer idProducto,
                                         @WebParam Integer idPedido,@WebParam Orden orden){
        servicio.actualizarCatntidadOrden(idProducto, idPedido, orden);
    }
    
    @WebMethod
    public boolean eliminarOrdenPorId(@WebParam Integer idProducto, @WebParam Integer idPedido){
        return servicio.eliminarOrden(idProducto,idPedido);
    }
    
    @WebMethod
    public boolean eliminarProductoPorId(@WebParam(name = "pvta") Integer idProducto){
        return servicio.eliminarPorductoPorId(idProducto);
    }
    
    @WebMethod
    public List<Producto> listarProductosPorNombre(@WebParam String nombreProducto){
        return servicio.listarProductoPorNombres(nombreProducto);
    }
    
    @WebMethod
    public HashMap<Integer,Integer> listarPrecios(){
        return servicio.listarPrecios();
    }
    
       
    @WebMethod
    public List<Orden> listarOrdenesPorIdProducto(@WebParam String pProducto){
        return servicio.obtenerOrdenes(pProducto);
    }
    
}
