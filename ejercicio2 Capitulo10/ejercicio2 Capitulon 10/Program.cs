//Crear una clase para llevar la información de los estudiantes de una escuela.

using System.ComponentModel.DataAnnotations;

public class Estudiantes
{
    [Key]
    public int IdEstudiante { get; set; }
    public string? Nombre { get; set; }
    public decimal Promedio { get; set; }
    public int Matricula { get; set; }

    public Estudiantes(int id,string nombre,decimal promedio, int matricula) {
        IdEstudiante = id;
        Nombre = nombre;
        Promedio = promedio;
        Matricula = matricula;

    }
}