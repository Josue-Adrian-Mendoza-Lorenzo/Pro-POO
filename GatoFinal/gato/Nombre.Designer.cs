namespace gato
{
    partial class Nombre
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtjugador1 = new System.Windows.Forms.TextBox();
            this.txtjugador2 = new System.Windows.Forms.TextBox();
            this.btnempezar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del jugador 1: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del jugador 2: ";
            // 
            // txtjugador1
            // 
            this.txtjugador1.Location = new System.Drawing.Point(12, 25);
            this.txtjugador1.Name = "txtjugador1";
            this.txtjugador1.Size = new System.Drawing.Size(145, 20);
            this.txtjugador1.TabIndex = 1;
            this.txtjugador1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtjugador1_KeyPress);
            // 
            // txtjugador2
            // 
            this.txtjugador2.Location = new System.Drawing.Point(12, 91);
            this.txtjugador2.Name = "txtjugador2";
            this.txtjugador2.Size = new System.Drawing.Size(145, 20);
            this.txtjugador2.TabIndex = 2;
            // 
            // btnempezar
            // 
            this.btnempezar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnempezar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempezar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnempezar.Location = new System.Drawing.Point(196, 48);
            this.btnempezar.Name = "btnempezar";
            this.btnempezar.Size = new System.Drawing.Size(90, 40);
            this.btnempezar.TabIndex = 3;
            this.btnempezar.Text = "Empezar";
            this.btnempezar.UseVisualStyleBackColor = false;
            this.btnempezar.Click += new System.EventHandler(this.btnempezar_Click);
            // 
            // Nombre
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(322, 140);
            this.ControlBox = false;
            this.Controls.Add(this.btnempezar);
            this.Controls.Add(this.txtjugador2);
            this.Controls.Add(this.txtjugador1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(338, 179);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(338, 179);
            this.Name = "Nombre";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombre";
            this.Load += new System.EventHandler(this.Nombre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtjugador1;
        private System.Windows.Forms.TextBox txtjugador2;
        private System.Windows.Forms.Button btnempezar;
    }
}