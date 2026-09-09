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
            label1 = new Label();
            label2 = new Label();
            BtCalcula = new Button();
            btLimpiar = new Button();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            txtResultado = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 55);
            label1.Name = "label1";
            label1.Size = new Size(157, 38);
            label1.TabIndex = 0;
            label1.Text = "NUMERO 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 126);
            label2.Name = "label2";
            label2.Size = new Size(157, 38);
            label2.TabIndex = 1;
            label2.Text = "NUMERO 2";
            // 
            // BtCalcula
            // 
            BtCalcula.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtCalcula.Location = new Point(388, 49);
            BtCalcula.Name = "BtCalcula";
            BtCalcula.Size = new Size(160, 48);
            BtCalcula.TabIndex = 2;
            BtCalcula.Text = "CALCULA";
            BtCalcula.UseVisualStyleBackColor = true;
            BtCalcula.Click += BtCalcula_Click;
            // 
            // btLimpiar
            // 
            btLimpiar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btLimpiar.Location = new Point(388, 117);
            btLimpiar.Name = "btLimpiar";
            btLimpiar.Size = new Size(160, 47);
            btLimpiar.TabIndex = 3;
            btLimpiar.Text = "LIMPIAR";
            btLimpiar.UseVisualStyleBackColor = true;
            btLimpiar.Click += button2_Click;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(209, 62);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(150, 31);
            txtNumero1.TabIndex = 4;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(209, 132);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(150, 31);
            txtNumero2.TabIndex = 5;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(398, 225);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(150, 31);
            txtResultado.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 231);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 7;
            label3.Text = "RESULTADO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 346);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(btLimpiar);
            Controls.Add(BtCalcula);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtCalcula;
        private Button btLimpiar;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private TextBox txtResultado;
        private Label label3;
    }
}
