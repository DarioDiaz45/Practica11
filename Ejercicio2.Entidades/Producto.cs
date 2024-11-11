namespace Ejercicio2.Entidades
{
    public class Producto
    {
        public Guid Codigo { get; set; }
        public DateTime FechaIngreso {  get; set; }
        public bool Activo {  get; set; }

        public bool Stock {  get; set; }
        public string? Descripcion { get; set; }
        public int Cantidad {  get; set; }
        public decimal PrecioUnitario { get; set; }
        
    }
}
