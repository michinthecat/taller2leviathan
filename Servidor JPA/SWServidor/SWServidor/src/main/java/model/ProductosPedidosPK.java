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
    private BigInteger pedidosidPedido;

    public ProductosPedidosPK() {
    }

    public ProductosPedidosPK(long productoidProducto, BigInteger pedidosidPedido) {
        this.productoidProducto = productoidProducto;
        this.pedidosidPedido = pedidosidPedido;
    }

    public long getProductoidProducto() {
        return productoidProducto;
    }

    public void setProductoidProducto(long productoidProducto) {
        this.productoidProducto = productoidProducto;
    }

    public BigInteger getPedidosidPedido() {
        return pedidosidPedido;
    }

    public void setPedidosidPedido(BigInteger pedidosidPedido) {
        this.pedidosidPedido = pedidosidPedido;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (int) productoidProducto;
        hash += (pedidosidPedido != null ? pedidosidPedido.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof ProductosPedidosPK)) {
            return false;
        }
        ProductosPedidosPK other = (ProductosPedidosPK) object;
        if (this.productoidProducto != other.productoidProducto) {
            return false;
        }
        if ((this.pedidosidPedido == null && other.pedidosidPedido != null) || (this.pedidosidPedido != null && !this.pedidosidPedido.equals(other.pedidosidPedido))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "model.ProductosPedidosPK[ productoidProducto=" + productoidProducto + ", pedidosidPedido=" + pedidosidPedido + " ]";
    }
    
}
