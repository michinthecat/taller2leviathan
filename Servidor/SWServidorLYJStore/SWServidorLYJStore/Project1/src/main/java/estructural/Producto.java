package estructural;

import java.io.Serializable;

import java.util.ArrayList;
import java.util.List;

public class Producto implements Serializable {
    @SuppressWarnings("compatibility:7218494295295732225")
    private static final long serialVersionUID = 1L;

    private Integer idProducto;
    private String nombre;
    private Double precioVenta;
    private Long upc;
    private List<Orden> ordenes;

    public Producto() {
        ordenes = new ArrayList<>();
    }


    public Producto(Integer idProducto) {
        this.idProducto = idProducto;
    }

    public Producto(Integer idProducto, String nombre, Double precioVenta, Long upc) {
        this.idProducto = idProducto;
        this.nombre = nombre;
        this.precioVenta = precioVenta;
        this.upc = upc;
    }


    public void setIdProducto(Integer idProducto) {
        this.idProducto = idProducto;
    }

    public Integer getIdProducto() {
        return idProducto;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getNombre() {
        return nombre;
    }

    public void setPrecioVenta(Double precioVenta) {
        this.precioVenta = precioVenta;
    }

    public Double getPrecioVenta() {
        return precioVenta;
    }

    public void setUpc(Long upc) {
        this.upc = upc;
    }

    public Long getUpc() {
        return upc;
    }

    public void setOrdenes(List<Orden> ordenes) {
        this.ordenes = ordenes;
    }

    public List<Orden> getOrdenes() {
        return ordenes;
    }
}
