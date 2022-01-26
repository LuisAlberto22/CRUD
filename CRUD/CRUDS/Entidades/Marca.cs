using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.CRUDS.Entidades
{
	public class Marca : Modelo
	{
		public int ID { get; set; }
		public string Nombre { get; set; }

		public Marca(int ID, string Nombre)
		{
			this.ID = ID;
			this.Nombre = Nombre;
		}

		public Marca(string Nombre)
		{
			this.Nombre= Nombre;
		}

	}
}
