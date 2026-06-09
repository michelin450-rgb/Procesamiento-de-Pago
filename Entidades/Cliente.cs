using System;
public class Cliente
{
    private string nombre;

    private string apellido;

    private int dni;

    private string correo;

    public string Nombre {get{return this.nombre;}set{this.nombre = value;}}

    public string Apellido {get{return this.apellido;}set{this.apellido = value;}}

    public int Dni {get{return this.dni;}set{this.dni = value;}}

    public string Correo {get{return this.correo;}set{this.correo = value;}}

    public Cliente(string nombre, string apellido, int dni, string correo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.dni = dni;
        this.correo = correo;

    }

    public void InformacionUsuario()
    {
        System.Console.WriteLine("");
    }
}