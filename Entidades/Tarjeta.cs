using System;
public class Tarjeta : Pagos
{
    private string tipo;
    private int recargo;
    
    public string Tipo {get{ return this.tipo;}set{ this.tipo = value;}}
    public int Recargo{get{return this.recargo;}set{this.recargo = value;}}

    public Tarjeta(int monto, Cliente cliente, string idTransaccion, string tipo, int recargo) : base (monto, cliente, idTransaccion)
    {
         this.tipo = tipo;
         this.recargo = recargo;
    }

    public override 

}