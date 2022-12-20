using System.Windows.Forms;

namespace BallGameBilliards
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.addBallButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addBallButton
            // 
            this.addBallButton.Location = new System.Drawing.Point(589, 12);
            this.addBallButton.Name = "addBallButton";
            this.addBallButton.Size = new System.Drawing.Size(109, 23);
            this.addBallButton.TabIndex = 0;
            this.addBallButton.Text = "&Добавить шарик";
            this.addBallButton.UseVisualStyleBackColor = true;
            this.addBallButton.Click += new System.EventHandler(this.addBallButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 494);
            this.Controls.Add(this.addBallButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бильярдые шарики. ";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private Button addBallButton;
    }
}