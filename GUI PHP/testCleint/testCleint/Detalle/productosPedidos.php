<?php

class productosPedidos {
    
    private $cantidad;
    private pedidos $pedidos;
    private $precio;
    private producto $producto;
    private productosPedidosPK $productosPedidosPK;
    
        
    public function __construct($pCantidad, pedidos $pPedidos, $pPrecio, producto $pProducto, productosPedidosPK $pProductosPedidosPK)
    {
        $this->cantidad = $pCantidad;
        $this->pedidos = $pPedidos;
        $this->precio = $pPrecio;
        $this->producto = $pProducto;
        $this->productosPedidosPK = $pProductosPedidosPK;       
    }
    
    public function getCantidad() {
        return $this->cantidad;
    }

    public function getPedidos(): pedidos {
        return $this->pedidos;
    }

    public function getPrecio() {
        return $this->precio;
    }

    public function getProducto() {
        return $this->producto;
    }

    public function getProductosPedidosPK(): productosPedidosPK {
        return $this->productosPedidosPK;
    }

    public function setCantidad($cantidad): void {
        $this->cantidad = $cantidad;
    }

    public function setPedidos(pedidos $pedidos): void {
        $this->pedidos = $pedidos;
    }

    public function setPrecio($precio): void {
        $this->precio = $precio;
    }

    public function setProducto(producto $producto): void {
        $this->producto = $producto;
    }

    public function setProductosPedidosPK(productosPedidosPK $productosPedidosPK): void {
        $this->productosPedidosPK = $productosPedidosPK;
    }


}
