<?php

function consultarProductoPorID(int $pIdProducto)
        {           
           $soapClient = new SoapClient('http://localhost:8080/SWServidor/SWControlador?WSDL',["classmap" => ["producto" => producto::class]]);  
           $producto = $soapClient->obtenerProducto(["idProducto"=>$pIdProducto])->return;       
                
           return $producto;  
        }            
        
        
function agregarProducto(producto $pProducto) : bool
        {             
            $soapClient = new SoapClient('http://localhost:8080/SWServidor/SWControlador?WSDL');            
            $respuesta = $soapClient->guardarProducto(["producto"=>$pProducto])->return;
             
            if ($respuesta == 1)
            {
                return true;
            }
            else
            {
               return false; 
            }     
          
        }      
        
        
        
function eliminarProductoPorID(int $pID): bool
        {           
            $cliente = new SoapClient('http://localhost:8080/SWServidor/SWControlador?WSDL');      
            $eliminarP = $cliente->eliminarProductoPorId(["idProducto"=>$pID])->return;     
                       
            if ($eliminarP == 1)
            {
                 return true;
            }
            else
            {
               return false; 
            }         
        }
        
        
function actualizarProductoPorID(producto $pProducto): bool
        {                                   
            $soapClient = new SoapClient('http://localhost:8080/SWServidor/SWControlador?WSDL');                       
                                                    
            $respuesta = $soapClient->actualizarPrecioVentaProducto(["producto"=>$pProducto])->return;
            
             if ($respuesta == 1)
            {
                return true;
            }
            else
            {
               return false; 
            }     
            
        }
        

function consultarProductosPorNombre(string $pNombre)
        {                               
            $soapClient = new SoapClient('http://localhost:8080/SWServidor/SWControlador?WSDL',["classmap" => ["producto" => producto::class]]);    
            $respuesta = $soapClient->listarProductosPorNombre(["nombre"=>$pNombre])->return;
           
            return $respuesta;
        }
        
        
        
?>

