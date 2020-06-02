namespace CapaPresentacion
{
    partial class FrmTest
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
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.cboTest = new System.Windows.Forms.ComboBox();
            this.btnHacerTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboCat
            // 
            this.cboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(141, 84);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(121, 24);
            this.cboCat.TabIndex = 0;
            this.cboCat.SelectedIndexChanged += new System.EventHandler(this.cboCat_SelectedIndexChanged);
            // 
            // cboTest
            // 
            this.cboTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTest.FormattingEnabled = true;
            this.cboTest.Location = new System.Drawing.Point(475, 84);
            this.cboTest.Name = "cboTest";
            this.cboTest.Size = new System.Drawing.Size(121, 24);
            this.cboTest.TabIndex = 1;
            // 
            // btnHacerTest
            // 
            this.btnHacerTest.Location = new System.Drawing.Point(49, 193);
            this.btnHacerTest.Name = "btnHacerTest";
            this.btnHacerTest.Size = new System.Drawing.Size(123, 23);
            this.btnHacerTest.TabIndex = 2;
            this.btnHacerTest.Text = "Hacer test";
            this.btnHacerTest.UseVisualStyleBackColor = true;
            this.btnHacerTest.Click += new System.EventHandler(this.btnHacerTest_Click);
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHacerTest);
            this.Controls.Add(this.cboTest);
            this.Controls.Add(this.cboCat);
            this.Name = "FrmTest";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.ComboBox cboTest;
        private System.Windows.Forms.Button btnHacerTest;
    }
}

