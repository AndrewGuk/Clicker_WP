using System;
using WindowsFormsApp1.Game;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class SecondForma : Form
    {
        Autoservis<People> autoservis = new Autoservis<People>();
        private ImageList image = new ImageList();
        
        public SecondForma(People people)
        {
            InitializeComponent();
            autoservis.People = people;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
        }

        private void SecondForma_Load(object sender, EventArgs e)
        {
            image.ImageSize = new Size(32, 32);
            string[] fn = System.IO.Directory.GetFiles(Application.StartupPath + "\\Images");
            image.Images.Add(Image.FromFile(fn[7].Replace('/','\\')));
            image.Images.Add(Image.FromFile(fn[1].Replace('/', '\\')));
            image.Images.Add(Image.FromFile(fn[5].Replace('/', '\\')));
            image.Images.Add(Image.FromFile(fn[4].Replace('/', '\\')));
            image.Images.Add(Image.FromFile(fn[6].Replace('/', '\\')));
            image.Images.Add(Image.FromFile(fn[2].Replace('/', '\\')));
            image.Images.Add(Image.FromFile(fn[8].Replace('/', '\\')));
            image.Images.Add(Image.FromFile(fn[3].Replace('/', '\\')));
            image.Images.Add(Image.FromFile(fn[0].Replace('/', '\\')));
            
            LoadShopCar();
            LoadUserTransport();
        }

        void LoadShopCar()
        {
            listView1.SmallImageList = image;
            string[][] temp = autoservis.PrintProperty();
            string[] types = temp[0];
            string[] price = temp[1];

            for (int i = 0; i < types.Length; i++)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { "", types[i], price[i] });
                listViewItem.ImageIndex = i;
                listView1.Items.Add(listViewItem);
            }
        }
        void LoadUserTransport()
        {
            listView2.SmallImageList = image;
            string[] temple = autoservis.People.PrintProperty();
            for (int i = 0; i < temple.Length; i++)
            {
                listView2.Items[i].SubItems.Add(temple[i]);
                listView2.Items[i].ImageIndex = TransportImage(temple[i]);
            }
        }
        int TransportImage(string x)
        {
            switch (x)
            {
                case "Forrest Gump":
                    return 0;
                case "Aist":
                    return 1;
                case "Java":
                    return 2;
                case "Mercedes":
                    return 3;
                case "Tundra":
                    return 4;
                case "MAZ":
                    return 5;
                case "Volvo":
                    return 6;
                case "Mi-26":
                    return 7;
                case "Charter":
                    return 8;
                default:
                    return 0;
            }
        }
        void SoldCar(int x)
        {
            if (autoservis.People.transports.Count <= x)
            {
                MessageBox.Show("Do you have this transport");
                return;
            }
            string y = listView2.Items[x].SubItems[1].Text;
            if (MessageBox.Show(autoservis.SellTransport(y), "Gratulue !", MessageBoxButtons.OK) == DialogResult.OK)
                Close();
        }
        void MessageBuyCar(int x)
        {
            LoadUserTransport();
            if (MessageBox.Show(autoservis.BuyTransport(x), "Gratulue !", MessageBoxButtons.OK) == DialogResult.OK)
                Close();
            
        }

        private void label_rollers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBuyCar(0);
        }
        private void label_bicycle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBuyCar(1);
        }
        private void label_moto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBuyCar(2);
        }
        private void label_car_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBuyCar(3);
        }
        private void label_bus_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBuyCar(4);
        }
        private void label_pickup_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBuyCar(5);
        }
        private void label_truck_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBuyCar(6);
        }
        private void label_helicopter_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBuyCar(7);
        }
        private void label_air_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBuyCar(8);
        }
        private void label9_sold_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("You can't sel your better transport");
        }
        private void label8_sold_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SoldCar(1);
        }
        private void label7_sold_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SoldCar(2);
        }
        private void label6_sold_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SoldCar(3);
        }
        private void label5_sold_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SoldCar(4);
        }
        private void label4_sold_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SoldCar(5);
        }
        private void label3_sold_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SoldCar(6);
        }
        private void label2_sold_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SoldCar(7);
        }
        private void label1_sold_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SoldCar(8);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
