using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.CRUDS.Entidades;

namespace CRUD.Formularios
{
	public partial class Buscar : Form
	{

		Productos Producto;
		public Buscar()
		{
			InitializeComponent();
		}

		private void BotonAceptar_Click(object sender, EventArgs e)
		{
			try
			{
				if (IDBox.Text is null)
					MessageBox.Show("Ingrese el id del registro que quiera buscar", "Error");
				else
				{
					Producto = Modelo.Buscar(typeof(Productos),"ID",int.Parse(IDBox.Text)) as Productos;
					if(Producto is null){
						MessageBox.Show("No se ha enontrado el registro", "Error");
						return;
					}
					MostrarDatos();
				}
			}
			catch
			{
				MessageBox.Show("ID invalido", "Error");
			}
		}

		private void BotonCerrar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Desea cancelar la acción?", "Cerrar", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				Dispose();
			}
		}

		private void MostrarDatos()
		{
			NombreBox.Text = Producto.NombreDelProducto;
			DistribuidorBox.Text = Producto.Distribuidor;
			MarcaBox.Text = Producto.MarcaDelProducto;
			PrecioBox.Text = Producto.Precio.ToString();
			ExistenciasBox.Text = Producto.Existencias.ToString();
			DescripcionBox.Text = Producto.Descripcion;
		}

		private void Buscar_Load(object sender, EventArgs e)
		{
		

		}
	}
}
