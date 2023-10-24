namespace WinFormsApp3
{
    partial class AddMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMemberForm));
            AddMember = new GroupBox();
            memberId = new Label();
            birthdayLabel = new Label();
            addMemberLabel = new Label();
            addressLabel = new Label();
            passwordLabel = new Label();
            phoneLabel = new Label();
            nameLabel = new Label();
            IDLabel = new Label();
            cancelButton = new Button();
            birthDate = new DateTimePicker();
            phone = new TextBox();
            addButton = new Button();
            memberAddress = new TextBox();
            memberName = new TextBox();
            memberpasswd = new TextBox();
            phoneNumberLabel = new Label();
            AddMember.SuspendLayout();
            SuspendLayout();
            // 
            // AddMember
            // 
            AddMember.BackgroundImage = (Image)resources.GetObject("AddMember.BackgroundImage");
            AddMember.BackgroundImageLayout = ImageLayout.Stretch;
            AddMember.Controls.Add(phoneNumberLabel);
            AddMember.Controls.Add(memberId);
            AddMember.Controls.Add(birthdayLabel);
            AddMember.Controls.Add(addMemberLabel);
            AddMember.Controls.Add(addressLabel);
            AddMember.Controls.Add(passwordLabel);
            AddMember.Controls.Add(phoneLabel);
            AddMember.Controls.Add(nameLabel);
            AddMember.Controls.Add(IDLabel);
            AddMember.Controls.Add(cancelButton);
            AddMember.Controls.Add(birthDate);
            AddMember.Controls.Add(phone);
            AddMember.Controls.Add(addButton);
            AddMember.Controls.Add(memberAddress);
            AddMember.Controls.Add(memberName);
            AddMember.Controls.Add(memberpasswd);
            AddMember.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            AddMember.Location = new Point(12, 0);
            AddMember.Name = "AddMember";
            AddMember.Size = new Size(1257, 672);
            AddMember.TabIndex = 0;
            AddMember.TabStop = false;
            AddMember.Text = "Welcome admin page";
            // 
            // memberId
            // 
            memberId.AutoSize = true;
            memberId.BackColor = Color.Transparent;
            memberId.Font = new Font("Modern No. 20", 14F, FontStyle.Regular, GraphicsUnit.Point);
            memberId.ForeColor = Color.Brown;
            memberId.Location = new Point(213, 198);
            memberId.Name = "memberId";
            memberId.Size = new Size(298, 30);
            memberId.TabIndex = 15;
            memberId.Text = "memberId auto generated";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.BackColor = Color.Transparent;
            birthdayLabel.Font = new Font("Modern No. 20", 14.999999F, FontStyle.Bold, GraphicsUnit.Point);
            birthdayLabel.Location = new Point(520, 432);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(141, 31);
            birthdayLabel.TabIndex = 14;
            birthdayLabel.Text = "Birthday:";
            // 
            // addMemberLabel
            // 
            addMemberLabel.AutoSize = true;
            addMemberLabel.BackColor = Color.Transparent;
            addMemberLabel.Font = new Font("Footlight MT Light", 30F, FontStyle.Bold, GraphicsUnit.Point);
            addMemberLabel.ForeColor = Color.Black;
            addMemberLabel.Location = new Point(343, 65);
            addMemberLabel.Name = "addMemberLabel";
            addMemberLabel.Size = new Size(476, 63);
            addMemberLabel.TabIndex = 13;
            addMemberLabel.Text = "Add new member";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = Color.Transparent;
            addressLabel.Font = new Font("Modern No. 20", 14.999999F, FontStyle.Bold, GraphicsUnit.Point);
            addressLabel.Location = new Point(28, 433);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(124, 31);
            addressLabel.TabIndex = 12;
            addressLabel.Text = "Address:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Modern No. 20", 14.999999F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(9, 310);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(143, 31);
            passwordLabel.TabIndex = 11;
            passwordLabel.Text = "Password:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.BackColor = Color.Transparent;
            phoneLabel.Font = new Font("Modern No. 20", 14.999999F, FontStyle.Bold, GraphicsUnit.Point);
            phoneLabel.Location = new Point(555, 310);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(104, 31);
            phoneLabel.TabIndex = 10;
            phoneLabel.Text = "Phone:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Modern No. 20", 14.999999F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(565, 203);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(96, 31);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "Name:";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.BackColor = Color.Transparent;
            IDLabel.Font = new Font("Modern No. 20", 14.999999F, FontStyle.Bold, GraphicsUnit.Point);
            IDLabel.Location = new Point(90, 199);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(58, 31);
            IDLabel.TabIndex = 8;
            IDLabel.Text = "ID:";
            // 
            // cancelButton
            // 
            cancelButton.BackgroundImage = (Image)resources.GetObject("cancelButton.BackgroundImage");
            cancelButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cancelButton.ForeColor = SystemColors.ControlLightLight;
            cancelButton.Location = new Point(601, 549);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(161, 58);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // birthDate
            // 
            birthDate.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            birthDate.Location = new Point(702, 429);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(300, 39);
            birthDate.TabIndex = 6;
            // 
            // phone
            // 
            phone.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phone.Location = new Point(702, 310);
            phone.Name = "phone";
            phone.Size = new Size(300, 39);
            phone.TabIndex = 5;
            phone.Text = "phone";
            // 
            // addButton
            // 
            addButton.BackgroundImage = (Image)resources.GetObject("addButton.BackgroundImage");
            addButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(286, 549);
            addButton.Name = "addButton";
            addButton.Size = new Size(167, 56);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // memberAddress
            // 
            memberAddress.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            memberAddress.Location = new Point(213, 431);
            memberAddress.Name = "memberAddress";
            memberAddress.Size = new Size(231, 39);
            memberAddress.TabIndex = 3;
            memberAddress.Text = "memberAddress";
            // 
            // memberName
            // 
            memberName.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            memberName.Location = new Point(702, 198);
            memberName.Name = "memberName";
            memberName.Size = new Size(300, 39);
            memberName.TabIndex = 2;
            memberName.Text = "memberName";
            // 
            // memberpasswd
            // 
            memberpasswd.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            memberpasswd.Location = new Point(213, 310);
            memberpasswd.Name = "memberpasswd";
            memberpasswd.Size = new Size(231, 39);
            memberpasswd.TabIndex = 1;
            memberpasswd.Text = "memberpassword";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.BackColor = Color.Transparent;
            phoneNumberLabel.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumberLabel.ForeColor = Color.Gray;
            phoneNumberLabel.Location = new Point(555, 352);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(255, 24);
            phoneNumberLabel.TabIndex = 21;
            phoneNumberLabel.Text = "For example: 04xxxxxxxx";
            // 
            // AddMemberForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 684);
            Controls.Add(AddMember);
            Name = "AddMemberForm";
            Text = "AddMemberForm";
            AddMember.ResumeLayout(false);
            AddMember.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox AddMember;
        private TextBox memberAddress;
        private TextBox memberName;
        private TextBox memberpasswd;
        private Button addButton;
        private DateTimePicker birthDate;
        private TextBox phone;
        private Button cancelButton;
        private Label IDLabel;
        private Label addressLabel;
        private Label passwordLabel;
        private Label phoneLabel;
        private Label nameLabel;
        private Label addMemberLabel;
        private Label birthdayLabel;
        private Label memberId;
        private Label phoneNumberLabel;
    }
}