
namespace EjemploProyectoTopicos
{
    partial class frmBinario
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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cmbBin = new System.Windows.Forms.ComboBox();
            this.lblTitResul = new System.Windows.Forms.Label();
            this.txtBin = new System.Windows.Forms.TextBox();
            this.lblTitBin = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnArchivar = new System.Windows.Forms.Button();
            this.lblResultadoBinario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBorrar.Location = new System.Drawing.Point(426, 314);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(115, 55);
            this.btnBorrar.TabIndex = 0;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // cmbBin
            // 
            this.cmbBin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbBin.FormattingEnabled = true;
            this.cmbBin.Items.AddRange(new object[] {
            "Decimal",
            "Octal",
            "Hexadecimal"});
            this.cmbBin.Location = new System.Drawing.Point(26, 113);
            this.cmbBin.Name = "cmbBin";
            this.cmbBin.Size = new System.Drawing.Size(199, 37);
            this.cmbBin.TabIndex = 1;
            // 
            // lblTitResul
            // 
            this.lblTitResul.AutoSize = true;
            this.lblTitResul.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitResul.Location = new System.Drawing.Point(37, 218);
            this.lblTitResul.Name = "lblTitResul";
            this.lblTitResul.Size = new System.Drawing.Size(138, 27);
            this.lblTitResul.TabIndex = 2;
            this.lblTitResul.Text = "Resultado:";
            // 
            // txtBin
            // 
            this.txtBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBin.Location = new System.Drawing.Point(248, 113);
            this.txtBin.Multiline = true;
            this.txtBin.Name = "txtBin";
            this.txtBin.Size = new System.Drawing.Size(196, 40);
            this.txtBin.TabIndex = 3;
            // 
            // lblTitBin
            // 
            this.lblTitBin.AutoSize = true;
            this.lblTitBin.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitBin.Location = new System.Drawing.Point(101, 32);
            this.lblTitBin.Name = "lblTitBin";
            this.lblTitBin.Size = new System.Drawing.Size(324, 45);
            this.lblTitBin.TabIndex = 2;
            this.lblTitBin.Text = "Binario a -------->";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRegresar.Location = new System.Drawing.Point(290, 314);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(115, 55);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConvertir.Location = new System.Drawing.Point(26, 314);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(115, 55);
            this.btnConvertir.TabIndex = 0;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            // 
            // btnArchivar
            // 
            this.btnArchivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnArchivar.Location = new System.Drawing.Point(156, 314);
            this.btnArchivar.Name = "btnArchivar";
            this.btnArchivar.Size = new System.Drawing.Size(115, 55);
            this.btnArchivar.TabIndex = 0;
            this.btnArchivar.Text = "Archivar";
            this.btnArchivar.UseVisualStyleBackColor = true;
            // 
            // lblResultadoBinario
            // 
            this.lblResultadoBinario.AutoSize = true;
            this.lblResultadoBinario.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoBinario.Location = new System.Drawing.Point(211, 218);
            this.lblResultadoBinario.Name = "lblResultadoBinario";
            this.lblResultadoBinario.Size = new System.Drawing.Size(60, 27);
            this.lblResultadoBinario.TabIndex = 2;
            this.lblResultadoBinario.Text = "????";
            // 
            // frmBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 430);
            this.Controls.Add(this.txtBin);
            this.Controls.Add(this.lblTitBin);
            this.Controls.Add(this.lblResultadoBinario);
            this.Controls.Add(this.lblTitResul);
            this.Controls.Add(this.cmbBin);
            this.Controls.Add(this.btnArchivar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnBorrar);
            this.Name = "frmBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cmbBin;
        private System.Windows.Forms.Label lblTitResul;
        private System.Windows.Forms.TextBox txtBin;
        private System.Windows.Forms.Label lblTitBin;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnArchivar;
        private System.Windows.Forms.Label lblResultadoBinario;
    }
}