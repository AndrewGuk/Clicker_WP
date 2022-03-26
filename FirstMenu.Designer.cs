namespace WindowsFormsApp1
{
    partial class FirstMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows
        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstMenu));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.name = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.Button_Work = new System.Windows.Forms.Button();
            this.Go_Autoservis = new System.Windows.Forms.Button();
            this.button_GoSea = new System.Windows.Forms.Button();
            this.label1_transport = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name.Location = new System.Drawing.Point(12, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(57, 17);
            this.name.TabIndex = 2;
            this.name.Text = "Name:  ";
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.money.Location = new System.Drawing.Point(9, 39);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(58, 17);
            this.money.TabIndex = 3;
            this.money.Text = "Money: ";
            // 
            // Button_Work
            // 
            this.Button_Work.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Work.BackgroundImage")));
            this.Button_Work.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Work.Location = new System.Drawing.Point(12, 172);
            this.Button_Work.Name = "Button_Work";
            this.Button_Work.Size = new System.Drawing.Size(161, 75);
            this.Button_Work.TabIndex = 5;
            this.Button_Work.UseVisualStyleBackColor = true;
            this.Button_Work.Click += new System.EventHandler(this.Button_Work_Click);
            // 
            // Go_Autoservis
            // 
            this.Go_Autoservis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Go_Autoservis.BackgroundImage")));
            this.Go_Autoservis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Go_Autoservis.Location = new System.Drawing.Point(216, 126);
            this.Go_Autoservis.Name = "Go_Autoservis";
            this.Go_Autoservis.Size = new System.Drawing.Size(135, 85);
            this.Go_Autoservis.TabIndex = 7;
            this.Go_Autoservis.UseVisualStyleBackColor = true;
            this.Go_Autoservis.Click += new System.EventHandler(this.Go_Autoservis_Click);
            // 
            // button_GoSea
            // 
            this.button_GoSea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_GoSea.BackgroundImage")));
            this.button_GoSea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_GoSea.Location = new System.Drawing.Point(216, 260);
            this.button_GoSea.Name = "button_GoSea";
            this.button_GoSea.Size = new System.Drawing.Size(130, 81);
            this.button_GoSea.TabIndex = 8;
            this.button_GoSea.UseVisualStyleBackColor = true;
            this.button_GoSea.Click += new System.EventHandler(this.button_GoSea_Click);
            // 
            // label1_transport
            // 
            this.label1_transport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_transport.Location = new System.Drawing.Point(9, 70);
            this.label1_transport.Name = "label1_transport";
            this.label1_transport.Size = new System.Drawing.Size(248, 23);
            this.label1_transport.TabIndex = 10;
            this.label1_transport.Text = "Transport:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(265, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FirstMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1_transport);
            this.Controls.Add(this.button_GoSea);
            this.Controls.Add(this.Go_Autoservis);
            this.Controls.Add(this.Button_Work);
            this.Controls.Add(this.money);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirstMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deliveryman";
            this.Load += new System.EventHandler(this.FirstMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button Button_Work;
        public System.Windows.Forms.Label money;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button Go_Autoservis;
        private System.Windows.Forms.Button button_GoSea;
        public System.Windows.Forms.Label label1_transport;
        private System.Windows.Forms.Button button1;
    }
}

