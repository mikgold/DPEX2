namespace DP.EX01
{
    public partial class LikedYourPostTheMost
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
            this.listBoxMostLikesFriends = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxMostLikesFriends
            // 
            this.listBoxMostLikesFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxMostLikesFriends.FormattingEnabled = true;
            this.listBoxMostLikesFriends.ItemHeight = 18;
            this.listBoxMostLikesFriends.Location = new System.Drawing.Point(0, 3);
            this.listBoxMostLikesFriends.Name = "listBoxMostLikesFriends";
            this.listBoxMostLikesFriends.Size = new System.Drawing.Size(416, 400);
            this.listBoxMostLikesFriends.TabIndex = 1;
            // 
            // LikedYourPostTheMost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxMostLikesFriends);
            this.Name = "LikedYourPostTheMost";
            this.Size = new System.Drawing.Size(599, 505);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMostLikesFriends;
    }
}
