namespace DP.EX01
{
    public partial class BasicOptionsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSelectFriend = new System.Windows.Forms.Label();
            this.pictureBoxSelectedFriend = new System.Windows.Forms.PictureBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.buttonShowEvents = new System.Windows.Forms.Button();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.buttonShowPosts = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.buttonShowFreinds = new System.Windows.Forms.Button();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.labelPost = new System.Windows.Forms.Label();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonCheckIns = new System.Windows.Forms.Button();
            this.listBoxCheckIns = new System.Windows.Forms.ListBox();
            this.panelSelectedFriend = new System.Windows.Forms.Panel();
            this.textBoxSelectedFriendBio = new System.Windows.Forms.TextBox();
            this.labelSelectedFriendDescription = new System.Windows.Forms.Label();
            this.textBoxSelectedFriendName = new System.Windows.Forms.TextBox();
            this.labelSelectedFriendName = new System.Windows.Forms.Label();
            this.labelSelectedEventInfo = new System.Windows.Forms.Label();
            this.richTextBoxSelectedEvent = new System.Windows.Forms.RichTextBox();
            this.labelSelectedEventDescription = new System.Windows.Forms.Label();
            this.richTextBoxSelectedEventDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFriend)).BeginInit();
            this.panelSelectedFriend.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSelectFriend
            // 
            this.labelSelectFriend.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.labelSelectFriend.AutoSize = true;
            this.labelSelectFriend.Location = new System.Drawing.Point(399, 350);
            this.labelSelectFriend.Name = "labelSelectFriend";
            this.labelSelectFriend.Size = new System.Drawing.Size(190, 13);
            this.labelSelectFriend.TabIndex = 33;
            this.labelSelectFriend.Text = "Select A friend to see his profile picture";
            // 
            // pictureBoxSelectedFriend
            // 
            this.pictureBoxSelectedFriend.Location = new System.Drawing.Point(9, 5);
            this.pictureBoxSelectedFriend.Name = "pictureBoxSelectedFriend";
            this.pictureBoxSelectedFriend.Size = new System.Drawing.Size(91, 64);
            this.pictureBoxSelectedFriend.TabIndex = 32;
            this.pictureBoxSelectedFriend.TabStop = false;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(264, 83);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(217, 251);
            this.listBoxEvents.TabIndex = 30;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // buttonShowEvents
            // 
            this.buttonShowEvents.Location = new System.Drawing.Point(308, 45);
            this.buttonShowEvents.Name = "buttonShowEvents";
            this.buttonShowEvents.Size = new System.Drawing.Size(103, 23);
            this.buttonShowEvents.TabIndex = 29;
            this.buttonShowEvents.Text = "Show My Events";
            this.buttonShowEvents.UseVisualStyleBackColor = true;
            this.buttonShowEvents.Click += new System.EventHandler(this.buttonShowEvents_Click);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(608, 394);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(179, 173);
            this.listBoxAlbums.TabIndex = 28;
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.Location = new System.Drawing.Point(608, 362);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Size = new System.Drawing.Size(134, 23);
            this.buttonAlbums.TabIndex = 27;
            this.buttonAlbums.Text = "Show my albums";
            this.buttonAlbums.UseVisualStyleBackColor = true;
            this.buttonAlbums.Click += new System.EventHandler(this.buttonAlbums_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(16, 83);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(213, 251);
            this.listBoxPosts.TabIndex = 26;
            // 
            // buttonShowPosts
            // 
            this.buttonShowPosts.Location = new System.Drawing.Point(16, 45);
            this.buttonShowPosts.Name = "buttonShowPosts";
            this.buttonShowPosts.Size = new System.Drawing.Size(105, 23);
            this.buttonShowPosts.TabIndex = 25;
            this.buttonShowPosts.Text = "Show my posts";
            this.buttonShowPosts.UseVisualStyleBackColor = true;
            this.buttonShowPosts.Click += new System.EventHandler(this.buttonShowPosts_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(212, 394);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(179, 173);
            this.listBoxFriends.Sorted = true;
            this.listBoxFriends.TabIndex = 24;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // buttonShowFreinds
            // 
            this.buttonShowFreinds.Location = new System.Drawing.Point(212, 362);
            this.buttonShowFreinds.Name = "buttonShowFreinds";
            this.buttonShowFreinds.Size = new System.Drawing.Size(133, 23);
            this.buttonShowFreinds.TabIndex = 23;
            this.buttonShowFreinds.Text = "Show Friends List";
            this.buttonShowFreinds.UseVisualStyleBackColor = true;
            this.buttonShowFreinds.Click += new System.EventHandler(this.buttonShowFreinds_Click);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Location = new System.Drawing.Point(712, 8);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(75, 23);
            this.buttonPostStatus.TabIndex = 22;
            this.buttonPostStatus.Text = "post";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(13, 13);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(123, 13);
            this.labelPost.TabIndex = 21;
            this.labelPost.Text = "Write Something to post:";
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(142, 10);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(553, 20);
            this.textBoxPost.TabIndex = 20;
            // 
            // buttonCheckIns
            // 
            this.buttonCheckIns.Location = new System.Drawing.Point(13, 362);
            this.buttonCheckIns.Name = "buttonCheckIns";
            this.buttonCheckIns.Size = new System.Drawing.Size(133, 23);
            this.buttonCheckIns.TabIndex = 19;
            this.buttonCheckIns.Text = "Show Chek Ins";
            this.buttonCheckIns.UseVisualStyleBackColor = true;
            this.buttonCheckIns.Click += new System.EventHandler(this.buttonCheckIns_Click);
            // 
            // listBoxCheckIns
            // 
            this.listBoxCheckIns.FormattingEnabled = true;
            this.listBoxCheckIns.Location = new System.Drawing.Point(12, 394);
            this.listBoxCheckIns.Name = "listBoxCheckIns";
            this.listBoxCheckIns.Size = new System.Drawing.Size(179, 173);
            this.listBoxCheckIns.TabIndex = 18;
            // 
            // panelSelectedFriend
            // 
            this.panelSelectedFriend.Controls.Add(this.textBoxSelectedFriendBio);
            this.panelSelectedFriend.Controls.Add(this.labelSelectedFriendDescription);
            this.panelSelectedFriend.Controls.Add(this.textBoxSelectedFriendName);
            this.panelSelectedFriend.Controls.Add(this.labelSelectedFriendName);
            this.panelSelectedFriend.Controls.Add(this.pictureBoxSelectedFriend);
            this.panelSelectedFriend.Location = new System.Drawing.Point(402, 364);
            this.panelSelectedFriend.Name = "panelSelectedFriend";
            this.panelSelectedFriend.Size = new System.Drawing.Size(200, 203);
            this.panelSelectedFriend.TabIndex = 34;
            // 
            // textBoxSelectedFriendBio
            // 
            this.textBoxSelectedFriendBio.Location = new System.Drawing.Point(9, 132);
            this.textBoxSelectedFriendBio.Name = "textBoxSelectedFriendBio";
            this.textBoxSelectedFriendBio.Size = new System.Drawing.Size(178, 20);
            this.textBoxSelectedFriendBio.TabIndex = 36;
            this.textBoxSelectedFriendBio.Leave += new System.EventHandler(this.textBoxSelectedFriendBio_Leave);
            // 
            // labelSelectedFriendDescription
            // 
            this.labelSelectedFriendDescription.AutoSize = true;
            this.labelSelectedFriendDescription.Location = new System.Drawing.Point(6, 104);
            this.labelSelectedFriendDescription.Name = "labelSelectedFriendDescription";
            this.labelSelectedFriendDescription.Size = new System.Drawing.Size(57, 13);
            this.labelSelectedFriendDescription.TabIndex = 35;
            this.labelSelectedFriendDescription.Text = "Biography:";
            // 
            // textBoxSelectedFriendName
            // 
            this.textBoxSelectedFriendName.Location = new System.Drawing.Point(50, 78);
            this.textBoxSelectedFriendName.Name = "textBoxSelectedFriendName";
            this.textBoxSelectedFriendName.Size = new System.Drawing.Size(137, 20);
            this.textBoxSelectedFriendName.TabIndex = 34;
            // 
            // labelSelectedFriendName
            // 
            this.labelSelectedFriendName.AutoSize = true;
            this.labelSelectedFriendName.Location = new System.Drawing.Point(6, 78);
            this.labelSelectedFriendName.Name = "labelSelectedFriendName";
            this.labelSelectedFriendName.Size = new System.Drawing.Size(38, 13);
            this.labelSelectedFriendName.TabIndex = 33;
            this.labelSelectedFriendName.Text = "Name:";
            // 
            // labelSelectedEventInfo
            // 
            this.labelSelectedEventInfo.AutoSize = true;
            this.labelSelectedEventInfo.Location = new System.Drawing.Point(515, 83);
            this.labelSelectedEventInfo.Name = "labelSelectedEventInfo";
            this.labelSelectedEventInfo.Size = new System.Drawing.Size(59, 13);
            this.labelSelectedEventInfo.TabIndex = 35;
            this.labelSelectedEventInfo.Text = "Event Info:";
            // 
            // richTextBoxSelectedEvent
            // 
            this.richTextBoxSelectedEvent.Location = new System.Drawing.Point(512, 103);
            this.richTextBoxSelectedEvent.Name = "richTextBoxSelectedEvent";
            this.richTextBoxSelectedEvent.Size = new System.Drawing.Size(245, 116);
            this.richTextBoxSelectedEvent.TabIndex = 36;
            this.richTextBoxSelectedEvent.Text = "";
            // 
            // labelSelectedEventDescription
            // 
            this.labelSelectedEventDescription.AutoSize = true;
            this.labelSelectedEventDescription.Location = new System.Drawing.Point(509, 241);
            this.labelSelectedEventDescription.Name = "labelSelectedEventDescription";
            this.labelSelectedEventDescription.Size = new System.Drawing.Size(63, 13);
            this.labelSelectedEventDescription.TabIndex = 37;
            this.labelSelectedEventDescription.Text = "Description:";
            // 
            // richTextBoxSelectedEventDescription
            // 
            this.richTextBoxSelectedEventDescription.Location = new System.Drawing.Point(518, 262);
            this.richTextBoxSelectedEventDescription.Name = "richTextBoxSelectedEventDescription";
            this.richTextBoxSelectedEventDescription.Size = new System.Drawing.Size(239, 72);
            this.richTextBoxSelectedEventDescription.TabIndex = 39;
            this.richTextBoxSelectedEventDescription.Text = "";
            this.richTextBoxSelectedEventDescription.Leave += new System.EventHandler(this.richTextBoxSelectedEventDescription_Leave);
            // 
            // BasicOptionsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBoxSelectedEventDescription);
            this.Controls.Add(this.labelSelectedEventDescription);
            this.Controls.Add(this.richTextBoxSelectedEvent);
            this.Controls.Add(this.labelSelectedEventInfo);
            this.Controls.Add(this.labelSelectFriend);
            this.Controls.Add(this.panelSelectedFriend);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.buttonShowEvents);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.buttonAlbums);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.buttonShowPosts);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.buttonShowFreinds);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.buttonCheckIns);
            this.Controls.Add(this.listBoxCheckIns);
            this.Name = "BasicOptionsUserControl";
            this.Size = new System.Drawing.Size(812, 602);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFriend)).EndInit();
            this.panelSelectedFriend.ResumeLayout(false);
            this.panelSelectedFriend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectFriend;
        private System.Windows.Forms.PictureBox pictureBoxSelectedFriend;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button buttonShowEvents;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button buttonShowPosts;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Button buttonShowFreinds;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Button buttonCheckIns;
        private System.Windows.Forms.ListBox listBoxCheckIns;
        private System.Windows.Forms.Panel panelSelectedFriend;
        private System.Windows.Forms.TextBox textBoxSelectedFriendBio;
        private System.Windows.Forms.Label labelSelectedFriendDescription;
        private System.Windows.Forms.TextBox textBoxSelectedFriendName;
        private System.Windows.Forms.Label labelSelectedFriendName;
        private System.Windows.Forms.Label labelSelectedEventInfo;
        private System.Windows.Forms.RichTextBox richTextBoxSelectedEvent;
        private System.Windows.Forms.Label labelSelectedEventDescription;
        private System.Windows.Forms.RichTextBox richTextBoxSelectedEventDescription;
    }
}
