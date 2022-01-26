using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace CRUD.Conexion
{
	public abstract class BaseConexion
	{
		protected static BaseConexion _Instancia;

		public DbConnection ConexionBD { get; protected set; }

		/// <summary>
		/// Cambia la conexion con una nueva con diferentes datos
		/// </summary>
		/// <param name="Datos">Los parametros necesarios para conectarse</param>
		/// <returns>Nueva conexion</returns>
		public abstract bool CambiarConexion(string Datos);

		/// <summary>
		/// Cierra la conexion a la base de datos
		/// </summary>
		/// <returns>retorna true si se ha podido cerrar, de lo contrario false</returns>
		public  bool CerrarConexion()
		{
			if (ConexionBD.State == System.Data.ConnectionState.Open)
			{
				try
				{
					ConexionBD.Close();
					return true;
				}
				catch (DbException)
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// Abre la conexion a la base de datos
		/// </summary>
		/// <returns>retorna true si se ha podido abrir la conexion, de lo contrario false</returns>
		public  bool IniciarConexion()
		{
			if (ConexionBD.State == System.Data.ConnectionState.Closed)
			{
				try
				{
					ConexionBD.Open();
					return true;
				}
				catch (DbException)
				{
					return false;
				}
			}
			return true;
		}
		/// <summary>
		/// Cambia la base de datos principal
		/// </summary>
		/// <param name="Base">Nombre de la base</param>
		/// <returns>retorna true si se ha podido cambiar la base de datos, de lo contrario false</returns>
		public  bool CambiarBaseDeDatos(string Base)
		{
			try
			{
				ConexionBD.ChangeDatabase(Base);
				return true;
			}
			catch
			{
				return false;
			}
			finally
			{
				ConexionBD.Close();
			}
		}

	}
}