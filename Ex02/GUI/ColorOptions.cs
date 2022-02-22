using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ex02
{
    public partial class ColorOptions : Form
    {
        private Color m_ChoosingColor;
        private bool m_IsColorWasChoose;

        public ColorOptions()
        {
            m_IsColorWasChoose = false;
            InitializeComponent();
        }

        public Color ChoosingColor
        {
            get
            {
                return m_ChoosingColor;
            }
        }

        public bool IsColorWasChoose
        {
            get
            {
                return m_IsColorWasChoose;
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            Button theSender = sender as Button;

            m_ChoosingColor = theSender.BackColor;
            m_IsColorWasChoose = true;
            Close();
        }
    }
}
