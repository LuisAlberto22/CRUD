namespace CRUD
{
	partial class Form1
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
			this.TablaDeRegistros = new System.Windows.Forms.DataGridView();
			this.BotonInsertar = new System.Windows.Forms.Button();
			this.BotonModificar = new System.Windows.Forms.Button();
			this.BotonEliminar = new System.Windows.Forms.Button();
			this.BotonBuscar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.TablaDeRegistros)).BeginInit();
			this.SuspendLayout();
			// 
			// TablaDeRegistros
			// 
			this.TablaDeRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TablaDeRegistros.GridColor = System.Drawing.SystemColors.Control;
			this.TablaDeRegistros.Location = new System.Drawing.Point(12, 12);
			this.TablaDeRegistros.MultiSelect = false;
			this.TablaDeRegistros.Name = "TablaDeRegistros";
			this.TablaDeRegistros.ReadOnly = true;
			this.TablaDeRegistros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.TablaDeRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.TablaDeRegistros.Size = new System.Drawing.Size(737, 332);
			this.TablaDeRegistros.TabIndex = 0;
			// 
			// BotonInsertar
			// 
			this.BotonInsertar.Location = new System.Drawing.Point(755, 17);
			this.BotonInsertar.Name = "BotonInsertar";
			this.BotonInsertar.Size = new System.Drawing.Size(121, 65);
			this.BotonInsertar.TabIndex = 1;
			this.BotonInsertar.Text = "Insertar";
			this.BotonInsertar.UseVisualStyleBackColor = true;
			this.BotonInsertar.Click += new System.EventHandler(this.BotonInsertar_Click);
			// 
			// BotonModificar
			// 
			this.BotonModificar.Location = new System.Drawing.Point(755, 102);
			this.BotonModificar.Name = "BotonModificar";
			this.BotonModificar.Size = new System.Drawing.Size(121, 65);
			this.BotonModificar.TabIndex = 2;
			this.BotonModificar.Text = "Modificar";
			this.BotonModificar.UseVisualStyleBackColor = true;
			this.BotonModificar.Click += new System.EventHandler(this.BotonModificar_Click);
			// 
			// BotonEliminar
			// 
			this.BotonEliminar.Location = new System.Drawing.Point(755, 283);
			this.BotonEliminar.Name = "BotonEliminar";
			this.BotonEliminar.Size = new System.Drawing.Size(121, 65);
			this.BotonEliminar.TabIndex = 3;
			this.BotonEliminar.Text = "Eliminar";
			this.BotonEliminar.UseVisualStyleBackColor = true;
			this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
			// 
			// BotonBuscar
			// 
			this.BotonBuscar.Location = new System.Drawing.Point(755, 189);
			this.BotonBuscar.Name = "BotonBuscar";
			this.BotonBuscar.Size = new System.Drawing.Size(121, 65);
			this.BotonBuscar.TabIndex = 4;
			this.BotonBuscar.Text = "Buscar";
			this.BotonBuscar.UseVisualStyleBackColor = true;
			this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 352);
			this.Controls.Add(this.BotonBuscar);
			this.Controls.Add(this.BotonEliminar);
			this.Controls.Add(this.BotonModificar);
			this.Controls.Add(this.BotonInsertar);
			this.Controls.Add(this.TablaDeRegistros);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema de ventas (Productos)";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.TablaDeRegistros)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView TablaDeRegistros;
		private System.Windows.Forms.Button BotonInsertar;
		private System.Windows.Forms.Button BotonModificar;
		private System.Windows.Forms.Button BotonEliminar;
		private System.Windows.Forms.Button BotonBuscar;
	}
}

