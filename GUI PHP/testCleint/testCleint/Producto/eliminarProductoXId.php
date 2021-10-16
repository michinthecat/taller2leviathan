<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Eliminar Producto Por ID</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"
              rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    </head>
    <body>
        
        <?php
        
        //Invocamos los archivos PHP necesarios
        require ("productoMapping.php");
        require ("producto.php");   
               
           
        if(isset($_GET['ConsultarTest']))        
        {     
            $ProductoR = consultarProductoPorID($_GET['idProducto']);   
            $result = $ProductoR->getNombre();
            $resultID = $ProductoR->getIdProducto();
            $idProductor = $ProductoR->getIdProducto();  
            $idStatus = "Producto En DB Actualmente";
                      
        }
        
        if(isset($_GET['EliminacionClick']))        
        {     
            if(eliminarProductoPorID($_GET['resultID']) == true)
            {
                $idStatus = "Se ha Eliminado Exitosamente el Producto";   
            }
            else
            {
                $idStatus = "Hubo un error al eliminar el Producto";   
            }                
        }
           
        
        ?> 
        
<br>  
<div class="d-flex justify-content-center" style="width: 100%; background-color: rgba(0,0,255,.1)">   
<label class="h1" ><a style="color: black;text-decoration: none" href="../index.php">Eliminar Producto</a></label>       
</div>
        
<br>           
<form action="eliminarProductoXId.php" method="get" align="center">
  <div class="input-group flex-nowrap">
    <span class="input-group-text" id="addon-wrapping">ID</span>
    
    <input type="number" class="form-control" placeholder="Ingrese el ID PRODUCTO" value = "<?php echo (isset($idProductor))?$idProductor:'';?>" name="idProducto" min="1" max="1000" required>    
    
  </div>
    <br>
    
 <input type="submit" class="btn btn-primary" name="ConsultarTest" value="Consultar Producto">
 <br>
 <br>
 
 <div class="input-group mb-3">
  <span class="input-group-text" id="inputGroup-sizing-default">ID</span>  
  <input type="text" class="form-control"  name="resultID" value = "<?php echo (isset($resultID))?$resultID:'';?>" readonly>
</div>
 
 <div class="input-group mb-3">
  <span class="input-group-text" id="inputGroup-sizing-default">Nombre Producto</span>  
  <input type="text" class="form-control"  name="result" value = "<?php echo (isset($result))?$result:'';?>" readonly>
</div>
 
 <div class="input-group mb-3">
  <span class="input-group-text" id="inputGroup-sizing-default">Status</span>  
  <input type="text" class="form-control"  name="status" value ="<?php echo (isset($idStatus))?$idStatus:'';?>" readonly>
</div>
 
 
 
 
 <input type="submit" class="btn btn-danger" name="EliminacionClick" value="Eliminar Producto">
 <br>
 
  
    
    
</form>                     
      
         
        
      
        

        
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" 
integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
        
        
        
    </body>
</html>
