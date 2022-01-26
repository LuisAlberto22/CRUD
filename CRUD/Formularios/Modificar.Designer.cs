namespace CRUD.Formularios
{
	partial class Modificar
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.NombreBox = new System.Windows.Forms.TextBox();
			this.MarcaBox = new System.Windows.Forms.TextBox();
			this.DistribuidorBox = new System.Windows.Forms.TextBox();
			this.ExistenciasBox = new System.Windows.Forms.TextBox();
			this.DescripcionBox = new System.Windows.Forms.TextBox();
			this.PrecioBox = new System.Windows.Forms.TextBox();
			this.BotonAceptar = new System.Windows.Forms.Button();
			this.BotonCerrar = new System.Windows.Forms.Button();
			this.NombreLabel = new System.Windows.Forms.Label();
			this.MarcaLabel = new System.Windows.Forms.Label();
			this.DistribuidorLabel = new System.Windows.Forms.Label();
			this.PrecioLabel = new System.Windows.Forms.Label();
			this.ExistenciasLabel = new System.Windows.Forms.Label();
			this.DescripcionLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// NombreBox
			// 
			this.NombreBox.Location = new System.Drawing.Point(72, 30);
			this.NombreBox.Name = "NombreBox";
			this.NombreBox.Size = new System.Drawing.Size(283, 20);
			this.NombreBox.TabIndex = 0;
			// 
			// MarcaBox
			// 
			this.MarcaBox.Location = new System.Drawing.Point(72, 70);
			this.MarcaBox.Name = "MarcaBox";
			this.MarcaBox.Size = new System.Drawing.Size(283, 20);
			this.MarcaBox.TabIndex = 1;
			// 
			// DistribuidorBox
			// 
			this.DistribuidorBox.Location = new System.Drawing.Point(72, 110);
			this.DistribuidorBox.Name = "DistribuidorBox";
			this.DistribuidorBox.Size = new System.Drawing.Size(283, 20);
			this.DistribuidorBox.TabIndex = 2;
			// 
			// ExistenciasBox
			// 
			this.ExistenciasBox.Location = new System.Drawing.Point(72, 149);
			this.ExistenciasBox.Name = "ExistenciasBox";
			this.ExistenciasBox.Size = new System.Drawing.Size(283, 20);
			this.ExistenciasBox.TabIndex = 3;
			// 
			// DescripcionBox
			// 
			this.DescripcionBox.Location = new System.Drawing.Point(72, 229);
			this.DescripcionBox.Multiline = true;
			this.DescripcionBox.Name = "DescripcionBox";
			this.DescripcionBox.Size = new System.Drawing.Size(283, 75);
			this.DescripcionBox.TabIndex = 4;
			// 
			// PrecioBox
			// 
			this.PrecioBox.Location = new System.Drawing.Point(72, 188);
			this.PrecioBox.Name = "PrecioBox";
			this.PrecioBox.Size = new System.Drawing.Size(283, 20);
			this.PrecioBox.TabIndex = 5;
			// 
			// BotonAceptar
			// 
			this.BotonAceptar.Location = new System.Drawing.Point(280, 310);
			this.BotonAceptar.Name = "BotonAceptar";
			this.BotonAceptar.Size = new System.Drawing.Size(75, 23);
			this.BotonAceptar.TabIndex = 7;
			this.BotonAceptar.Text = "Aceptar";
			this.BotonAceptar.UseVisualStyleBackColor = true;
			this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
			// 
			// BotonCerrar
			// 
			this.BotonCerrar.Location = new System.Drawing.Point(199, 310);
			this.BotonCerrar.Name = "BotonCerrar";
			this.BotonCerrar.Size = new System.Drawing.Size(75, 23);
			this.BotonCerrar.TabIndex = 8;
			this.BotonCerrar.Text = "Cancelar";
			this.BotonCerrar.UseVisualStyleBackColor = true;
			this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
			// 
			// NombreLabel
			// 
			this.NombreLabel.AutoSize = true;
			this.NombreLabel.Location = new System.Drawing.Point(4, 33);
			this.NombreLabel.Name = "NombreLabel";
			this.NombreLabel.Size = new System.Drawing.Size(44, 13);
			this.NombreLabel.TabIndex = 9;
			this.NombreLabel.Text = "Nombre";
			// 
			// MarcaLabel
			// 
			this.MarcaLabel.AutoSize = true;
			this.MarcaLabel.Location = new System.Drawing.Point(4, 73);
			this.MarcaLabel.Name = "MarcaLabel";
			this.MarcaLabel.Size = new System.Drawing.Size(37, 13);
			this.MarcaLabel.TabIndex = 10;
			this.MarcaLabel.Text = "Marca";
			// 
			// DistribuidorLabel
			// 
			this.DistribuidorLabel.AutoSize = true;
			this.DistribuidorLabel.Location = new System.Drawing.Point(4, 113);
			this.DistribuidorLabel.Name = "DistribuidorLabel";
			this.DistribuidorLabel.Size = new System.Drawing.Size(59, 13);
			this.DistribuidorLabel.TabIndex = 11;
			this.DistribuidorLabel.Text = "Distribuidor";
			// 
			// PrecioLabel
			// 
			this.PrecioLabel.AutoSize = true;
			this.PrecioLabel.Location = new System.Drawing.Point(4, 191);
			this.PrecioLabel.Name = "PrecioLabel";
			this.PrecioLabel.Size = new System.Drawing.Size(37, 13);
			this.PrecioLabel.TabIndex = 12;
			this.PrecioLabel.Text = "Precio";
			// 
			// ExistenciasLabel
			// 
			this.ExistenciasLabel.AutoSize = true;
			this.ExistenciasLabel.Location = new System.Drawing.Point(4, 152);
			this.ExistenciasLabel.Name = "ExistenciasLabel";
			this.ExistenciasLabel.Size = new System.Drawing.Size(60, 13);
			this.ExistenciasLabel.TabIndex = 13;
			this.ExistenciasLabel.Text = "Existencias";
			// 
			// DescripcionLabel
			// 
			this.DescripcionLabel.AutoSize = true;
			this.DescripcionLabel.Location = new System.Drawing.Point(4, 232);
			this.DescripcionLabel.Name = "DescripcionLabel";
			this.DescripcionLabel.Size = new System.Drawing.Size(63, 13);
			this.DescripcionLabel.TabIndex = 14;
			this.DescripcionLabel.Text = "Descripcion";
			// 
			// Modificar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(367, 345);
			this.Controls.Add(this.DescripcionLabel);
			this.Controls.Add(this.ExistenciasLabel);
			this.Controls.Add(this.PrecioLabel);
			this.Controls.Add(this.DistribuidorLabel);
			this.Controls.Add(this.MarcaLabel);
			this.Controls.Add(this.NombreLabel);
			this.Controls.Add(this.BotonCerrar);
			this.Controls.Add(this.BotonAceptar);
			this.Controls.Add(this.PrecioBox);
			this.Controls.Add(this.DescripcionBox);
			this.Controls.Add(this.ExistenciasBox);
			this.Controls.Add(this.DistribuidorBox);
			this.Controls.Add(this.MarcaBox);
			this.Controls.Add(this.NombreBox);
			this.Name = "Modificar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modificar";
			this.Load += new System.EventHandler(this.Modificar_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox NombreBox;
		private System.Windows.Forms.TextBox MarcaBox;
		private System.Windows.Forms.TextBox DistribuidorBox;
		private System.Windows.Forms.TextBox ExistenciasBox;
		private System.Windows.Forms.TextBox DescripcionBox;
		private System.Windows.Forms.TextBox PrecioBox;
		private System.Windows.Forms.Button BotonAceptar;
		private System.Windows.Forms.Button BotonCerrar;
		private System.Windows.Forms.Label NombreLabel;
		private System.Windows.Forms.Label MarcaLabel;
		private System.Windows.Forms.Label DistribuidorLabel;
		private System.Windows.Forms.Label PrecioLabel;
		private System.Windows.Forms.Label ExistenciasLabel;
		private System.Windows.Forms.Label DescripcionLabel;
	}
}