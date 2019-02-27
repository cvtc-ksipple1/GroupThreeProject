namespace GUI_Example
{
    partial class GUI_Example
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Example));
            this.Name = new System.Windows.Forms.Label();
            this.ContactInfo = new System.Windows.Forms.Label();
            this.ProfilePic = new System.Windows.Forms.PictureBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.dobInfo = new System.Windows.Forms.Label();
            this.phoneNum = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.checkedInValue = new System.Windows.Forms.CheckBox();
            this.checkInLabel = new System.Windows.Forms.Label();
            this.daysInLast30Label = new System.Windows.Forms.Label();
            this.daysInLast30Total = new System.Windows.Forms.Label();
            this.historyLabel = new System.Windows.Forms.Label();
            this.daysStayedTotal = new System.Windows.Forms.Label();
            this.daysStayedTotalLabel = new System.Windows.Forms.Label();
            this.strikesTotal = new System.Windows.Forms.Label();
            this.strikesLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.socialNum = new System.Windows.Forms.Label();
            this.socialLabel = new System.Windows.Forms.Label();
            this.notesTextbox = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.magnifyLogo = new System.Windows.Forms.PictureBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magnifyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.Name.Location = new System.Drawing.Point(158, 33);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(159, 29);
            this.Name.TabIndex = 0;
            this.Name.Text = "John A. Smith";
            this.Name.Click += new System.EventHandler(this.Name_Click);
            // 
            // ContactInfo
            // 
            this.ContactInfo.AutoSize = true;
            this.ContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.ContactInfo.Location = new System.Drawing.Point(12, 119);
            this.ContactInfo.Name = "ContactInfo";
            this.ContactInfo.Size = new System.Drawing.Size(225, 29);
            this.ContactInfo.TabIndex = 1;
            this.ContactInfo.Text = "Contact Information:";
            // 
            // ProfilePic
            // 
            this.ProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePic.Image")));
            this.ProfilePic.Location = new System.Drawing.Point(35, 33);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(103, 83);
            this.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePic.TabIndex = 2;
            this.ProfilePic.TabStop = false;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.dobLabel.Location = new System.Drawing.Point(12, 161);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(119, 22);
            this.dobLabel.TabIndex = 4;
            this.dobLabel.Text = "Date Of Birth:";
            // 
            // dobInfo
            // 
            this.dobInfo.AutoSize = true;
            this.dobInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.dobInfo.Location = new System.Drawing.Point(159, 161);
            this.dobInfo.Name = "dobInfo";
            this.dobInfo.Size = new System.Drawing.Size(100, 22);
            this.dobInfo.TabIndex = 5;
            this.dobInfo.Text = "01/08/1993";
            // 
            // phoneNum
            // 
            this.phoneNum.AutoSize = true;
            this.phoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.phoneNum.Location = new System.Drawing.Point(159, 192);
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Size = new System.Drawing.Size(122, 22);
            this.phoneNum.TabIndex = 7;
            this.phoneNum.Text = "715-999-8888";
            this.phoneNum.Click += new System.EventHandler(this.label3_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.phoneLabel.Location = new System.Drawing.Point(12, 192);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(135, 22);
            this.phoneLabel.TabIndex = 6;
            this.phoneLabel.Text = "Phone Number:";
            // 
            // checkedInValue
            // 
            this.checkedInValue.AutoSize = true;
            this.checkedInValue.Checked = true;
            this.checkedInValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkedInValue.Location = new System.Drawing.Point(780, 201);
            this.checkedInValue.Name = "checkedInValue";
            this.checkedInValue.Size = new System.Drawing.Size(15, 14);
            this.checkedInValue.TabIndex = 10;
            this.checkedInValue.UseVisualStyleBackColor = true;
            // 
            // checkInLabel
            // 
            this.checkInLabel.AutoSize = true;
            this.checkInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkInLabel.Location = new System.Drawing.Point(664, 196);
            this.checkInLabel.Name = "checkInLabel";
            this.checkInLabel.Size = new System.Drawing.Size(101, 20);
            this.checkInLabel.TabIndex = 12;
            this.checkInLabel.Text = "Checked In?";
            // 
            // daysInLast30Label
            // 
            this.daysInLast30Label.AutoSize = true;
            this.daysInLast30Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.daysInLast30Label.Location = new System.Drawing.Point(592, 132);
            this.daysInLast30Label.Name = "daysInLast30Label";
            this.daysInLast30Label.Size = new System.Drawing.Size(221, 20);
            this.daysInLast30Label.TabIndex = 11;
            this.daysInLast30Label.Text = "Days Stayed In The Last 30:";
            // 
            // daysInLast30Total
            // 
            this.daysInLast30Total.AutoSize = true;
            this.daysInLast30Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.daysInLast30Total.Location = new System.Drawing.Point(819, 132);
            this.daysInLast30Total.Name = "daysInLast30Total";
            this.daysInLast30Total.Size = new System.Drawing.Size(27, 20);
            this.daysInLast30Total.TabIndex = 13;
            this.daysInLast30Total.Text = "20";
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.historyLabel.Location = new System.Drawing.Point(591, 86);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(93, 29);
            this.historyLabel.TabIndex = 14;
            this.historyLabel.Text = "History:";
            // 
            // daysStayedTotal
            // 
            this.daysStayedTotal.AutoSize = true;
            this.daysStayedTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.daysStayedTotal.Location = new System.Drawing.Point(819, 152);
            this.daysStayedTotal.Name = "daysStayedTotal";
            this.daysStayedTotal.Size = new System.Drawing.Size(27, 20);
            this.daysStayedTotal.TabIndex = 16;
            this.daysStayedTotal.Text = "20";
            // 
            // daysStayedTotalLabel
            // 
            this.daysStayedTotalLabel.AutoSize = true;
            this.daysStayedTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.daysStayedTotalLabel.Location = new System.Drawing.Point(592, 152);
            this.daysStayedTotalLabel.Name = "daysStayedTotalLabel";
            this.daysStayedTotalLabel.Size = new System.Drawing.Size(151, 20);
            this.daysStayedTotalLabel.TabIndex = 15;
            this.daysStayedTotalLabel.Text = "Days Stayed Total:";
            this.daysStayedTotalLabel.Click += new System.EventHandler(this.label12_Click);
            // 
            // strikesTotal
            // 
            this.strikesTotal.AutoSize = true;
            this.strikesTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.strikesTotal.Location = new System.Drawing.Point(456, 194);
            this.strikesTotal.Name = "strikesTotal";
            this.strikesTotal.Size = new System.Drawing.Size(18, 20);
            this.strikesTotal.TabIndex = 18;
            this.strikesTotal.Text = "2";
            // 
            // strikesLabel
            // 
            this.strikesLabel.AutoSize = true;
            this.strikesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.strikesLabel.Location = new System.Drawing.Point(384, 194);
            this.strikesLabel.Name = "strikesLabel";
            this.strikesLabel.Size = new System.Drawing.Size(66, 20);
            this.strikesLabel.TabIndex = 17;
            this.strikesLabel.Text = "Strikes:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.genderLabel.Location = new System.Drawing.Point(337, 40);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(69, 20);
            this.genderLabel.TabIndex = 19;
            this.genderLabel.Text = "Gender:";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbGender.Location = new System.Drawing.Point(412, 42);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 21);
            this.cbGender.TabIndex = 21;
            // 
            // socialNum
            // 
            this.socialNum.AutoSize = true;
            this.socialNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.socialNum.Location = new System.Drawing.Point(241, 71);
            this.socialNum.Name = "socialNum";
            this.socialNum.Size = new System.Drawing.Size(134, 25);
            this.socialNum.TabIndex = 23;
            this.socialNum.Text = "###-##-1111";
            // 
            // socialLabel
            // 
            this.socialLabel.AutoSize = true;
            this.socialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.socialLabel.Location = new System.Drawing.Point(158, 71);
            this.socialLabel.Name = "socialLabel";
            this.socialLabel.Size = new System.Drawing.Size(77, 25);
            this.socialLabel.TabIndex = 22;
            this.socialLabel.Text = "Social:";
            // 
            // notesTextbox
            // 
            this.notesTextbox.Location = new System.Drawing.Point(17, 311);
            this.notesTextbox.Name = "notesTextbox";
            this.notesTextbox.Size = new System.Drawing.Size(837, 20);
            this.notesTextbox.TabIndex = 24;
            this.notesTextbox.Text = "Guest ";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.notesLabel.Location = new System.Drawing.Point(12, 283);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(74, 25);
            this.notesLabel.TabIndex = 25;
            this.notesLabel.Text = "Notes:";
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(734, 12);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(100, 20);
            this.searchTextbox.TabIndex = 28;
            // 
            // magnifyLogo
            // 
            this.magnifyLogo.Image = ((System.Drawing.Image)(resources.GetObject("magnifyLogo.Image")));
            this.magnifyLogo.Location = new System.Drawing.Point(659, 9);
            this.magnifyLogo.Name = "magnifyLogo";
            this.magnifyLogo.Size = new System.Drawing.Size(19, 20);
            this.magnifyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.magnifyLogo.TabIndex = 29;
            this.magnifyLogo.TabStop = false;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(684, 13);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(44, 13);
            this.searchLabel.TabIndex = 30;
            this.searchLabel.Text = "Search:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(759, 37);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 31;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GUI_Example
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(874, 396);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.magnifyLogo);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.notesTextbox);
            this.Controls.Add(this.socialNum);
            this.Controls.Add(this.socialLabel);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.strikesTotal);
            this.Controls.Add(this.strikesLabel);
            this.Controls.Add(this.daysStayedTotal);
            this.Controls.Add(this.daysStayedTotalLabel);
            this.Controls.Add(this.historyLabel);
            this.Controls.Add(this.daysInLast30Total);
            this.Controls.Add(this.checkInLabel);
            this.Controls.Add(this.daysInLast30Label);
            this.Controls.Add(this.checkedInValue);
            this.Controls.Add(this.phoneNum);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.dobInfo);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.ProfilePic);
            this.Controls.Add(this.ContactInfo);
            this.Controls.Add(this.Name);
            this.Name = "GUI_Example";
            this.Text = "Profile:";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magnifyLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label ContactInfo;
        private System.Windows.Forms.PictureBox ProfilePic;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label dobInfo;
        private System.Windows.Forms.Label phoneNum;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.CheckBox checkedInValue;
        private System.Windows.Forms.Label checkInLabel;
        private System.Windows.Forms.Label daysInLast30Label;
        private System.Windows.Forms.Label daysInLast30Total;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.Label daysStayedTotal;
        private System.Windows.Forms.Label daysStayedTotalLabel;
        private System.Windows.Forms.Label strikesTotal;
        private System.Windows.Forms.Label strikesLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label socialNum;
        private System.Windows.Forms.Label socialLabel;
        private System.Windows.Forms.TextBox notesTextbox;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.PictureBox magnifyLogo;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button searchButton;
    }
}