
namespace Paractico1_Ejercicio8_TDI
{
    partial class Form1
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
            this.tittleLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cuilLabel = new System.Windows.Forms.Label();
            this.verifiedLabel = new System.Windows.Forms.Label();
            this.validateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tittleLabel
            // 
            this.tittleLabel.AutoSize = true;
            this.tittleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittleLabel.Location = new System.Drawing.Point(78, 50);
            this.tittleLabel.Name = "tittleLabel";
            this.tittleLabel.Size = new System.Drawing.Size(308, 31);
            this.tittleLabel.TabIndex = 0;
            this.tittleLabel.Text = "Validador de CUIT/CUIL";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(84, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 38);
            this.textBox1.TabIndex = 1;
            // 
            // cuilLabel
            // 
            this.cuilLabel.AutoSize = true;
            this.cuilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuilLabel.Location = new System.Drawing.Point(81, 143);
            this.cuilLabel.Name = "cuilLabel";
            this.cuilLabel.Size = new System.Drawing.Size(201, 17);
            this.cuilLabel.TabIndex = 2;
            this.cuilLabel.Text = "Ingrese su CUIL/CUIT a validar";
            // 
            // verifiedLabel
            // 
            this.verifiedLabel.AutoSize = true;
            this.verifiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifiedLabel.Location = new System.Drawing.Point(79, 258);
            this.verifiedLabel.Name = "verifiedLabel";
            this.verifiedLabel.Size = new System.Drawing.Size(0, 25);
            this.verifiedLabel.TabIndex = 3;
            // 
            // validateButton
            // 
            this.validateButton.Location = new System.Drawing.Point(372, 163);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(95, 38);
            this.validateButton.TabIndex = 4;
            this.validateButton.Text = "Validar";
            this.validateButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 406);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.verifiedLabel);
            this.Controls.Add(this.cuilLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tittleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittleLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label cuilLabel;
        private System.Windows.Forms.Label verifiedLabel;
        private System.Windows.Forms.Button validateButton;
    }
}

