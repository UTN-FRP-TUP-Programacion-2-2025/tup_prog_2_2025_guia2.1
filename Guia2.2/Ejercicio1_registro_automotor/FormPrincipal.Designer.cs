namespace Ejercicio1
{
    partial class FormPrincipal
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
            btnRegistrar = new Button();
            lbxRegistros = new ListBox();
            btnListar = new Button();
            tbImpresoRegistro = new TextBox();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(391, 29);
            btnRegistrar.Margin = new Padding(4, 5, 4, 5);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(168, 51);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lbxRegistros
            // 
            lbxRegistros.FormattingEnabled = true;
            lbxRegistros.Location = new Point(12, 127);
            lbxRegistros.Name = "lbxRegistros";
            lbxRegistros.Size = new Size(372, 144);
            lbxRegistros.TabIndex = 2;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(391, 127);
            btnListar.Margin = new Padding(4, 5, 4, 5);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(168, 51);
            btnListar.TabIndex = 3;
            btnListar.Text = "Listar Registros";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // tbImpresoRegistro
            // 
            tbImpresoRegistro.AllowDrop = true;
            tbImpresoRegistro.Location = new Point(12, 15);
            tbImpresoRegistro.Multiline = true;
            tbImpresoRegistro.Name = "tbImpresoRegistro";
            tbImpresoRegistro.Size = new Size(372, 94);
            tbImpresoRegistro.TabIndex = 4;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 286);
            Controls.Add(tbImpresoRegistro);
            Controls.Add(btnListar);
            Controls.Add(lbxRegistros);
            Controls.Add(btnRegistrar);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPrincipal";
            Text = "Registro Vehicular";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListBox lbxRegistros;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox tbImpresoRegistro;
    }
}

