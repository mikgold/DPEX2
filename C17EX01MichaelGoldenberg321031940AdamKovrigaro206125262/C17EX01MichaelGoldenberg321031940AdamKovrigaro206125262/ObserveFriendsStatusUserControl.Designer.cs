﻿namespace DP.EX01
{
    partial class ObserveFriendsStatusUserControl
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
            this.listBoxOrderMethod = new System.Windows.Forms.ListBox();
            this.labelFilterMethod = new System.Windows.Forms.Label();
            this.buttonAttach = new System.Windows.Forms.Button();
            this.buttonDetach = new System.Windows.Forms.Button();
            this.listBoxFriendsList = new System.Windows.Forms.ListBox();
            this.labelFriend = new System.Windows.Forms.Label();
            this.buttonFetchMethods = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxOrderMethod
            // 
            this.listBoxOrderMethod.FormattingEnabled = true;
            this.listBoxOrderMethod.Location = new System.Drawing.Point(26, 57);
            this.listBoxOrderMethod.Name = "listBoxOrderMethod";
            this.listBoxOrderMethod.Size = new System.Drawing.Size(120, 95);
            this.listBoxOrderMethod.TabIndex = 0;
            this.listBoxOrderMethod.SelectedIndexChanged += new System.EventHandler(this.listBoxOrderMethod_SelectedIndexChanged);
            // 
            // labelFilterMethod
            // 
            this.labelFilterMethod.AutoSize = true;
            this.labelFilterMethod.Location = new System.Drawing.Point(23, 27);
            this.labelFilterMethod.Name = "labelFilterMethod";
            this.labelFilterMethod.Size = new System.Drawing.Size(108, 13);
            this.labelFilterMethod.TabIndex = 1;
            this.labelFilterMethod.Text = "Choose order method";
            // 
            // buttonAttach
            // 
            this.buttonAttach.Location = new System.Drawing.Point(60, 256);
            this.buttonAttach.Name = "buttonAttach";
            this.buttonAttach.Size = new System.Drawing.Size(75, 23);
            this.buttonAttach.TabIndex = 6;
            this.buttonAttach.Text = "Attach";
            this.buttonAttach.UseVisualStyleBackColor = true;
            // 
            // buttonDetach
            // 
            this.buttonDetach.Location = new System.Drawing.Point(342, 256);
            this.buttonDetach.Name = "buttonDetach";
            this.buttonDetach.Size = new System.Drawing.Size(75, 23);
            this.buttonDetach.TabIndex = 7;
            this.buttonDetach.Text = "Detach";
            this.buttonDetach.UseVisualStyleBackColor = true;
            // 
            // listBoxFriendsList
            // 
            this.listBoxFriendsList.FormattingEnabled = true;
            this.listBoxFriendsList.Location = new System.Drawing.Point(232, 57);
            this.listBoxFriendsList.Name = "listBoxFriendsList";
            this.listBoxFriendsList.Size = new System.Drawing.Size(120, 186);
            this.listBoxFriendsList.TabIndex = 8;
            // 
            // labelFriend
            // 
            this.labelFriend.AutoSize = true;
            this.labelFriend.Location = new System.Drawing.Point(229, 27);
            this.labelFriend.Name = "labelFriend";
            this.labelFriend.Size = new System.Drawing.Size(75, 13);
            this.labelFriend.TabIndex = 9;
            this.labelFriend.Text = "Choose Friend";
            // 
            // buttonFetchMethods
            // 
            this.buttonFetchMethods.Location = new System.Drawing.Point(26, 158);
            this.buttonFetchMethods.Name = "buttonFetchMethods";
            this.buttonFetchMethods.Size = new System.Drawing.Size(109, 23);
            this.buttonFetchMethods.TabIndex = 10;
            this.buttonFetchMethods.Text = "Fetch methods";
            this.buttonFetchMethods.UseVisualStyleBackColor = true;
            this.buttonFetchMethods.Click += new System.EventHandler(this.buttonFetchMethods_Click);
            // 
            // ObserveFriendsStatusUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonFetchMethods);
            this.Controls.Add(this.labelFriend);
            this.Controls.Add(this.listBoxFriendsList);
            this.Controls.Add(this.buttonDetach);
            this.Controls.Add(this.buttonAttach);
            this.Controls.Add(this.labelFilterMethod);
            this.Controls.Add(this.listBoxOrderMethod);
            this.Name = "ObserveFriendsStatusUserControl";
            this.Size = new System.Drawing.Size(522, 378);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOrderMethod;
        private System.Windows.Forms.Label labelFilterMethod;
        private System.Windows.Forms.Button buttonAttach;
        private System.Windows.Forms.Button buttonDetach;
        private System.Windows.Forms.ListBox listBoxFriendsList;
        private System.Windows.Forms.Label labelFriend;
        private System.Windows.Forms.Button buttonFetchMethods;
    }
}
