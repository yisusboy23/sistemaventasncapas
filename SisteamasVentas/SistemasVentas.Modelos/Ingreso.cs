using System;

public class Ingreso
	public Ingreso()
	{
	public int IdIngreso { get; set; } 
	public int IdProveedor { get; set; }
    public string FechaIngreso { get; set; }
    public decimal Total {  get; set; }
    public string Estado { get; set; }
	}
}
