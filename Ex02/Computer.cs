using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Ex02
{
    public class Computer
    {
        private const int k_NumberOfComputerRaffles = 4;
        private static readonly Random sr_RandomIndex;
        private readonly List<Color> r_GuessingOptions;
        private readonly Color[] r_SecretCode;

        static Computer()
        {
            sr_RandomIndex = new Random();
        }

        public Computer()
        {
            r_GuessingOptions = new List<Color>(8) { Color.Purple, Color.Red, Color.Aqua, Color.Lime, Color.Navy, Color.Yellow, Color.Maroon, Color.White };

            r_SecretCode = GetSequenceFromTheComputer();
        }

        public Color[] SecretCode
        {
            get
            {
                return r_SecretCode;
            }
        }

        public Color[] GetSequenceFromTheComputer()
        {
            int randomIndexInArray;
            Color[] secretCode = new Color[k_NumberOfComputerRaffles];

            for (int i = 0; i < k_NumberOfComputerRaffles; i++)
            {
                randomIndexInArray = getRandomIndex();
                secretCode[i] = r_GuessingOptions[randomIndexInArray];
                r_GuessingOptions.RemoveAt(randomIndexInArray);
            }

            return secretCode;
        }

        public eFeedback[] GetFeedbackFromComputer(Color[] i_PlayerCurrentGuess)
        {
            int numberOfV = 0, numberOfX = 0, index = 0;
            eFeedback[] feedback = { eFeedback.Wrong, eFeedback.Wrong, eFeedback.Wrong, eFeedback.Wrong };

            for (int i = 0; i < r_SecretCode.Length; i++)
            {
                if (i_PlayerCurrentGuess[i].Equals(r_SecretCode[i]))
                {
                    numberOfV++;
                }
                else if (r_SecretCode.Contains(i_PlayerCurrentGuess[i]))
                {
                    numberOfX++;
                }
            }

            for (; index < numberOfV; index++)
            {
                feedback[index] = eFeedback.V;
            }

            for (int j = 0; j < numberOfX; j++, index++)
            {
                feedback[index] = eFeedback.X;
            }

            return feedback;
        }

        private int getRandomIndex()
        {
            return sr_RandomIndex.Next(0, r_GuessingOptions.Count);
        }
    }
}
