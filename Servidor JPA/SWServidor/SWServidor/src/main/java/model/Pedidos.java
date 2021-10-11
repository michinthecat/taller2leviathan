/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

import java.io.Serializable;
import java.math.BigDecimal;
import java.util.Collection;
import java.util.Date;
import javax.persistence.Basic;
import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.OneToMany;
import javax.persistence.Table;
import javax.persistence.Temporal;
import javax.persistence.TemporalType;
import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

/**
 *
 * @author jeiss
 */
@Entity
@Table(name = "PEDIDOS")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Pedidos.findAll", query = "SELECT p FROM Pedidos p"),
    @NamedQuery(name = "Pedidos.findByIdPedido", query = "SELECT p FROM Pedidos p WHERE p.idPedido = :idPedido"),
    @NamedQuery(name = "Pedidos.findByFecha", query = "SELECT p FROM Pedidos p WHERE p.fecha = :fecha"),
    @NamedQuery(name = "Pedidos.findByPrecioEnvio", query = "SELECT p FROM Pedidos p WHERE p.precioEnvio = :precioEnvio"),
    @NamedQuery(name = "Pedidos.findByPrecioImpuestos", query = "SELECT p FROM Pedidos p WHERE p.precioImpuestos = :precioImpuestos"),
    @NamedQuery(name = "Pedidos.findByGuia", query = "SELECT p FROM Pedidos p WHERE p.guia = :guia")})
public class Pedidos implements Serializable {

    private static final long serialVersionUID = 1L;
    // @Max(value=?)  @Min(value=?)//if you know range of your decimal fields consider using these annotations to enforce field validation
    @Id
    @Basic(optional = false)
    @NotNull
    @Column(name = "ID_PEDIDO")
    private BigDecimal idPedido;
    @Basic(optional = false)
    @NotNull
    @Column(name = "FECHA")
    @Temporal(TemporalType.TIMESTAMP)
    private Date fecha;
    @Basic(optional = false)
    @NotNull
    @Column(name = "PRECIO_ENVIO")
    private long precioEnvio;
    @Basic(optional = false)
    @NotNull
    @Column(name = "PRECIO_IMPUESTOS")
    private long precioImpuestos;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 50)
    @Column(name = "GUIA")
    private String guia;
    @OneToMany(cascade = CascadeType.ALL, mappedBy = "pedidos")
    private Collection<ProductosPedidos> productosPedidosCollection;

    public Pedidos() {
    }

    public Pedidos(BigDecimal idPedido) {
        this.idPedido = idPedido;
    }

    public Pedidos(BigDecimal idPedido, Date fecha, long precioEnvio, long precioImpuestos, String guia) {
        this.idPedido = idPedido;
        this.fecha = fecha;
        this.precioEnvio = precioEnvio;
        this.precioImpuestos = precioImpuestos;
        this.guia = guia;
    }

    public BigDecimal getIdPedido() {
        return idPedido;
    }

    public void setIdPedido(BigDecimal idPedido) {
        this.idPedido = idPedido;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public long getPrecioEnvio() {
        return precioEnvio;
    }

    public void setPrecioEnvio(long precioEnvio) {
        this.precioEnvio = precioEnvio;
    }

    public long getPrecioImpuestos() {
        return precioImpuestos;
    }

    public void setPrecioImpuestos(long precioImpuestos) {
        this.precioImpuestos = precioImpuestos;
    }

    public String getGuia() {
        return guia;
    }

    public void setGuia(String guia) {
        this.guia = guia;
    }

    @XmlTransient
    public Collection<ProductosPedidos> getProductosPedidosCollection() {
        return productosPedidosCollection;
    }

    public void setProductosPedidosCollection(Collection<ProductosPedidos> productosPedidosCollection) {
        this.productosPedidosCollection = productosPedidosCollection;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (idPedido != null ? idPedido.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Pedidos)) {
            return false;
        }
        Pedidos other = (Pedidos) object;
        if ((this.idPedido == null && other.idPedido != null) || (this.idPedido != null && !this.idPedido.equals(other.idPedido))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "model.Pedidos[ idPedido=" + idPedido + " ]";
    }
    
}
