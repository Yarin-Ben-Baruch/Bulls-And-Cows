using System.Drawing;
using System.Linq;

namespace Ex02
{
    public class GameManager
    {
        private readonly Computer r_Computer;
        private readonly CurrentGuess r_CurrentGuess;
        private eFeedback[] m_CurrentFeedback;
        private int m_CounterRows;
        private int m_NumberOfGames;

        public GameManager()
        {
            r_Computer = new Computer();
            r_CurrentGuess = new CurrentGuess();
            m_CounterRows = 0;
        }

        public int CounterRows
        {
            get
            {
                return m_CounterRows;
            }

            set
            {
                m_CounterRows = value;
            }
        }

        public void RunGame()
        {
            GameConfiguration gameConfiguration = new GameConfiguration();

            gameConfiguration.ShowDialog();

            if (gameConfiguration.CloseByStart)
            {
                m_NumberOfGames = gameConfiguration.NumberOfGames;

                GameBoard gameBoard = new GameBoard(m_NumberOfGames, this);

                gameBoard.ShowDialog();
            }
        }

        public bool AddColorToGuess(Color i_ColorToAdd, int i_IndexToAdd)
        {
            bool isColorWasAdd = false;

            if (r_CurrentGuess.IsValidColorGuess(i_IndexToAdd, i_ColorToAdd))
            {
                r_CurrentGuess.CurrentColorsGuess[i_IndexToAdd] = i_ColorToAdd;
                isColorWasAdd = true;
            }

            return isColorWasAdd;
        }

        public bool IsRowColored()
        {
            return r_CurrentGuess.IsRowColored();
        }

        public eFeedback[] GetFeedback()
        {
            eFeedback[] feedback = r_Computer.GetFeedbackFromComputer(r_CurrentGuess.CurrentColorsGuess);

            r_CurrentGuess.ResetGuessColors();
            m_CurrentFeedback = feedback;

            return feedback;
        }

        public bool IsGameInProgress()
        {
            return CounterRows < m_NumberOfGames && !isWinner();
        }

        public Color[] GetSecretCode()
        {
           return r_Computer.SecretCode;
        }

        private bool isWinner()
        {
            return !(m_CurrentFeedback.Contains(eFeedback.Wrong) || m_CurrentFeedback.Contains(eFeedback.X));
        }
    }
}
