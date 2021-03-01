
namespace WindowsFormsApp1
{
    partial class User
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.UserDataGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.UserId = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton7 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDataGV
            // 
            this.UserDataGV.AllowUserToAddRows = false;
            this.UserDataGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.UserDataGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.UserDataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserDataGV.BackgroundColor = System.Drawing.Color.White;
            this.UserDataGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserDataGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserDataGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.UserDataGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserDataGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.UserDataGV.EnableHeadersVisualStyles = false;
            this.UserDataGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserDataGV.Location = new System.Drawing.Point(422, 78);
            this.UserDataGV.Name = "UserDataGV";
            this.UserDataGV.RowHeadersVisible = false;
            this.UserDataGV.RowHeadersWidth = 51;
            this.UserDataGV.RowTemplate.Height = 24;
            this.UserDataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDataGV.Size = new System.Drawing.Size(356, 301);
            this.UserDataGV.TabIndex = 47;
            this.UserDataGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.UserDataGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.UserDataGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.UserDataGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.UserDataGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UserDataGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UserDataGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.UserDataGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserDataGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.UserDataGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UserDataGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.UserDataGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.UserDataGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.UserDataGV.ThemeStyle.HeaderStyle.Height = 4;
            this.UserDataGV.ThemeStyle.ReadOnly = false;
            this.UserDataGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.UserDataGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserDataGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.UserDataGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UserDataGV.ThemeStyle.RowsStyle.Height = 24;
            this.UserDataGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserDataGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.BorderRadius = 10;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton2.HoverState.BorderColor = System.Drawing.Color.Red;
            this.guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2GradientButton2.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Location = new System.Drawing.Point(270, 264);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(102, 40);
            this.guna2GradientButton2.TabIndex = 50;
            this.guna2GradientButton2.Text = "Delete";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 10;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Honeydew;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Blue;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.ForeColor = System.Drawing.Color.Gray;
            this.guna2GradientButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton1.HoverState.Image")));
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(142, 264);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(102, 40);
            this.guna2GradientButton1.TabIndex = 49;
            this.guna2GradientButton1.Text = "Edit";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2GradientButton5
            // 
            this.guna2GradientButton5.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton5.BorderRadius = 10;
            this.guna2GradientButton5.CheckedState.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.CustomImages.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientButton5.FillColor2 = System.Drawing.Color.Blue;
            this.guna2GradientButton5.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.guna2GradientButton5.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2GradientButton5.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2GradientButton5.HoverState.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientButton5.HoverState.ForeColor = System.Drawing.Color.Gray;
            this.guna2GradientButton5.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton5.HoverState.Image")));
            this.guna2GradientButton5.HoverState.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.Location = new System.Drawing.Point(21, 264);
            this.guna2GradientButton5.Name = "guna2GradientButton5";
            this.guna2GradientButton5.ShadowDecoration.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.Size = new System.Drawing.Size(102, 40);
            this.guna2GradientButton5.TabIndex = 48;
            this.guna2GradientButton5.Text = "ADD";
            this.guna2GradientButton5.Click += new System.EventHandler(this.guna2GradientButton5_Click);
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.BorderRadius = 10;
            this.guna2GradientButton3.CheckedState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.CustomImages.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.FillColor = System.Drawing.Color.Aquamarine;
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.Blue;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton3.HoverState.BorderColor = System.Drawing.Color.Lime;
            this.guna2GradientButton3.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2GradientButton3.HoverState.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientButton3.HoverState.ForeColor = System.Drawing.Color.Gray;
            this.guna2GradientButton3.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton3.HoverState.Image")));
            this.guna2GradientButton3.HoverState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton3.Image")));
            this.guna2GradientButton3.Location = new System.Drawing.Point(670, 398);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.ShadowDecoration.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Size = new System.Drawing.Size(108, 40);
            this.guna2GradientButton3.TabIndex = 51;
            this.guna2GradientButton3.Text = "Home";
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // UserId
            // 
            this.UserId.Animated = true;
            this.UserId.BorderColor = System.Drawing.Color.Lime;
            this.UserId.BorderRadius = 8;
            this.UserId.BorderThickness = 2;
            this.UserId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserId.DefaultText = "";
            this.UserId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserId.DisabledState.Parent = this.UserId;
            this.UserId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserId.FocusedState.Parent = this.UserId;
            this.UserId.ForeColor = System.Drawing.Color.Blue;
            this.UserId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserId.HoverState.Parent = this.UserId;
            this.UserId.Location = new System.Drawing.Point(158, 78);
            this.UserId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserId.Name = "UserId";
            this.UserId.PasswordChar = '\0';
            this.UserId.PlaceholderText = "Enter ID";
            this.UserId.SelectedText = "";
            this.UserId.ShadowDecoration.Parent = this.UserId;
            this.UserId.Size = new System.Drawing.Size(214, 44);
            this.UserId.TabIndex = 52;
            this.UserId.TextChanged += new System.EventHandler(this.UserId_TextChanged);
            // 
            // UserName
            // 
            this.UserName.Animated = true;
            this.UserName.BorderColor = System.Drawing.Color.Lime;
            this.UserName.BorderRadius = 8;
            this.UserName.BorderThickness = 2;
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.DefaultText = "";
            this.UserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserName.DisabledState.Parent = this.UserName;
            this.UserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserName.FocusedState.Parent = this.UserName;
            this.UserName.ForeColor = System.Drawing.Color.Blue;
            this.UserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserName.HoverState.Parent = this.UserName;
            this.UserName.Location = new System.Drawing.Point(158, 131);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserName.Name = "UserName";
            this.UserName.PasswordChar = '\0';
            this.UserName.PlaceholderText = "Enter Name";
            this.UserName.SelectedText = "";
            this.UserName.ShadowDecoration.Parent = this.UserName;
            this.UserName.Size = new System.Drawing.Size(214, 44);
            this.UserName.TabIndex = 53;
            // 
            // UserPassword
            // 
            this.UserPassword.Animated = true;
            this.UserPassword.BorderColor = System.Drawing.Color.Lime;
            this.UserPassword.BorderRadius = 8;
            this.UserPassword.BorderThickness = 2;
            this.UserPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserPassword.DefaultText = "";
            this.UserPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserPassword.DisabledState.Parent = this.UserPassword;
            this.UserPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserPassword.FocusedState.Parent = this.UserPassword;
            this.UserPassword.ForeColor = System.Drawing.Color.Blue;
            this.UserPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserPassword.HoverState.Parent = this.UserPassword;
            this.UserPassword.Location = new System.Drawing.Point(158, 182);
            this.UserPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.PasswordChar = '\0';
            this.UserPassword.PlaceholderText = "Enter Password";
            this.UserPassword.SelectedText = "";
            this.UserPassword.ShadowDecoration.Parent = this.UserPassword;
            this.UserPassword.Size = new System.Drawing.Size(214, 44);
            this.UserPassword.TabIndex = 54;
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.BorderRadius = 5;
            this.guna2GradientButton4.CheckedState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.CustomImages.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.FillColor = System.Drawing.Color.White;
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.DimGray;
            this.guna2GradientButton4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientButton4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2GradientButton4.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GradientButton4.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.HoverState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton4.Image")));
            this.guna2GradientButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton4.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2GradientButton4.Location = new System.Drawing.Point(12, 78);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.ShadowDecoration.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Size = new System.Drawing.Size(111, 45);
            this.guna2GradientButton4.TabIndex = 55;
            this.guna2GradientButton4.Text = "ID";
            this.guna2GradientButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton4.UseTransparentBackground = true;
            // 
            // guna2GradientButton6
            // 
            this.guna2GradientButton6.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton6.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton6.BorderRadius = 5;
            this.guna2GradientButton6.CheckedState.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.CustomImages.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.FillColor = System.Drawing.Color.White;
            this.guna2GradientButton6.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientButton6.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.guna2GradientButton6.ForeColor = System.Drawing.Color.DimGray;
            this.guna2GradientButton6.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientButton6.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2GradientButton6.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GradientButton6.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton6.HoverState.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton6.Image")));
            this.guna2GradientButton6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton6.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2GradientButton6.Location = new System.Drawing.Point(12, 130);
            this.guna2GradientButton6.Name = "guna2GradientButton6";
            this.guna2GradientButton6.ShadowDecoration.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.Size = new System.Drawing.Size(111, 45);
            this.guna2GradientButton6.TabIndex = 56;
            this.guna2GradientButton6.Text = "Name";
            this.guna2GradientButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton6.UseTransparentBackground = true;
            // 
            // guna2GradientButton7
            // 
            this.guna2GradientButton7.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton7.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton7.BorderRadius = 5;
            this.guna2GradientButton7.CheckedState.Parent = this.guna2GradientButton7;
            this.guna2GradientButton7.CustomImages.Parent = this.guna2GradientButton7;
            this.guna2GradientButton7.FillColor = System.Drawing.Color.White;
            this.guna2GradientButton7.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientButton7.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.guna2GradientButton7.ForeColor = System.Drawing.Color.DimGray;
            this.guna2GradientButton7.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton7.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientButton7.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2GradientButton7.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GradientButton7.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton7.HoverState.Parent = this.guna2GradientButton7;
            this.guna2GradientButton7.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton7.Image")));
            this.guna2GradientButton7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton7.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2GradientButton7.Location = new System.Drawing.Point(12, 179);
            this.guna2GradientButton7.Name = "guna2GradientButton7";
            this.guna2GradientButton7.ShadowDecoration.Parent = this.guna2GradientButton7;
            this.guna2GradientButton7.Size = new System.Drawing.Size(139, 45);
            this.guna2GradientButton7.TabIndex = 57;
            this.guna2GradientButton7.Text = "Password";
            this.guna2GradientButton7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton7.UseTransparentBackground = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(491, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 29);
            this.label4.TabIndex = 58;
            this.label4.Text = "Registered Users";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2GradientButton7);
            this.Controls.Add(this.guna2GradientButton6);
            this.Controls.Add(this.guna2GradientButton4);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.UserId);
            this.Controls.Add(this.guna2GradientButton3);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.guna2GradientButton5);
            this.Controls.Add(this.UserDataGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView UserDataGV;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton5;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2TextBox UserId;
        private Guna.UI2.WinForms.Guna2TextBox UserName;
        private Guna.UI2.WinForms.Guna2TextBox UserPassword;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton6;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}