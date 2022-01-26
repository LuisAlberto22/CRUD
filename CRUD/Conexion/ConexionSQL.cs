using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;

namespace CRUD.Conexion
{
	public class ConexionSQL : BaseConexion
	{
		private ConexionSQL(string datos)
		{
			ConexionBD = new SqlConnection(datos);
		}
		/// <summary>
		/// Obtiene la instancia de conexion
		/// </summary>
		/// <param name="datos">Los parametros necesarios para conectarse</param>
		/// <returns>Conexion</returns>
		public static BaseConexion ObtenerInstancia(string datos)
		{
			try
			{
				if (_Instancia is null)
				{
					_Instancia = new ConexionSQL(datos);
				}

				return _Instancia;
			}
			catch
			{
				return _Instancia;
			}
		}

		public override bool CambiarConexion(string Datos)
		{
			if (!CerrarConexion())
				return false;
			ConexionBD = new SqlConnection(Datos);
			return true;
		}
	}
}