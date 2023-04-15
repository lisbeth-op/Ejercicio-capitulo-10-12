public class Estudiante
{
    public string? nombre { get; set; }
    public int edad { get; set; }
    public string? curso { get; set; }
    public decimal promedio { get; set; }

    public Estudiante(string nombre, int edad, string curso, decimal promedio)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.curso = curso;
        this.promedio = promedio;
    }

}
