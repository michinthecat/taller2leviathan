<?php

class productosPedidosPK {
   
    private $pedidosidPedido; 
    private $productoidProducto;
    
    public function __construct($pedidosidPedido, $productoidProducto)
    {
        $this->pedidosidPedido = $pedidosidPedido;
        $this->productoidProducto = $productoidProducto;
    }
    
    public function getPedidosidPedido() {
        return $this->pedidosidPedido;
    }

    public function getProductoidProducto() {
        return $this->productoidProducto;
    }

    public function setPedidosidPedido($pedidosidPedido): void {
        $this->pedidosidPedido = $pedidosidPedido;
    }

    public function setProductoidProducto($productoidProducto): void {
        $this->productoidProducto = $productoidProducto;
    }



    
}
