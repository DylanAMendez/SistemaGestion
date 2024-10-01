using SistemaGestionBussiness;

var obtenerTodosLosProductos = ProductoBussiness.GetProductos();

foreach(var it in obtenerTodosLosProductos)
{
    Console.WriteLine("descripcion del producto id : " + it.Id + ", " + it.Descripcion);
}

var obtenerUnProducto = ProductoBussiness.ObtenerUnProducto(5);
Console.WriteLine("producto a buscar : " + obtenerUnProducto);

if(obtenerUnProducto != null)
{
    obtenerUnProducto.Descripcion = "Producto modificado";

    ProductoBussiness.ModificarUnProducto(obtenerUnProducto.Id, obtenerUnProducto);

    Console.WriteLine("Producto modificado con descripción: " + obtenerUnProducto.Descripcion);
}