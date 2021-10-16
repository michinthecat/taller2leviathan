<!DOCTYPE html>

<html>
    <head>
        <meta charset="UTF-8">
        <title>Actualizar Producto</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"
              rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    </head>
    <body>  
        
        <?php
        
        
        require ("productoMapping.php");
        require ("producto.php");            
                            
               
        if(isset($_GET['ConsultarTest']))        
        {               
            $ProductoR = consultarProductoPorID($_GET['nameInputID']);         
            //aca va un metodo uwu
            $varID = $ProductoR->getIdProducto();
            $varNombre = $ProductoR->getNombre();            
            $varPrecio = $ProductoR->getPrecioVenta();
            $varUpc = $ProductoR->getUpc();  
            $idProductor = $ProductoR->getIdProducto();        
                                      
        }           
        
        if(isset($_GET['updateButton']))        
        {               
            $ProductoEditar = new producto($_GET['nameOutputID'], $_GET['nameOutputNombre'], $_GET['nameInputPrecio'], $_GET['nameOutputUpc']);         
            
            actualizarProductoPorID($ProductoEditar);         
           
        }     
        
        
        ?>        
        <br>  
        <div class="d-flex justify-content-center" style="width: 100%; background-color: rgba(0,0,255,.1)">   
        <label class="h1" ><a style="color: black;text-decoration: none" href="../index.php">Actualizar Producto</a></label>       
        </div>
        
<br>           
<form action="actualizarProducto.php" method="get" align="center">
  <div class="input-group flex-nowrap">
    <span class="input-group-text" id="addon-wrapping">ID</span>
    
    <input type="number" class="form-control" placeholder="Ingrese el ID PRODUCTO" value = "<?php echo (isset($idProductor))?$idProductor:'';?>"  name="nameInputID" min="1" max="500" required>    
    
  </div>
    <br>
    
 <input type="submit" class="btn btn-primary" name="ConsultarTest" value="Consultar Producto">
 <br>
 <br>
 
 <div class="input-group mb-3">       
  <span class="input-group-text" id="inputGroup-sizing-default">ID</span>  
  <input  type="text" class="form-control"  name="nameOutputID" value = "<?php echo (isset($varID))?$varID :'';?>" readonly>
</div>
 
 <div class="input-group mb-3">
  <span class="input-group-text" id="inputGroup-sizing-default">Nombre Producto</span>  
  <input type="text" class="form-control"  name="nameOutputNombre" value = "<?php echo (isset($varNombre))?$varNombre:'';?>" readonly>
</div> 
 
 <div class="input-group mb-3">
  <span class="input-group-text" id="inputGroup-sizing-default">Precio</span>  
  <input type="text" class="form-control"  name="nameOutputPrecio" value = "<?php echo (isset($varPrecio))?$varPrecio:'';?>" readonly>
</div> 
 
 <div class="input-group mb-3">
  <span class="input-group-text" id="inputGroup-sizing-default">UPC</span>  
  <input type="text" class="form-control"  name="nameOutputUpc" value = "<?php echo (isset($varUpc))?$varUpc:'';?>" readonly>
</div> 
 
 <br>
 
  <br>  
        <div class="d-flex justify-content-center" style="width: 100%; background-color: rgba(0,0,255,.1)">   
        <label class="h3" >Ingrese el nuevo Precio del Producto</label>       
        </div>
  
  <br>  
  
    <div class="input-group mb-3">       
  <span class="input-group-text" id="inputGroup-sizing-default">Nuevo Precio</span>  
  <input  type="number" class="form-control"  name="nameInputPrecio" value = "">
</div>
  
   <br>  
  
  <input type="submit" class="btn btn-primary" name="updateButton" value="Actualizar Producto">
    
</form>


      
         
        
      
        

        
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" 
integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
        
        
        
    </body>
</html>
