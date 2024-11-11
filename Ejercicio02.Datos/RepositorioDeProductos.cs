using Ejercicio2.Entidades;

namespace Ejercicio02.Datos
{
    public class RepositorioDeProductos
    {
        private readonly char separatorChar= '|';
        private string archivo = "Productos.txt";
        private string RutaTrabajo = AppDomain.CurrentDomain.BaseDirectory;
        private List<Producto>? producto;
        public RepositorioDeProductos()
        {
            producto = new List<Producto>();
            LeerDatos();

        }
        public void Agregar (Producto productos)
        {
            producto!.Add(productos);
        }
        public List<Producto>GetProductos() => producto!;

        public void GuardarDatos()
        {
            var rutaArchivo = Path.Combine(RutaTrabajo, archivo);
            using (var escritor = new StreamWriter(rutaArchivo))
            {
                foreach (var productos in producto!)
                {
                    string linea = ConstruirLinea(productos);
                    escritor.WriteLine(linea);
                }
            }
        }

        private string ConstruirLinea(Producto productos)
        {
            return $"{productos.Cantidad}| {productos.PrecioUnitario} | {productos.Descripcion}|{productos.Codigo}";
        }

        private void LeerDatos()
        {
            var rutaArchivo = Path.Combine(RutaTrabajo,archivo);
            if (!File.Exists(rutaArchivo)) return;
            using(var lector=new StreamReader(rutaArchivo))
            {
                while (!lector.EndOfStream)
                {
                    string linea = lector.ReadLine()!;
                    Producto producto = ConstruirProducto(linea);
                    Agregar(producto); 
                }
            }
        }

        private Producto ConstruirProducto(string linea)
        {
            var campos = linea.Split(separatorChar);
            var codigo =Guid.Parse(campos[3]);
            var descripcion = campos[2];
            var cantidad = int.Parse(campos[0]);
            var precioUnitario = int.Parse(campos[1]);
            
            return new Producto
            {
                Codigo = codigo,
                Descripcion = descripcion,
                Cantidad = cantidad,
                PrecioUnitario = precioUnitario,
                
            };
        }
        public int GetCantidad()
        {
            return producto!.Count;
            
        }

        public void Borrar(Producto productos)
        {
            producto!.Remove(productos);
        }
    }
}
