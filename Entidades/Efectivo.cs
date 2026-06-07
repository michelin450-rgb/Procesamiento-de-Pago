using System;
public class Efectivo : Pagos
{
    private int pagoEfectivo;
    
    private int vuelto; 

    public int PagoEfectivo{get{return this.pagoEfectivo;}set{this.pagoEfectivo = value;}}

    public int Vuelto{get{return this.vuelto;}set{this.vuelto = value;}}

    public Efectivo(int monto, Cliente cliente, string idTransaccion,int pagoEfectivo) : base (monto, cliente, idTransaccion)
    {
        this.pagoEfectivo = pagoEfectivo;
         
    }
    public override void MostrarInfo()
    {
        System.Console.WriteLine("==== SISTEMA DE PAGOS ====");
        System.Console.WriteLine($"Titular: {Cliente.Apellido}, {Cliente.Nombre}");
        System.Console.WriteLine("Procesando pago..");
        ProcesamientoDePago();
    }

    public override void ProcesamientoDePago()
    {

        if(this.pagoEfectivo < this.Monto)
        {
            System.Console.WriteLine("Pago en efectivo insuficiente!!");
            
            
        }else
        {
            System.Console.WriteLine("Pago Realizado");
            System.Console.WriteLine($"Monto: {this.Monto}");
            System.Console.WriteLine($"Efectivo: {this.pagoEfectivo}");
            System.Console.WriteLine($"Vuelto: {CalculoDePago()}");

        }

    }

    public override int CalculoDePago()
    {
     if(this.pagoEfectivo > this.Monto)
        {
            int vuelto = this.pagoEfectivo - this.Monto;
            return vuelto;
        }
        else
        {
            return 0;
        }
    }
}