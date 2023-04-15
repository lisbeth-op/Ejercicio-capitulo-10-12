public class Innentario
{
    public int CodigoProducto { get; set; }
    public String? Nombre { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }

    public Innentario(int CodigoProducto, String Nombre, int Cantidad, double Precio)
    {
        this.CodigoProducto = CodigoProducto;
        this.Nombre = Nombre;
        this.Cantidad = Cantidad;
        this.Precio = Precio;

    }


}