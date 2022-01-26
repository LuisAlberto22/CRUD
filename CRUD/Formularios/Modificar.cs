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
	public partial class Modificar : Form
	{

		private Productos Modelo;

		public Modificar(Productos Modelo)
		{
			InitializeComponent();
			this.Modelo =Modelo;
		}

		private void Modificar_Load(object sender, EventArgs e)
		{
			NombreBox.Text = Modelo.NombreDelProducto;
			DistribuidorBox.Text = Modelo.Distribuidor;
			MarcaBox.Text = Modelo.MarcaDelProducto;
			PrecioBox.Text = Modelo.Precio.ToString();
			ExistenciasBox.Text = Modelo.Existencias.ToString();
			DescripcionBox.Text = Modelo.Descripcion;
		}

		private void BotonCerrar_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("¿Desea cancelar la acción?","Cerrar", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				Dispose();
			}
		}

		private void BotonAceptar_Click(object sender, EventArgs e)
		{
			try
			{
				Modelo.NombreDelProducto = NombreBox.Text;
				Modelo.MarcaDelProducto = MarcaBox.Text;
				Modelo.Precio = decimal.Parse(PrecioBox.Text);
				Modelo.Existencias = int.Parse(ExistenciasBox.Text);
				Modelo.Descripcion = DescripcionBox.Text;
				Modelo.Distribuidor = DistribuidorBox.Text;
				Modelo.Modificar();
				MessageBox.Show("El registro se ha modificado correctamente", "Mensaje");
				Dispose();
			}
			catch (Exception)
			{
				MessageBox.Show("Error en el formato de los valores","Error");
			}
		}
	}
}
