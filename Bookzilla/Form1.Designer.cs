namespace Bookzilla
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            loginbutton = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox1pass = new TextBox();
            usernametxt = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(loginbutton);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(textBox1pass);
            splitContainer1.Panel2.Controls.Add(usernametxt);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 311;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // loginbutton
            // 
            loginbutton.BackColor = SystemColors.MenuHighlight;
            loginbutton.BackgroundImageLayout = ImageLayout.None;
            loginbutton.FlatAppearance.BorderColor = Color.White;
            loginbutton.FlatAppearance.BorderSize = 0;
            loginbutton.FlatAppearance.MouseDownBackColor = Color.White;
            loginbutton.FlatAppearance.MouseOverBackColor = Color.White;
            loginbutton.FlatStyle = FlatStyle.Popup;
            loginbutton.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbutton.ForeColor = Color.Transparent;
            loginbutton.Location = new Point(158, 249);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(188, 35);
            loginbutton.TabIndex = 5;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(140, 188);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(140, 135);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 2;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // textBox1pass
            // 
            textBox1pass.BorderStyle = BorderStyle.FixedSingle;
            textBox1pass.Cursor = Cursors.IBeam;
            textBox1pass.Location = new Point(134, 201);
            textBox1pass.Multiline = true;
            textBox1pass.Name = "textBox1pass";
            textBox1pass.Size = new Size(236, 31);
            textBox1pass.TabIndex = 3;
            // 
            // usernametxt
            // 
            usernametxt.BorderStyle = BorderStyle.FixedSingle;
            usernametxt.Cursor = Cursors.IBeam;
            usernametxt.Location = new Point(134, 148);
            usernametxt.Multiline = true;
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(236, 31);
            usernametxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Book", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(148, 67);
            label1.Name = "label1";
            label1.Size = new Size(198, 30);
            label1.TabIndex = 0;
            label1.Text = "Login into account";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox usernametxt;
        private Label label3;
        private TextBox textBox1pass;
        private Button loginbutton;
    }
}
