using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using System.Timers;
namespace crossy_road
{
    public partial class Form1 : Form
    {
        public bool vittoria = false;
        private int sfondoCounter = 0;
        private int easterEgg = 0;
        private int bananaoro = 0;
        private int auto1_X = 274, auto1_Y = 9;
        private int auto2_X = 367, auto2_Y = 330;
        private int auto3_X = 487, auto3_Y = 450;
        private int auto4_X = 581, auto4_Y = 20;
        private int auto5_X = 703, auto5_Y = 315;
        private int auto6_X = 796, auto6_Y = 457;
        private int auto7_X = 916, auto7_Y = 189;
        private int auto8_X = 1015, auto8_Y = 533;
        private int lives = 3;

        public Form1()
        {
            InitializeComponent();
            schermata_sconfitta.Visible = false;
            banana.Visible = false;
            button2.Visible = false;
            button2.Enabled = false;
            MessageBox.Show("LEFT click su 'Avanti' per avanzare e RIGHT click su 'Avanti' per andare indietro");
            Application.Idle += OnGameLoop;
        }

        private void OnGameLoop(object sender, EventArgs e)
        {
            MoveCars();
            CheckCollisions();

            if (sfondoCounter >= 5)
            {
                ResetCarsToOriginalPositions();
                Application.Idle -= OnGameLoop;
            }
        }

        private void MoveCars()
        {
            auto1_Y += 2;
            auto2_Y += (sfondoCounter >= 1) ? 2 : 1;
            auto3_Y += 1;
            auto4_Y += (sfondoCounter >= 3) ? 3 : 1;
            auto5_Y += 2;
            auto6_Y += (sfondoCounter >= 2) ? 3 : 1;
            auto7_Y += (sfondoCounter >= 5) ? 2 : 1;
            auto8_Y += 3;

            if (auto1_Y > this.Height) auto1_Y = -auto1.Height;
            if (auto2_Y > this.Height) auto2_Y = -auto2.Height;
            if (auto3_Y > this.Height) auto3_Y = -auto3.Height;
            if (auto4_Y > this.Height) auto4_Y = -auto4.Height;
            if (auto5_Y > this.Height) auto5_Y = -auto5.Height;
            if (auto6_Y > this.Height) auto6_Y = -auto6.Height;
            if (auto7_Y > this.Height) auto7_Y = -auto7.Height;
            if (auto8_Y > this.Height) auto8_Y = -auto8.Height;

            auto1.Location = new Point(auto1_X, auto1_Y);
            auto2.Location = new Point(auto2_X, auto2_Y);
            auto3.Location = new Point(auto3_X, auto3_Y);
            auto4.Location = new Point(auto4_X, auto4_Y);
            auto5.Location = new Point(auto5_X, auto5_Y);
            auto6.Location = new Point(auto6_X, auto6_Y);
            auto7.Location = new Point(auto7_X, auto7_Y);
            auto8.Location = new Point(auto8_X, auto8_Y);
        }


        private void CheckCollisions()
        {
            Rectangle mandaglioRect = Mandaglio.Bounds;

            if (mandaglioRect.IntersectsWith(auto1.Bounds) ||
                mandaglioRect.IntersectsWith(auto2.Bounds) ||
                mandaglioRect.IntersectsWith(auto3.Bounds) ||
                mandaglioRect.IntersectsWith(auto4.Bounds) ||
                mandaglioRect.IntersectsWith(auto5.Bounds) ||
                mandaglioRect.IntersectsWith(auto6.Bounds) ||
                mandaglioRect.IntersectsWith(auto7.Bounds) ||
                mandaglioRect.IntersectsWith(auto8.Bounds))
            {
                lives--;
                if (lives == 2) cuore3.Visible = false;
                else if (lives == 1) cuore2.Visible = false;
                else if (lives == 0)
                {
                    cuore1.Visible = false;
                    MessageBox.Show("Game Over! Hai finito le vite.");
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    Mandaglio.Visible = false;
                    cuore1.Visible = false;
                    cuore2.Visible = false;
                    cuore3.Visible = false;
                    auto1.Visible = false;
                    auto2.Visible = false;
                    auto3.Visible = false;
                    auto4.Visible = false;
                    auto5.Visible = false;
                    auto6.Visible = false;
                    auto7.Visible = false;
                    auto8.Visible = false;
                    schermata_sconfitta.Visible = true;
                    button2.Visible = true;
                    button2.Enabled = true;
                    button1.Visible = false;
                    button1.Enabled = false;
                }
                Mandaglio.Left = 167;
            }
        }

        private void ResetCarsToOriginalPositions()
        {
            auto1_X = 270; auto1_Y = 9;
            auto2_X = 369; auto2_Y = 285;
            auto3_X = 485; auto3_Y = 521;
            auto4_X = 583; auto4_Y = 79;
            auto5_X = 701; auto5_Y = 315;
            auto6_X = 798; auto6_Y = 457;
            auto7_X = 915; auto7_Y = 189;
            auto8_X = 1014; auto8_Y = 533;

            auto1.Location = new Point(auto1_X, auto1_Y);
            auto2.Location = new Point(auto2_X, auto2_Y);
            auto3.Location = new Point(auto3_X, auto3_Y);
            auto4.Location = new Point(auto4_X, auto4_Y);
            auto5.Location = new Point(auto5_X, auto5_Y);
            auto6.Location = new Point(auto6_X, auto6_Y);
            auto7.Location = new Point(auto7_X, auto7_Y);
            auto8.Location = new Point(auto8_X, auto8_Y);
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Mandaglio.Left += 105;
            }
            else if (e.Button == MouseButtons.Right)
            {
                Mandaglio.Left -= 105;
            }
            if (Mandaglio.Left <= 0 && sfondoCounter == 1)
            {
                banana.Visible = true;
                MessageBox.Show("Hai trovato una banana persa da Nugget!!");
                easterEgg++;
                banana.Visible = false;
            }
            if (Mandaglio.Left <= -1000 && sfondoCounter == 3)
            {
                banana.Visible = true;
                MessageBox.Show("Hai trovato una banana persa da Nugget!!");
                easterEgg++;
                banana.Visible = false;
            }
            if (Mandaglio.Left <= -3000 && sfondoCounter == 4)
            {
                banana.Visible = true;
                MessageBox.Show("Hai trovato una banana persa da Nugget!!");
                easterEgg++;
                banana.Visible = false;
            }
            if (easterEgg == 3)
            {
                MessageBox.Show("Complimenti hai trovato tutte le banane!!");
                bananaoro = 1;
                easterEgg = 0;
            }


            if (Mandaglio.Left >= 1100)
            {
                sfondoCounter++;

                if (sfondoCounter == 1) this.BackgroundImage = Properties.Resources.Sfondo2;
                else if (sfondoCounter == 2) this.BackgroundImage = Properties.Resources.Sfondo3;
                else if (sfondoCounter == 3) this.BackgroundImage = Properties.Resources.Sfondo4;
                else if (sfondoCounter == 4) this.BackgroundImage = Properties.Resources.Sfondo5;
                else if (sfondoCounter == 5)
                {
                    Form3 credits = new Form3();
                    credits.Show();
                    this.Close();
                }

                Mandaglio.Left = 167;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button2.Enabled = false;
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}