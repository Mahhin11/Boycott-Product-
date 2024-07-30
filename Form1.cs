using System;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace ComplexWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add any initialization logic here, if needed
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            TransitionToForm(form2);
        }

        private void btnOpenForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            TransitionToForm(form3);
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            // Animation logic here
        }

        private void TransitionToForm(Form newForm)
        {
            System.Windows.Forms.Timer fadeOutTimer = new System.Windows.Forms.Timer(); // Specify the full namespace here
            fadeOutTimer.Interval = 10;
            fadeOutTimer.Tick += (s, ev) =>
            {
                if (this.Opacity > 0)
                {
                    this.Opacity -= 0.05;
                }
                else
                {
                    fadeOutTimer.Stop();
                    newForm.Opacity = 0;
                    newForm.Show();
                    System.Windows.Forms.Timer fadeInTimer = new System.Windows.Forms.Timer(); // Specify the full namespace here
                    fadeInTimer.Interval = 10;
                    fadeInTimer.Tick += (s2, ev2) =>
                    {
                        if (newForm.Opacity < 1)
                        {
                            newForm.Opacity += 0.05;
                        }
                        else
                        {
                            fadeInTimer.Stop();
                        }
                    };
                    fadeInTimer.Start();
                    this.Hide();
                }
            };
            fadeOutTimer.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle text changes if necessary
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Handle label2 click event if necessary
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label1 click event if necessary
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Handle groupBox1 enter event if necessary
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open Form4 when the link label is clicked
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
