/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

import java.io.Serializable;
import java.math.BigInteger;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.EmbeddedId;
import javax.persistence.Entity;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.validation.constraints.NotNull;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author jeiss
 */
@Entity
@Table(name = "PRODUCTOS_PEDIDOS")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "ProductosPedidos.findAll", query = "SELECT p FROM ProductosPedidos p"),
    @NamedQuery(name = "ProductosPedidos.findByProductoidProducto", query = "SELECT p FROM ProductosPedidos p WHERE p.productosPedidosPK.productoidProducto = :productoidProducto"),
    @NamedQuery(name = "ProductosPedidos.findByPedidosidPedido", query = "SELECT p FROM ProductosPedidos p WHERE p.productosPedidosPK.pedidosidPedido = :pedidosidPedido"),
    @NamedQuery(name = "ProductosPedidos.findByCantidad", query = "SELECT p FROM ProductosPedidos p WHERE p.cantidad = :cantidad"),
    @NamedQuery(name = "ProductosPedidos.findByPrecio", query = "SELECT p FROM ProductosPedidos p WHERE p.precio = :precio")})
public class ProductosPedidos implements Serializable {

    private static final long serialVersionUID = 1L;
    @EmbeddedId
    private ProductosPedidosPK productosPedidosPK;
    @Basic(optional = false)
    @NotNull
    @Column(name = "CANTIDAD")
    private short cantidad;
    @Basic(optional = false)
    @NotNull
    @Column(name = "PRECIO")
    private BigInteger precio;
    @JoinColumn(name = "PEDIDOSID_PEDIDO", referencedColumnName = "ID_PEDIDO", insertable = false, updatable = false)
    @ManyToOne(optional = false)
    private Pedidos pedidos;
    @JoinColumn(name = "PRODUCTOID_PRODUCTO", referencedColumnName = "ID_PRODUCTO", insertable = false, updatable = false)
    @ManyToOne(optional = false)
    private Producto producto;

    

    public ProductosPedidos(ProductosPedidosPK productosPedidosPK, short cantidad, BigInteger precio, Pedidos pedidos, Producto producto)
    {
        this.productosPedidosPK = productosPedidosPK;
        this.cantidad = cantidad;
        this.precio = precio;
        this.pedidos = pedidos;
        this.producto = producto;
    }
    
    public ProductosPedidos() {
    }

    public ProductosPedidos(ProductosPedidosPK productosPedidosPK) {
        this.productosPedidosPK = productosPedidosPK;
    }

    public ProductosPedidos(Pedidos pedidos, Producto producto,short cantidad, BigInteger precio) {
        this.cantidad = cantidad;
        this.precio = precio;
        this.pedidos = pedidos;
        this.producto = producto;
    }
   
    public ProductosPedidos(ProductosPedidosPK productosPedidosPK, short cantidad, BigInteger precio) {
        this.productosPedidosPK = productosPedidosPK;
        this.cantidad = cantidad;
        this.precio = precio;
    }

    public ProductosPedidos(long productoidProducto, BigInteger pedidosidPedido) {
        this.productosPedidosPK = new ProductosPedidosPK(productoidProducto, pedidosidPedido);
    }

    public ProductosPedidosPK getProductosPedidosPK() {
        return productosPedidosPK;
    }

    public void setProductosPedidosPK(ProductosPedidosPK productosPedidosPK) {
        this.productosPedidosPK = productosPedidosPK;
    }

    public short getCantidad() {
        return cantidad;
    }

    public void setCantidad(short cantidad) {
        this.cantidad = cantidad;
    }

    public BigInteger getPrecio() {
        return precio;
    }

    public void setPrecio(BigInteger precio) {
        this.precio = precio;
    }

    public Pedidos getPedidos() {
        return pedidos;
    }

    public void setPedidos(Pedidos pedidos) {
        this.pedidos = pedidos;
    }

    public Producto getProducto() {
        return producto;
    }

    public void setProducto(Producto producto) {
        this.producto = producto;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (productosPedidosPK != null ? productosPedidosPK.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof ProductosPedidos)) {
            return false;
        }
        ProductosPedidos other = (ProductosPedidos) object;
        if ((this.productosPedidosPK == null && other.productosPedidosPK != null) || (this.productosPedidosPK != null && !this.productosPedidosPK.equals(other.productosPedidosPK))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "model.ProductosPedidos[ productosPedidosPK=" + productosPedidosPK + " ]";
    }
    
}
