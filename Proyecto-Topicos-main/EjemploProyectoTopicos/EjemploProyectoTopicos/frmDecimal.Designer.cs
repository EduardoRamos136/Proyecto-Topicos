
namespace EjemploProyectoTopicos
{
    partial class frmDecimal
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
            this.txtDecim = new System.Windows.Forms.TextBox();
            this.lblTitDecim = new System.Windows.Forms.Label();
            this.lblResultadoBinario = new System.Windows.Forms.Label();
            this.lblTitResul = new System.Windows.Forms.Label();
            this.cmbDecim = new System.Windows.Forms.ComboBox();
            this.btnArchivar = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDecim
            // 
            this.txtDecim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDecim.Location = new System.Drawing.Point(262, 128);
            this.txtDecim.Multiline = true;
            this.txtDecim.Name = "txtDecim";
            this.txtDecim.Size = new System.Drawing.Size(196, 40);
            this.txtDecim.TabIndex = 12;
            // 
            // lblTitDecim
            // 
            this.lblTitDecim.AutoSize = true;
            this.lblTitDecim.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitDecim.Location = new System.Drawing.Point(103, 47);
            this.lblTitDecim.Name = "lblTitDecim";
            this.lblTitDecim.Size = new System.Drawing.Size(343, 45);
            this.lblTitDecim.TabIndex = 9;
            this.lblTitDecim.Text = "Decimal a -------->";
            // 
            // lblResultadoBinario
            // 
            this.lblResultadoBinario.AutoSize = true;
            this.lblResultadoBinario.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoBinario.Location = new System.Drawing.Point(213, 233);
            this.lblResultadoBinario.Name = "lblResultadoBinario";
            this.lblResultadoBinario.Size = new System.Drawing.Size(60, 27);
            this.lblResultadoBinario.TabIndex = 10;
            this.lblResultadoBinario.Text = "????";
            // 
            // lblTitResul
            // 
            this.lblTitResul.AutoSize = true;
            this.lblTitResul.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitResul.Location = new System.Drawing.Point(39, 233);
            this.lblTitResul.Name = "lblTitResul";
            this.lblTitResul.Size = new System.Drawing.Size(138, 27);
            this.lblTitResul.TabIndex = 11;
            this.lblTitResul.Text = "Resultado:";
            // 
            // cmbDecim
            // 
            this.cmbDecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDecim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbDecim.FormattingEnabled = true;
            this.cmbDecim.Items.AddRange(new object[] {
            "Binario",
            "Octal",
            "Hexadecimal"});
            this.cmbDecim.Location = new System.Drawing.Point(28, 128);
            this.cmbDecim.Name = "cmbDecim";
            this.cmbDecim.Size = new System.Drawing.Size(204, 37);
            this.cmbDecim.TabIndex = 8;
            // 
            // btnArchivar
            // 
            this.btnArchivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnArchivar.Location = new System.Drawing.Point(158, 329);
            this.btnArchivar.Name = "btnArchivar";
            this.btnArchivar.Size = new System.Drawing.Size(115, 55);
            this.btnArchivar.TabIndex = 4;
            this.btnArchivar.Text = "Archivar";
            this.btnArchivar.UseVisualStyleBackColor = true;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConvertir.Location = new System.Drawing.Point(28, 329);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(115, 55);
            this.btnConvertir.TabIndex = 5;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRegresar.Location = new System.Drawing.Point(292, 329);
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
            this.btnBorrar.Location = new System.Drawing.Point(428, 329);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(115, 55);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmDecimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 430);
            this.Controls.Add(this.txtDecim);
            this.Controls.Add(this.lblTitDecim);
            this.Controls.Add(this.lblResultadoBinario);
            this.Controls.Add(this.lblTitResul);
            this.Controls.Add(this.cmbDecim);
            this.Controls.Add(this.btnArchivar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnBorrar);
            this.Name = "frmDecimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDecim;
        private System.Windows.Forms.Label lblTitDecim;
        private System.Windows.Forms.Label lblResultadoBinario;
        private System.Windows.Forms.Label lblTitResul;
        private System.Windows.Forms.ComboBox cmbDecim;
        private System.Windows.Forms.Button btnArchivar;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnBorrar;
    }
}