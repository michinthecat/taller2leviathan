<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Agregar Detalle</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"
              rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    </head>
    <body>  
        
        <?php
        require ("productosPedidosMapping.php");      
                            
               
        if(isset($_GET['ConsultarTest']))        
        {                    
              
              $pIdProducto = $_GET['InputProductoID'];
              $pIdPedido = $_GET['InputPedidoID'];  
              $pCantidad = $_GET['InputCantidad'];  
              $pPrecio = $_GET['InputPrecio'];
                             
             
            if(agregarDetalle($pIdProducto,$pIdPedido,$pPrecio,$pCantidad) == true)
            {
             $idProductor = "Se ha agregado Exitosamente el Detalle";   
            }
            else
            {
             $idProductor = "Hubo un error al agregar el Detalle";   
            }      
              
        }                  
        
        ?> 
        
        <br>  
        <div class="d-flex justify-content-center" style="width: 100%; background-color: rgba(0,0,255,.1)">   
        <label class="h1" ><a style="color: black;text-decoration: none" href="../index.php">Agregar Detalle</a></label>       
        </div>
        
        <br>  
        
<form action="agregarDetalle.php" method="get" align="center">
    
  <div class="input-group flex-nowrap">    
    <span class="input-group-text">ID Producto</span>    
    <input type="number" class="form-control" placeholder="Ingrese el ID PRODUCTO" name="InputProductoID" min="1" max="2000" required>
    <span class="input-group-text">ID Producto</span>    
    <input type="number" class="form-control" placeholder="Ingrese el ID PEDIDO" name="InputPedidoID" min="1" max="2000" required> 
    <span class="input-group-text">Cantidad</span>    
    <input type="number" class="form-control" placeholder="Ingrese el ID PRODUCTO" name="InputCantidad" min="1" max="500" required>
    <span class="input-group-text">Precio</span>    
    <input type="number" class="form-control" placeholder="Ingrese el ID PEDIDO" name="InputPrecio" min="1" max="2000" required>
    
    <br>
    <br>
  
  </div> 
    
    <br>
    
    
    <div class="input-group flex-nowrap">    
    <span class="input-group-text">Status</span>    
    <input type="text" class="form-control"  name="OutPutStatus" value = "<?php echo (isset($idProductor))?$idProductor:'';?>" readonly>
    </div>
     <br>
  
 <input type="submit" class="btn btn-primary" name="ConsultarTest" value="Agregar Detalle" >
 <br>
</form>      
        
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" 
integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
        
        
        
    </body>
</html>
