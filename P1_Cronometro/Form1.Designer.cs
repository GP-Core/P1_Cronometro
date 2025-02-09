namespace P1_Cronometro
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
            lblCronometro = new Label();
            btnIniciar = new Button();
            timerCronometro = new System.Windows.Forms.Timer(components);
            btnPausar = new Button();
            btnReiniciar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblCronometro
            // 
            lblCronometro.AutoSize = true;
            lblCronometro.BackColor = Color.FromArgb(29, 40, 71);
            lblCronometro.Font = new Font("Digital-7 Mono", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCronometro.ForeColor = Color.FromArgb(56, 211, 207);
            lblCronometro.Location = new Point(64, 23);
            lblCronometro.Name = "lblCronometro";
            lblCronometro.Size = new Size(331, 82);
            lblCronometro.TabIndex = 0;
            lblCronometro.Text = "00:00:00";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(98, 98, 98);
            btnIniciar.Font = new Font("Itim", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(45, 167);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(99, 41);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "INICIAR";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // timerCronometro
            // 
            timerCronometro.Interval = 1000;
            timerCronometro.Tick += timerCronometro_Tick;
            // 
            // btnPausar
            // 
            btnPausar.BackColor = Color.FromArgb(98, 98, 98);
            btnPausar.Font = new Font("Itim", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPausar.ForeColor = Color.White;
            btnPausar.Location = new Point(201, 167);
            btnPausar.Name = "btnPausar";
            btnPausar.Size = new Size(99, 41);
            btnPausar.TabIndex = 2;
            btnPausar.Text = "PAUSAR";
            btnPausar.UseVisualStyleBackColor = false;
            btnPausar.Click += btnPausar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.FromArgb(98, 98, 98);
            btnReiniciar.Font = new Font("Itim", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReiniciar.ForeColor = Color.White;
            btnReiniciar.Location = new Point(342, 167);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(118, 41);
            btnReiniciar.TabIndex = 3;
            btnReiniciar.Text = "REINICIAR";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(181, 181, 181);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnReiniciar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnPausar);
            panel1.Controls.Add(btnIniciar);
            panel1.Location = new Point(90, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 221);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(29, 40, 71);
            panel2.Controls.Add(lblCronometro);
            panel2.Location = new Point(30, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 132);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(181, 181, 181);
            panel3.Location = new Point(137, 277);
            panel3.Name = "panel3";
            panel3.Size = new Size(118, 30);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(181, 181, 181);
            panel4.Location = new Point(434, 277);
            panel4.Name = "panel4";
            panel4.Size = new Size(118, 30);
            panel4.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 361);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Cronometro";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCronometro;
        private Button btnIniciar;
        private System.Windows.Forms.Timer timerCronometro;
        private Button btnPausar;
        private Button btnReiniciar;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}
