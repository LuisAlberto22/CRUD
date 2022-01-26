using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.Conexion;
using CRUD.CRUDS.Entidades;
using CRUD.Formularios;

namespace CRUD
{
	public partial class Form1 : Form, IBooteable
	{
		Productos producto;

		public Form1()
		{
			InitializeComponent();
		}

		public void Boot()
		{
			RefrescarTabla();
		}

		/// <summary>
		/// Refresca los datos en la tabla
		/// </summary>
		public void RefrescarTabla()
		{
			TablaDeRegistros.DataSource 
				= Modelo.Todos(typeof(Productos)).ConvertAll(i => (Productos)i);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		/// <summary>
		/// Obtiene la fila seleccionada por el usuario y lo almacena en la variable producto
		/// </summary>
		private void FilaSeleccionada()
		{
			var celdas = TablaDeRegistros.SelectedRows[0].Cells;
			producto = new Productos(int.Parse(celdas[0].Value.ToString())
				, celdas[1].Value.ToString()
				, celdas[2].Value.ToString()
				, celdas[3].Value.ToString()
				, int.Parse(celdas[4].Value.ToString())
				, decimal.Parse(celdas[5].Value.ToString())
				, celdas[6].Value.ToString());
		}

		/// <summary>
		/// Abre el formulario para ingresar un nuevo registro
		/// </summary>
		private void BotonInsertar_Click(object sender, EventArgs e)
		{
			new Insertar().ShowDialog();
			RefrescarTabla();
		}

		/// <summary>
		/// Abre el formulario para modificar el registro seleccionado por el usuario
		/// </summary>
		private void BotonModificar_Click(object sender, EventArgs e)
		{
			try
			{ 
				FilaSeleccionada();
				new Modificar(producto).ShowDialog();
				RefrescarTabla();
			}
			catch (ArgumentOutOfRangeException)
			{
				MessageBox.Show("No ha seleccionado algun registro", "Error");
			}
		}

		/// <summary>
		/// Elimina el registro seleccionado por el usuario
		/// </summary>
		private void BotonEliminar_Click(object sender, EventArgs e)
		{
			try
			{
				FilaSeleccionada();
				if (MessageBox.Show("Estas seguro que desea eliminar","Advertencia",MessageBoxButtons.OKCancel) == DialogResult.OK)
					producto.Eliminar();
				RefrescarTabla();
			}
			catch (ArgumentOutOfRangeException)
			{
				MessageBox.Show("No ha seleccionado algun registro", "Error");
			}
		}

		/// <summary>
		/// Abre el fromulario de busqueda
		/// </summary>
		private void BotonBuscar_Click(object sender, EventArgs e)
		{
			new Buscar().ShowDialog();
		}
	}
}
