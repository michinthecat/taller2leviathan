<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Consultar Detalle</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"
              rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    </head>
    <body>  
        
        <?php
        require ("productosPedidosMapping.php");      
                            
               
        if(isset($_GET['ConsultarTest']))        
        {                    
              
              $ProductoR = consultarDetallePorID($_GET['InputPedidoID'],$_GET['InputProductoID']);                           
          
              $varProductoID = $ProductoR->getProductosPedidosPK()->getProductoidProducto(); //." = Nombre del Producto: ". $ProductoR->getProducto()->getNombre();
              $varPedidoID = $ProductoR->getProductosPedidosPK()->getPedidosidPedido() ; //." = Comprado el: ". $ProductoR->getPedidos()->getFecha() ;        
              $varCantidad = $ProductoR->getCantidad();
              $varPrecio = $ProductoR->getPrecio();   
              
        }                  
        
        ?> 
        
        <br>  
        <div class="d-flex justify-content-center" style="width: 100%; background-color: rgba(0,0,255,.1)">   
        <label class="h1"><a style="color: black;text-decoration: none" href="../index.php">Consultar Detalle</a></label>       
        </div>
        
        <br>           
<form action="consultarDetalle.php" method="get" align="center">
    
  <div class="input-group flex-nowrap">    
    <span class="input-group-text">ID Producto</span>    
    <input type="number" class="form-control" placeholder="Ingrese el ID PRODUCTO" name="InputProductoID" min="1" max="2000" required>
    <span class="input-group-text">ID Pedido</span>    
    <input type="number" class="form-control" placeholder="Ingrese el ID PEDIDO" name="InputPedidoID" min="1" max="500" required>    
  </div>
    
  
    <br>
    
 <input type="submit" class="btn btn-primary" name="ConsultarTest" value="Consultar Detalle">
 <br>
 <br>
 
 <div class="input-group mb-3">       
  <span class="input-group-text" id="inputGroup-sizing-default">ID Producto</span>  
  <input  type="text" class="form-control"  name="nameOutputIDProducto" value = "<?php echo (isset($varProductoID))?$varProductoID :'';?>" readonly>
</div>
 
 <div class="input-group mb-3">
  <span class="input-group-text" id="inputGroup-sizing-default">ID Pedido</span>  
  <input type="text" class="form-control"  name="nameOutputIDPedido" value = "<?php echo (isset($varPedidoID))?$varPedidoID:'';?>" readonly>
</div> 
 
 <div class="input-group mb-3">
  <span class="input-group-text" id="inputGroup-sizing-default">Cantidad</span>  
  <input type="number" class="form-control"  name="nameOutputCantidad" value = "<?php echo (isset($varCantidad))?$varCantidad:'';?>" readonly>
</div> 
 
 <div class="input-group mb-3">
  <span class="input-group-text" id="inputGroup-sizing-default">Precio</span>  
  <input type="number" class="form-control"  name="nameOutputPrecio" value = "<?php echo (isset($varPrecio))?$varPrecio:'';?>" readonly>
</div> 
 
 <br>
 
  
    
    
</form>                     
      
         
        
      
        

        
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" 
integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
        
        
        
    </body>
</html>