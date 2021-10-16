<!DOCTYPE html>

<html>
    <head>
        <meta charset="UTF-8">
        <title>Listar Productos Por Nombre</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"
              rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    </head>
    <body>  
        <br>  
        <div class="d-flex justify-content-center" style="width: 100%; background-color: rgba(0,0,255,.1)">   
        <label class="h1" ><a style="color: black;text-decoration: none" href="../index.php">Listar Productos Por Nombre</a></label>       
        </div>
        
<br>           
<form action="listarProductoPorNombre.php" method="get" align="center">
  <div class="input-group flex-nowrap">
    <span class="input-group-text" id="addon-wrapping">NOMBRE</span>
    
    <input type="text" class="form-control" placeholder="Ingrese el Nombre Del Producto" value = "" name="nameInputNombre">    
    
  </div>
    <br>
    
 <input type="submit" class="btn btn-primary" name="ConsultarTest" value="Consultar Productos">
 
    
    
</form>     

<br>
 <?php
 
        require ("productoMapping.php");
        require ("producto.php");            
                            
               
       if(isset($_GET['ConsultarTest']))        
        {               
            $ProductoR = consultarProductosPorNombre($_GET['nameInputNombre']);
                                 
            if(is_array($ProductoR))
            {
            echo "<table class="."table table-striped"."><tr>";
            echo "<th> ID </th>"
               . "<th> Nombre </th>"
               . "<th> Precio </th>"
               . "<th> UPC </th>";
            echo "</tr>";

            foreach ($ProductoR as $k => $cur)
            {
                echo "<tr>";
                echo "<td>" . $cur->getIdProducto() . "</td>";
                echo "<td>" . $cur->getNombre() . "</td>";
                echo "<td>" . $cur->getPrecioVenta() . "</td>";
                echo "<td>" . $cur->getUpc() . "</td>";
                echo "</tr>";
            }
            echo "</table>";  
            }
            
            else
                {
                echo "<table class="."table table-striped"."><tr>";
                echo "<th> ID </th>"
                 . "<th> Nombre </th>"
                 . "<th> Precio </th>"
                 . "<th> UPC </th>";
                echo "</tr>";            
            
                 echo "<tr>";
                 echo "<td>" . $ProductoR->getIdProducto() . "</td>";
                 echo "<td>" . $ProductoR->getNombre() . "</td>";
                 echo "<td>" . $ProductoR->getPrecioVenta() . "</td>";
                 echo "<td>" . $ProductoR->getUpc() . "</td>";
                 echo "</tr>";
                
                 echo "</table>";
                }
            }     

 ?>
   
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" 
integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
        
        
        
    </body>
</html>
