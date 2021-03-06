﻿namespace Fare_Matrix_CPY.AdminPortal
{
    partial class CreateAccount
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnBrowse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbxUserImage = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtConfirmPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMiddleName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtFirstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.transition = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblInstruction);
            this.panel1.Controls.Add(this.lblHeader);
            this.transition.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 64);
            this.panel1.TabIndex = 0;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.transition.SetDecoration(this.lblInstruction, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblInstruction.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.ForeColor = System.Drawing.Color.White;
            this.lblInstruction.Location = new System.Drawing.Point(30, 42);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(249, 13);
            this.lblInstruction.TabIndex = 2;
            this.lblInstruction.Text = "&Use your google account to sign up a new account";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.transition.SetDecoration(this.lblHeader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblHeader.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(24, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(226, 28);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Create a New Account";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 4;
            this.bunifuElipse1.TargetControl = this;
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.guna2Button2);
            this.mainPanel.Controls.Add(this.guna2Button1);
            this.mainPanel.Controls.Add(this.btnBrowse);
            this.mainPanel.Controls.Add(this.pbxUserImage);
            this.mainPanel.Controls.Add(this.groupBox2);
            this.mainPanel.Controls.Add(this.groupBox1);
            this.transition.SetDecoration(this.mainPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 64);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(582, 338);
            this.mainPanel.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Activecolor = System.Drawing.Color.CadetBlue;
            this.btnBrowse.BackColor = System.Drawing.Color.White;
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowse.BorderRadius = 3;
            this.btnBrowse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBrowse.ButtonText = "Browse Image";
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.btnBrowse, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnBrowse.DisabledColor = System.Drawing.Color.Gray;
            this.btnBrowse.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBrowse.Iconimage = null;
            this.btnBrowse.Iconimage_right = null;
            this.btnBrowse.Iconimage_right_Selected = null;
            this.btnBrowse.Iconimage_Selected = null;
            this.btnBrowse.IconRightVisible = true;
            this.btnBrowse.IconRightZoom = 0D;
            this.btnBrowse.IconVisible = true;
            this.btnBrowse.IconZoom = 90D;
            this.btnBrowse.IsTab = false;
            this.btnBrowse.Location = new System.Drawing.Point(418, 196);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Normalcolor = System.Drawing.Color.White;
            this.btnBrowse.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.btnBrowse.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrowse.selected = false;
            this.btnBrowse.Size = new System.Drawing.Size(91, 21);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse Image";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrowse.Textcolor = System.Drawing.Color.Black;
            this.btnBrowse.TextFont = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pbxUserImage
            // 
            this.transition.SetDecoration(this.pbxUserImage, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pbxUserImage.Image = global::Fare_Matrix_CPY.Properties.Resources.account;
            this.pbxUserImage.Location = new System.Drawing.Point(380, 22);
            this.pbxUserImage.Name = "pbxUserImage";
            this.pbxUserImage.Size = new System.Drawing.Size(164, 157);
            this.pbxUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUserImage.TabIndex = 4;
            this.pbxUserImage.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtConfirmPassword);
            this.groupBox2.Controls.Add(this.lblConfirm);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.lblPassword);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.lblUsername);
            this.transition.SetDecoration(this.groupBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtConfirmPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPassword.isPassword = true;
            this.txtConfirmPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtConfirmPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.txtConfirmPassword.LineThickness = 2;
            this.txtConfirmPassword.Location = new System.Drawing.Point(130, 92);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(182, 25);
            this.txtConfirmPassword.TabIndex = 56;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.transition.SetDecoration(this.lblConfirm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblConfirm.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.Black;
            this.lblConfirm.Location = new System.Drawing.Point(13, 97);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(116, 15);
            this.lblConfirm.TabIndex = 55;
            this.lblConfirm.Text = "Confirm Password:";
            this.lblConfirm.Click += new System.EventHandler(this.lblConfirm_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.txtPassword.LineThickness = 2;
            this.txtPassword.Location = new System.Drawing.Point(130, 59);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(182, 25);
            this.txtPassword.TabIndex = 54;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.transition.SetDecoration(this.lblPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(53, 66);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 16);
            this.lblPassword.TabIndex = 53;
            this.lblPassword.Text = "Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtEmail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.txtEmail.LineThickness = 2;
            this.txtEmail.Location = new System.Drawing.Point(130, 26);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 25);
            this.txtEmail.TabIndex = 52;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.transition.SetDecoration(this.lblUsername, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(51, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 16);
            this.lblUsername.TabIndex = 51;
            this.lblUsername.Text = "Username:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMiddleName);
            this.groupBox1.Controls.Add(this.lblMiddleName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.transition.SetDecoration(this.groupBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Information";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtMiddleName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtMiddleName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMiddleName.isPassword = false;
            this.txtMiddleName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtMiddleName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMiddleName.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.txtMiddleName.LineThickness = 2;
            this.txtMiddleName.Location = new System.Drawing.Point(118, 96);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(182, 25);
            this.txtMiddleName.TabIndex = 56;
            this.txtMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.transition.SetDecoration(this.lblMiddleName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblMiddleName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.ForeColor = System.Drawing.Color.Black;
            this.lblMiddleName.Location = new System.Drawing.Point(23, 101);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(96, 16);
            this.lblMiddleName.TabIndex = 55;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtFirstName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFirstName.isPassword = false;
            this.txtFirstName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtFirstName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFirstName.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.txtFirstName.LineThickness = 2;
            this.txtFirstName.Location = new System.Drawing.Point(118, 63);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(182, 25);
            this.txtFirstName.TabIndex = 54;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.transition.SetDecoration(this.lblFirstName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblFirstName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(35, 68);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 16);
            this.lblFirstName.TabIndex = 53;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtLastName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastName.isPassword = false;
            this.txtLastName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtLastName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLastName.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.txtLastName.LineThickness = 2;
            this.txtLastName.Location = new System.Drawing.Point(118, 30);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(182, 25);
            this.txtLastName.TabIndex = 52;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.transition.SetDecoration(this.lblLastName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblLastName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(36, 35);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(83, 16);
            this.lblLastName.TabIndex = 51;
            this.lblLastName.Text = "Last Name:";
            // 
            // transition
            // 
            this.transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.transition.DefaultAnimation = animation1;
            this.transition.Interval = 2;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 7;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.transition.SetDecoration(this.guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button1.FillColor = System.Drawing.Color.CornflowerBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(468, 266);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Enabled = true;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.guna2Button1.Size = new System.Drawing.Size(102, 35);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "Next";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 7;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.transition.SetDecoration(this.guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button2.FillColor = System.Drawing.Color.CornflowerBlue;
            this.guna2Button2.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(363, 266);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Enabled = true;
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.guna2Button2.Size = new System.Drawing.Size(102, 35);
            this.guna2Button2.TabIndex = 7;
            this.guna2Button2.Text = "Back";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.transition.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(14, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Note: Please input all the require fields.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.transition.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(378, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 11);
            this.label2.TabIndex = 9;
            this.label2.Text = "(Optional)";
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 402);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeader;
        private System.Windows.Forms.Label lblInstruction;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Transition transition;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrowse;
        private System.Windows.Forms.PictureBox pbxUserImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirm;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMiddleName;
        private System.Windows.Forms.Label lblMiddleName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}