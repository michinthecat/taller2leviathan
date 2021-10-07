package servicess;

import dbpack.ConexionOracle;

import estructural.Orden;

import estructural.Producto;

import java.sql.ResultSet;

import java.sql.SQLException;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class ServicioOrden {
    ResultSet resultSet;
    ConexionOracle bd = new ConexionOracle();

    public ServicioOrden() {
    }

    public boolean insertar(Orden orden) {   
        String queryOrden =
            "INSERT INTO productos_pedidos VALUES (" + orden.getProducto().getIdProducto() + "," + orden.getPedidoId() +
            "," + orden.getCantidad() + "," + orden.getPrecio() + ")";
        try {
            bd.executeUpdateStatement(queryOrden);
            return true;
        } catch (Exception ex) {
            ex.printStackTrace();
            return false;
        }
    }

    public boolean insertarProducto(Producto producto){
        String queryProducto =
            "INSERT INTO producto VALUES (" + producto.getIdProducto() + ",'" +
            producto.getNombre() + "'," + producto.getPrecioVenta() + "," +
            producto.getUpc() + ")";
        try{
            bd.executeUpdateStatement(queryProducto);
            return true;
        }catch(Exception ez){
            ez.printStackTrace();
            return false;
        }
    }

    public void actualizarPrecioVentaProducto(Number idProducto, Producto producto_actualizar) {
        String queryProducto =
            "update producto set precio_venta= " + producto_actualizar.getPrecioVenta() + " where id_producto = " +
            idProducto + " ";
        try {
            bd.executeUpdateStatement(queryProducto);
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }
    
    public void actualizarCatntidadOrden(Integer idProducto, Integer idPedido, Orden orden){
        String queryOrden = "update productos_pedidos set cantidad = "+orden.getCantidad() +" where productoid_producto = "+idProducto+ " and pedidosid_pedido = "+idPedido;
        try {
            bd.executeUpdateStatement(queryOrden);
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }


    public Producto buscarProductoPorId(Integer idProducto) {
        String queryProducto = "SELECT * FROM producto WHERE id_producto = " + idProducto;
        Producto producto = new Producto();
        List<Orden> ordenes = obtenerOrdenes(idProducto.toString());
        producto.setIdProducto(idProducto);
        producto.setOrdenes(ordenes);


        try {
            resultSet = bd.executeQueryStatement(queryProducto);
            while (resultSet.next()) {
                producto.setNombre(resultSet.getString(2));
                producto.setPrecioVenta(resultSet.getDouble(3));
                producto.setUpc(resultSet.getLong(4));
            }


        } catch (Exception ex) {
            ex.printStackTrace();
        }
        return producto;
    }

    public Orden buscarOrdenPorIds(Integer idProducto,Integer idPedido){
        String queryOrden = "select * from productos_pedidos where productoid_producto = "+idProducto+" and pedidosid_pedido = "+idPedido+"";
        Orden ordenBuscada = new Orden();
        ordenBuscada.setProducto(buscarProductoPorId(idProducto));
        try{
            resultSet = bd.executeQueryStatement(queryOrden);
            while (resultSet.next()){
                ordenBuscada.setPedidoId(resultSet.getInt(2));
                ordenBuscada.setCantidad(resultSet.getInt(3));
                ordenBuscada.setPrecio(resultSet.getDouble(4));
            }
        }catch(Exception ez){
            ez.printStackTrace();
        }
        return ordenBuscada;
    }

    public List<Orden> obtenerOrdenes(String idProducto) {
    String queryOrdenSeleccionada;
    if(idProducto.equals(""))
        {
            queryOrdenSeleccionada = "SELECT * FROM productos_pedidos";
        }
        else
        {
            queryOrdenSeleccionada = "SELECT * FROM productos_pedidos WHERE productoid_producto=" + idProducto;
        }
        
        List<Orden> ordenes = new ArrayList();
        try {
            resultSet = bd.executeQueryStatement(queryOrdenSeleccionada);
            while (resultSet.next()) {
                ordenes.add(new Orden(resultSet.getInt(2),new Producto(resultSet.getInt(1)), resultSet.getInt(3), resultSet.getDouble(4)));
            }

        } catch (Exception e) {
            e.printStackTrace();
        }

        System.out.println(ordenes.size());

        return ordenes;
    }


    public boolean eliminarOrden(Integer idProducto,Integer idPedido) {
        String queryOrden = "delete from productos_pedidos where productoid_producto = " + idProducto +" and pedidosid_pedido = "+idPedido;
        try {
            bd.executeUpdateStatement(queryOrden);
            return true;
        } catch (Exception ex) {
            ex.printStackTrace();
            return false;
        }
    }
    
    public boolean eliminarPorductoPorId(Integer id){
        String queryProducto = "delete from producto where id_producto = " + id;
        try {
            bd.executeUpdateStatement(queryProducto);
            return true;
        } catch (Exception ex) {
            ex.printStackTrace();
            return false;
        }
    }

    public List<Producto> listarProductoPorNombres(String nombreProducto) {
        String queryProducto = "select * from producto where upper(nombre) like( upper('%" + nombreProducto + "%'))";
        List<Producto> productos = new ArrayList<>();

        try {
            resultSet = bd.executeQueryStatement(queryProducto);
            while (resultSet.next()) {
                productos.add(new Producto(resultSet.getInt(1), resultSet.getString(2), resultSet.getDouble(3),
                                           resultSet.getLong(4)));
            }
        } catch (Exception ex) {
            ex.printStackTrace();
        }

        return productos;
    }
    
    public HashMap<Integer,Integer> listarPrecios(){
        String query = "select precio, count(*) as cantidad from productos_pedidos  group by precio";
        HashMap<Integer, Integer> nuevaLista = new HashMap<Integer, Integer>();
        try{
                    resultSet = bd.executeQueryStatement(query);
                    while (resultSet.next()){
                        nuevaLista.put(resultSet.getInt("precio"), resultSet.getInt("cantidad"));
                        
                    }
                }catch(SQLException ex){
                    System.out.println("error");
                }
                return nuevaLista;
    }
    
   
    
}
