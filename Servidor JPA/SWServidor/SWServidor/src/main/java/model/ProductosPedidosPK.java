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
import javax.persistence.Embeddable;
import javax.validation.constraints.NotNull;

/**
 *
 * @author jeiss
 */
@Embeddable
public class ProductosPedidosPK implements Serializable {

    @Basic(optional = false)
    @NotNull
    @Column(name = "PRODUCTOID_PRODUCTO")
    private long productoidProducto;
    @Basic(optional = false)
    @NotNull
    @Column(name = "PEDIDOSID_PEDIDO")
    private long pedidosidPedido;

    public ProductosPedidosPK() {
    }

    public ProductosPedidosPK(long productoidProducto, long pedidosidPedido) {
        this.productoidProducto = productoidProducto;
        this.pedidosidPedido = pedidosidPedido;
    }

    public long getProductoidProducto() {
        return productoidProducto;
    }

    public void setProductoidProducto(long productoidProducto) {
        this.productoidProducto = productoidProducto;
    }

    public long getPedidosidPedido() {
        return pedidosidPedido;
    }

    public void setPedidosidPedido(long pedidosidPedido) {
        this.pedidosidPedido = pedidosidPedido;
    }

    @Override
    public int hashCode() {
        int hash = 7;
        return hash;
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (obj == null) {
            return false;
        }
        if (getClass() != obj.getClass()) {
            return false;
        }
        final ProductosPedidosPK other = (ProductosPedidosPK) obj;
        if (this.productoidProducto != other.productoidProducto) {
            return false;
        }
        if (this.pedidosidPedido != other.pedidosidPedido) {
            return false;
        }
        return true;
    }

    
    

    @Override
    public String toString() {
        return "model.ProductosPedidosPK[ productoidProducto=" + productoidProducto + ", pedidosidPedido=" + pedidosidPedido + " ]";
    }
    
}
