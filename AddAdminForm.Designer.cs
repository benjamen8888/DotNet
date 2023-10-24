namespace WinFormsApp3
{
    partial class AddAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdminForm));
            AddAdminGroupBox = new GroupBox();
            addressLabel = new Label();
            addadmintitle = new Label();
            yearLabel = new Label();
            phoneLabel = new Label();
            passwordLabel = new Label();
            userLabel = new Label();
            cancelButton = new Button();
            submitButton = new Button();
            birthDatePicker = new DateTimePicker();
            phoneTextBox = new TextBox();
            addressTextBox = new TextBox();
            passwordTextBox = new TextBox();
            userNameTextBox = new TextBox();
            AddAdminGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AddAdminGroupBox
            // 
            AddAdminGroupBox.BackColor = Color.Transparent;
            AddAdminGroupBox.BackgroundImage = (Image)resources.GetObject("AddAdminGroupBox.BackgroundImage");
            AddAdminGroupBox.BackgroundImageLayout = ImageLayout.Stretch;
            AddAdminGroupBox.Controls.Add(addressLabel);
            AddAdminGroupBox.Controls.Add(addadmintitle);
            AddAdminGroupBox.Controls.Add(yearLabel);
            AddAdminGroupBox.Controls.Add(phoneLabel);
            AddAdminGroupBox.Controls.Add(passwordLabel);
            AddAdminGroupBox.Controls.Add(userLabel);
            AddAdminGroupBox.Controls.Add(cancelButton);
            AddAdminGroupBox.Controls.Add(submitButton);
            AddAdminGroupBox.Controls.Add(birthDatePicker);
            AddAdminGroupBox.Controls.Add(phoneTextBox);
            AddAdminGroupBox.Controls.Add(addressTextBox);
            AddAdminGroupBox.Controls.Add(passwordTextBox);
            AddAdminGroupBox.Controls.Add(userNameTextBox);
            AddAdminGroupBox.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            AddAdminGroupBox.Location = new Point(5, 12);
            AddAdminGroupBox.Name = "AddAdminGroupBox";
            AddAdminGroupBox.Size = new Size(1248, 695);
            AddAdminGroupBox.TabIndex = 0;
            AddAdminGroupBox.TabStop = false;
            AddAdminGroupBox.Text = "AddAdmin";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            addressLabel.Location = new Point(98, 373);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(121, 37);
            addressLabel.TabIndex = 13;
            addressLabel.Text = "Adress:";
            // 
            // addadmintitle
            // 
            addadmintitle.AutoSize = true;
            addadmintitle.BackColor = Color.Transparent;
            addadmintitle.Font = new Font("Footlight MT Light", 30F, FontStyle.Bold, GraphicsUnit.Point);
            addadmintitle.ForeColor = Color.Black;
            addadmintitle.Location = new Point(409, 63);
            addadmintitle.Name = "addadmintitle";
            addadmintitle.Size = new Size(428, 63);
            addadmintitle.TabIndex = 12;
            addadmintitle.Text = "Add new admin";
            addadmintitle.Click += WelcomeLabel_Click;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            yearLabel.Location = new Point(578, 283);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(145, 37);
            yearLabel.TabIndex = 11;
            yearLabel.Text = "Birthday:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.BackColor = Color.Transparent;
            phoneLabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            phoneLabel.Location = new Point(569, 183);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(232, 37);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Phone number:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(98, 283);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(174, 37);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Password*:";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.BackColor = Color.Transparent;
            userLabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            userLabel.Location = new Point(98, 184);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(189, 37);
            userLabel.TabIndex = 9;
            userLabel.Text = "User name*:";
            // 
            // cancelButton
            // 
            cancelButton.BackgroundImage = (Image)resources.GetObject("cancelButton.BackgroundImage");
            cancelButton.Location = new Point(673, 498);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(164, 55);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // submitButton
            // 
            submitButton.BackgroundImage = (Image)resources.GetObject("submitButton.BackgroundImage");
            submitButton.Location = new Point(359, 498);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(165, 55);
            submitButton.TabIndex = 7;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // birthDatePicker
            // 
            birthDatePicker.Font = new Font("Modern No. 20", 14F, FontStyle.Regular, GraphicsUnit.Point);
            birthDatePicker.Location = new Point(854, 281);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new Size(300, 37);
            birthDatePicker.TabIndex = 5;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Font = new Font("Modern No. 20", 14F, FontStyle.Regular, GraphicsUnit.Point);
            phoneTextBox.Location = new Point(854, 184);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(196, 37);
            phoneTextBox.TabIndex = 3;
            phoneTextBox.Text = "phone";
            // 
            // addressTextBox
            // 
            addressTextBox.Font = new Font("Modern No. 20", 14F, FontStyle.Regular, GraphicsUnit.Point);
            addressTextBox.Location = new Point(305, 375);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(202, 37);
            addressTextBox.TabIndex = 2;
            addressTextBox.Text = "addressTextBox3";
            addressTextBox.TextChanged += addressTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Modern No. 20", 14F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(305, 283);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(202, 37);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.Text = "passwordTextBox";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Font = new Font("Modern No. 20", 14F, FontStyle.Regular, GraphicsUnit.Point);
            userNameTextBox.Location = new Point(305, 184);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(202, 37);
            userNameTextBox.TabIndex = 0;
            userNameTextBox.Text = "userNameTextBox";
            // 
            // AddAdminForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1252, 709);
            Controls.Add(AddAdminGroupBox);
            Name = "AddAdminForm";
            Text = "AddAdminForm";
            AddAdminGroupBox.ResumeLayout(false);
            AddAdminGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox AddAdminGroupBox;
        private TextBox passwordTextBox;
        private TextBox userNameTextBox;
        private TextBox phoneTextBox;
        private TextBox addressTextBox;
        private DateTimePicker birthDatePicker;
        private ListBox roleListBox;
        private Button cancelButton;
        private Button submitButton;
        private Label userLabel;
        private Label yearLabel;
        private Label phoneLabel;
        private Label passwordLabel;
        private Label addadmintitle;
        private Label addressLabel;
    }
}