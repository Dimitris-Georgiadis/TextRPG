namespace ui
{
    partial class TestRPG
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbHitPoints = new System.Windows.Forms.Label();
            this.lbGold = new System.Windows.Forms.Label();
            this.lbExperience = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HitPoints:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gold:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Experience:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level:";
            // 
            // lbHitPoints
            // 
            this.lbHitPoints.AutoSize = true;
            this.lbHitPoints.Location = new System.Drawing.Point(110, 19);
            this.lbHitPoints.Name = "lbHitPoints";
            this.lbHitPoints.Size = new System.Drawing.Size(0, 13);
            this.lbHitPoints.TabIndex = 4;
            // 
            // lbGold
            // 
            this.lbGold.AutoSize = true;
            this.lbGold.Location = new System.Drawing.Point(110, 45);
            this.lbGold.Name = "lbGold";
            this.lbGold.Size = new System.Drawing.Size(0, 13);
            this.lbGold.TabIndex = 5;
            // 
            // lbExperience
            // 
            this.lbExperience.AutoSize = true;
            this.lbExperience.Location = new System.Drawing.Point(110, 73);
            this.lbExperience.Name = "lbExperience";
            this.lbExperience.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbExperience.Size = new System.Drawing.Size(0, 13);
            this.lbExperience.TabIndex = 6;
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Location = new System.Drawing.Point(110, 99);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(0, 13);
            this.lbLevel.TabIndex = 7;
            // 
            // TestRPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 651);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.lbExperience);
            this.Controls.Add(this.lbGold);
            this.Controls.Add(this.lbHitPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TestRPG";
            this.Text = "TestRPG";
            this.Load += new System.EventHandler(this.TestRPG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbHitPoints;
        private System.Windows.Forms.Label lbGold;
        private System.Windows.Forms.Label lbExperience;
        private System.Windows.Forms.Label lbLevel;
    }
}

