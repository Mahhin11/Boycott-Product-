using System;
using System.Windows.Forms;

namespace ComplexWindowsFormsApp
{
    public partial class Form4 : Form  // Correct the class name
    {
        public Form4()  // Correct the constructor name
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Load the text content into the RichTextBox
            string boycottInfo = "The Boycott Product Alternate System (BPAS) is designed for individuals who want to support the ongoing boycott against Israeli products. By choosing BPAS, users demonstrate their solidarity with the Palestinian cause and take a stand against the Israeli occupation and apartheid policies. The system offers a comprehensive and user-friendly platform that provides information on boycotted products and suggests ethical alternatives. This empowers consumers to make informed decisions aligned with their values, supporting local and sustainable brands while promoting ethical consumption practices.\n\n© 2024 Boycott Product Alternate System";
            richTextBox1.Text = boycottInfo;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle text changed event if needed
        }
    }
}
