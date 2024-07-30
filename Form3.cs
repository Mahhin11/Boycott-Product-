using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComplexWindowsFormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Define the list of image pairs (front and back)
            var images = new[]
            {
                new { Front = Properties.Resources.kfc, Back = Properties.Resources.FRICHICKS },
                new { Front = Properties.Resources.Lays, Back = Properties.Resources.OYEHOYE },
                new { Front = Properties.Resources.Pizza_Hut, Back = Properties.Resources.Cheezious },

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
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
               
        }

        private class ImageTag
        {
            public Image? Front { get; set; }
            public Image? Back { get; set; }
            public bool IsFront { get; set; }
        }
    }
}
