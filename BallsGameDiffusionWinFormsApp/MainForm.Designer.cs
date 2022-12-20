using System.Windows.Forms;

namespace BallsGameDiffusionWinFormsApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.redGasLeftSideLabel = new System.Windows.Forms.Label();
            this.redGasTopSideLabel = new System.Windows.Forms.Label();
            this.redGasRightSideLabel = new System.Windows.Forms.Label();
            this.redGasBottomSideLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.blueGasLeftSideLabel = new System.Windows.Forms.Label();
            this.blueGasTopSideLabel = new System.Windows.Forms.Label();
            this.blueGasRightSideLabel = new System.Windows.Forms.Label();
            this.blueGasBottomSideLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // redGasLeftSideLabel
            // 
            this.redGasLeftSideLabel.AutoSize = true;
            this.redGasLeftSideLabel.BackColor = System.Drawing.SystemColors.Control;
            this.redGasLeftSideLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.redGasLeftSideLabel.Location = new System.Drawing.Point(157, 282);
            this.redGasLeftSideLabel.Name = "redGasLeftSideLabel";
            this.redGasLeftSideLabel.Size = new System.Drawing.Size(13, 15);
            this.redGasLeftSideLabel.TabIndex = 0;
            this.redGasLeftSideLabel.Text = "0";
            // 
            // redGasTopSideLabel
            // 
            this.redGasTopSideLabel.AutoSize = true;
            this.redGasTopSideLabel.BackColor = System.Drawing.SystemColors.Control;
            this.redGasTopSideLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.redGasTopSideLabel.Location = new System.Drawing.Point(713, 16);
            this.redGasTopSideLabel.Name = "redGasTopSideLabel";
            this.redGasTopSideLabel.Size = new System.Drawing.Size(13, 15);
            this.redGasTopSideLabel.TabIndex = 1;
            this.redGasTopSideLabel.Text = "0";
            // 
            // redGasRightSideLabel
            // 
            this.redGasRightSideLabel.AutoSize = true;
            this.redGasRightSideLabel.BackColor = System.Drawing.SystemColors.Control;
            this.redGasRightSideLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.redGasRightSideLabel.Location = new System.Drawing.Point(1303, 282);
            this.redGasRightSideLabel.Name = "redGasRightSideLabel";
            this.redGasRightSideLabel.Size = new System.Drawing.Size(13, 15);
            this.redGasRightSideLabel.TabIndex = 2;
            this.redGasRightSideLabel.Text = "0";
            // 
            // redGasBottomSideLabel
            // 
            this.redGasBottomSideLabel.AutoSize = true;
            this.redGasBottomSideLabel.BackColor = System.Drawing.SystemColors.Control;
            this.redGasBottomSideLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.redGasBottomSideLabel.Location = new System.Drawing.Point(713, 642);
            this.redGasBottomSideLabel.Name = "redGasBottomSideLabel";
            this.redGasBottomSideLabel.Size = new System.Drawing.Size(13, 15);
            this.redGasBottomSideLabel.TabIndex = 3;
            this.redGasBottomSideLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(12, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Давление красного газа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(568, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Давление красного газа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Location = new System.Drawing.Point(568, 642);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Давление красного газа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(1158, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Давление красного газа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Location = new System.Drawing.Point(25, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Давление синего газа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Location = new System.Drawing.Point(581, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Давление синего газа";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Location = new System.Drawing.Point(1171, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Давление синего газа";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Location = new System.Drawing.Point(581, 657);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Давление синего газа";
            // 
            // blueGasLeftSideLabel
            // 
            this.blueGasLeftSideLabel.AutoSize = true;
            this.blueGasLeftSideLabel.BackColor = System.Drawing.SystemColors.Control;
            this.blueGasLeftSideLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.blueGasLeftSideLabel.Location = new System.Drawing.Point(157, 297);
            this.blueGasLeftSideLabel.Name = "blueGasLeftSideLabel";
            this.blueGasLeftSideLabel.Size = new System.Drawing.Size(13, 15);
            this.blueGasLeftSideLabel.TabIndex = 12;
            this.blueGasLeftSideLabel.Text = "0";
            // 
            // blueGasTopSideLabel
            // 
            this.blueGasTopSideLabel.AutoSize = true;
            this.blueGasTopSideLabel.BackColor = System.Drawing.SystemColors.Control;
            this.blueGasTopSideLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.blueGasTopSideLabel.Location = new System.Drawing.Point(713, 31);
            this.blueGasTopSideLabel.Name = "blueGasTopSideLabel";
            this.blueGasTopSideLabel.Size = new System.Drawing.Size(13, 15);
            this.blueGasTopSideLabel.TabIndex = 13;
            this.blueGasTopSideLabel.Text = "0";
            // 
            // blueGasRightSideLabel
            // 
            this.blueGasRightSideLabel.AutoSize = true;
            this.blueGasRightSideLabel.BackColor = System.Drawing.SystemColors.Control;
            this.blueGasRightSideLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.blueGasRightSideLabel.Location = new System.Drawing.Point(1303, 297);
            this.blueGasRightSideLabel.Name = "blueGasRightSideLabel";
            this.blueGasRightSideLabel.Size = new System.Drawing.Size(13, 15);
            this.blueGasRightSideLabel.TabIndex = 14;
            this.blueGasRightSideLabel.Text = "0";
            // 
            // blueGasBottomSideLabel
            // 
            this.blueGasBottomSideLabel.AutoSize = true;
            this.blueGasBottomSideLabel.BackColor = System.Drawing.SystemColors.Control;
            this.blueGasBottomSideLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.blueGasBottomSideLabel.Location = new System.Drawing.Point(713, 657);
            this.blueGasBottomSideLabel.Name = "blueGasBottomSideLabel";
            this.blueGasBottomSideLabel.Size = new System.Drawing.Size(13, 15);
            this.blueGasBottomSideLabel.TabIndex = 15;
            this.blueGasBottomSideLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 681);
            this.Controls.Add(this.blueGasBottomSideLabel);
            this.Controls.Add(this.blueGasRightSideLabel);
            this.Controls.Add(this.blueGasTopSideLabel);
            this.Controls.Add(this.blueGasLeftSideLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redGasBottomSideLabel);
            this.Controls.Add(this.redGasRightSideLabel);
            this.Controls.Add(this.redGasTopSideLabel);
            this.Controls.Add(this.redGasLeftSideLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Шарики\". Диффузия";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Timer timer1;
        private Label redGasLeftSideLabel;
        private Label redGasTopSideLabel;
        private Label redGasRightSideLabel;
        private Label redGasBottomSideLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label blueGasLeftSideLabel;
        private Label blueGasTopSideLabel;
        private Label blueGasRightSideLabel;
        private Label blueGasBottomSideLabel;
    }
}