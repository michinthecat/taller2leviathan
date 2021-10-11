/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package services;

import db.ConexionOracle;
import java.math.BigInteger;
import java.util.List;
import javax.persistence.EntityManager;
import javax.persistence.Query;
import model.Pedidos;
import model.Producto;
import model.ProductosPedidos;
import model.ProductosPedidosPK;

/**
 *
 * @author jeiss
 */
public class Servicio {
    
    private EntityManager getEntitymanager(){
        return ConexionOracle.getConexion().getFactory().createEntityManager();
    }
    
    public Servicio(){
        
    }
    
    public boolean crearProducto(Producto est){
        
        EntityManager em = getEntitymanager();
        
        try{
            em.getTransaction().begin();
            em.persist(est);
            em.getTransaction().commit();
            return true;
        }catch(Exception e){
            return false;
        }
    }
 
    public Producto buscarProductoPorId(Long idProducto){
        
        EntityManager em = getEntitymanager();
        Producto productoBuscado = null;
        try{
            productoBuscado = em.find(Producto.class, idProducto);
        }catch(Exception e){
            e.printStackTrace();
        }
        return productoBuscado;
    }
    
    public List<Producto> listarPorductos(){
        EntityManager em = getEntitymanager();
        Query consulta = em.createNamedQuery("Producto.findAll");
        List<Producto> productos = consulta.getResultList();
        return productos;
    }
    
    public List<Producto> listarProductosPorNombre(String nombre){
        EntityManager em = getEntitymanager();
        Query consulta = em.createQuery("SELECT p FROM Producto p WHERE p.nombre LIKE '%"+nombre+"%' ");
        List<Producto> productos = consulta.getResultList();
        return productos;
    }
    
    public boolean eliminarProductoPorId(Long idProducto){
        EntityManager em = getEntitymanager();
        Producto buscado = buscarProductoPorId(idProducto);
        try{
            em.getTransaction().begin();
            em.remove(em.merge(buscado));
            em.getTransaction().commit();
            return true;
        }catch(Exception e){
            return false;
        }
    }
    
    public boolean actualizarPrecioVentaProducto(Producto producto){
        EntityManager em = getEntitymanager();
        try{
            em.getTransaction().begin();
            em.merge(producto);
            em.getTransaction().commit();
            return true;
        }catch(Exception e){
            return false;
        }
    }
    
    //ordenes
    
    public boolean guardarProductosPedidos(ProductosPedidos productosPedidos){
        EntityManager em = getEntitymanager();
        try{
            em.getTransaction().begin();
            em.persist(productosPedidos);
            em.getTransaction().commit();
            return true;
        }catch(Exception ex){
            ex.printStackTrace();
            return false;
        }
    }
    
    public ProductosPedidos buscarProductosPedidos(Long idPedido, Long idProducto){
        EntityManager em = getEntitymanager();
        ProductosPedidos productoPedidoBuscado = null;
        try{
            ProductosPedidosPK clave = new ProductosPedidosPK();
            clave.setPedidosidPedido(BigInteger.valueOf(idPedido));
            clave.setProductoidProducto(idProducto);
            productoPedidoBuscado = em.find(ProductosPedidos.class, clave );
        }catch(Exception e){
            e.printStackTrace();
        }
        return productoPedidoBuscado;
    }
    
    public boolean eliminarProductoPedido(Long idPedido, Long idProducto){
        EntityManager em = getEntitymanager();
        ProductosPedidos productoPedidoBuscado = buscarProductosPedidos(idPedido, idProducto);
        try{
            em.getTransaction().begin();
            em.remove(em.merge(productoPedidoBuscado));
            em.getTransaction().commit();
            return true;
        }catch(Exception e){
            return false;
        }
    }
    
    public List<ProductosPedidos> listarOrdenes(){
        EntityManager em = getEntitymanager();
        Query consulta = em.createNamedQuery("ProductosPedidos.findAll");
        List<ProductosPedidos> productosPedidos = consulta.getResultList();
        return productosPedidos;
    }
    
    public boolean actualizarProductosPedidos(Long idPedido, Long idProducto, short cantidad){
        EntityManager em = getEntitymanager();
        ProductosPedidos productoPedidoBuscado = null;
        try{
            ProductosPedidosPK clave = new ProductosPedidosPK();
            clave.setPedidosidPedido(BigInteger.valueOf(idPedido));
            clave.setProductoidProducto(idProducto);
            productoPedidoBuscado = em.find(ProductosPedidos.class, clave );
            productoPedidoBuscado.setCantidad(cantidad);
            em.getTransaction().begin();
            em.merge(productoPedidoBuscado);
            em.getTransaction().commit();
            return true;
        }catch(Exception e){
            return false;
        }
    }
    
    
    
}
