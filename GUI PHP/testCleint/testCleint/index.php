<html>
    <head>        
        <meta charset="UTF-8">
        <title>Proyecto 2</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" 
              integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">

    </head>
    <body>
        
 <nav class="navbar navbar-expand-lg navbar-light bg-light">
  <div class="container-fluid">
    <a class="navbar-brand" href="index.php">LYJ STORE</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNavDropdown">
      <ul class="navbar-nav">
          
<a style="margin: 5px" class="btn btn-light" href="index.php" role="button">Inicio</a> 
        
<div class="btn-group">
  <button style="margin: 5px" type="button" class="btn btn-light dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false">
    Productos
  </button>
  <ul class="dropdown-menu">
    <li><a class="dropdown-item" href="Producto/adicionarProducto.php">Adicionar Producto</a></li>
    <li><a class="dropdown-item" href="Producto/eliminarProductoXId.php">Eliminar Producto</a></li>
    <li><a class="dropdown-item" href="Producto/listarProductoPorNombre.php">Listar Producto</a></li>   
    <li><a class="dropdown-item" href="Producto/consultarProducto.php">Consultar Producto</a></li>
    <li><a class="dropdown-item" href="Producto/actualizarProducto.php">Actualizar Producto</a></li>
  </ul>
</div>
        
<div class="btn-group">
  <button style="margin: 5px" type="button" class="btn btn-light dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false">
    Detalle (Productos - Pedidos)
  </button>
  <ul class="dropdown-menu">
    <li><a class="dropdown-item" href="Detalle/agregarDetalle.php">Adicionar Detalle</a></li>
    <li><a class="dropdown-item" href="Detalle/eliminarDetalleId.php">Eliminar Detalle</a></li>
    <li><a class="dropdown-item" href="Detalle/listarDetalles.php">Listar Detalle</a></li>      
    <li><a class="dropdown-item" href="Detalle/consultarDetalle.php">Consultar Detalle</a></li>
    <li><a class="dropdown-item" href="Detalle/actualizarDetalle.php">Actualizar Detalle</a></li>
  </ul>
</div>

        

<a style="margin: 5px" class="btn btn-light" href="Graficar/graficar.php" role="button">Graficar</a>

<a style="margin: 5px" class="btn btn-light" href="Ayuda/ayuda.php" role="button">Ayuda</a>

      </ul>
    </div>
  </div>
</nav>
        

        
        
        
        
        
        
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" 
        integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    </body>
</html>


