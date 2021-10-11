/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package services;

import java.math.BigInteger;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import model.Producto;
import model.ProductosPedidos;
import model.ProductosPedidosPK;

/**
 *
 * @author jeiss
 */
@WebService(serviceName = "SWControlador")
public class SWControlador {

    Servicio servicio = new Servicio();
    
    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "guardarProducto")
    public boolean guardarProducto(@WebParam(name = "producto") Producto producto) {
        return servicio.crearProducto(producto);
    }
    
    @WebMethod(operationName = "obtenerProducto")
    public Producto buscarProductoPorId(@WebParam(name = "idProducto") Long idProducto){
        return servicio.buscarProductoPorId(idProducto);
    }
    
    @WebMethod(operationName = "eliminarProductoPorId")
    public boolean eliminarProductoPorId(@WebParam(name = "idProducto") Long idProducto){
        return servicio.eliminarProductoPorId(idProducto);
    }
    
    
    @WebMethod(operationName = "listarProductosPorNombre")
    public List<Producto>  listarProductosPorNombre(String nombre){
        if (nombre.equals("")) {
            return servicio.listarPorductos();
        }else{
        return servicio.listarProductosPorNombre(nombre);
        }
    }
    
    @WebMethod(operationName = "actualizarPrecioVentaProducto")
    public boolean actualizarPrecioVentaProducto(@WebParam(name = "producto") Producto producto){
        return servicio.actualizarPrecioVentaProducto(producto);
    }
    
    //ordenes----------------------
    @WebMethod(operationName = "guardarProductoPedido")
    public boolean guardarProductosPedidos(@WebParam(name = "productoPedido") ProductosPedidos productosPedidos){
        return servicio.guardarProductosPedidos(productosPedidos);
    }
    
    @WebMethod(operationName = "buscarProductoPedido")
    public ProductosPedidos buscarProductosPedidos(@WebParam(name = "idPedido") Long idPedido, @WebParam(name = "idProducto") Long idProducto){        
        return servicio.buscarProductosPedidos(idPedido,idProducto);
    }
    
    @WebMethod(operationName = "eliminarOrdenPorId")
    public boolean eliminarOrdenPorId(@WebParam(name = "idPedido") Long idPedido, @WebParam(name = "idProducto") Long idProducto){
        return servicio.eliminarProductoPedido(idPedido, idProducto);
    }
    
    @WebMethod(operationName = "listarOrdenes")
    public List<ProductosPedidos> listarOrdenes(){
        return servicio.listarOrdenes();     
    }
    
    @WebMethod(operationName = "actualizarOrden")
    public boolean actualizarProductosPedidos(@WebParam(name = "idPedido") Long idPedido, @WebParam(name = "idProducto") Long idProducto, @WebParam(name = "cantidad") short cantidad){
        return servicio.actualizarProductosPedidos(idPedido,idProducto, cantidad);
    }
}
