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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboCat
            // 
            this.cboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(143, 97);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(121, 24);
            this.cboCat.TabIndex = 0;
            this.cboCat.SelectedIndexChanged += new System.EventHandler(this.cboCat_SelectedIndexChanged);
            // 
            // cboTest
            // 
            this.cboTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTest.FormattingEnabled = true;
            this.cboTest.Location = new System.Drawing.Point(474, 97);
            this.cboTest.Name = "cboTest";
            this.cboTest.Size = new System.Drawing.Size(164, 24);
            this.cboTest.TabIndex = 1;
            this.cboTest.SelectedIndexChanged += new System.EventHandler(this.cboTest_SelectedIndexChanged);
            // 
            // btnHacerTest
            // 
            this.btnHacerTest.Location = new System.Drawing.Point(52, 238);
            this.btnHacerTest.Name = "btnHacerTest";
            this.btnHacerTest.Size = new System.Drawing.Size(123, 23);
            this.btnHacerTest.TabIndex = 2;
            this.btnHacerTest.Text = "Hacer test";
            this.btnHacerTest.UseVisualStyleBackColor = true;
            this.btnHacerTest.Click += new System.EventHandler(this.btnHacerTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Categorias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tests";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(49, 178);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 17);
            this.lblTest.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOS TEST DE ARITZ";
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHacerTest);
            this.Controls.Add(this.cboTest);
            this.Controls.Add(this.cboCat);
            this.Name = "FrmTest";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.ComboBox cboTest;
        private System.Windows.Forms.Button btnHacerTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label label3;
    }
}

