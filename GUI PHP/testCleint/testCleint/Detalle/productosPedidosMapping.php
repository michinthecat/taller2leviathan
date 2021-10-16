<?php


require '../Detalle/productosPedidos.php';
require '../Pedidos/pedidos.php';
require '../Producto/producto.php';
require '../ProductosPedidosPK/productosPedidosPK.php';

function listarDetallesPorID(string $pIdProducto)
        {                                                   
            $soapClient = new SoapClient('http://localhost:8080/SWServidor/SWControlador?WSDL',["classmap" =>[
                   "productosPedidos" => productosPedidos::class,
                   "pedidos" => pedidos::class,
                   "producto" => producto::class,
                   "productosPedidosPK" => productosPedidosPK::class
               ]]);  
            
            //Comprobacion de campo vacio para retornar todas las ordenes          
            If($pIdProducto == "")
            {
                $respuesta = $soapClient->listarOrdenes()->return; 
            }
            else
            {
              $respuesta = $soapClient->listarOrdenesPorIdProducto(["idProducto"=>$pIdProducto])->return;    
            }
            
            
            
            return $respuesta;      
        }

function consultarDetallePorID(int $idPedido, int $idProducto)
        {           
               $soapClient = new SoapClient('http://localhost:8080/SWServidor/SWControlador?WSDL',["classmap" =>[
                   "productosPedidos" => productosPedidos::class,
                   "pedidos" => pedidos::class,
                   "producto" => producto::class,
                   "productosPedidosPK" => productosPedidosPK::class
               ]]);   
               $detalle = $soapClient->buscarProductoPedido(["idPedido"=>$idPedido, "idProducto"=>$idProducto])->return;       
                    
           return $detalle;
        }  
        
function agregarDetalle(int $pIdProducto, int $pIdPedido, int $pPrecio, int $pCantidad, $pFecha): bool
{          
    
            $idPK = new productosPedidosPK($pIdPedido, $pIdProducto);                                          
                                                       
            $soapClient = new SoapClient('http://localhost:8080/SWServidor/SWControlador?WSDL');            
           
            $params =array('productosPedidosPK'=>$idPK, 'cantidad'=>$pCantidad, 'precio'=>$pPrecio, 'fecha'=>$pFecha);                      

            $respuesta = $soapClient->guardarProductoPedido(["productoPedido"=>$params])->return;
                              
            if ($respuesta == 1)
            {
                return true;
            }
            else
            {
               return false; 
            }     

}

function eliminarDetalle(int $idPedido, int $idProducto): bool
{
            $Soapcliente = new SoapClient('http://localhost:8080/SWServidor/SWControlador?WSDL');      
            $eliminarP = $Soapcliente->eliminarOrdenPorId(["idPedido"=>$idPedido,"idProducto"=>$idProducto])->return;     
                       
            if ($eliminarP == 1)
            {
                 return true;
            }
            else
            {
               return false; 
            }      
}

function actualizarDetalle (int $pIdPedido, int $PIdProducto, int $pCantidad):bool
{
            $Soapcliente = new SoapClient('http://localhost:8080/SWServidor/SWControlador?WSDL');      
            $eliminarP = $Soapcliente->actualizarOrden(["idPedido"=>$pIdPedido,"idProducto"=>$PIdProducto,"cantidad"=>$pCantidad])->return;     
                       
            if ($eliminarP == 1)
            {
                 return true;
            }
            else
            {
               return false; 
            }      
}




