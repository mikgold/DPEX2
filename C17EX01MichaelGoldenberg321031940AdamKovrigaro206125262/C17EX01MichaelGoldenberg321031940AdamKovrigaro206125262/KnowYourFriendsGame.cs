using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace DP.EX01
{
    public class KnowYourFriendsGame
    {
        private const int k_maxScore = 10;
        private const int k_halfScore = 5;

        private int m_nLevel;
        private int m_score;
        private bool m_usedClue;
        private int m_nCorrectAnswers;
        private int m_nUsedClues;
        private string m_lastAnswerDesc;
        private IEnumerable<User> m_freindsList;
        private User m_currentFriend;
        private int m_secondsPerLevel = 20;
        private int m_friendsCount = 10;

        public User CurrentFriend
        {
            get { return m_currentFriend; }
        }

        public int Level
        {
            get { return m_nLevel; }
        }

        public int SecondsPerLevel
        {
            get { return m_secondsPerLevel; }
        }

        public int FriendsCount
        {
            get { return m_friendsCount; }
        }

        /// <summary>
        /// Start a new game
        /// </summary>
        /// <returns>whether  the game was started succesfully</returns>
        public bool StartNewGame()
        {
            this.m_nLevel = 1;            
            this.m_score = 0;
            this.m_nUsedClues = 0;
            this.m_nCorrectAnswers = 0;
            this.m_usedClue = false;
            m_freindsList = FacebookUtilities.GetTenRandomFriends();

            if (m_freindsList != null)
            {
                m_currentFriend = this.m_freindsList.ElementAt(0);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Get the next frien
        /// </summary>
        /// <returns>whether we have more rounds to play</returns>
        public bool NextRound()
        {
            if (this.m_nLevel == m_friendsCount)
            {
                return false;
            }

            this.m_nUsedClues += this.m_usedClue ? 1 : 0;
            this.m_nLevel++;
            this.m_usedClue = false;
            m_lastAnswerDesc = string.Format("Last friend was {0}", m_currentFriend.Name);
            m_currentFriend = this.m_freindsList.ElementAt(this.m_nLevel - 1);

            return true;
        }

        public bool CheckAnswer(string i_strName)
        {
            bool isCorrectAnswer = m_currentFriend.Name.ToLower() == i_strName.ToLower();
            if (isCorrectAnswer)
            {
                this.m_nCorrectAnswers++;
                this.m_score += m_usedClue ? k_halfScore : k_maxScore;                
            }

            return isCorrectAnswer;
        }

        public string GetLastAnswerDescription()
        {
            return m_lastAnswerDesc;
        }

        public string GetAClue()
        {
            string strClue;
            int randomNumber = new Random().Next(1, 3);
            if (this.m_usedClue)
            {
                strClue = "Sorry you've already used your clue";
            }
            else if (randomNumber == 1)
            {
                strClue = "First name is: " + m_currentFriend.FirstName;
            }
            else
            {
                strClue = "Last name is: " + m_currentFriend.LastName;
            }

            this.m_usedClue = true;
            return strClue;
        }

        public string GetScoreText()
        {
            return string.Format(
@"Correct answers {0}/{1}
Used {2} clues
Total score is: {3}/{4}",
            this.m_nCorrectAnswers,
            this.m_nLevel - 1, 
            this.m_nUsedClues, 
            this.m_score, 
            (this.m_nLevel - 1) * k_maxScore);
        }       
    }
}