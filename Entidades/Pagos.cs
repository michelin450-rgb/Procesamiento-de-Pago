using System;
public abstract class Pagos
{
    private int monto;

    private Cliente cliente;

    private int idTransaccion;

    public int Monto {get{return this.monto;}set{ this.monto = value;}}

    public Cliente Cliente {get{return this.cliente;}set{ this.cliente = value;}}

    public int IdTransaccion{get{return this.idTransaccion;}set{ this.idTransaccion = value;}}

    public Pagos (int monto, Cliente cliente, int idTransaccion)
    {
        this.monto = monto;
        this.cliente = cliente;
        this.idTransaccion = idTransaccion;

    }
    public abstract void MostrarInfo();
    
    public abstract void ProcesamientoDePago();

    public abstract int CalculoDePago();
    
}