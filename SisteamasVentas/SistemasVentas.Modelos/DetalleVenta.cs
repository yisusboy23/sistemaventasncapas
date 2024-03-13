using System;

public class DetalleVenta
{
	public DetalleVenta()
	{
		public int IdDetaleVenta {  get; set; }
	public int IdVenta { get; set; }
	public int IdProducto { get; set; }
	public int Cantidad { get; set; }
	public decimal PrecioVenta { get; set; }
	public decimal SubTotal { get; set; }
	public string Estado { get; set; }
	}
}
