<html>
    <head>
        <meta charset="UTF-8">
        <title>Adicionar Producto Por ID</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"
              rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    </head>
    <body>  
        
        <?php        
        
        require ("productoMapping.php");
        require ("producto.php");            
                            
               
        if(isset($_GET['AdicionarButton']))        
        {             
            $ProductoNuevo = new producto($_GET['nameInputID'], $_GET['nameInputNombre'], $_GET['nameinputPrecio'], $_GET['nameInputUpc']);
             
            
            if(agregarProducto($ProductoNuevo) == true)
            {
             $idProductor = "Se ha agregado Exitosamente el Producto";   
            }
            else
            {
                $idProductor = "Hubo un error al agregar el Producto";   
            }               
        }                  
        
        
        
        ?>  
        
<br>   

<div class="d-flex justify-content-center" style="width: 100%; background-color: rgba(0,0,255,.1)">   
        <label class="h1" ><a style="color: black;text-decoration: none" href="../index.php">Adicionar Producto</a></label>       
</div>

<br>

 <form action="adicionarProducto.php" method="get" align="center">  
     
 <div class="input-group mb-3">       
  <span class="input-group-text" id="inputGroup-sizing-default">ID</span>  
  <input  type="number" class="form-control"  name="nameInputID" value = "">
</div>
 
 <div class="input-group mb-3">
  <span class="input-group-text" id="inputGroup-sizing-default">Nombre Producto</span>  
  <input type="text" class="form-control"  name="nameInputNombre" value = "">
</div> 
 
 <div class="input-group mb-3">
  <span class="input-group-text" id="inputGroup-sizing-default">Precio</span>  
  <input type="number" class="form-control"  name="nameinputPrecio" value = "">
</div> 
 
 <div class="input-group mb-3">
  <span class="input-group-text" id="inputGroup-sizing-default">UPC</span>  
  <input type="number" class="form-control"  name="nameInputUpc" value = "">
</div> 
 
 <br>
 
<div class="input-group mb-3">
  <span class="input-group-text" id="inputGroup-sizing-default">Status</span>  
   <input  type="text" class="form-control"  name="statusOutput" readonly value = "<?php echo (isset($idProductor))?$idProductor:'';?>">
</div>
 
 
 <br>
 <input type="submit" class="btn btn-primary" name="AdicionarButton" value="Adicionar Producto">
 <br>
 <br>        
</form>                     
      
         
        
      
        

        
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" 
integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
        
        
        
    </body>
</html>