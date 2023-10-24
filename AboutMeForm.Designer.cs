namespace WinFormsApp3
{
    partial class AboutMeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutMeForm));
            pictureBox = new PictureBox();
            openFileDialog = new OpenFileDialog();
            uploadPictureButton = new Button();
            pictureLabel = new Label();
            memberId = new Label();
            memberAddress = new Label();
            memberpasswd = new Label();
            memberName = new Label();
            phone = new Label();
            role = new Label();
            birthDate = new Label();
            AboutLabel = new Label();
            idLabel = new Label();
            passwordLabel = new Label();
            phonrLabel = new Label();
            roleLabel = new Label();
            nameLabel = new Label();
            addressLabel = new Label();
            birthdayLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(98, 216);
            pictureBox.Margin = new Padding(4, 5, 4, 5);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(203, 259);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // uploadPictureButton
            // 
            uploadPictureButton.BackgroundImage = (Image)resources.GetObject("uploadPictureButton.BackgroundImage");
            uploadPictureButton.Font = new Font("Rockwell Extra Bold", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            uploadPictureButton.ForeColor = SystemColors.ControlLightLight;
            uploadPictureButton.Location = new Point(120, 517);
            uploadPictureButton.Margin = new Padding(4, 5, 4, 5);
            uploadPictureButton.Name = "uploadPictureButton";
            uploadPictureButton.Size = new Size(152, 49);
            uploadPictureButton.TabIndex = 2;
            uploadPictureButton.Text = "Upload";
            uploadPictureButton.UseVisualStyleBackColor = true;
            uploadPictureButton.Click += UploadPictureButton_Click;
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.BackColor = Color.Transparent;
            pictureLabel.Font = new Font("Sitka Banner", 10.499999F, FontStyle.Bold, GraphicsUnit.Point);
            pictureLabel.Location = new Point(98, 174);
            pictureLabel.Margin = new Padding(4, 0, 4, 0);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new Size(220, 30);
            pictureLabel.TabIndex = 3;
            pictureLabel.Text = "Up Load What You Like:";
            // 
            // memberId
            // 
            memberId.AutoSize = true;
            memberId.BackColor = Color.Transparent;
            memberId.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            memberId.Location = new Point(557, 168);
            memberId.Margin = new Padding(4, 0, 4, 0);
            memberId.Name = "memberId";
            memberId.Size = new Size(129, 33);
            memberId.TabIndex = 4;
            memberId.Text = "memberId";
            // 
            // memberAddress
            // 
            memberAddress.AutoSize = true;
            memberAddress.BackColor = Color.Transparent;
            memberAddress.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            memberAddress.Location = new Point(557, 544);
            memberAddress.Margin = new Padding(4, 0, 4, 0);
            memberAddress.Name = "memberAddress";
            memberAddress.Size = new Size(195, 33);
            memberAddress.TabIndex = 5;
            memberAddress.Text = "memberAddress";
            // 
            // memberpasswd
            // 
            memberpasswd.AutoSize = true;
            memberpasswd.BackColor = Color.Transparent;
            memberpasswd.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            memberpasswd.Location = new Point(557, 414);
            memberpasswd.Margin = new Padding(4, 0, 4, 0);
            memberpasswd.Name = "memberpasswd";
            memberpasswd.Size = new Size(182, 33);
            memberpasswd.TabIndex = 6;
            memberpasswd.Text = "memberpasswd";
            // 
            // memberName
            // 
            memberName.AutoSize = true;
            memberName.BackColor = Color.Transparent;
            memberName.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            memberName.Location = new Point(557, 229);
            memberName.Margin = new Padding(4, 0, 4, 0);
            memberName.Name = "memberName";
            memberName.Size = new Size(164, 33);
            memberName.TabIndex = 7;
            memberName.Text = "memberName";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.BackColor = Color.Transparent;
            phone.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phone.Location = new Point(557, 353);
            phone.Margin = new Padding(4, 0, 4, 0);
            phone.Name = "phone";
            phone.Size = new Size(81, 33);
            phone.TabIndex = 8;
            phone.Text = "phone";
            // 
            // role
            // 
            role.AutoSize = true;
            role.BackColor = Color.Transparent;
            role.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            role.Location = new Point(557, 290);
            role.Margin = new Padding(4, 0, 4, 0);
            role.Name = "role";
            role.Size = new Size(59, 33);
            role.TabIndex = 9;
            role.Text = "role";
            // 
            // birthDate
            // 
            birthDate.AutoSize = true;
            birthDate.BackColor = Color.Transparent;
            birthDate.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            birthDate.Location = new Point(557, 478);
            birthDate.Margin = new Padding(4, 0, 4, 0);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(123, 33);
            birthDate.TabIndex = 10;
            birthDate.Text = "birthDate";
            // 
            // AboutLabel
            // 
            AboutLabel.AutoSize = true;
            AboutLabel.BackColor = Color.Transparent;
            AboutLabel.Font = new Font("Footlight MT Light", 30F, FontStyle.Bold, GraphicsUnit.Point);
            AboutLabel.ForeColor = Color.Black;
            AboutLabel.Location = new Point(193, 63);
            AboutLabel.Margin = new Padding(4, 0, 4, 0);
            AboutLabel.Name = "AboutLabel";
            AboutLabel.Size = new Size(431, 63);
            AboutLabel.TabIndex = 11;
            AboutLabel.Text = "My Information";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = Color.Transparent;
            idLabel.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            idLabel.ForeColor = Color.Black;
            idLabel.Location = new Point(393, 172);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(56, 29);
            idLabel.TabIndex = 12;
            idLabel.Text = "ID:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.Black;
            passwordLabel.Location = new Point(393, 414);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(147, 29);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Password:";
            // 
            // phonrLabel
            // 
            phonrLabel.AutoSize = true;
            phonrLabel.BackColor = Color.Transparent;
            phonrLabel.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phonrLabel.ForeColor = Color.Black;
            phonrLabel.Location = new Point(393, 354);
            phonrLabel.Name = "phonrLabel";
            phonrLabel.Size = new Size(103, 29);
            phonrLabel.TabIndex = 14;
            phonrLabel.Text = "Phone:";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.BackColor = Color.Transparent;
            roleLabel.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            roleLabel.ForeColor = Color.Black;
            roleLabel.Location = new Point(393, 292);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(81, 29);
            roleLabel.TabIndex = 15;
            roleLabel.Text = "Role:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.Black;
            nameLabel.Location = new Point(393, 229);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(98, 29);
            nameLabel.TabIndex = 16;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = Color.Transparent;
            addressLabel.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addressLabel.ForeColor = Color.Black;
            addressLabel.Location = new Point(393, 548);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(128, 29);
            addressLabel.TabIndex = 17;
            addressLabel.Text = "Address:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.BackColor = Color.Transparent;
            birthdayLabel.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            birthdayLabel.ForeColor = Color.Black;
            birthdayLabel.Location = new Point(393, 480);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(132, 29);
            birthdayLabel.TabIndex = 18;
            birthdayLabel.Text = "Birthday:";
            // 
            // AboutMeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1042, 625);
            Controls.Add(birthdayLabel);
            Controls.Add(addressLabel);
            Controls.Add(nameLabel);
            Controls.Add(roleLabel);
            Controls.Add(phonrLabel);
            Controls.Add(passwordLabel);
            Controls.Add(idLabel);
            Controls.Add(AboutLabel);
            Controls.Add(birthDate);
            Controls.Add(role);
            Controls.Add(phone);
            Controls.Add(memberName);
            Controls.Add(memberpasswd);
            Controls.Add(memberAddress);
            Controls.Add(memberId);
            Controls.Add(pictureLabel);
            Controls.Add(uploadPictureButton);
            Controls.Add(pictureBox);
            Font = new Font("Sitka Banner", 10.499999F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AboutMeForm";
            Text = "AboutMeForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private OpenFileDialog openFileDialog;
        private Button uploadPictureButton;
        private Label pictureLabel;
        private Label memberId;
        private Label memberAddress;
        private Label memberpasswd;
        private Label memberName;
        private Label phone;
        private Label role;
        private Label birthDate;
        private Label AboutLabel;
        private Label idLabel;
        private Label passwordLabel;
        private Label phonrLabel;
        private Label roleLabel;
        private Label nameLabel;
        private Label addressLabel;
        private Label birthdayLabel;
    }
}