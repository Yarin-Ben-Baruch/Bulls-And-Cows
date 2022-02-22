using System.Drawing;
using System.Linq;

namespace Ex02
{
    public class CurrentGuess
    {
        private const int k_NumberOfColors = 4;
        private readonly Color[] r_CurrentColorsGuess;

        public CurrentGuess()
        {
            r_CurrentColorsGuess = new Color[k_NumberOfColors];

            ResetGuessColors();
        }

        public Color[] CurrentColorsGuess
        {
            get
            {
                return r_CurrentColorsGuess;
            }
        }

        public bool IsRowColored()
        {
            return !isColorInGuess(Color.Black);
        }

        public void ResetGuessColors()
        {
            for (int i = 0; i < r_CurrentColorsGuess.Length; i++)
            {
                r_CurrentColorsGuess[i] = Color.Black;
            }
        }

        public bool IsValidColorGuess(int i_IndexToAdd, Color i_ColorToAdd)
        {
            return CurrentColorsGuess[i_IndexToAdd].Equals(i_ColorToAdd) || !isColorInGuess(i_ColorToAdd);
        }

        private bool isColorInGuess(Color i_SelectedColor)
        {
            return CurrentColorsGuess.Contains(i_SelectedColor);
        }
    }
}
