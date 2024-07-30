using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComplexWindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Define the list of image pairs (front and back)
            var images = new[]
            {
                new { Front = Properties.Resources.Coke_mi, Back = Properties.Resources.Gourmet_Cola },
                new { Front = Properties.Resources.Frutavitals, Back = Properties.Resources.MazzaJuice },
                new { Front = Properties.Resources.milkpak, Back = Properties.Resources.OLLPERS}
            };

            for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
            {
                if (col >= images.Length) break;

                // Create PictureBox
                PictureBox pictureBox = new PictureBox
                {
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = images[col].Front,
                    Tag = new ImageTag { Front = images[col].Front, Back = images[col].Back, IsFront = true }
                };

                // Add click event handler
                pictureBox.Click += PictureBox_Click;

                // Add PictureBox to TableLayoutPanel
                tableLayoutPanel1.Controls.Add(pictureBox, col, 0);
            }

            // Add TextBox controls and Button to the FlowLayoutPanel
            controlPanel.Controls.Add(textBox4);
            controlPanel.Controls.Add(button2);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox && pictureBox.Tag is ImageTag imageTag)
            {
                // Swap the image
                if (imageTag.IsFront)
                {
                    pictureBox.Image = imageTag.Back;
                }
                else
                {
                    pictureBox.Image = imageTag.Front;
                }

                imageTag.IsFront = !imageTag.IsFront;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of Form1
            Form1 form1 = new Form1();

            // Show the Form1 instance
            form1.Show();

            // Hide or close the current form (Form3)
            this.Hide();
            // or you can use this.Close(); if you want to close Form3 instead of hiding it
        }
    

        private class ImageTag
        {
            public Image Front { get; set; }
            public Image Back { get; set; }
            public bool IsFront { get; set; }
        }
    }
}
