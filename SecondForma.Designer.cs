using WindowsFormsApp1.Game;


namespace WindowsFormsApp1
{
    partial class SecondForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.Windows.Forms.ColumnHeader columnHeader2;
            System.Windows.Forms.ColumnHeader columnHeader3;
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondForma));
            this.Sprisok = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label_rollers = new System.Windows.Forms.Label();
            this.label_bicycle = new System.Windows.Forms.Label();
            this.label_moto = new System.Windows.Forms.Label();
            this.label_car = new System.Windows.Forms.Label();
            this.label_bus = new System.Windows.Forms.Label();
            this.label_pickup = new System.Windows.Forms.Label();
            this.label_truck = new System.Windows.Forms.Label();
            this.label_helicopter = new System.Windows.Forms.Label();
            this.label_air = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1_sold = new System.Windows.Forms.Label();
            this.label2_sold = new System.Windows.Forms.Label();
            this.label3_sold = new System.Windows.Forms.Label();
            this.label4_sold = new System.Windows.Forms.Label();
            this.label5_sold = new System.Windows.Forms.Label();
            this.label6_sold = new System.Windows.Forms.Label();
            this.label7_sold = new System.Windows.Forms.Label();
            this.label8_sold = new System.Windows.Forms.Label();
            this.label9_sold = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "";
            columnHeader1.Width = 32;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "type";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "cost";
            // 
            // Sprisok
            // 
            this.Sprisok.Location = new System.Drawing.Point(64, 225);
            this.Sprisok.Name = "Sprisok";
            this.Sprisok.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sprisok.Size = new System.Drawing.Size(75, 23);
            this.Sprisok.TabIndex = 0;
            this.Sprisok.Text = "Товары";
            this.Sprisok.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView1.Enabled = false;
            this.listView1.HideSelection = false;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView1.Location = new System.Drawing.Point(416, 0);
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(153, 328);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label_rollers
            // 
            this.label_rollers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_rollers.Location = new System.Drawing.Point(426, 24);
            this.label_rollers.Name = "label_rollers";
            this.label_rollers.Size = new System.Drawing.Size(153, 34);
            this.label_rollers.TabIndex = 2;
            this.label_rollers.Text = "label1";
            this.label_rollers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_rollers_MouseDoubleClick);
            // 
            // label_bicycle
            // 
            this.label_bicycle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_bicycle.Location = new System.Drawing.Point(426, 58);
            this.label_bicycle.Name = "label_bicycle";
            this.label_bicycle.Size = new System.Drawing.Size(153, 34);
            this.label_bicycle.TabIndex = 4;
            this.label_bicycle.Text = "label1";
            this.label_bicycle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_bicycle_MouseDoubleClick);
            // 
            // label_moto
            // 
            this.label_moto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_moto.Location = new System.Drawing.Point(426, 92);
            this.label_moto.Name = "label_moto";
            this.label_moto.Size = new System.Drawing.Size(153, 34);
            this.label_moto.TabIndex = 5;
            this.label_moto.Text = "label1";
            this.label_moto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_moto_MouseDoubleClick);
            // 
            // label_car
            // 
            this.label_car.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_car.Location = new System.Drawing.Point(426, 126);
            this.label_car.Name = "label_car";
            this.label_car.Size = new System.Drawing.Size(153, 34);
            this.label_car.TabIndex = 6;
            this.label_car.Text = "label1";
            this.label_car.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_car_MouseDoubleClick);
            // 
            // label_bus
            // 
            this.label_bus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_bus.Location = new System.Drawing.Point(426, 160);
            this.label_bus.Name = "label_bus";
            this.label_bus.Size = new System.Drawing.Size(153, 34);
            this.label_bus.TabIndex = 7;
            this.label_bus.Text = "label1";
            this.label_bus.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_bus_MouseDoubleClick);
            // 
            // label_pickup
            // 
            this.label_pickup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_pickup.Location = new System.Drawing.Point(426, 194);
            this.label_pickup.Name = "label_pickup";
            this.label_pickup.Size = new System.Drawing.Size(153, 34);
            this.label_pickup.TabIndex = 8;
            this.label_pickup.Text = "label1";
            this.label_pickup.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_pickup_MouseDoubleClick);
            // 
            // label_truck
            // 
            this.label_truck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_truck.Location = new System.Drawing.Point(426, 228);
            this.label_truck.Name = "label_truck";
            this.label_truck.Size = new System.Drawing.Size(153, 34);
            this.label_truck.TabIndex = 9;
            this.label_truck.Text = "label1";
            this.label_truck.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_truck_MouseDoubleClick);
            // 
            // label_helicopter
            // 
            this.label_helicopter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_helicopter.Location = new System.Drawing.Point(426, 262);
            this.label_helicopter.Name = "label_helicopter";
            this.label_helicopter.Size = new System.Drawing.Size(153, 34);
            this.label_helicopter.TabIndex = 10;
            this.label_helicopter.Text = "label1";
            this.label_helicopter.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_helicopter_MouseDoubleClick);
            // 
            // label_air
            // 
            this.label_air.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_air.Location = new System.Drawing.Point(426, 296);
            this.label_air.Name = "label_air";
            this.label_air.Size = new System.Drawing.Size(153, 34);
            this.label_air.TabIndex = 11;
            this.label_air.Text = "label1";
            this.label_air.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_air_MouseDoubleClick);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader4});
            this.listView2.Enabled = false;
            this.listView2.HideSelection = false;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18});
            this.listView2.Location = new System.Drawing.Point(-1, 1);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(111, 329);
            this.listView2.TabIndex = 12;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            this.columnHeader5.Width = 32;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Your transport";
            this.columnHeader4.Width = 79;
            // 
            // label1_sold
            // 
            this.label1_sold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1_sold.Location = new System.Drawing.Point(-4, 296);
            this.label1_sold.Name = "label1_sold";
            this.label1_sold.Size = new System.Drawing.Size(99, 34);
            this.label1_sold.TabIndex = 21;
            this.label1_sold.Text = "label1";
            this.label1_sold.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label1_sold_MouseDoubleClick);
            // 
            // label2_sold
            // 
            this.label2_sold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2_sold.Location = new System.Drawing.Point(-4, 262);
            this.label2_sold.Name = "label2_sold";
            this.label2_sold.Size = new System.Drawing.Size(99, 34);
            this.label2_sold.TabIndex = 20;
            this.label2_sold.Text = "label1";
            this.label2_sold.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label2_sold_MouseDoubleClick);
            // 
            // label3_sold
            // 
            this.label3_sold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3_sold.Location = new System.Drawing.Point(-4, 228);
            this.label3_sold.Name = "label3_sold";
            this.label3_sold.Size = new System.Drawing.Size(99, 34);
            this.label3_sold.TabIndex = 19;
            this.label3_sold.Text = "label1";
            this.label3_sold.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label3_sold_MouseDoubleClick);
            // 
            // label4_sold
            // 
            this.label4_sold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4_sold.Location = new System.Drawing.Point(-4, 194);
            this.label4_sold.Name = "label4_sold";
            this.label4_sold.Size = new System.Drawing.Size(99, 34);
            this.label4_sold.TabIndex = 18;
            this.label4_sold.Text = "label1";
            this.label4_sold.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label4_sold_MouseDoubleClick);
            // 
            // label5_sold
            // 
            this.label5_sold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5_sold.Location = new System.Drawing.Point(-4, 160);
            this.label5_sold.Name = "label5_sold";
            this.label5_sold.Size = new System.Drawing.Size(99, 34);
            this.label5_sold.TabIndex = 17;
            this.label5_sold.Text = "label1";
            this.label5_sold.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label5_sold_MouseDoubleClick);
            // 
            // label6_sold
            // 
            this.label6_sold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6_sold.Location = new System.Drawing.Point(-4, 126);
            this.label6_sold.Name = "label6_sold";
            this.label6_sold.Size = new System.Drawing.Size(99, 34);
            this.label6_sold.TabIndex = 16;
            this.label6_sold.Text = "label1";
            this.label6_sold.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label6_sold_MouseDoubleClick);
            // 
            // label7_sold
            // 
            this.label7_sold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7_sold.Location = new System.Drawing.Point(-4, 92);
            this.label7_sold.Name = "label7_sold";
            this.label7_sold.Size = new System.Drawing.Size(99, 34);
            this.label7_sold.TabIndex = 15;
            this.label7_sold.Text = "label1";
            this.label7_sold.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label7_sold_MouseDoubleClick);
            // 
            // label8_sold
            // 
            this.label8_sold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8_sold.Location = new System.Drawing.Point(-4, 58);
            this.label8_sold.Name = "label8_sold";
            this.label8_sold.Size = new System.Drawing.Size(99, 34);
            this.label8_sold.TabIndex = 14;
            this.label8_sold.Text = "label1";
            this.label8_sold.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label8_sold_MouseDoubleClick);
            // 
            // label9_sold
            // 
            this.label9_sold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9_sold.Location = new System.Drawing.Point(-4, 24);
            this.label9_sold.Name = "label9_sold";
            this.label9_sold.Size = new System.Drawing.Size(99, 34);
            this.label9_sold.TabIndex = 13;
            this.label9_sold.Text = "label1";
            this.label9_sold.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label9_sold_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(106, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 329);
            this.panel1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(193, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SecondForma
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 328);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1_sold);
            this.Controls.Add(this.label2_sold);
            this.Controls.Add(this.label3_sold);
            this.Controls.Add(this.label4_sold);
            this.Controls.Add(this.label5_sold);
            this.Controls.Add(this.label6_sold);
            this.Controls.Add(this.label7_sold);
            this.Controls.Add(this.label8_sold);
            this.Controls.Add(this.label9_sold);
            this.Controls.Add(this.label_air);
            this.Controls.Add(this.label_helicopter);
            this.Controls.Add(this.label_truck);
            this.Controls.Add(this.label_pickup);
            this.Controls.Add(this.label_bus);
            this.Controls.Add(this.label_car);
            this.Controls.Add(this.label_moto);
            this.Controls.Add(this.label_bicycle);
            this.Controls.Add(this.label_rollers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SecondForma";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сar shop";
            this.Load += new System.EventHandler(this.SecondForma_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sprisok;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label_rollers;
        private System.Windows.Forms.Label label_bicycle;
        private System.Windows.Forms.Label label_moto;
        private System.Windows.Forms.Label label_car;
        private System.Windows.Forms.Label label_bus;
        private System.Windows.Forms.Label label_pickup;
        private System.Windows.Forms.Label label_truck;
        private System.Windows.Forms.Label label_helicopter;
        private System.Windows.Forms.Label label_air;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1_sold;
        private System.Windows.Forms.Label label2_sold;
        private System.Windows.Forms.Label label3_sold;
        private System.Windows.Forms.Label label4_sold;
        private System.Windows.Forms.Label label5_sold;
        private System.Windows.Forms.Label label6_sold;
        private System.Windows.Forms.Label label7_sold;
        private System.Windows.Forms.Label label8_sold;
        private System.Windows.Forms.Label label9_sold;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}