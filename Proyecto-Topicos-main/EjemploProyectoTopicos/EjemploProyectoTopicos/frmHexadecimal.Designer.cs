
namespace EjemploProyectoTopicos
{
    partial class frmHexadecimal
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
            this.txtHex = new System.Windows.Forms.TextBox();
            this.lblTitHex = new System.Windows.Forms.Label();
            this.lblResultadoOctal = new System.Windows.Forms.Label();
            this.lblTitResul = new System.Windows.Forms.Label();
            this.cmbHex = new System.Windows.Forms.ComboBox();
            this.btnArchivar = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHex
            // 
            this.txtHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHex.Location = new System.Drawing.Point(302, 147);
            this.txtHex.Multiline = true;
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(196, 40);
            this.txtHex.TabIndex = 21;
            // 
            // lblTitHex
            // 
            this.lblTitHex.AutoSize = true;
            this.lblTitHex.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitHex.Location = new System.Drawing.Point(105, 40);
            this.lblTitHex.Name = "lblTitHex";
            this.lblTitHex.Size = new System.Drawing.Size(437, 45);
            this.lblTitHex.TabIndex = 18;
            this.lblTitHex.Text = "Hexadecimal a -------->";
            // 
            // lblResultadoOctal
            // 
            this.lblResultadoOctal.AutoSize = true;
            this.lblResultadoOctal.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoOctal.Location = new System.Drawing.Point(251, 252);
            this.lblResultadoOctal.Name = "lblResultadoOctal";
            this.lblResultadoOctal.Size = new System.Drawing.Size(60, 27);
            this.lblResultadoOctal.TabIndex = 19;
            this.lblResultadoOctal.Text = "????";
            // 
            // lblTitResul
            // 
            this.lblTitResul.AutoSize = true;
            this.lblTitResul.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitResul.Location = new System.Drawing.Point(77, 252);
            this.lblTitResul.Name = "lblTitResul";
            this.lblTitResul.Size = new System.Drawing.Size(138, 27);
            this.lblTitResul.TabIndex = 20;
            this.lblTitResul.Text = "Resultado:";
            // 
            // cmbHex
            // 
            this.cmbHex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbHex.FormattingEnabled = true;
            this.cmbHex.Items.AddRange(new object[] {
            "Decimal",
            "Binario",
            "Octal"});
            this.cmbHex.Location = new System.Drawing.Point(66, 147);
            this.cmbHex.Name = "cmbHex";
            this.cmbHex.Size = new System.Drawing.Size(207, 37);
            this.cmbHex.TabIndex = 17;
            // 
            // btnArchivar
            // 
            this.btnArchivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnArchivar.Location = new System.Drawing.Point(158, 335);
            this.btnArchivar.Name = "btnArchivar";
            this.btnArchivar.Size = new System.Drawing.Size(115, 55);
            this.btnArchivar.TabIndex = 13;
            this.btnArchivar.Text = "Archivar";
            this.btnArchivar.UseVisualStyleBackColor = true;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConvertir.Location = new System.Drawing.Point(28, 335);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(115, 55);
            this.btnConvertir.TabIndex = 14;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRegresar.Location = new System.Drawing.Point(292, 335);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(115, 55);
            this.btnRegresar.TabIndex = 15;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBorrar.Location = new System.Drawing.Point(428, 335);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(115, 55);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmHexadecimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 430);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.lblTitHex);
            this.Controls.Add(this.lblResultadoOctal);
            this.Controls.Add(this.lblTitResul);
            this.Controls.Add(this.cmbHex);
            this.Controls.Add(this.btnArchivar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnBorrar);
            this.Name = "frmHexadecimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hexadecimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.Label lblTitHex;
        private System.Windows.Forms.Label lblResultadoOctal;
        private System.Windows.Forms.Label lblTitResul;
        private System.Windows.Forms.ComboBox cmbHex;
        private System.Windows.Forms.Button btnArchivar;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnBorrar;
    }
}