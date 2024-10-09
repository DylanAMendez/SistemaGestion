using SistemaGestionBussiness;

var productoBussiness = new ProductoBussiness();

var obtenerTodosLosProductos = productoBussiness.GetProductos();

foreach(var it in obtenerTodosLosProductos)
{
    Console.WriteLine("descripcion del producto id : " + it.Id + ", " + it.Descripcion);
}

var obtenerUnProducto = productoBussiness.ObtenerUnProducto(5);

if (obtenerUnProducto != null)
{
    obtenerUnProducto.Descripcion = "Producto modificado";

    productoBussiness.ModificarUnProducto(obtenerUnProducto.Id, obtenerUnProducto);

    Console.WriteLine("Producto modificado con descripción: " + obtenerUnProducto.Descripcion);
}