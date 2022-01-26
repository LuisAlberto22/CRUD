using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CRUD.Conexion;
using CRUD.Herramientas;
using System.Data.SqlClient;
using System.Configuration;

namespace CRUD.CRUDS.Entidades
{
	public class Modelo : IBooteable, ICloneable
	{
		protected string NombreKey = "ID";

		protected static BaseConexion BaseConexion;

		public void Boot()
		{
			BaseConexion = ConexionSQL.ObtenerInstancia(ConfigurationManager
				.ConnectionStrings["DatosDeConexion"].ConnectionString);
		}
	
		/// <summary>
		/// Busca el Modelo en la base de datos
		/// </summary>
		/// <param name="Modelo">Tipo del modelo a buscar</param>
		/// <param name="ID">El ID del modelo a buscar</param>
		/// <param name="NK">Nombre de la primary key de la tabla</param>
		/// <returns>Si el modelo se ha encontrado retorna el modelo, de lo contrario retorna null</returns>
		public static Modelo Buscar(Type Modelo,string NK,int ID)
		{
		    if (Modelo.IsSubclassOf(typeof(Modelo)))
		      {
			try
			{
				BaseConexion.IniciarConexion();
				SqlCommand Comando = new SqlCommand($"SELECT * FROM {Modelo.Name} WHERE {NK} = {ID}", BaseConexion.ConexionBD as SqlConnection);
				return ConvertidorSQLDataAModelo.ObtenerModelos(Comando.ExecuteReader(),Modelo.Name).FirstOrDefault();
			}
			catch (SqlException e)
			{
				throw new Exception(e.Message);
			}
			finally
			{
				BaseConexion.CerrarConexion();
			}
		    }else
		    	throw new Exception("La variable Modelo no es de tipo Modelo");
		}
		
		/// <summary>
		/// Retorna todos los elementos de la tabla en la base de datos
		/// </summary>
		/// <param name="Modelo">Tipo del modelo a buscar</param>
		/// <returns>Retorna una lista de los modelos de la tabla</returns>
		public static List<Modelo> Todos(Type Modelo)  
		{
			if (Modelo.IsSubclassOf(typeof(Modelo)))
		        {
				try
				{
					BaseConexion.IniciarConexion();
					SqlCommand Comando = new SqlCommand($"SELECT * FROM {Modelo.Name}", BaseConexion.ConexionBD as SqlConnection);
					return ConvertidorSQLDataAModelo.ObtenerModelos(Comando.ExecuteReader(), Modelo.Name);
				}
				catch (SqlException e)
				{
					throw new Exception(e.Message);
				}
				finally
				{
					BaseConexion.CerrarConexion();
				}
			  }else
		    		throw new Exception("La variable Modelo no es de tipo Modelo");
		}

		/// <summary>
		/// Elimina el modelo de su respectiva tabla en la base de datos
		/// </summary>
		/// <param name="Modelo">Modelo a eliminar</param>
		/// 
		/// <returns>Retorna true si se ha podido eliminar, de lo contrario false</returns>
		public bool Eliminar()
		{
			try
			{
				BaseConexion.IniciarConexion();
				SqlCommand Comando = new SqlCommand($"DELETE FROM {GetType().Name} WHERE {NombreKey} =" +
					$" {GetType().GetProperty(NombreKey).GetValue(this)}", BaseConexion.ConexionBD as SqlConnection);
				Comando.ExecuteNonQuery();
				return true;
				
			}
			catch (SqlException e)
			{
				throw new Exception(e.Message);
			}
			finally
			{
				BaseConexion.CerrarConexion();
			}
		}
		/// <summary>
		/// Inserta un modelo en su respectiva tabla en la base de datos
		/// </summary>
		/// <param name="Modelo">Modelo a insertar</param>
		/// <returns>Retorna true si se ha podido insertar, de lo contrario false</returns>
		public bool Insertar()
		{
			try
			{
				BaseConexion.IniciarConexion();
				var propiedades = GetType().GetProperties().Where(i => i.Name != NombreKey).Select(i =>"'"+i.GetValue(this)+"'");	

				SqlCommand Comando = new SqlCommand($"INSERT INTO {GetType().Name} VALUES({string.Join(",", propiedades)})"
					, BaseConexion.ConexionBD as SqlConnection);

				Comando.ExecuteNonQuery();
				return true;

			}
			catch(SqlException e)
			{
				throw new Exception(e.Message);
			}
			finally
			{
				BaseConexion.CerrarConexion();
			}
		}
		/// <summary>
		/// Modifica el modelo de su respectiva tabla en la base de datos
		/// </summary>
		/// <param name = "Modelo" > Modelo a modificar</param>
		/// <returns>Retorna true si se ha podido modificar, de lo contrario false</returns>	 
		public bool Modificar()
		{
			try
			{
				BaseConexion.IniciarConexion();
				var propiedades = GetType().GetProperties().Where(i => i.Name != NombreKey).Select(i => $"{i.Name} = '{i.GetValue(this)}'");
				
				SqlCommand Comando = new SqlCommand($"UPDATE {GetType().Name} SET {string.Join(",", propiedades)} WHERE {NombreKey} = {GetType().GetProperty(NombreKey).GetValue(this)}"
					, BaseConexion.ConexionBD as SqlConnection);

				Comando.ExecuteNonQuery();
				return true;

			}
			catch (SqlException e)
			{
				throw new Exception(e.Message);
			}
			finally
			{
				BaseConexion.CerrarConexion();
			}
		}
		/// <summary>
		/// Clona el Modelo
		/// </summary>
		/// <returns>Regresa un clon del objeto</returns>
		public object Clone()
		{
			var propiedades = GetType().GetProperties().ToArray();
			return GetType().GetConstructor(propiedades.Select(i => i.GetType()).ToArray())
				.Invoke(propiedades.Select(i => i.GetValue(this)).ToArray());
		}
	}
}
