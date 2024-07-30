namespace ComplexWindowsFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Button btnOpenForm3;
        private System.Windows.Forms.Button btnOpenForm2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            displayLabel = new Label();
            animationTimer = new System.Windows.Forms.Timer(components);
            btnOpenForm2 = new Button();
            btnOpenForm3 = new Button();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // displayLabel
            // 
            displayLabel.AutoSize = true;
            displayLabel.Location = new Point(12, 64);
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(0, 25);
            displayLabel.TabIndex = 2;
            // 
            // animationTimer
            // 
            animationTimer.Enabled = true;
            animationTimer.Interval = 50;
            animationTimer.Tick += animationTimer_Tick;
            // 
            // btnOpenForm2
            // 
            btnOpenForm2.BackColor = Color.SlateGray;
            btnOpenForm2.Location = new Point(543, 302);
            btnOpenForm2.Name = "btnOpenForm2";
            btnOpenForm2.Size = new Size(103, 66);
            btnOpenForm2.TabIndex = 3;
            btnOpenForm2.Text = "Drinks";
            btnOpenForm2.UseVisualStyleBackColor = false;
            btnOpenForm2.Click += btnOpenForm2_Click;
            // 
            // btnOpenForm3
            // 
            btnOpenForm3.BackColor = Color.SlateGray;
            btnOpenForm3.Location = new Point(670, 302);
            btnOpenForm3.Name = "btnOpenForm3";
            btnOpenForm3.Size = new Size(103, 66);
            btnOpenForm3.TabIndex = 4;
            btnOpenForm3.Text = "Food";
            btnOpenForm3.UseVisualStyleBackColor = false;
            btnOpenForm3.Click += btnOpenForm3_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(406, 173);
            label1.Name = "label1";
            label1.Size = new Size(380, 114);
            label1.TabIndex = 5;
            label1.Text = "Boycott Product Alternate System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateGray;
            button1.Location = new Point(420, 302);
            button1.Name = "button1";
            button1.Size = new Size(103, 66);
            button1.TabIndex = 6;
            button1.Text = "Clothing";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Berlin Sans FB", 11F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(-4, 1);
            label2.Name = "label2";
            label2.Size = new Size(863, 88);
            label2.TabIndex = 7;
            label2.Text = "Select Your Category Below For Alternates ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Red;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Comic Sans MS", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkColor = Color.Lavender;
            linkLabel1.Location = new Point(518, 409);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(145, 25);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "About Boycott";
            linkLabel1.VisitedLinkColor = Color.Khaki;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(859, 462);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(btnOpenForm3);
            Controls.Add(button1);
            Controls.Add(btnOpenForm2);
            Controls.Add(label1);
            Controls.Add(displayLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Button button1;
        private Label label2;
        private LinkLabel linkLabel1;
    }
}
