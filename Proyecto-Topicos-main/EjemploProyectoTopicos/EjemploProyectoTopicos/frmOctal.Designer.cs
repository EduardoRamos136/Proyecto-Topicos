
namespace EjemploProyectoTopicos
{
    partial class frmOctal
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
            this.txtOct = new System.Windows.Forms.TextBox();
            this.lblTitOct = new System.Windows.Forms.Label();
            this.lblResultadoOctal = new System.Windows.Forms.Label();
            this.lblTitResul = new System.Windows.Forms.Label();
            this.cmbOct = new System.Windows.Forms.ComboBox();
            this.btnArchivar = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOct
            // 
            this.txtOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtOct.Location = new System.Drawing.Point(293, 138);
            this.txtOct.Multiline = true;
            this.txtOct.Name = "txtOct";
            this.txtOct.Size = new System.Drawing.Size(196, 40);
            this.txtOct.TabIndex = 12;
            // 
            // lblTitOct
            // 
            this.lblTitOct.AutoSize = true;
            this.lblTitOct.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitOct.Location = new System.Drawing.Point(106, 31);
            this.lblTitOct.Name = "lblTitOct";
            this.lblTitOct.Size = new System.Drawing.Size(284, 45);
            this.lblTitOct.TabIndex = 9;
            this.lblTitOct.Text = "Octal a -------->";
            // 
            // lblResultadoOctal
            // 
            this.lblResultadoOctal.AutoSize = true;
            this.lblResultadoOctal.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoOctal.Location = new System.Drawing.Point(252, 243);
            this.lblResultadoOctal.Name = "lblResultadoOctal";
            this.lblResultadoOctal.Size = new System.Drawing.Size(60, 27);
            this.lblResultadoOctal.TabIndex = 10;
            this.lblResultadoOctal.Text = "????";
            // 
            // lblTitResul
            // 
            this.lblTitResul.AutoSize = true;
            this.lblTitResul.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitResul.Location = new System.Drawing.Point(78, 243);
            this.lblTitResul.Name = "lblTitResul";
            this.lblTitResul.Size = new System.Drawing.Size(138, 27);
            this.lblTitResul.TabIndex = 11;
            this.lblTitResul.Text = "Resultado:";
            // 
            // cmbOct
            // 
            this.cmbOct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbOct.FormattingEnabled = true;
            this.cmbOct.Items.AddRange(new object[] {
            "Decimal",
            "Binario",
            "Hexadecimal"});
            this.cmbOct.Location = new System.Drawing.Point(67, 138);
            this.cmbOct.Name = "cmbOct";
            this.cmbOct.Size = new System.Drawing.Size(207, 37);
            this.cmbOct.TabIndex = 8;
            // 
            // btnArchivar
            // 
            this.btnArchivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnArchivar.Location = new System.Drawing.Point(159, 326);
            this.btnArchivar.Name = "btnArchivar";
            this.btnArchivar.Size = new System.Drawing.Size(115, 55);
            this.btnArchivar.TabIndex = 4;
            this.btnArchivar.Text = "Archivar";
            this.btnArchivar.UseVisualStyleBackColor = true;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConvertir.Location = new System.Drawing.Point(29, 326);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(115, 55);
            this.btnConvertir.TabIndex = 5;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRegresar.Location = new System.Drawing.Point(293, 326);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(115, 55);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBorrar.Location = new System.Drawing.Point(429, 326);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(115, 55);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmOctal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 430);
            this.Controls.Add(this.txtOct);
            this.Controls.Add(this.lblTitOct);
            this.Controls.Add(this.lblResultadoOctal);
            this.Controls.Add(this.lblTitResul);
            this.Controls.Add(this.cmbOct);
            this.Controls.Add(this.btnArchivar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnBorrar);
            this.Name = "frmOctal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Octal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOct;
        private System.Windows.Forms.Label lblTitOct;
        private System.Windows.Forms.Label lblResultadoOctal;
        private System.Windows.Forms.Label lblTitResul;
        private System.Windows.Forms.ComboBox cmbOct;
        private System.Windows.Forms.Button btnArchivar;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnBorrar;
    }
}