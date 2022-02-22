using System.Drawing;
using System.Windows.Forms;

namespace Ex02
{
    public partial class ColorOptions
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
            m_ButtonColors = new Button[8];
            m_Colors = new[] { Color.Purple, Color.Red, Color.Aqua, Color.Lime, Color.Navy, Color.Yellow, Color.Maroon, Color.White };

            int colorButtonLeft = 16, colorButtonTop = 16;

            for (int i = 0; i < m_ButtonColors.Length; i++)
            {
                if (i == 4)
                {
                    colorButtonLeft = 16;
                    colorButtonTop = 132;
                }

                m_ButtonColors[i] = new Button();
                m_ButtonColors[i].BackColor = m_Colors[i];
                m_ButtonColors[i].Location = new System.Drawing.Point(colorButtonLeft, colorButtonTop);
                m_ButtonColors[i].Size = new System.Drawing.Size(100, 100);
                m_ButtonColors[i].Click += new System.EventHandler(this.buttonColor_Click);
                this.Controls.Add(m_ButtonColors[i]);

                colorButtonLeft += 116;
            }

            this.SuspendLayout();
            
            // 
            // ColorOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(m_ButtonColors[7].Right + 16, m_ButtonColors[7].Bottom + 16);
            this.Text = "Pic A Color:";
            this.ResumeLayout(false);
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        }

        #endregion

        private Button[] m_ButtonColors;
        private Color[] m_Colors;
    }
}