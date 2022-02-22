using System;
using System.Windows.Forms;

namespace Ex02
{
    public partial class GameConfiguration : Form
    {
        private int m_NumberOfGames;
        private bool m_CloseByStart;

        public GameConfiguration()
        {
            InitializeComponent();
            m_NumberOfGames = 0;
            m_CloseByStart = false;
        }

        public int NumberOfGames
        {
            get
            {
                return m_NumberOfGames + 4;
            }
        }

        public bool CloseByStart
        {
            get
            {
                return m_CloseByStart;
            }
        }

        private void buttonNumberOfChances_Click(object sender, EventArgs e)
        {
            Button theSender = sender as Button;

            m_NumberOfGames = (m_NumberOfGames + 1) % 7;
            theSender.Text = string.Format("Number of chances: {0}", NumberOfGames);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            m_CloseByStart = true;
            Close();
        }
    }
}
