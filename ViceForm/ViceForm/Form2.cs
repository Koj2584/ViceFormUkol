﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }
        Form form2;
        List<string> l = new List<string>();
        string text = "";
        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                form2 = new Form();
                form2.Width = 500;

                Button b1 = new Button();
                Button b2 = new Button();
                TextBox txt = new TextBox();

                b1.DialogResult = DialogResult.OK;
                b1.Text = "Ulož";
                b1.Click += B1_Click;
                b1.Location = new Point(0, 100);

                b2.DialogResult = DialogResult.Cancel;
                b2.Text = "Zruš";
                b2.Click += B2_Click;
                b2.Location = new Point(200, 100);

                txt.Focus();
                txt.Location = new Point(0, 0);
                txt.TextChanged += Txt_TextChanged;

                form2.Controls.Add(txt);
                form2.Controls.Add(b1);
                form2.Controls.Add(b2);
                form2.ActiveControl = txt;
                form2.AcceptButton = b1;


                if (form2.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Add(text);
                    text = "";
                }
                else
                {
                    break;
                }
            }
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            text = ((TextBox)sender).Text;
        }

        private void B2_Click(object sender, EventArgs e)
        {
            form2.Close();
            text = "";
        }

        private void B1_Click(object sender, EventArgs e)
        {
            form2.Close();
        }
    }
}

