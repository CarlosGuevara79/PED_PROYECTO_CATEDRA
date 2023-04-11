
namespace ProyectoCatedra_PED_MR190768_GM172474_CM221954.Forms
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_datosCola = new System.Windows.Forms.DataGridView();
            this.Campo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datosCola)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Atender";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_datosCola
            // 
            this.dgv_datosCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datosCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Campo1,
            this.Campo2,
            this.Campo3,
            this.Campo4});
            this.dgv_datosCola.Location = new System.Drawing.Point(121, 12);
            this.dgv_datosCola.Name = "dgv_datosCola";
            this.dgv_datosCola.Size = new System.Drawing.Size(646, 392);
            this.dgv_datosCola.TabIndex = 1;
            // 
            // Campo1
            // 
            this.Campo1.HeaderText = "Campo1";
            this.Campo1.Name = "Campo1";
            // 
            // Campo2
            // 
            this.Campo2.HeaderText = "Campo2";
            this.Campo2.Name = "Campo2";
            // 
            // Campo3
            // 
            this.Campo3.HeaderText = "Campo3";
            this.Campo3.Name = "Campo3";
            // 
            // Campo4
            // 
            this.Campo4.HeaderText = "Campo4";
            this.Campo4.Name = "Campo4";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_datosCola);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datosCola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_datosCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo4;
    }
}