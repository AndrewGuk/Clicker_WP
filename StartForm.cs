using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Game;


namespace WindowsFormsApp1
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        public StartForm(People people)
        {
            this.people = people;
        }
        public People people = new People();

        private void StartForm_Load(object sender, EventArgs e)
        {
            button1.Text = "New\ngame!";
            button1.FlatAppearance.BorderSize = 0 ;
            button1.BackColor = Color.Transparent;

            label_name.Visible = false;
            label_name.BackColor = Color.Transparent;
            label_name.ForeColor = Color.FromArgb(7, 106, 143);

            button2_create.Visible = false;
            button2_create.BackColor = Color.Transparent;
            button2_create.FlatAppearance.BorderSize = 0;

            textBox_userName.Visible = false;
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(21, 171, 237);
            button2_create.BackColor = Color.FromArgb(21, 171, 237);
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            button2_create.BackColor = Color.Transparent;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button2_create.Visible = true;
            label_name.Visible = true;
            textBox_userName.Visible = true;
            this.panel1.Controls.Remove(button1);
        }
        private void button2_create_Click(object sender, EventArgs e)
        {
            people.Name = textBox_userName.Text;
            textBox_userName.Enabled = false;
            Hide();
            FirstMenu firstMenu = new FirstMenu(people);
            firstMenu.ShowDialog();
        }
    }
}
