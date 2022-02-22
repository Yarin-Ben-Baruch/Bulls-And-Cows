using System;
using System.Drawing;
using System.Windows.Forms;
using Ex02.GUI;

namespace Ex02
{
    public partial class GameBoard : Form
    {
        private const int k_RowSize = 4;
        private readonly GameManager r_GameManager;
        private readonly int r_NumberOfChances;

        public GameBoard(int i_NumberOfChances, GameManager i_GameManager)
        {
            r_GameManager = i_GameManager;
            r_NumberOfChances = i_NumberOfChances;

            InitializeComponent();
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            ColorButton theSender = sender as ColorButton;
            ColorOptions colorOptions = new ColorOptions();

            colorOptions.ShowDialog();
            if (colorOptions.IsColorWasChoose)
            {
                if (r_GameManager.AddColorToGuess(colorOptions.ChoosingColor, theSender.Index))
                {
                    theSender.BackColor = colorOptions.ChoosingColor;

                    if (r_GameManager.IsRowColored())
                    {
                        m_ButtonArrows[r_GameManager.CounterRows].Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("You can't choose the same color twice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonArrow_Click(object sender, EventArgs e)
        {
            Button theSender = sender as Button;
            const bool v_IsEnable = true;

            showGuessFeedbackToUser();
            theSender.Enabled = false;
            updateGuessButtonsEnableStatus(!v_IsEnable);

            r_GameManager.CounterRows++;

            if (r_GameManager.IsGameInProgress())
            {
                updateGuessButtonsEnableStatus(v_IsEnable);
            }
            else
            {
                showResultToUser();
            }
        }

        private void showResultToUser()
        {
            Color[] secretCode = r_GameManager.GetSecretCode();

            for (int i = 0; i < secretCode.Length; i++)
            {
                m_ButtonSecretCode[i].BackColor = secretCode[i];
            }
        }

        private void showGuessFeedbackToUser()
        {
            eFeedback[] feedbacks = r_GameManager.GetFeedback();

            for (int i = 0; i < feedbacks.Length; i++)
            {
                if (feedbacks[i].Equals(eFeedback.V))
                {
                    m_ButtonFeedbacks[r_GameManager.CounterRows, i].BackColor = Color.Black;
                }
                else if (feedbacks[i].Equals(eFeedback.X))
                {
                    m_ButtonFeedbacks[r_GameManager.CounterRows, i].BackColor = Color.Yellow;
                }
            }
        }

        private void updateGuessButtonsEnableStatus(bool i_IsEnabled)
        {
            for(int i = 0; i < k_RowSize; i++)
            {
                m_ButtonGuess[r_GameManager.CounterRows, i].Enabled = i_IsEnabled;
            }
        }
    }
}
