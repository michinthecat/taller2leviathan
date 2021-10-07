package estructural;

import com.oracle.xmlns.internal.webservices.jaxws_databinding.XmlWebParam;

import javax.jws.WebParam;

public class Orden {
    
    private Integer pedidoId;
    private Producto producto;
    private Integer cantidad;
    private Double Precio;

    public Orden(){
        
    }


    public Orden(Integer pedidoId, Integer cantidad, Double Precio) {
        this.pedidoId = pedidoId;
        this.cantidad = cantidad;
        this.Precio = Precio;
    }

    public Orden(Integer pedidoId, Producto producto, Integer cantidad, Double Precio) {
        this.pedidoId = pedidoId;
        this.producto = producto;
        this.cantidad = cantidad;
        this.Precio = Precio;
    }



    public void setPedidoId(Integer pedidoId) {
        this.pedidoId = pedidoId;
    }

    public Integer getPedidoId() {
        return pedidoId;
    }

    public void setProducto(Producto producto) {
        this.producto = producto;
    }

    public Producto getProducto() {
        return producto;
    }

    public void setCantidad(Integer cantidad) {
        this.cantidad = cantidad;
    }

    public Integer getCantidad() {
        return cantidad;
    }

    public void setPrecio(Double Precio) {
        this.Precio = Precio;
    }

    public Double getPrecio() {
        return Precio;
    }

}
