using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VacationPanel : Form
    {
        public VacationPanel()
        {
            InitializeComponent();
        }

        private void VacationPanel_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    this.Invoke(new Action(() =>
                    {
                        if (i == progressBar1.Maximum)
                        {
                            progressBar1.Maximum = i + 1;
                            progressBar1.Value = i + 1;
                            progressBar1.Maximum = i;
                            if (MessageBox.Show("Your vacation is over (\ncome again!", "Soory( !", MessageBoxButtons.OK) == DialogResult.OK)
                                Close();
                        }
                        else
                            progressBar1.Value = i + 1;
                        progressBar1.Value = i;
                    }));
                    System.Threading.Thread.Sleep(100);
                }
            });
        }
    }
}
