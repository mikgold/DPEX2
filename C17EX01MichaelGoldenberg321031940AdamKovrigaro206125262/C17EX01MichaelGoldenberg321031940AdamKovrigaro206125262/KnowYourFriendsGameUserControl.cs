using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DP.EX01
{
    public partial class KnowYourFriendsGameUserControl : UserControl
    {
        private KnowYourFriendsGame friendsGame;

        public KnowYourFriendsGameUserControl()
        {
            InitializeComponent();            
            friendsGame = new KnowYourFriendsGame();
            labelSeconds.Text = friendsGame.SecondsPerLevel + " sec";
        }

        public void StartGame()
        {
            new Thread(newGame).Start();
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            nextFriend();
            incorrectAnswer();
        }

        private void incorrectAnswer()
        {
            labelLastAnswer.ForeColor = Color.Red;
            labelLastAnswer.Text = "Incorrect!! " + friendsGame.GetLastAnswerDescription();
        }

        private void nextFriend()
        {
            if (!friendsGame.NextRound())
            {
                labelGameLevel.Text = "Game over";
                MessageBox.Show("The game is over press the new game button");
                timerLevel.Stop();
            }
            else
            {                
                fetchCurrentFriendInGame();
            }
        }

        private void fetchCurrentFriendInGame()
        {
            pictureBox1.LoadAsync(friendsGame.CurrentFriend.PictureLargeURL);
            labelClue.Invoke(new Action(() => labelClue.Text = "You Have one clue"));
            textBoxNameInGame.Invoke(new Action(() => textBoxNameInGame.Text = string.Empty));
            labelScore.Invoke(new Action(() => labelScore.Text = friendsGame.GetScoreText()));
            labelGameLevel.Invoke(new Action(() => labelGameLevel.Text = "Level: " + friendsGame.Level));
            labelSeconds.Invoke(new Action(() => labelSeconds.Text = friendsGame.SecondsPerLevel + " sec"));
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
                incorrectAnswer();
            }
        }

        private void buttonClue_Click(object sender, EventArgs e)
        {
            labelClue.Text = friendsGame.GetAClue();
        }

        private void newGame()
        {
            labelLastAnswer.Invoke(new Action(() => labelLastAnswer.Text = string.Empty));
                        
            if (!friendsGame.StartNewGame())
            {
                this.Invoke(new Action(() => this.Enabled = false));
                MessageBox.Show("We don't have enough friends to play please login to secondary app");
            }
            else
            {
                fetchCurrentFriendInGame();
                labelLastAnswer.Invoke(new Action(() => timerLevel.Start()));
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

        private void timerLevel_Tick(object sender, EventArgs e)
        {
            char[] txt = { ' ', 's' };
            int seconds = int.Parse(labelSeconds.Text.Split(txt)[0]);
            if (seconds > 0)
            {
                labelSeconds.Text = --seconds + " sec";
            }
            else
            {
                nextFriend();
                incorrectAnswer();
            }
        }

    }
}
