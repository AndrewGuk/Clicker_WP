using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Game;

namespace WindowsFormsApp1
{
    public partial class FirstMenu : Form
    {
        private People people;
        public FirstMenu(People people)
        {
            InitializeComponent();
            this.people = people;
            button_GoSea.FlatAppearance.BorderSize = 0;
            Button_Work.FlatAppearance.BorderSize = 0;
            Go_Autoservis.FlatAppearance.BorderSize = 0;
            name.BackColor = Color.Transparent;
            money.BackColor = Color.Transparent;
            label1_transport.BackColor = Color.Transparent;
            button_GoSea.Enabled = false;
        }
        private void FirstMenu_Load(object sender, EventArgs e)
        {
            name.Text = name.Text + people.Name.ToString();
            label1_transport.Text = "Transport: " + LabelTransport();
            money.Text = $"Money: {people.BankAccount.ToString()} $";
        }
        private void Button_Work_Click(object sender, EventArgs e)
        {
                Working_form working_Form = new Working_form();
                working_Form.ShowDialog();
            
                label1_transport.Text = "Transport: " + LabelTransport();
                people.Working(people);
                money.Text = $"Money: {people.BankAccount.ToString()} $";

                if (label1_transport.Text != "Transport: There is nothing(")
                    button_GoSea.Enabled = true;
        }
        private void Go_Autoservis_Click(object sender, EventArgs e)
        {
            SecondForma secondForma = new SecondForma(people);
            secondForma.ShowDialog();
        }
        
        public object AddPeople()
        {
            return people;
        }

        private void button_GoSea_Click(object sender, EventArgs e)
        {
            string x = people.DriveInSea();
            if (x == "HURRAH! We are going to the sea!")
            {
                if (MessageBox.Show(x, "Gratulue !", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    VacationPanel vacationPanel = new VacationPanel();
                    vacationPanel.ShowDialog();
                }
            }
            else 
                MessageBox.Show(x);
        }

        string LabelTransport()
        {
            if (people.transports.Count != 0)
                return people.transports[0].Name.ToString();
            else
                return "There is nothing(";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resault = MessageBox.Show("Are you sure you want to exit?", "EXIT", MessageBoxButtons.OKCancel);
            if (resault == DialogResult.OK)
                Environment.Exit(0);
        }
    }
}
    



