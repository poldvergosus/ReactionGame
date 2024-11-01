using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ReactionTest
{
    public partial class Form1 : Form
    {
        private Random random;
        public Form1()
        {

            InitializeComponent();
            random = new Random();

            timerRandom = new Timer();
            timerRandom.Tick += timerRandom_Tick;
            timerRandom.Interval = random.Next(1000, 5000);
            timerRandom.Start();

            timerReaction = new Timer();
            timerReaction.Tick += timerReaction_Tick;
            timerReaction.Interval = 550;

            label.Visible = false;

            Debug.WriteLine("покажи текст1");
        }

        private void timerRandom_Tick(object sender, EventArgs e)
        {

            timerRandom.Stop();
            label.Visible = true;

            timerReaction.Start();
        }
        private void timerReaction_Tick(object sender, EventArgs e)
        {
            timerReaction.Stop();
            label.Visible = false;
            timerRandom.Interval = random.Next(1000, 5000);
            timerRandom.Start();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (label.Visible && e.KeyCode == Keys.Space)
            {
                timerReaction.Stop();
                DialogResult res = MessageBox.Show("Молодец. Хочешь усложнить игру?", "ЕЕЕЕЕ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    if (timerReaction.Interval >= 250)
                    {
                        timerReaction.Interval -= 50;
                    }
                    else
                        MessageBox.Show(" Ты самый быстрый палец на диком западе");
                }
                label.Visible = false;
                timerRandom.Interval = random.Next(1000, 5000);
                timerRandom.Start();
            }
        }


    }
}
