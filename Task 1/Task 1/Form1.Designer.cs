namespace Task_1
{
    partial class Form1
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
            this.lblGameTime = new System.Windows.Forms.Label();
            this.txtUnitInfo = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rtxtMap = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFoward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGameTime
            // 
            this.lblGameTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTime.Location = new System.Drawing.Point(412, 572);
            this.lblGameTime.Name = "lblGameTime";
            this.lblGameTime.Size = new System.Drawing.Size(115, 223);
            this.lblGameTime.TabIndex = 1;
            this.lblGameTime.Text = "0:00";
            this.lblGameTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUnitInfo
            // 
            this.txtUnitInfo.Location = new System.Drawing.Point(16, 570);
            this.txtUnitInfo.Multiline = true;
            this.txtUnitInfo.Name = "txtUnitInfo";
            this.txtUnitInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUnitInfo.Size = new System.Drawing.Size(244, 165);
            this.txtUnitInfo.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(266, 570);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 87);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(266, 663);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(140, 132);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "&Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(533, 570);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 225);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rtxtMap
            // 
            this.rtxtMap.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMap.Location = new System.Drawing.Point(13, 27);
            this.rtxtMap.Name = "rtxtMap";
            this.rtxtMap.Size = new System.Drawing.Size(597, 526);
            this.rtxtMap.TabIndex = 6;
            this.rtxtMap.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(16, 741);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 54);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFoward
            // 
            this.btnFoward.Location = new System.Drawing.Point(143, 741);
            this.btnFoward.Name = "btnFoward";
            this.btnFoward.Size = new System.Drawing.Size(117, 54);
            this.btnFoward.TabIndex = 8;
            this.btnFoward.Text = "&Foward";
            this.btnFoward.UseVisualStyleBackColor = true;
            this.btnFoward.Click += new System.EventHandler(this.btnFoward_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 807);
            this.Controls.Add(this.btnFoward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rtxtMap);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtUnitInfo);
            this.Controls.Add(this.lblGameTime);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GADE6112 - Task 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGameTime;
        private System.Windows.Forms.TextBox txtUnitInfo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtxtMap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFoward;
    }
}

