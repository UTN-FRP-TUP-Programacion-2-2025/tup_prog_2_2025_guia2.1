namespace Ejercicio2
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
            tbMultilineauNReciboDeSueldo = new TextBox();
            btnRegistrarEmpleado = new Button();
            btnGenerar = new Button();
            btnMostrarLiquidaciones = new Button();
            SuspendLayout();
            // 
            // tbMultilineauNReciboDeSueldo
            // 
            tbMultilineauNReciboDeSueldo.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbMultilineauNReciboDeSueldo.Location = new Point(18, 92);
            tbMultilineauNReciboDeSueldo.Margin = new Padding(4, 5, 4, 5);
            tbMultilineauNReciboDeSueldo.Multiline = true;
            tbMultilineauNReciboDeSueldo.Name = "tbMultilineauNReciboDeSueldo";
            tbMultilineauNReciboDeSueldo.Size = new Size(640, 324);
            tbMultilineauNReciboDeSueldo.TabIndex = 0;
            // 
            // btnRegistrarEmpleado
            // 
            btnRegistrarEmpleado.Location = new Point(89, 14);
            btnRegistrarEmpleado.Margin = new Padding(4, 5, 4, 5);
            btnRegistrarEmpleado.Name = "btnRegistrarEmpleado";
            btnRegistrarEmpleado.Size = new Size(131, 52);
            btnRegistrarEmpleado.TabIndex = 1;
            btnRegistrarEmpleado.Text = "Registrar Empleado(1)";
            btnRegistrarEmpleado.UseVisualStyleBackColor = true;
            btnRegistrarEmpleado.Click += btnRegistrarEmpleado_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(255, 15);
            btnGenerar.Margin = new Padding(4, 5, 4, 5);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(163, 51);
            btnGenerar.TabIndex = 3;
            btnGenerar.Text = "Generar Liquidaciones(2)";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMostrarLiquidaciones
            // 
            btnMostrarLiquidaciones.Location = new Point(467, 16);
            btnMostrarLiquidaciones.Margin = new Padding(4, 5, 4, 5);
            btnMostrarLiquidaciones.Name = "btnMostrarLiquidaciones";
            btnMostrarLiquidaciones.Size = new Size(155, 50);
            btnMostrarLiquidaciones.TabIndex = 4;
            btnMostrarLiquidaciones.Text = "Mostrar Liquidaciones(3)";
            btnMostrarLiquidaciones.UseVisualStyleBackColor = true;
            btnMostrarLiquidaciones.Click += btnMostrarLiquidaciones_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 424);
            Controls.Add(btnMostrarLiquidaciones);
            Controls.Add(btnGenerar);
            Controls.Add(btnRegistrarEmpleado);
            Controls.Add(tbMultilineauNReciboDeSueldo);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio2";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMultilineauNReciboDeSueldo;
        private System.Windows.Forms.Button btnRegistrarEmpleado;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnMostrarLiquidaciones;
    }
}

