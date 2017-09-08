namespace DP.EX01
{
    public partial class KnowYourFriendsGameUserControl
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
            this.labelLastAnswer = new System.Windows.Forms.Label();
            this.labelGameLevel = new System.Windows.Forms.Label();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.labelClue = new System.Windows.Forms.Label();
            this.buttonClue = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxNameInGame = new System.Windows.Forms.TextBox();
            this.labelEnterName = new System.Windows.Forms.Label();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLastAnswer
            // 
            this.labelLastAnswer.AutoSize = true;
            this.labelLastAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLastAnswer.Location = new System.Drawing.Point(33, 278);
            this.labelLastAnswer.Name = "labelLastAnswer";
            this.labelLastAnswer.Size = new System.Drawing.Size(0, 16);
            this.labelLastAnswer.TabIndex = 23;
            // 
            // labelGameLevel
            // 
            this.labelGameLevel.AutoSize = true;
            this.labelGameLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGameLevel.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelGameLevel.Location = new System.Drawing.Point(22, 54);
            this.labelGameLevel.Name = "labelGameLevel";
            this.labelGameLevel.Size = new System.Drawing.Size(50, 20);
            this.labelGameLevel.TabIndex = 22;
            this.labelGameLevel.Text = "Level:";
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(24, 513);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGame.TabIndex = 21;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonSkip
            // 
            this.buttonSkip.Location = new System.Drawing.Point(612, 91);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(90, 32);
            this.buttonSkip.TabIndex = 20;
            this.buttonSkip.Text = "I Don\'t Know";
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // labelClue
            // 
            this.labelClue.AutoSize = true;
            this.labelClue.Location = new System.Drawing.Point(346, 155);
            this.labelClue.Name = "labelClue";
            this.labelClue.Size = new System.Drawing.Size(30, 13);
            this.labelClue.TabIndex = 19;
            this.labelClue.Text = "clue:";
            // 
            // buttonClue
            // 
            this.buttonClue.Location = new System.Drawing.Point(225, 150);
            this.buttonClue.Name = "buttonClue";
            this.buttonClue.Size = new System.Drawing.Size(115, 23);
            this.buttonClue.TabIndex = 18;
            this.buttonClue.Text = "I want a clue";
            this.buttonClue.UseVisualStyleBackColor = true;
            this.buttonClue.Click += new System.EventHandler(this.buttonClue_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelScore.Location = new System.Drawing.Point(32, 303);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(55, 20);
            this.labelScore.TabIndex = 17;
            this.labelScore.Text = "Score:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(450, 91);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 32);
            this.buttonSubmit.TabIndex = 16;
            this.buttonSubmit.Text = "submit name";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxNameInGame
            // 
            this.textBoxNameInGame.Location = new System.Drawing.Point(225, 94);
            this.textBoxNameInGame.Name = "textBoxNameInGame";
            this.textBoxNameInGame.Size = new System.Drawing.Size(219, 20);
            this.textBoxNameInGame.TabIndex = 15;
            // 
            // labelEnterName
            // 
            this.labelEnterName.AutoSize = true;
            this.labelEnterName.Location = new System.Drawing.Point(222, 77);
            this.labelEnterName.Name = "labelEnterName";
            this.labelEnterName.Size = new System.Drawing.Size(65, 13);
            this.labelEnterName.TabIndex = 14;
            this.labelEnterName.Text = "The name is";
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelInstructions.Location = new System.Drawing.Point(20, 23);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(761, 24);
            this.labelInstructions.TabIndex = 13;
            this.labelInstructions.Text = "The game will show 10 of your friends profile picture and you\'ll have to guess hi" +
    "s full name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 187);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // KnowYourFriendsGameUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelLastAnswer);
            this.Controls.Add(this.labelGameLevel);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.labelClue);
            this.Controls.Add(this.buttonClue);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxNameInGame);
            this.Controls.Add(this.labelEnterName);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KnowYourFriendsGameUserControl";
            this.Size = new System.Drawing.Size(799, 577);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLastAnswer;
        private System.Windows.Forms.Label labelGameLevel;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.Label labelClue;
        private System.Windows.Forms.Button buttonClue;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxNameInGame;
        private System.Windows.Forms.Label labelEnterName;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
