﻿namespace DigitalClock
{
    partial class DigitalClock
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
            this.components = new System.ComponentModel.Container();
            this.clockLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.redButton = new System.Windows.Forms.Button();
            this.orangeButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.styleButton1 = new System.Windows.Forms.Button();
            this.styleButton2 = new System.Windows.Forms.Button();
            this.styleButton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clockLabel
            // 
            this.clockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.ForeColor = System.Drawing.Color.Red;
            this.clockLabel.Location = new System.Drawing.Point(26, 21);
            this.clockLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(1010, 476);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "Loading...";
            this.clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.redButton.Location = new System.Drawing.Point(12, 544);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(25, 23);
            this.redButton.TabIndex = 1;
            this.redButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // orangeButton
            // 
            this.orangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeButton.Location = new System.Drawing.Point(43, 544);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(25, 23);
            this.orangeButton.TabIndex = 2;
            this.orangeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.orangeButton.UseVisualStyleBackColor = false;
            this.orangeButton.Click += new System.EventHandler(this.orangeButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(74, 544);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(25, 23);
            this.yellowButton.TabIndex = 3;
            this.yellowButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenButton.Location = new System.Drawing.Point(105, 544);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(25, 23);
            this.greenButton.TabIndex = 4;
            this.greenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.blueButton.Location = new System.Drawing.Point(136, 544);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(25, 23);
            this.blueButton.TabIndex = 5;
            this.blueButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // styleButton1
            // 
            this.styleButton1.BackColor = System.Drawing.Color.White;
            this.styleButton1.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleButton1.Location = new System.Drawing.Point(167, 544);
            this.styleButton1.Name = "styleButton1";
            this.styleButton1.Size = new System.Drawing.Size(75, 23);
            this.styleButton1.TabIndex = 6;
            this.styleButton1.Text = "Style 1";
            this.styleButton1.UseVisualStyleBackColor = false;
            this.styleButton1.Click += new System.EventHandler(this.styleButton1_Click);
            // 
            // styleButton2
            // 
            this.styleButton2.BackColor = System.Drawing.Color.White;
            this.styleButton2.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleButton2.Location = new System.Drawing.Point(248, 544);
            this.styleButton2.Name = "styleButton2";
            this.styleButton2.Size = new System.Drawing.Size(75, 23);
            this.styleButton2.TabIndex = 7;
            this.styleButton2.Text = "Style 2";
            this.styleButton2.UseVisualStyleBackColor = false;
            this.styleButton2.Click += new System.EventHandler(this.styleButton2_Click);
            // 
            // styleButton3
            // 
            this.styleButton3.BackColor = System.Drawing.Color.White;
            this.styleButton3.Font = new System.Drawing.Font("NSimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleButton3.Location = new System.Drawing.Point(329, 544);
            this.styleButton3.Name = "styleButton3";
            this.styleButton3.Size = new System.Drawing.Size(75, 23);
            this.styleButton3.TabIndex = 8;
            this.styleButton3.Text = "Style 1";
            this.styleButton3.UseVisualStyleBackColor = false;
            this.styleButton3.Click += new System.EventHandler(this.styleButton3_Click);
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1059, 579);
            this.Controls.Add(this.styleButton3);
            this.Controls.Add(this.styleButton2);
            this.Controls.Add(this.styleButton1);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.orangeButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.clockLabel);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "DigitalClock";
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.DigitalClock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button orangeButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button styleButton1;
        private System.Windows.Forms.Button styleButton2;
        private System.Windows.Forms.Button styleButton3;
    }
}

