using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP.EX01
{
    public partial class KnowYourFriendsGameUserControl : UserControl
    {
        private KnowYourFriendsGame friendsGame;

        public KnowYourFriendsGameUserControl()
        {
            InitializeComponent();
            friendsGame = new KnowYourFriendsGame();
        }

        public void StartGame()
        {
            newGame();
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            nextFriend();
            labelLastAnswer.ForeColor = Color.Red;
            labelLastAnswer.Text = "Incorrect!! " + friendsGame.GetLastAnswerDescription();
        }

        private void nextFriend()
        {
            if (!friendsGame.NextRound())
            {
                labelGameLevel.Text = "Game over";
                MessageBox.Show("The game is over press the new game button");
            }
            else
            {
                fetchCurrentFriendInGame();
            }
        }

        private void fetchCurrentFriendInGame()
        {
            pictureBox1.LoadAsync(friendsGame.CurrentFriend.PictureLargeURL);
            labelClue.Text = "You Have one clue";
            textBoxNameInGame.Text = string.Empty;
            labelScore.Text = friendsGame.GetScoreText();
            labelGameLevel.Text = "Level: " + friendsGame.Level;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            bool isCorrcet = friendsGame.CheckAnswer(textBoxNameInGame.Text);
            labelLastAnswer.Text = friendsGame.GetLastAnswerDescription();
            nextFriend();

            if (isCorrcet)
            {
                labelLastAnswer.ForeColor = Color.Green;
                labelLastAnswer.Text = "Last answer was correct!! " + friendsGame.GetLastAnswerDescription();
            }
            else
            {
                labelLastAnswer.ForeColor = Color.Red;
                labelLastAnswer.Text = "Last answer was  incorrect!! " + friendsGame.GetLastAnswerDescription();
            }
        }

        private void buttonClue_Click(object sender, EventArgs e)
        {
            labelClue.Text = friendsGame.GetAClue();
        }

        private void newGame()
        {
            labelLastAnswer.Text = string.Empty;
                        
            if (!friendsGame.StartNewGame())
            {
                this.Enabled = false;
                MessageBox.Show("We don't have enough friends to play please login to secondary app");
            }
            else
            {
                fetchCurrentFriendInGame();
            }            
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            try
            {
                newGame();
            }
            catch
            {
                MessageBox.Show("Something went wrong try again later");
            }
            
        }
    }
}
