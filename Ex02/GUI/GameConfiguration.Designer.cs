using System.Windows.Forms;

namespace Ex02
{
    public partial class GameConfiguration
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
            this.m_ButtonNumberOfChances = new System.Windows.Forms.Button();
            this.m_ButtonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_ButtonNumberOfChances
            // 
            this.m_ButtonNumberOfChances.Location = new System.Drawing.Point(28, 31);
            this.m_ButtonNumberOfChances.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_ButtonNumberOfChances.Name = "m_ButtonNumberOfChances";
            this.m_ButtonNumberOfChances.Size = new System.Drawing.Size(445, 42);
            this.m_ButtonNumberOfChances.TabIndex = 0;
            this.m_ButtonNumberOfChances.Text = "Number of chances: 4";
            this.m_ButtonNumberOfChances.UseVisualStyleBackColor = true;
            this.m_ButtonNumberOfChances.Click += new System.EventHandler(this.buttonNumberOfChances_Click);
            // 
            // m_ButtonStart
            // 
            this.m_ButtonStart.Location = new System.Drawing.Point(296, 159);
            this.m_ButtonStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_ButtonStart.Name = "m_ButtonStart";
            this.m_ButtonStart.Size = new System.Drawing.Size(177, 40);
            this.m_ButtonStart.TabIndex = 1;
            this.m_ButtonStart.Text = "Start";
            this.m_ButtonStart.UseVisualStyleBackColor = true;
            this.m_ButtonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // GameConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 221);
            this.Controls.Add(this.m_ButtonStart);
            this.Controls.Add(this.m_ButtonNumberOfChances);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "GameConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bool Pgia";
            this.ResumeLayout(false);
        }

        #endregion

        private Button m_ButtonNumberOfChances;
        private Button m_ButtonStart;
    }
}