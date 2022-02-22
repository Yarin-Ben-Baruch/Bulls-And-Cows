using System.Drawing;
using System.Windows.Forms;
using Ex02.GUI;

namespace Ex02
{
    public partial class GameBoard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            int secretCodeLeft = 16, secretCodeTop = 16;
            int guessLeft = 16, guessTop = 105;

            m_ButtonSecretCode = new Button[k_RowSize];
            m_ButtonGuess = new ColorButton[r_NumberOfChances, k_RowSize];
            m_ButtonArrows = new Button[r_NumberOfChances];
            m_ButtonFeedbacks = new Button[r_NumberOfChances, k_RowSize];

            for (int i = 0; i < m_ButtonSecretCode.Length; i++)
            {
                m_ButtonSecretCode[i] = new Button();
                m_ButtonSecretCode[i].BackColor = System.Drawing.Color.Black;
                m_ButtonSecretCode[i].Enabled = false;
                m_ButtonSecretCode[i].Location = new System.Drawing.Point(secretCodeLeft, secretCodeTop);
                m_ButtonSecretCode[i].Size = new System.Drawing.Size(50, 50);
                m_ButtonSecretCode[i].TabIndex = 0;
                m_ButtonSecretCode[i].UseVisualStyleBackColor = false;
                this.Controls.Add(m_ButtonSecretCode[i]);
                secretCodeLeft += 60;
            }

            for (int j = 0; j < r_NumberOfChances; j++)
            {
                for (int i = 0; i < k_RowSize; i++)
                {
                    m_ButtonGuess[j, i] = new ColorButton(i);
                    m_ButtonGuess[j, i].Enabled = j == 0;

                    m_ButtonGuess[j, i].Location = new System.Drawing.Point(guessLeft, guessTop);
                    m_ButtonGuess[j, i].Size = new System.Drawing.Size(50, 50);
                    m_ButtonGuess[j, i].Click += new System.EventHandler(this.buttonGuess_Click);
                    this.Controls.Add(m_ButtonGuess[j, i]);
                    guessLeft += 60;
                }

                m_ButtonArrows[j] = new Button();
                m_ButtonArrows[j].Enabled = false;
                m_ButtonArrows[j].Location = new System.Drawing.Point(guessLeft, guessTop + 12);
                m_ButtonArrows[j].Size = new System.Drawing.Size(50, 26);
                m_ButtonArrows[j].Text = "-->>";
                m_ButtonArrows[j].Click += new System.EventHandler(this.buttonArrow_Click);
                this.Controls.Add(m_ButtonArrows[j]);

                int feedbackLeft = guessLeft + 60, feedbackTop = guessTop + 5;

                for (int i = 0; i < k_RowSize; i++)
                {
                    if (i == 2)
                    {
                        feedbackLeft = guessLeft + 60;
                        feedbackTop += 24;
                    }

                    m_ButtonFeedbacks[j, i] = new Button();
                    m_ButtonFeedbacks[j, i].Enabled = false;
                    m_ButtonFeedbacks[j, i].Location = new System.Drawing.Point(feedbackLeft, feedbackTop);
                    m_ButtonFeedbacks[j, i].Size = new System.Drawing.Size(16, 16);
                    this.Controls.Add(m_ButtonFeedbacks[j, i]);
                    feedbackLeft += 24;
                }

                guessLeft = 16;
                guessTop += 60;
            }

            this.SuspendLayout();
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new Size(m_ButtonFeedbacks[0, 3].Right + 16, m_ButtonGuess[r_NumberOfChances - 1, 0].Bottom + 16);
            this.Text = "Bool Pgia";
            this.ResumeLayout(false);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        }

        #endregion
        private Button[] m_ButtonSecretCode;
        private ColorButton[,] m_ButtonGuess;
        private Button[] m_ButtonArrows;
        private Button[,] m_ButtonFeedbacks;
    }
}