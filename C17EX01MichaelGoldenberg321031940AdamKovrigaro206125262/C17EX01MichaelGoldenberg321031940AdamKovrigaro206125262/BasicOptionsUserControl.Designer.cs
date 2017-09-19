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
            this.components = new System.ComponentModel.Container();
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
            this.pictureBoxAlbums = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelTotLikes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLikesInAlbum = new System.Windows.Forms.Label();
            this.labelCreationAlbum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxMostLikedPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFriend)).BeginInit();
            this.panelSelectedFriend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLikedPhoto)).BeginInit();
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
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
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
            this.richTextBoxSelectedEvent.Size = new System.Drawing.Size(409, 116);
            this.richTextBoxSelectedEvent.TabIndex = 36;
            this.richTextBoxSelectedEvent.Text = string.Empty;
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
            this.richTextBoxSelectedEventDescription.Size = new System.Drawing.Size(403, 72);
            this.richTextBoxSelectedEventDescription.TabIndex = 39;
            this.richTextBoxSelectedEventDescription.Text = string.Empty;
            this.richTextBoxSelectedEventDescription.Leave += new System.EventHandler(this.richTextBoxSelectedEventDescription_Leave);
            // 
            // pictureBoxAlbums
            // 
            this.pictureBoxAlbums.Location = new System.Drawing.Point(806, 405);
            this.pictureBoxAlbums.Name = "pictureBoxAlbums";
            this.pictureBoxAlbums.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxAlbums.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbums.TabIndex = 40;
            this.pictureBoxAlbums.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelTotLikes
            // 
            this.labelTotLikes.AutoSize = true;
            this.labelTotLikes.Location = new System.Drawing.Point(806, 468);
            this.labelTotLikes.Name = "labelTotLikes";
            this.labelTotLikes.Size = new System.Drawing.Size(79, 13);
            this.labelTotLikes.TabIndex = 43;
            this.labelTotLikes.Text = "Likes In Album:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(806, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Creation Date:";
            // 
            // labelLikesInAlbum
            // 
            this.labelLikesInAlbum.AutoSize = true;
            this.labelLikesInAlbum.Location = new System.Drawing.Point(892, 468);
            this.labelLikesInAlbum.Name = "labelLikesInAlbum";
            this.labelLikesInAlbum.Size = new System.Drawing.Size(0, 13);
            this.labelLikesInAlbum.TabIndex = 45;
            // 
            // labelCreationAlbum
            // 
            this.labelCreationAlbum.AutoSize = true;
            this.labelCreationAlbum.Location = new System.Drawing.Point(892, 496);
            this.labelCreationAlbum.Name = "labelCreationAlbum";
            this.labelCreationAlbum.Size = new System.Drawing.Size(0, 13);
            this.labelCreationAlbum.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(809, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "most liked photo:";
            // 
            // pictureBoxMostLikedPhoto
            // 
            this.pictureBoxMostLikedPhoto.Location = new System.Drawing.Point(809, 530);
            this.pictureBoxMostLikedPhoto.Name = "pictureBoxMostLikedPhoto";
            this.pictureBoxMostLikedPhoto.Size = new System.Drawing.Size(61, 37);
            this.pictureBoxMostLikedPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostLikedPhoto.TabIndex = 48;
            this.pictureBoxMostLikedPhoto.TabStop = false;
            // 
            // BasicOptionsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxMostLikedPhoto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCreationAlbum);
            this.Controls.Add(this.labelLikesInAlbum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTotLikes);
            this.Controls.Add(this.pictureBoxAlbums);
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
            this.Size = new System.Drawing.Size(956, 602);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFriend)).EndInit();
            this.panelSelectedFriend.ResumeLayout(false);
            this.panelSelectedFriend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLikedPhoto)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxAlbums;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLikesInAlbum;
        private System.Windows.Forms.Label labelCreationAlbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxMostLikedPhoto;
        private System.Windows.Forms.Label labelTotLikes;
    }
}
