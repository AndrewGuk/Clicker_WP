using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Working_form : Form
    {
        public Working_form()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }
        private async void Form1_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i == progressBar1.Maximum)
                {
                    progressBar1.Maximum = i + 1;
                    progressBar1.Value = i + 1;
                    progressBar1.Maximum = i;
                }
                else
                    progressBar1.Value = i + 1;
                progressBar1.Value = i;
                progressBar1.CreateGraphics().DrawString($"{i.ToString()}%", new Font("Arial", (float)10, FontStyle.Regular), Brushes.Black, new PointF(progressBar1.Width / 2 - 20, progressBar1.Height / 2 - 7));
                Thread.Sleep(20);
            }
            Close();
        }
    }
}
