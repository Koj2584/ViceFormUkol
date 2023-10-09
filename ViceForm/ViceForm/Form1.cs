using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViceForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form form2 = new Form();
        Random r = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Visible = false;
            int x = r.Next(0, 1800);
            int y = r.Next(0, 1000);
            form2.Location = new Point(x, y);
            form2.MouseEnter += uskoc;
            form2.FormBorderStyle = FormBorderStyle.None;
            Timer t = new Timer();
            t.Interval = 100;
            t.Tick += T_Tick;
            //t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            Form f =new Form();
            f.Show();
            int x = r.Next(0, 1800);
            int y = r.Next(0, 1000);
            f.Location = new Point(x, y);
            f.MouseEnter += uskoc;
            f.FormBorderStyle = FormBorderStyle.None;
        }

        private void uskoc(object sender, EventArgs e)
        {
            int x = r.Next(0, 1800);
            int y = r.Next(0, 1000);
            ((Form)sender).Location = new Point(x, y);
            Form f = new Form();
            f.Show();
            x = r.Next(0, 1800);
            y = r.Next(0, 1000);
            f.Location = new Point(x, y);
            f.MouseEnter += uskoc;
            f.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
