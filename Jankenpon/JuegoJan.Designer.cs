namespace Jankenpon
{
    partial class JuegoJan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuegoJan));
            this.panelDatos = new System.Windows.Forms.Panel();
            this.lblDatos = new System.Windows.Forms.Label();
            this.JuegoJankenpon = new System.Windows.Forms.ImageList(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pBMachine = new System.Windows.Forms.PictureBox();
            this.pBJugador = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMachine = new System.Windows.Forms.Label();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBJugador)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelDatos.Controls.Add(this.btnExit);
            this.panelDatos.Controls.Add(this.lblDatos);
            this.panelDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDatos.Location = new System.Drawing.Point(-2, -3);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(629, 95);
            this.panelDatos.TabIndex = 0;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(3, 12);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(57, 20);
            this.lblDatos.TabIndex = 0;
            this.lblDatos.Text = "label1";
            // 
            // JuegoJankenpon
            // 
            this.JuegoJankenpon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("JuegoJankenpon.ImageStream")));
            this.JuegoJankenpon.TransparentColor = System.Drawing.Color.Transparent;
            this.JuegoJankenpon.Images.SetKeyName(0, "Piedra.png");
            this.JuegoJankenpon.Images.SetKeyName(1, "Papel.png");
            this.JuegoJankenpon.Images.SetKeyName(2, "Tijeras.png");
            // 
            // btnStop
            // 
            this.btnStop.Image = global::Jankenpon.Properties.Resources.stopButton;
            this.btnStop.Location = new System.Drawing.Point(322, 313);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(108, 62);
            this.btnStop.TabIndex = 4;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Image = global::Jankenpon.Properties.Resources.playButton;
            this.btnIniciar.Location = new System.Drawing.Point(151, 313);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(108, 62);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pBMachine
            // 
            this.pBMachine.Image = global::Jankenpon.Properties.Resources.Piedra;
            this.pBMachine.Location = new System.Drawing.Point(362, 143);
            this.pBMachine.Name = "pBMachine";
            this.pBMachine.Size = new System.Drawing.Size(93, 100);
            this.pBMachine.TabIndex = 2;
            this.pBMachine.TabStop = false;
            // 
            // pBJugador
            // 
            this.pBJugador.Image = global::Jankenpon.Properties.Resources.Papel;
            this.pBJugador.Location = new System.Drawing.Point(138, 143);
            this.pBJugador.Name = "pBJugador";
            this.pBJugador.Size = new System.Drawing.Size(93, 100);
            this.pBJugador.TabIndex = 1;
            this.pBJugador.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::Jankenpon.Properties.Resources.exitButton;
            this.btnExit.Location = new System.Drawing.Point(499, 24);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 56);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.lblMachine);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-2, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 95);
            this.panel1.TabIndex = 2;
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(3, 12);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(57, 20);
            this.lblMachine.TabIndex = 0;
            this.lblMachine.Text = "label1";
            // 
            // JuegoJan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 543);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.pBMachine);
            this.Controls.Add(this.pBJugador);
            this.Controls.Add(this.panelDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JuegoJan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JuegoJan";
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBJugador)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.PictureBox pBJugador;
        private System.Windows.Forms.ImageList JuegoJankenpon;
        private System.Windows.Forms.PictureBox pBMachine;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMachine;
    }
}