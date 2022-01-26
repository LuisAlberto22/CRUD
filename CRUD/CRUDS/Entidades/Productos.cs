using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CRUD.Conexion;

namespace CRUD.CRUDS.Entidades
{
	public class Productos : Modelo
	{
		public int ID{get; set;}

		public string NombreDelProducto { get; set; }

		public string MarcaDelProducto{ get; set; }
		
		public string Distribuidor { get; set; }

		public int Existencias { get; set; }

		public decimal Precio { get; set; }

		public string Descripcion { get; set; }
		public Productos(int ID, string NombreDelProducto,string MarcaDelProducto,
			string Distribuidor,int Existencias, decimal Precio,string Descripcion = null)
		{
			this.ID = ID;
			this.NombreDelProducto = NombreDelProducto;
			this.Distribuidor = Distribuidor;
			this.MarcaDelProducto = MarcaDelProducto;
			this.Existencias = Existencias;
			this.Descripcion = Descripcion;
			this.Precio = Precio;
		}
		public Productos(string NombreDelProducto, string MarcaDelProducto,
			string Distribuidor, int Existencias, decimal Precio, string Descripcion = null)
		{
			this.NombreDelProducto = NombreDelProducto;
			this.Distribuidor = Distribuidor;
			this.MarcaDelProducto = MarcaDelProducto;
			this.Existencias = Existencias;
			this.Descripcion = Descripcion;
			this.Precio = Precio;
		}

	}
}