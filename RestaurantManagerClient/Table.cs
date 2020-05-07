using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
namespace RestaurantManagerClient
{
    public partial class Table : PictureBox
    {
        public Label tableName = new Label();
        public Stopwatch timeLeft = new Stopwatch();
        public bool isOpen = true;




        public string Value
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        public Table(EventHandler eventHandler)
        {
            Size = new System.Drawing.Size(60, 60);
            this.tableName.BackColor = Color.Transparent;
            this.tableName.ForeColor = Color.White;
            this.tableName.Location = new Point(0, this.Size.Height / 3);
            this.tableName.Size = new Size(this.Size.Width, this.Size.Height / 3);
            this.tableName.Font = new Font("Arial", 15, FontStyle.Bold);
            this.tableName.TextAlign = ContentAlignment.MiddleCenter;
            this.Image = Resources.table;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(tableName);
            InitializeComponent();
            this.Click += new EventHandler(eventHandler);
            this.openTable(this, new EventArgs());

        }

        public Table()
        {
            Size = new System.Drawing.Size(60, 60);
            this.tableName.BackColor = Color.Transparent;
            this.tableName.ForeColor = Color.White;
            this.tableName.Location = new Point(0, this.Size.Height / 3);
            this.tableName.Size = new Size(this.Size.Width, this.Size.Height / 3);
            this.tableName.Font = new Font("Arial", 15, FontStyle.Bold);
            this.tableName.TextAlign = ContentAlignment.MiddleCenter;
            this.Image = Resources.table;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(tableName);
            InitializeComponent();
            this.openTable(this, new EventArgs());
        }

        public void sitGuest(object sender, EventArgs e)
        {
            if (this.isOpen)
            {
                this.isOpen = false;
                var busyTableMenu = new MetroContextMenu(this.components);
                busyTableMenu.Items.Add("Clear table", null, openTable);
                this.ContextMenuStrip = busyTableMenu;
                this.timeLeft.Start();
                this.Image = Resources.busytable;
            }
        }

        private void openTable(object sender, EventArgs e)
        {
            if (!this.isOpen)
            {
                this.timeLeft.Stop();
                this.Image = Resources.table;
                this.isOpen = true;
                var tableMenu = new MetroContextMenu(this.components);
                tableMenu.Items.Add("Add guest", null, sitGuest);
                this.ContextMenuStrip = tableMenu;
            }

        }




        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            try
            {
                this.tableName.Text = Tag.ToString();
            }
            catch (Exception e) { }

        }
    }
}
