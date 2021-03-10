
namespace WindowsFormsApp1
{
    partial class Department
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DepNameT = new Guna.UI2.WinForms.Guna2TextBox();
            this.DepDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.DepDuration = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton7 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DepDataGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GradientButton8 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton15 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.searchbox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.DepDataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(323, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "Department List";
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
            this.guna2GradientButton5.Location = new System.Drawing.Point(33, 286);
            this.guna2GradientButton5.Name = "guna2GradientButton5";
            this.guna2GradientButton5.ShadowDecoration.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.Size = new System.Drawing.Size(102, 40);
            this.guna2GradientButton5.TabIndex = 36;
            this.guna2GradientButton5.Text = "ADD";
            this.guna2GradientButton5.Click += new System.EventHandler(this.guna2GradientButton5_Click);
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
            this.guna2GradientButton1.Location = new System.Drawing.Point(161, 286);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(102, 40);
            this.guna2GradientButton1.TabIndex = 37;
            this.guna2GradientButton1.Text = "Edit";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
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
            this.guna2GradientButton2.Location = new System.Drawing.Point(287, 286);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(102, 40);
            this.guna2GradientButton2.TabIndex = 38;
            this.guna2GradientButton2.Text = "Delete";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
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
            this.guna2GradientButton3.Location = new System.Drawing.Point(827, 522);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.ShadowDecoration.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Size = new System.Drawing.Size(102, 40);
            this.guna2GradientButton3.TabIndex = 39;
            this.guna2GradientButton3.Text = "Home";
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DepNameT
            // 
            this.DepNameT.Animated = true;
            this.DepNameT.BorderColor = System.Drawing.Color.Lime;
            this.DepNameT.BorderRadius = 8;
            this.DepNameT.BorderThickness = 2;
            this.DepNameT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DepNameT.DefaultText = "";
            this.DepNameT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DepNameT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DepNameT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DepNameT.DisabledState.Parent = this.DepNameT;
            this.DepNameT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DepNameT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DepNameT.FocusedState.Parent = this.DepNameT;
            this.DepNameT.ForeColor = System.Drawing.Color.Blue;
            this.DepNameT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DepNameT.HoverState.Parent = this.DepNameT;
            this.DepNameT.Location = new System.Drawing.Point(175, 87);
            this.DepNameT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DepNameT.Name = "DepNameT";
            this.DepNameT.PasswordChar = '\0';
            this.DepNameT.PlaceholderText = "Enter Name";
            this.DepNameT.SelectedText = "";
            this.DepNameT.ShadowDecoration.Parent = this.DepNameT;
            this.DepNameT.Size = new System.Drawing.Size(214, 44);
            this.DepNameT.TabIndex = 40;
            // 
            // DepDesc
            // 
            this.DepDesc.Animated = true;
            this.DepDesc.BorderColor = System.Drawing.Color.Lime;
            this.DepDesc.BorderRadius = 8;
            this.DepDesc.BorderThickness = 2;
            this.DepDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DepDesc.DefaultText = "";
            this.DepDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DepDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DepDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DepDesc.DisabledState.Parent = this.DepDesc;
            this.DepDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DepDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DepDesc.FocusedState.Parent = this.DepDesc;
            this.DepDesc.ForeColor = System.Drawing.Color.Blue;
            this.DepDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DepDesc.HoverState.Parent = this.DepDesc;
            this.DepDesc.Location = new System.Drawing.Point(175, 139);
            this.DepDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DepDesc.Name = "DepDesc";
            this.DepDesc.PasswordChar = '\0';
            this.DepDesc.PlaceholderText = "Enter Description";
            this.DepDesc.SelectedText = "";
            this.DepDesc.ShadowDecoration.Parent = this.DepDesc;
            this.DepDesc.Size = new System.Drawing.Size(214, 44);
            this.DepDesc.TabIndex = 41;
            // 
            // DepDuration
            // 
            this.DepDuration.Animated = true;
            this.DepDuration.BorderColor = System.Drawing.Color.Lime;
            this.DepDuration.BorderRadius = 8;
            this.DepDuration.BorderThickness = 2;
            this.DepDuration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DepDuration.DefaultText = "";
            this.DepDuration.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DepDuration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DepDuration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DepDuration.DisabledState.Parent = this.DepDuration;
            this.DepDuration.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DepDuration.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DepDuration.FocusedState.Parent = this.DepDuration;
            this.DepDuration.ForeColor = System.Drawing.Color.Blue;
            this.DepDuration.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DepDuration.HoverState.Parent = this.DepDuration;
            this.DepDuration.Location = new System.Drawing.Point(175, 191);
            this.DepDuration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DepDuration.Name = "DepDuration";
            this.DepDuration.PasswordChar = '\0';
            this.DepDuration.PlaceholderText = "Enter time duration";
            this.DepDuration.SelectedText = "";
            this.DepDuration.ShadowDecoration.Parent = this.DepDuration;
            this.DepDuration.Size = new System.Drawing.Size(214, 44);
            this.DepDuration.TabIndex = 42;
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
            this.guna2GradientButton4.Location = new System.Drawing.Point(12, 86);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.ShadowDecoration.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Size = new System.Drawing.Size(111, 45);
            this.guna2GradientButton4.TabIndex = 43;
            this.guna2GradientButton4.Text = "Name";
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
            this.guna2GradientButton6.Location = new System.Drawing.Point(12, 139);
            this.guna2GradientButton6.Name = "guna2GradientButton6";
            this.guna2GradientButton6.ShadowDecoration.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.Size = new System.Drawing.Size(142, 45);
            this.guna2GradientButton6.TabIndex = 44;
            this.guna2GradientButton6.Text = "Description";
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
            this.guna2GradientButton7.Location = new System.Drawing.Point(12, 190);
            this.guna2GradientButton7.Name = "guna2GradientButton7";
            this.guna2GradientButton7.ShadowDecoration.Parent = this.guna2GradientButton7;
            this.guna2GradientButton7.Size = new System.Drawing.Size(142, 45);
            this.guna2GradientButton7.TabIndex = 45;
            this.guna2GradientButton7.Text = "Duration";
            this.guna2GradientButton7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton7.UseTransparentBackground = true;
            // 
            // DepDataGV
            // 
            this.DepDataGV.AllowUserToAddRows = false;
            this.DepDataGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DepDataGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DepDataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DepDataGV.BackgroundColor = System.Drawing.Color.White;
            this.DepDataGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DepDataGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DepDataGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DepDataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DepDataGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DepDataGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.DepDataGV.EnableHeadersVisualStyles = false;
            this.DepDataGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DepDataGV.Location = new System.Drawing.Point(440, 112);
            this.DepDataGV.Name = "DepDataGV";
            this.DepDataGV.RowHeadersVisible = false;
            this.DepDataGV.RowHeadersWidth = 51;
            this.DepDataGV.RowTemplate.Height = 24;
            this.DepDataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DepDataGV.Size = new System.Drawing.Size(476, 336);
            this.DepDataGV.TabIndex = 46;
            this.DepDataGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DepDataGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DepDataGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DepDataGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DepDataGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DepDataGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DepDataGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DepDataGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DepDataGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DepDataGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DepDataGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DepDataGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DepDataGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DepDataGV.ThemeStyle.HeaderStyle.Height = 4;
            this.DepDataGV.ThemeStyle.ReadOnly = false;
            this.DepDataGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DepDataGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DepDataGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DepDataGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DepDataGV.ThemeStyle.RowsStyle.Height = 24;
            this.DepDataGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DepDataGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2GradientButton8
            // 
            this.guna2GradientButton8.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton8.BorderRadius = 10;
            this.guna2GradientButton8.CheckedState.Parent = this.guna2GradientButton8;
            this.guna2GradientButton8.CustomImages.Parent = this.guna2GradientButton8;
            this.guna2GradientButton8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientButton8.FillColor2 = System.Drawing.Color.Blue;
            this.guna2GradientButton8.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.guna2GradientButton8.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton8.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton8.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2GradientButton8.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2GradientButton8.HoverState.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientButton8.HoverState.ForeColor = System.Drawing.Color.Gray;
            this.guna2GradientButton8.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton8.HoverState.Image")));
            this.guna2GradientButton8.HoverState.Parent = this.guna2GradientButton8;
            this.guna2GradientButton8.Location = new System.Drawing.Point(550, 65);
            this.guna2GradientButton8.Name = "guna2GradientButton8";
            this.guna2GradientButton8.ShadowDecoration.Parent = this.guna2GradientButton8;
            this.guna2GradientButton8.Size = new System.Drawing.Size(102, 40);
            this.guna2GradientButton8.TabIndex = 105;
            this.guna2GradientButton8.Text = "Refresh";
            // 
            // guna2GradientButton15
            // 
            this.guna2GradientButton15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2GradientButton15.BorderRadius = 10;
            this.guna2GradientButton15.CheckedState.Parent = this.guna2GradientButton15;
            this.guna2GradientButton15.CustomImages.Parent = this.guna2GradientButton15;
            this.guna2GradientButton15.FillColor = System.Drawing.Color.Lime;
            this.guna2GradientButton15.FillColor2 = System.Drawing.Color.Aqua;
            this.guna2GradientButton15.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.guna2GradientButton15.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton15.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton15.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2GradientButton15.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2GradientButton15.HoverState.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientButton15.HoverState.ForeColor = System.Drawing.Color.Gray;
            this.guna2GradientButton15.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton15.HoverState.Image")));
            this.guna2GradientButton15.HoverState.Parent = this.guna2GradientButton15;
            this.guna2GradientButton15.Location = new System.Drawing.Point(827, 67);
            this.guna2GradientButton15.Name = "guna2GradientButton15";
            this.guna2GradientButton15.ShadowDecoration.Parent = this.guna2GradientButton15;
            this.guna2GradientButton15.Size = new System.Drawing.Size(89, 36);
            this.guna2GradientButton15.TabIndex = 104;
            this.guna2GradientButton15.Text = "Search";
            this.guna2GradientButton15.Click += new System.EventHandler(this.guna2GradientButton15_Click);
            // 
            // searchbox1
            // 
            this.searchbox1.Animated = true;
            this.searchbox1.BorderColor = System.Drawing.Color.Lime;
            this.searchbox1.BorderRadius = 8;
            this.searchbox1.BorderThickness = 2;
            this.searchbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbox1.DefaultText = "";
            this.searchbox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchbox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchbox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchbox1.DisabledState.Parent = this.searchbox1;
            this.searchbox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchbox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchbox1.FocusedState.Parent = this.searchbox1;
            this.searchbox1.ForeColor = System.Drawing.Color.Blue;
            this.searchbox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchbox1.HoverState.Parent = this.searchbox1;
            this.searchbox1.Location = new System.Drawing.Point(687, 65);
            this.searchbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchbox1.Name = "searchbox1";
            this.searchbox1.PasswordChar = '\0';
            this.searchbox1.PlaceholderText = "Enter Student ID\r\n";
            this.searchbox1.SelectedText = "";
            this.searchbox1.ShadowDecoration.Parent = this.searchbox1;
            this.searchbox1.Size = new System.Drawing.Size(133, 40);
            this.searchbox1.TabIndex = 103;
            this.searchbox1.TextChanged += new System.EventHandler(this.searchbox1_TextChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 6;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(892, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(51, 40);
            this.guna2ControlBox1.TabIndex = 106;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(955, 574);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2GradientButton8);
            this.Controls.Add(this.guna2GradientButton15);
            this.Controls.Add(this.searchbox1);
            this.Controls.Add(this.DepDataGV);
            this.Controls.Add(this.guna2GradientButton7);
            this.Controls.Add(this.guna2GradientButton6);
            this.Controls.Add(this.guna2GradientButton4);
            this.Controls.Add(this.DepDuration);
            this.Controls.Add(this.DepDesc);
            this.Controls.Add(this.DepNameT);
            this.Controls.Add(this.guna2GradientButton3);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.guna2GradientButton5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Department";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepDataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton5;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TextBox DepNameT;
        private Guna.UI2.WinForms.Guna2TextBox DepDesc;
        private Guna.UI2.WinForms.Guna2TextBox DepDuration;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton6;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton7;
        private Guna.UI2.WinForms.Guna2DataGridView DepDataGV;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton8;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton15;
        private Guna.UI2.WinForms.Guna2TextBox searchbox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}