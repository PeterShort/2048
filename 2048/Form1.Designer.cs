namespace _2048 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gameControlFrame = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonUp = new System.Windows.Forms.Button();
            this.ButtonRight = new System.Windows.Forms.Button();
            this.ButtonDown = new System.Windows.Forms.Button();
            this.ButtonLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameControlFrame
            // 
            this.gameControlFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameControlFrame.Location = new System.Drawing.Point(101, 79);
            this.gameControlFrame.Name = "gameControlFrame";
            this.gameControlFrame.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.gameControlFrame.Size = new System.Drawing.Size(342, 309);
            this.gameControlFrame.TabIndex = 0;
            // 
            // ButtonUp
            // 
            this.ButtonUp.Location = new System.Drawing.Point(242, 415);
            this.ButtonUp.Name = "ButtonUp";
            this.ButtonUp.Size = new System.Drawing.Size(46, 44);
            this.ButtonUp.TabIndex = 1;
            this.ButtonUp.Text = "UP";
            this.ButtonUp.UseVisualStyleBackColor = true;
            this.ButtonUp.Click += new System.EventHandler(this.ButtonUp_Click);
            // 
            // ButtonRight
            // 
            this.ButtonRight.Location = new System.Drawing.Point(294, 465);
            this.ButtonRight.Name = "ButtonRight";
            this.ButtonRight.Size = new System.Drawing.Size(46, 44);
            this.ButtonRight.TabIndex = 2;
            this.ButtonRight.Text = "RIGHT";
            this.ButtonRight.UseVisualStyleBackColor = true;
            this.ButtonRight.Click += new System.EventHandler(this.ButtonRight_Click);
            // 
            // ButtonDown
            // 
            this.ButtonDown.Location = new System.Drawing.Point(242, 508);
            this.ButtonDown.Name = "ButtonDown";
            this.ButtonDown.Size = new System.Drawing.Size(46, 44);
            this.ButtonDown.TabIndex = 3;
            this.ButtonDown.Text = "DOWN";
            this.ButtonDown.UseVisualStyleBackColor = true;
            this.ButtonDown.Click += new System.EventHandler(this.ButtonDown_Click);
            // 
            // ButtonLeft
            // 
            this.ButtonLeft.Location = new System.Drawing.Point(190, 465);
            this.ButtonLeft.Name = "ButtonLeft";
            this.ButtonLeft.Size = new System.Drawing.Size(46, 44);
            this.ButtonLeft.TabIndex = 4;
            this.ButtonLeft.Text = "LEFT";
            this.ButtonLeft.UseVisualStyleBackColor = true;
            this.ButtonLeft.Click += new System.EventHandler(this.ButtonLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 585);
            this.Controls.Add(this.ButtonLeft);
            this.Controls.Add(this.ButtonDown);
            this.Controls.Add(this.ButtonRight);
            this.Controls.Add(this.ButtonUp);
            this.Controls.Add(this.gameControlFrame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel gameControlFrame;
        private System.Windows.Forms.Button ButtonUp;
        private System.Windows.Forms.Button ButtonRight;
        private System.Windows.Forms.Button ButtonDown;
        private System.Windows.Forms.Button ButtonLeft;
    }
}

