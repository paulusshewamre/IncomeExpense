namespace IncomeExpense
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label18 = new Label();
            label13 = new Label();
            label1 = new Label();
            UnameTb = new TextBox();
            label2 = new Label();
            PasswordTb = new TextBox();
            LoginBtn = new Button();
            label10 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("DejaVu Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(0, 0, 64);
            label18.Location = new Point(137, 45);
            label18.Name = "label18";
            label18.Size = new Size(236, 33);
            label18.TabIndex = 77;
            label18.Text = "AppleTech 1.0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Felix Titling", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(0, 0, 192);
            label13.Location = new Point(-153, 143);
            label13.Name = "label13";
            label13.Size = new Size(141, 21);
            label13.TabIndex = 74;
            label13.Text = "Income Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Felix Titling", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(84, 286);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 79;
            label1.Text = "User Name";
            // 
            // UnameTb
            // 
            UnameTb.Font = new Font("Arial Nova", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnameTb.Location = new Point(84, 323);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(344, 32);
            UnameTb.TabIndex = 78;
            UnameTb.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Felix Titling", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(84, 389);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 81;
            label2.Text = "Password";
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Arial Nova", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTb.Location = new Point(84, 426);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(344, 32);
            PasswordTb.TabIndex = 80;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.SkyBlue;
            LoginBtn.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.FromArgb(0, 0, 192);
            LoginBtn.Location = new Point(331, 556);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(125, 53);
            LoginBtn.TabIndex = 82;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cambria", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(33, 615);
            label10.Name = "label10";
            label10.Size = new Size(74, 21);
            label10.TabIndex = 84;
            label10.Text = "Register";
            label10.Click += label10_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(186, 103);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(115, 77);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 85;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(422, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 86;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(491, 658);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(label10);
            Controls.Add(LoginBtn);
            Controls.Add(label2);
            Controls.Add(PasswordTb);
            Controls.Add(label1);
            Controls.Add(UnameTb);
            Controls.Add(label18);
            Controls.Add(label13);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label18;
        private Label label13;
        private Label label1;
        private TextBox UnameTb;
        private Label label2;
        private TextBox PasswordTb;
        private Button LoginBtn;
        private Label label10;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}