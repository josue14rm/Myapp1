namespace Myapp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            configurarAlarmaToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            timerReloj = new System.Windows.Forms.Timer(components);
            lb1 = new Label();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configurarAlarmaToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // configurarAlarmaToolStripMenuItem
            // 
            configurarAlarmaToolStripMenuItem.Name = "configurarAlarmaToolStripMenuItem";
            configurarAlarmaToolStripMenuItem.Size = new Size(270, 34);
            configurarAlarmaToolStripMenuItem.Text = "Configurar Alarma";
            configurarAlarmaToolStripMenuItem.Click += configurarAlarmaToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(270, 34);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // timerReloj
            // 
            timerReloj.Enabled = true;
            timerReloj.Interval = 1000;
            timerReloj.Tick += timerReloj_Tick;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb1.Location = new Point(229, 138);
            lb1.Name = "lb1";
            lb1.Size = new Size(79, 96);
            lb1.TabIndex = 2;
            lb1.Text = "0";
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(532, 229);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(238, 121);
            axWindowsMediaPlayer1.TabIndex = 3;
            axWindowsMediaPlayer1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(lb1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timerReloj;
        private Label lb1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem configurarAlarmaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}
