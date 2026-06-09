using System;
public class Tarjeta : Pagos
{
    private string tipo;
    private int recargo;
    
    public string Tipo {get{ return this.tipo;}set{ this.tipo = value;}}
    public int Recargo{get{return this.recargo;}set{this.recargo = value;}}

    public Tarjeta(int monto, Cliente cliente, int idTransaccion, string tipo, int recargo) : base (monto, cliente, idTransaccion)
    {
         this.tipo = tipo;
         this.recargo = recargo;
    }

    public override void MostrarInfo()
    {
        System.Console.WriteLine("==== SISTEMA DE PAGOS ====");
        System.Console.WriteLine($"Titular: {Cliente.Apellido}, {Cliente.Nombre}");
        ProcesamientoDePago();
    }

    public override void ProcesamientoDePago()
    {
        System.Console.WriteLine($"--Tarjeta de {this.tipo}--");
        System.Console.WriteLine($"--Recargo del {this.recargo}%--");
        System.Console.WriteLine($"Monto original: {this.Monto}. Monto con recargo: {CalculoDePago()}");
        System.Console.WriteLine("Realizando pago...");
        System.Console.WriteLine("Pago realizado con exito!");
        System.Console.WriteLine("==============================");
    }

    public override int CalculoDePago()
    {
        int recargo = (this.Monto * this.recargo) / 100;

        int total = this.Monto + recargo;

        return total;
    }

}