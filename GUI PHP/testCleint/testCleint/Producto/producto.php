<?php

class producto {
    
    private $idProducto;
    private $nombre;
    private $precioVenta;
    private $upc;
    
        
    public function __construct($pID, $pNombre, $pPrecioVenta, $pUpc)
    {
        $this->idProducto = $pID;
        $this->nombre = $pNombre;
        $this->precioVenta = $pPrecioVenta;
        $this->upc = $pUpc;
        
    }
    
    public function getIdProducto()
    {
        return $this->idProducto;
       
    }
    
     public function setIdProducto(int $pID)
    {
        $this->idProducto = $pID;
    }
    
    public function getNombre()
    {
       return $this->nombre;
    }
    
     public function setNombre(string $pNombre)
    {
        $this->nombre = $pNombre;
    }
    
    public function getPrecioVenta()
    {
        return $this->precioVenta;
    }
    
     public function setPrecioVenta(int $precioVenta)
    {
        $this->precioVenta = $precioVenta;
    }
    
    public function getUpc()
    {
       return $this->upc;
    }
    
     public function setUpc(int $pUpc)
    {
        $this->upc = $pUpc;
    }
        
    
    
    
}
