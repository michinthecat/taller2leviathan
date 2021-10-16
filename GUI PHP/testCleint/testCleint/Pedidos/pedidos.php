<?php


class pedidos {
   
    private $fecha; 
    private $guia; 
    private $idPedido; 
    private $precioEnvio; 
    private $precioImpuestos;
    
    public function __construct($fecha, $guia, $idPedido, $precioEnvio, $precioImpuestos) {
        $this->fecha = $fecha;
        $this->guia = $guia;
        $this->idPedido = $idPedido;
        $this->precioEnvio = $precioEnvio;
        $this->precioImpuestos = $precioImpuestos;
    }
    
    public function getFecha() {
        return $this->fecha;
    }

    public function getGuia() {
        return $this->guia;
    }

    public function getIdPedido() {
        return $this->idPedido;
    }

    public function getPrecioEnvio() {
        return $this->precioEnvio;
    }

    public function getPrecioImpuestos() {
        return $this->precioImpuestos;
    }

    public function setFecha($fecha): void {
        $this->fecha = $fecha;
    }

    public function setGuia($guia): void {
        $this->guia = $guia;
    }

    public function setIdPedido($idPedido): void {
        $this->idPedido = $idPedido;
    }

    public function setPrecioEnvio($precioEnvio): void {
        $this->precioEnvio = $precioEnvio;
    }

    public function setPrecioImpuestos($precioImpuestos): void {
        $this->precioImpuestos = $precioImpuestos;
    }



    
    
}
