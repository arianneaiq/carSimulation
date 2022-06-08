namespace carSimulation
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnAccelerate = new System.Windows.Forms.Button();
            this.btnBreaks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speed of my Ferrari is 210\r\n km/h en maximun speed is 240 km/h";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInfo.Location = new System.Drawing.Point(55, 101);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(545, 28);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "Speed of my Ferrari is 210 km/h and its maximun is 240 km/h";
            // 
            // btnAccelerate
            // 
            this.btnAccelerate.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccelerate.Location = new System.Drawing.Point(82, 207);
            this.btnAccelerate.Name = "btnAccelerate";
            this.btnAccelerate.Size = new System.Drawing.Size(251, 76);
            this.btnAccelerate.TabIndex = 2;
            this.btnAccelerate.Text = "Accelerate";
            this.btnAccelerate.UseVisualStyleBackColor = true;
            this.btnAccelerate.Click += new System.EventHandler(this.btnAccelerate_Click);
            // 
            // btnBreaks
            // 
            this.btnBreaks.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBreaks.Location = new System.Drawing.Point(405, 207);
            this.btnBreaks.Name = "btnBreaks";
            this.btnBreaks.Size = new System.Drawing.Size(251, 76);
            this.btnBreaks.TabIndex = 3;
            this.btnBreaks.Text = "Use the breaks";
            this.btnBreaks.UseVisualStyleBackColor = true;
            this.btnBreaks.Click += new System.EventHandler(this.btnBreaks_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(777, 446);
            this.Controls.Add(this.btnBreaks);
            this.Controls.Add(this.btnAccelerate);
            this.Controls.Add(this.lbInfo);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnAccelerate;
        private System.Windows.Forms.Button btnBreaks;
    }
}
