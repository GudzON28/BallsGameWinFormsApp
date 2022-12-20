using System.Windows.Forms;

namespace BallsGameWinFormsApp
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
            this.createBallsButton = new System.Windows.Forms.Button();
            this.stopBallsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createBallsButton
            // 
            this.createBallsButton.Location = new System.Drawing.Point(1010, 12);
            this.createBallsButton.Name = "createBallsButton";
            this.createBallsButton.Size = new System.Drawing.Size(127, 23);
            this.createBallsButton.TabIndex = 0;
            this.createBallsButton.Text = "&Создать шарики";
            this.createBallsButton.UseVisualStyleBackColor = true;
            this.createBallsButton.Click += new System.EventHandler(this.createBallsButton_Click);
            // 
            // stopBallsButton
            // 
            this.stopBallsButton.Enabled = false;
            this.stopBallsButton.Location = new System.Drawing.Point(1010, 596);
            this.stopBallsButton.Name = "stopBallsButton";
            this.stopBallsButton.Size = new System.Drawing.Size(127, 23);
            this.stopBallsButton.TabIndex = 1;
            this.stopBallsButton.Text = "&Остановить шарики";
            this.stopBallsButton.UseVisualStyleBackColor = true;
            this.stopBallsButton.Click += new System.EventHandler(this.stopBallsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 631);
            this.Controls.Add(this.stopBallsButton);
            this.Controls.Add(this.createBallsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Шарики\"";
            this.ResumeLayout(false);

        }

        #endregion

        private Button createBallsButton;
        private Button stopBallsButton;
    }
}