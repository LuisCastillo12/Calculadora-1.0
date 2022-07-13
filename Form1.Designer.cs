namespace Calculadora
{
    partial class Calculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnMayor = new System.Windows.Forms.Button();
            this.btnMenor = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnpromLiteral = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(86, 143);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(216, 20);
            this.txtN1.TabIndex = 2;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(86, 170);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(216, 20);
            this.txtN2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero 2";
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(36, 207);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(43, 24);
            this.btnSuma.TabIndex = 5;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(138, 207);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(43, 24);
            this.btnDivision.TabIndex = 6;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.BtnDivision_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(89, 207);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(43, 24);
            this.btnResta.TabIndex = 7;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.BtnResta_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(187, 207);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(43, 24);
            this.btnMultiplicacion.TabIndex = 8;
            this.btnMultiplicacion.Text = "*";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.BtnMultiplicacion_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(246, 207);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(95, 24);
            this.btnPromedio.TabIndex = 9;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.BtnPromedio_Click);
            // 
            // btnMayor
            // 
            this.btnMayor.Location = new System.Drawing.Point(36, 237);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(64, 29);
            this.btnMayor.TabIndex = 10;
            this.btnMayor.Text = "Mayor";
            this.btnMayor.UseVisualStyleBackColor = true;
            this.btnMayor.Click += new System.EventHandler(this.BtnMayor_Click);
            // 
            // btnMenor
            // 
            this.btnMenor.Location = new System.Drawing.Point(122, 237);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(64, 29);
            this.btnMenor.TabIndex = 11;
            this.btnMenor.Text = "Menor";
            this.btnMenor.UseVisualStyleBackColor = true;
            this.btnMenor.Click += new System.EventHandler(this.BtnMenor_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(38, 282);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(55, 13);
            this.Resultado.TabIndex = 12;
            this.Resultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(123, 279);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(232, 20);
            this.txtResultado.TabIndex = 13;
            // 
            // btnpromLiteral
            // 
            this.btnpromLiteral.Location = new System.Drawing.Point(207, 237);
            this.btnpromLiteral.Name = "btnpromLiteral";
            this.btnpromLiteral.Size = new System.Drawing.Size(148, 29);
            this.btnpromLiteral.TabIndex = 14;
            this.btnpromLiteral.Text = "Eq literal del promedio";
            this.btnpromLiteral.UseVisualStyleBackColor = true;
            this.btnpromLiteral.Click += new System.EventHandler(this.BtnpromLiteral_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Calculadora";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Version 1.0";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 345);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnpromLiteral);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.btnMenor);
            this.Controls.Add(this.btnMayor);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.Button btnMenor;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnpromLiteral;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

