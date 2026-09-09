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
            lbReloj = new Label();
            lbFecha = new Label();
            TimeReloj = new System.Windows.Forms.Timer(components);
            lbEjecucion = new Label();
            btnEncender = new Button();
            SuspendLayout();
            // 
            // lbReloj
            // 
            lbReloj.AutoSize = true;
            lbReloj.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbReloj.Location = new Point(89, 64);
            lbReloj.Name = "lbReloj";
            lbReloj.Size = new Size(79, 96);
            lbReloj.TabIndex = 0;
            lbReloj.Text = "0";
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFecha.Location = new Point(89, 179);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(79, 96);
            lbFecha.TabIndex = 1;
            lbFecha.Text = "0";
            // 
            // TimeReloj
            // 
            TimeReloj.Enabled = true;
            TimeReloj.Interval = 1000;
            TimeReloj.Tick += TimeReloj_Tick;
            // 
            // lbEjecucion
            // 
            lbEjecucion.AutoSize = true;
            lbEjecucion.Location = new Point(89, 309);
            lbEjecucion.Name = "lbEjecucion";
            lbEjecucion.Size = new Size(174, 25);
            lbEjecucion.TabIndex = 2;
            lbEjecucion.Text = "Tiempo en ejecucion";
            // 
            // btnEncender
            // 
            btnEncender.Location = new Point(89, 361);
            btnEncender.Name = "btnEncender";
            btnEncender.Size = new Size(112, 34);
            btnEncender.TabIndex = 3;
            btnEncender.Text = "button1";
            btnEncender.UseVisualStyleBackColor = true;
            btnEncender.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEncender);
            Controls.Add(lbEjecucion);
            Controls.Add(lbFecha);
            Controls.Add(lbReloj);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbReloj;
        private Label lbFecha;
        private System.Windows.Forms.Timer TimeReloj;
        private Label lbEjecucion;
        private Button btnEncender;
    }
}
