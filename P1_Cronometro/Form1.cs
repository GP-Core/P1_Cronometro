using Microsoft.VisualBasic;

namespace P1_Cronometro
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int seg = 0, min = 0, hor = 0;


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timerCronometro.Start();
            btnIniciar.ForeColor = Color.FromArgb(56, 211, 207);
            btnIniciar.BackColor = Color.FromArgb(29, 40, 71);

            btnPausar.ForeColor = Color.White;
            btnPausar.BackColor = Color.FromArgb(98,98,98);

            btnReiniciar.ForeColor = Color.White;
            btnReiniciar.BackColor = Color.FromArgb(98,98,98);
        }

        private void timerCronometro_Tick(object sender, EventArgs e)
        {

            seg++;
            
            if (seg == 60)
            {
                seg = 0;
                min++;
            }
            else if (min == 60)
            {
                min = 0;
                hor++;

            }
            lblCronometro.Text = hor.ToString("D2") + ":" + min.ToString("D2") + ":" + seg.ToString("D2");

        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            timerCronometro.Stop();
            btnPausar.ForeColor = Color.FromArgb(56, 211, 207);
            btnPausar.BackColor = Color.FromArgb(29, 40, 71);

            btnIniciar.ForeColor = Color.White;
            btnIniciar.BackColor = Color.FromArgb(98, 98, 98);

            btnReiniciar.ForeColor = Color.White;
            btnReiniciar.BackColor = Color.FromArgb(98, 98, 98);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            btnReiniciar.ForeColor = Color.FromArgb(56, 211, 207);
            btnReiniciar.BackColor = Color.FromArgb(29, 40, 71);

            btnPausar.ForeColor = Color.White;
            btnPausar.BackColor = Color.FromArgb(98, 98, 98);

            btnIniciar.ForeColor = Color.White;
            btnIniciar.BackColor = Color.FromArgb(98, 98, 98);
            timerCronometro.Stop();
            lblCronometro.Text = "00:00:00";
            seg = 0;
            min = 0;
            hor = 0;
        }


    }
}
