namespace IncomeExpense
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            pictureBox1 = new PictureBox();
            label10 = new Label();
            AddBtn = new Button();
            label2 = new Label();
            PhoneTb = new TextBox();
            label1 = new Label();
            UnameTb = new TextBox();
            label18 = new Label();
            label3 = new Label();
            PasswordTb = new TextBox();
            label4 = new Label();
            AddressTb = new TextBox();
            label5 = new Label();
            DOB = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(422, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 96;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Caladea", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(172, 725);
            label10.Name = "label10";
            label10.Size = new Size(51, 21);
            label10.TabIndex = 94;
            label10.Text = "Back";
            label10.Click += label10_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.SkyBlue;
            AddBtn.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.FromArgb(0, 0, 192);
            AddBtn.Location = new Point(132, 658);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(125, 53);
            AddBtn.TabIndex = 92;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Felix Titling", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(50, 223);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 91;
            label2.Text = "Phone";
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Arial Nova", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneTb.Location = new Point(49, 247);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(344, 32);
            PhoneTb.TabIndex = 90;
            PhoneTb.TextChanged += PhoneTb_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Felix Titling", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(50, 131);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 89;
            label1.Text = "User Name";
            // 
            // UnameTb
            // 
            UnameTb.Font = new Font("Arial Nova", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnameTb.Location = new Point(49, 167);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(344, 32);
            UnameTb.TabIndex = 88;
            UnameTb.TextChanged += UnameTb_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("DejaVu Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(0, 0, 64);
            label18.Location = new Point(152, 61);
            label18.Name = "label18";
            label18.Size = new Size(160, 33);
            label18.TabIndex = 87;
            label18.Text = "Add User";
            label18.Click += label18_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Felix Titling", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(50, 372);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 98;
            label3.Text = "Password";
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Arial Nova", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTb.Location = new Point(50, 407);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(344, 32);
            PasswordTb.TabIndex = 97;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Felix Titling", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(50, 463);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 100;
            label4.Text = "Address";
            // 
            // AddressTb
            // 
            AddressTb.Font = new Font("Arial Nova", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddressTb.Location = new Point(50, 501);
            AddressTb.Multiline = true;
            AddressTb.Name = "AddressTb";
            AddressTb.Size = new Size(344, 117);
            AddressTb.TabIndex = 99;
            AddressTb.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Felix Titling", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 192);
            label5.Location = new Point(50, 289);
            label5.Name = "label5";
            label5.Size = new Size(145, 21);
            label5.TabIndex = 101;
            label5.Text = "Date Of Birth";
            // 
            // DOB
            // 
            DOB.Font = new Font("Arial Nova", 12F);
            DOB.Format = DateTimePickerFormat.Short;
            DOB.Location = new Point(50, 322);
            DOB.Name = "DOB";
            DOB.Size = new Size(344, 32);
            DOB.TabIndex = 102;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(491, 850);
            Controls.Add(DOB);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(AddressTb);
            Controls.Add(label3);
            Controls.Add(PasswordTb);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(AddBtn);
            Controls.Add(label2);
            Controls.Add(PhoneTb);
            Controls.Add(label1);
            Controls.Add(UnameTb);
            Controls.Add(label18);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label10;
        private Button AddBtn;
        private Label label2;
        private TextBox PhoneTb;
        private Label label1;
        private TextBox UnameTb;
        private Label label18;
        private Label label3;
        private TextBox PasswordTb;
        private Label label4;
        private TextBox AddressTb;
        private Label label5;
        private DateTimePicker DOB;
    }
}