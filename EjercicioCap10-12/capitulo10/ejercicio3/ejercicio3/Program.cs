public abstract class Poligono
{
    protected readonly int lados;
    protected readonly double longitudLado;

    protected Poligono(int lados, double longitudLado)
    {
        if (lados <= 0 || longitudLado <= 0)
        {
            throw new ArgumentException("El número de lados y la longitud del lado deben ser mayores que cero.");
        }
        this.lados = lados;
        this.longitudLado = longitudLado;
    }

    public abstract double Perimetro();

    public abstract double Area();

    public override string ToString()
    {
        return $"El polígono tiene {lados} lados y un área de {Area()} unidades cuadradas.";
    }
}

public class PoligonoRegular : Poligono
{
    public PoligonoRegular(int lados, double longitudLado) : base(lados, longitudLado)
    {
    }

    public override double Perimetro()
    {
        return lados * longitudLado;
    }

    public override double Area()
    {
        return (lados * longitudLado * longitudLado) / (4 * Math.Tan(Math.PI / lados));
    }
}

public class Triangulo : Poligono
{
    public Triangulo(double lado1, double lado2, double lado3) : base(3, lado1)
    {
        if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0 || lado1 + lado2 <= lado3 || lado2 + lado3 <= lado1 || lado1 + lado3 <= lado2)
        {
            throw new ArgumentException("Los lados no forman un triángulo válido.");
        }
    }

    public override double Perimetro()
    {
        return longitudLado * 3;
    }

    public override double Area()
    {
        double s = Perimetro() / 2;
        return Math.Sqrt(s * (s - longitudLado) * (s - longitudLado) * (s - longitudLado));
    }
}

