<!DOCTYPE html>

<html>
    <head>
        <meta charset="UTF-8">
        <title>Listar Detalles</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"
              rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    </head>
    <body>  
        <br>  
        <div class="d-flex justify-content-center" style="width: 100%; background-color: rgba(0,0,255,.1)">   
        <label class="h1" ><a style="color: black;text-decoration: none" href="../index.php">Listar Detalles</a></label>       
        </div>
        
<br>           
<form action="listarDetalles.php" method="get" align="center">
  
<div class="input-group flex-nowrap">
    <span class="input-group-text" id="addon-wrapping">ID PRODUCTO</span>
    
    <input type="number" class="form-control" placeholder="Ingrese el ID Producto" value = "" name="nameInputProductoID">    
    
  </div>    
    
    <br>
    
 <input type="submit" class="btn btn-primary" name="ConsultarTest" value="Consultar Detalles">
 
    
    
</form>     

<br>

<?php
 
        require ("productosPedidosMapping.php");   
        
        
            if(isset($_GET['ConsultarTest']))        
            {               
            $DetalleR = listarDetallesPorID($_GET['nameInputProductoID']);            
                
            if($DetalleR == false)
            {
                echo "ID NO ENCONTRADO";
            }
           
            
            if(is_array($DetalleR))
            {
            echo "<table class="."table table-striped"."><tr>";
            echo "<th> ID PRODUCTO </th>"
               . "<th> ID PEDIDO </th>"
               . "<th> Cantidad </th>"
               . "<th> Precio </th>";
            echo "</tr>";

            foreach ($DetalleR as $k => $cur)
            {
                echo "<tr>";
                echo "<td>" . $cur->getProductosPedidosPK()->getProductoidProducto() . "</td>";
                echo "<td>" . $cur->getProductosPedidosPK()->getPedidosidPedido() . "</td>";
                echo "<td>" . $cur->getCantidad() . "</td>";
                echo "<td>" . $cur->getPrecio() . "</td>";
                echo "</tr>";
            }
            echo "</table>";  
            }
            
           if(is_object($DetalleR))           
                {
                echo "<table class="."table table-striped"."><tr>";
                echo "<th> ID PRODUCTO </th>"
               . "<th> ID PEDIDO </th>"
               . "<th> Cantidad </th>"
               . "<th> Precio </th>";
                echo "</tr>";            
            
                 echo "<tr>";
                 echo "<td>" . $DetalleR->getProductosPedidosPK()->getProductoidProducto() . "</td>";
                 echo "<td>" . $DetalleR->getProductosPedidosPK()->getPedidosidPedido() . "</td>";
                 echo "<td>" . $DetalleR->getCantidad() . "</td>";
                 echo "<td>" . $DetalleR ->getPrecio() . "</td>";
                 echo "</tr>";
                
                 echo "</table>";
                }
            }     

 ?>
   
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" 
integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
        
   
    </body>
</html>

