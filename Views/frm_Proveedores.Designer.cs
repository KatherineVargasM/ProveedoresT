namespace Proveedores
{
    partial class frm_Proveedores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Proveedores = new System.Windows.Forms.Label();
            this.lbl_NombreEmpresa = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Lista = new System.Windows.Forms.Label();
            this.txt_NombreEmpresa = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.lst_Proveedores = new System.Windows.Forms.ListBox();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Proveedores
            // 
            this.lbl_Proveedores.AutoSize = true;
            this.lbl_Proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Proveedores.Location = new System.Drawing.Point(328, 43);
            this.lbl_Proveedores.Name = "lbl_Proveedores";
            this.lbl_Proveedores.Size = new System.Drawing.Size(208, 29);
            this.lbl_Proveedores.TabIndex = 0;
            this.lbl_Proveedores.Text = "PROVEEDORES";
            // 
            // lbl_NombreEmpresa
            // 
            this.lbl_NombreEmpresa.AutoSize = true;
            this.lbl_NombreEmpresa.Location = new System.Drawing.Point(79, 102);
            this.lbl_NombreEmpresa.Name = "lbl_NombreEmpresa";
            this.lbl_NombreEmpresa.Size = new System.Drawing.Size(133, 20);
            this.lbl_NombreEmpresa.TabIndex = 1;
            this.lbl_NombreEmpresa.Text = "Nombre Empresa";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(137, 137);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(75, 20);
            this.lbl_Direccion.TabIndex = 2;
            this.lbl_Direccion.Text = "Direccion";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(141, 169);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(71, 20);
            this.lbl_Telefono.TabIndex = 3;
            this.lbl_Telefono.Text = "Telefono";
            // 
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.Location = new System.Drawing.Point(54, 226);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(158, 20);
            this.lbl_Lista.TabIndex = 4;
            this.lbl_Lista.Text = "Lista de Proveedores";
            // 
            // txt_NombreEmpresa
            // 
            this.txt_NombreEmpresa.Location = new System.Drawing.Point(218, 99);
            this.txt_NombreEmpresa.Name = "txt_NombreEmpresa";
            this.txt_NombreEmpresa.Size = new System.Drawing.Size(454, 26);
            this.txt_NombreEmpresa.TabIndex = 5;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(218, 134);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(454, 26);
            this.txt_Direccion.TabIndex = 6;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(218, 169);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(454, 26);
            this.txt_Telefono.TabIndex = 7;
            // 
            // lst_Proveedores
            // 
            this.lst_Proveedores.FormattingEnabled = true;
            this.lst_Proveedores.ItemHeight = 20;
            this.lst_Proveedores.Location = new System.Drawing.Point(218, 226);
            this.lst_Proveedores.Name = "lst_Proveedores";
            this.lst_Proveedores.Size = new System.Drawing.Size(454, 144);
            this.lst_Proveedores.TabIndex = 8;
            this.lst_Proveedores.DoubleClick += new System.EventHandler(this.lst_Proveedores_DoubleClick);
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Location = new System.Drawing.Point(218, 385);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(109, 50);
            this.btn_Grabar.TabIndex = 9;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(333, 384);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(109, 50);
            this.btn_Modificar.TabIndex = 10;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(448, 385);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(109, 50);
            this.btn_Eliminar.TabIndex = 11;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(563, 385);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(109, 50);
            this.btn_Cancelar.TabIndex = 12;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frm_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 468);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Grabar);
            this.Controls.Add(this.lst_Proveedores);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_NombreEmpresa);
            this.Controls.Add(this.lbl_Lista);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.lbl_NombreEmpresa);
            this.Controls.Add(this.lbl_Proveedores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frm_Proveedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Proveedores;
        private System.Windows.Forms.Label lbl_NombreEmpresa;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Lista;
        private System.Windows.Forms.TextBox txt_NombreEmpresa;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.ListBox lst_Proveedores;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}

