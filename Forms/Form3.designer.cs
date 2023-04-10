
namespace ProyectoCatedra_PED_MR190768_GM172474_CM221954.Forms
{
    partial class Form3
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
            this.panel_l = new System.Windows.Forms.Panel();
            this.panel_cola = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_atendido = new System.Windows.Forms.Label();
            this.panel_l.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_l
            // 
            this.panel_l.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_l.Controls.Add(this.lbl_atendido);
            this.panel_l.Controls.Add(this.label1);
            this.panel_l.Controls.Add(this.pictureBox1);
            this.panel_l.Location = new System.Drawing.Point(13, 13);
            this.panel_l.Name = "panel_l";
            this.panel_l.Size = new System.Drawing.Size(214, 425);
            this.panel_l.TabIndex = 0;
            // 
            // panel_cola
            // 
            this.panel_cola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_cola.Location = new System.Drawing.Point(234, 13);
            this.panel_cola.Name = "panel_cola";
            this.panel_cola.Size = new System.Drawing.Size(554, 425);
            this.panel_cola.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(39, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 155);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ultimo atenido:";
            // 
            // lbl_atendido
            // 
            this.lbl_atendido.AutoSize = true;
            this.lbl_atendido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_atendido.Location = new System.Drawing.Point(43, 249);
            this.lbl_atendido.Name = "lbl_atendido";
            this.lbl_atendido.Size = new System.Drawing.Size(12, 13);
            this.lbl_atendido.TabIndex = 2;
            this.lbl_atendido.Text = "\"";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_cola);
            this.Controls.Add(this.panel_l);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel_l.ResumeLayout(false);
            this.panel_l.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_l;
        private System.Windows.Forms.Label lbl_atendido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_cola;
    }
}