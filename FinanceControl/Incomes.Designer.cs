namespace FinanceControl
{
    partial class Incomes
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incomes));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label7 = new Label();
            label6 = new Label();
            IncomeList = new Guna.UI2.WinForms.Guna2DataGridView();
            pictureBox6 = new PictureBox();
            DeleteBtn = new Button();
            EditBtn = new Button();
            AddBtn = new Button();
            label5 = new Label();
            DescTb = new TextBox();
            label4 = new Label();
            label3 = new Label();
            CatTb = new TextBox();
            label2 = new Label();
            AmountTb = new TextBox();
            label1 = new Label();
            NameTb = new TextBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox7 = new PictureBox();
            Logout = new PictureBox();
            DashboardBtn = new PictureBox();
            IncomeBtn = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            DateTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)IncomeList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DashboardBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IncomeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.PaleTurquoise;
            label7.Location = new Point(769, 86);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(137, 29);
            label7.TabIndex = 35;
            label7.Text = "Income List";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.PaleTurquoise;
            label6.Location = new Point(154, 21);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(212, 36);
            label6.TabIndex = 4;
            label6.Text = "Finance Control";
            // 
            // IncomeList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            IncomeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Trebuchet MS", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            IncomeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            IncomeList.ColumnHeadersHeight = 30;
            IncomeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Trebuchet MS", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            IncomeList.DefaultCellStyle = dataGridViewCellStyle3;
            IncomeList.GridColor = Color.FromArgb(231, 229, 255);
            IncomeList.Location = new Point(392, 118);
            IncomeList.Margin = new Padding(2, 3, 2, 3);
            IncomeList.Name = "IncomeList";
            IncomeList.RowHeadersVisible = false;
            IncomeList.RowHeadersWidth = 62;
            IncomeList.Size = new Size(883, 609);
            IncomeList.TabIndex = 34;
            IncomeList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            IncomeList.ThemeStyle.AlternatingRowsStyle.Font = null;
            IncomeList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            IncomeList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            IncomeList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            IncomeList.ThemeStyle.BackColor = Color.White;
            IncomeList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            IncomeList.ThemeStyle.HeaderStyle.BackColor = Color.PaleTurquoise;
            IncomeList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            IncomeList.ThemeStyle.HeaderStyle.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IncomeList.ThemeStyle.HeaderStyle.ForeColor = Color.Black;
            IncomeList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            IncomeList.ThemeStyle.HeaderStyle.Height = 30;
            IncomeList.ThemeStyle.ReadOnly = false;
            IncomeList.ThemeStyle.RowsStyle.BackColor = Color.White;
            IncomeList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            IncomeList.ThemeStyle.RowsStyle.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IncomeList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            IncomeList.ThemeStyle.RowsStyle.Height = 33;
            IncomeList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            IncomeList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            IncomeList.CellContentClick += IncomeList_CellContentClick;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(204, 86);
            pictureBox6.Margin = new Padding(2, 3, 2, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(63, 64);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 33;
            pictureBox6.TabStop = false;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Crimson;
            DeleteBtn.FlatAppearance.BorderColor = Color.Crimson;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatAppearance.MouseOverBackColor = Color.Red;
            DeleteBtn.ForeColor = Color.Black;
            DeleteBtn.Location = new Point(188, 684);
            DeleteBtn.Margin = new Padding(2, 3, 2, 3);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(100, 38);
            DeleteBtn.TabIndex = 32;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.PaleTurquoise;
            EditBtn.FlatAppearance.BorderColor = Color.PaleTurquoise;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatAppearance.MouseOverBackColor = Color.MediumTurquoise;
            EditBtn.ForeColor = Color.Black;
            EditBtn.Location = new Point(246, 626);
            EditBtn.Margin = new Padding(2, 3, 2, 3);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(100, 38);
            EditBtn.TabIndex = 31;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.PaleTurquoise;
            AddBtn.FlatAppearance.BorderColor = Color.PaleTurquoise;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatAppearance.MouseOverBackColor = Color.MediumTurquoise;
            AddBtn.ForeColor = Color.Black;
            AddBtn.Location = new Point(131, 626);
            AddBtn.Margin = new Padding(2, 3, 2, 3);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(100, 38);
            AddBtn.TabIndex = 30;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.PaleTurquoise;
            label5.Location = new Point(131, 538);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(135, 29);
            label5.TabIndex = 29;
            label5.Text = "Description";
            // 
            // DescTb
            // 
            DescTb.BackColor = Color.FromArgb(4, 13, 18);
            DescTb.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescTb.ForeColor = Color.White;
            DescTb.Location = new Point(131, 570);
            DescTb.Margin = new Padding(2, 3, 2, 3);
            DescTb.Name = "DescTb";
            DescTb.Size = new Size(214, 36);
            DescTb.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.PaleTurquoise;
            label4.Location = new Point(131, 441);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 29);
            label4.TabIndex = 27;
            label4.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.PaleTurquoise;
            label3.Location = new Point(131, 345);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 29);
            label3.TabIndex = 25;
            label3.Text = "Category";
            // 
            // CatTb
            // 
            CatTb.BackColor = Color.FromArgb(4, 13, 18);
            CatTb.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CatTb.ForeColor = Color.White;
            CatTb.Location = new Point(131, 377);
            CatTb.Margin = new Padding(2, 3, 2, 3);
            CatTb.Name = "CatTb";
            CatTb.Size = new Size(214, 36);
            CatTb.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.PaleTurquoise;
            label2.Location = new Point(131, 250);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 29);
            label2.TabIndex = 23;
            label2.Text = "Amount";
            // 
            // AmountTb
            // 
            AmountTb.BackColor = Color.FromArgb(4, 13, 18);
            AmountTb.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountTb.ForeColor = Color.White;
            AmountTb.Location = new Point(131, 282);
            AmountTb.Margin = new Padding(2, 3, 2, 3);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(214, 36);
            AmountTb.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.PaleTurquoise;
            label1.Location = new Point(131, 155);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 29);
            label1.TabIndex = 21;
            label1.Text = "Income";
            // 
            // NameTb
            // 
            NameTb.BackColor = Color.FromArgb(4, 13, 18);
            NameTb.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameTb.ForeColor = Color.White;
            NameTb.Location = new Point(131, 187);
            NameTb.Margin = new Padding(2, 3, 2, 3);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(214, 36);
            NameTb.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(87, 0);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1217, 80);
            panel2.TabIndex = 19;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1184, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(51, 8);
            pictureBox7.Margin = new Padding(2, 3, 2, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(63, 64);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // Logout
            // 
            Logout.Image = (Image)resources.GetObject("Logout.Image");
            Logout.Location = new Point(12, 684);
            Logout.Margin = new Padding(2, 3, 2, 3);
            Logout.Name = "Logout";
            Logout.Size = new Size(63, 64);
            Logout.SizeMode = PictureBoxSizeMode.StretchImage;
            Logout.TabIndex = 4;
            Logout.TabStop = false;
            Logout.Click += pictureBox5_Click;
            // 
            // DashboardBtn
            // 
            DashboardBtn.Image = (Image)resources.GetObject("DashboardBtn.Image");
            DashboardBtn.Location = new Point(12, 349);
            DashboardBtn.Margin = new Padding(2, 3, 2, 3);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Size = new Size(63, 64);
            DashboardBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            DashboardBtn.TabIndex = 3;
            DashboardBtn.TabStop = false;
            DashboardBtn.Click += DashboardBtn_Click;
            // 
            // IncomeBtn
            // 
            IncomeBtn.Image = (Image)resources.GetObject("IncomeBtn.Image");
            IncomeBtn.Location = new Point(12, 254);
            IncomeBtn.Margin = new Padding(2, 3, 2, 3);
            IncomeBtn.Name = "IncomeBtn";
            IncomeBtn.Size = new Size(63, 64);
            IncomeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            IncomeBtn.TabIndex = 2;
            IncomeBtn.TabStop = false;
            IncomeBtn.Click += IncomeBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 158);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 64);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 13, 18);
            panel1.Controls.Add(Logout);
            panel1.Controls.Add(DashboardBtn);
            panel1.Controls.Add(IncomeBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(87, 760);
            panel1.TabIndex = 18;
            // 
            // DateTb
            // 
            DateTb.Checked = true;
            DateTb.CustomizableEdges = customizableEdges1;
            DateTb.FillColor = Color.PaleTurquoise;
            DateTb.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateTb.Format = DateTimePickerFormat.Short;
            DateTb.Location = new Point(131, 472);
            DateTb.Margin = new Padding(2, 3, 2, 3);
            DateTb.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DateTb.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DateTb.Name = "DateTb";
            DateTb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DateTb.Size = new Size(215, 36);
            DateTb.TabIndex = 36;
            DateTb.Value = new DateTime(2024, 3, 13, 16, 24, 20, 985);
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 15;
            guna2Elipse2.TargetControl = IncomeList;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 8F);
            label8.ForeColor = Color.PaleTurquoise;
            label8.Location = new Point(219, 726);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(47, 22);
            label8.TabIndex = 37;
            label8.Text = "Clear";
            label8.Click += label8_Click;
            // 
            // Incomes
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 13, 18);
            ClientSize = new Size(1304, 760);
            Controls.Add(label8);
            Controls.Add(DateTb);
            Controls.Add(label7);
            Controls.Add(IncomeList);
            Controls.Add(pictureBox6);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(label5);
            Controls.Add(DescTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(CatTb);
            Controls.Add(label2);
            Controls.Add(AmountTb);
            Controls.Add(label1);
            Controls.Add(NameTb);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Trebuchet MS", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Incomes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Incomes";
            ((System.ComponentModel.ISupportInitialize)IncomeList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logout).EndInit();
            ((System.ComponentModel.ISupportInitialize)DashboardBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)IncomeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView IncomeList;
        private PictureBox pictureBox6;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button AddBtn;
        private Label label5;
        private TextBox DescTb;
        private Label label4;
        private Label label3;
        private TextBox CatTb;
        private Label label2;
        private TextBox AmountTb;
        private Label label1;
        private TextBox NameTb;
        private Panel panel2;
        private PictureBox pictureBox7;
        private PictureBox Logout;
        private PictureBox DashboardBtn;
        private PictureBox IncomeBtn;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTb;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Label label8;
        private PictureBox pictureBox2;
    }
}