namespace AngryBirdsWinFormsApp
{
    partial class AngryBirdsMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AngryBirdsMainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.maximumUpClickZone = new System.Windows.Forms.PictureBox();
            this.maximumRightClickZone = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.birdUsedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.maximumUpClickZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumRightClickZone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Счёт:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(43, 24);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(13, 15);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "0";
            // 
            // maximumUpClickZone
            // 
            this.maximumUpClickZone.BackColor = System.Drawing.Color.Black;
            this.maximumUpClickZone.Location = new System.Drawing.Point(0, 420);
            this.maximumUpClickZone.Name = "maximumUpClickZone";
            this.maximumUpClickZone.Size = new System.Drawing.Size(188, 1);
            this.maximumUpClickZone.TabIndex = 2;
            this.maximumUpClickZone.TabStop = false;
            // 
            // maximumRightClickZone
            // 
            this.maximumRightClickZone.BackColor = System.Drawing.Color.Black;
            this.maximumRightClickZone.Location = new System.Drawing.Point(187, 420);
            this.maximumRightClickZone.Name = "maximumRightClickZone";
            this.maximumRightClickZone.Size = new System.Drawing.Size(1, 252);
            this.maximumRightClickZone.TabIndex = 3;
            this.maximumRightClickZone.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Зона клика для запуска";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Потрачено птичек: ";
            // 
            // birdUsedLabel
            // 
            this.birdUsedLabel.AutoSize = true;
            this.birdUsedLabel.Location = new System.Drawing.Point(121, 9);
            this.birdUsedLabel.Name = "birdUsedLabel";
            this.birdUsedLabel.Size = new System.Drawing.Size(13, 15);
            this.birdUsedLabel.TabIndex = 6;
            this.birdUsedLabel.Text = "0";
            // 
            // AngryBirdsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 670);
            this.Controls.Add(this.birdUsedLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maximumRightClickZone);
            this.Controls.Add(this.maximumUpClickZone);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AngryBirdsMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angry Birds";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AngryBirdsMainForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.maximumUpClickZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumRightClickZone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox maximumUpClickZone;
        private System.Windows.Forms.PictureBox maximumRightClickZone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label birdUsedLabel;
    }
}