using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.CRUDS.Entidades;
using System.Data.SqlClient;

namespace CRUD.Herramientas
{
	public static class ConvertidorSQLDataAModelo
	{
		/// <summary>
		/// Convierte los Datos en el modelo especificado
		/// </summary>
		/// <param name="Datos">Datos a convertir</param>
		/// <param name="tabla">Nombre de la tabla que pertenecen</param>
		/// <returns>Lista de modelos</returns>
		public static List<Modelo> ObtenerModelos(SqlDataReader Datos, string tabla)
		{
			List<Modelo> Modelos = new List<Modelo>();
			while (Datos.Read())
			{
				Type[] tipos = new Type[Datos.FieldCount];
				object[] parametros = new object[Datos.FieldCount];
				for (int i = 0; i < Datos.FieldCount; i++)
				{
					parametros[i] = Datos[i];
					tipos[i] = Datos[i].GetType();
				}
				Modelos.Add(Type.GetType("CRUD.CRUDS.Entidades." + tabla).GetConstructor(tipos).Invoke(parametros) as Modelo);
			}
			return Modelos;
		}
	}
}
