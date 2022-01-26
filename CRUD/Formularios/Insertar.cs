using CRUD.CRUDS.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Formularios
{
	public partial class Insertar : Form
	{
		public Insertar()
		{
			InitializeComponent();
		}

		private void Insertar_Load(object sender, EventArgs e)
		{

		}

		private void BotonCerrar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Desea cancelar la acción?", "Cerrar", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				Dispose();
			}
		}

		private void BotonAceptar_Click(object sender, EventArgs e)
		{
			try
			{
				new Productos(NombreBox.Text
					, MarcaBox.Text
					, DistribuidorBox.Text
					, int.Parse(ExistenciasBox.Text)
					, decimal.Parse(PrecioBox.Text)
					, DescripcionBox.Text).Insertar();
				MessageBox.Show("El registro se ha ingresado correctamente", "Mensaje");
				Dispose();
			}
			catch (Exception)
			{
				MessageBox.Show("Error en el formato de los valores", "Valores invalidos");
			}
		}
	}
}
