namespace Task_2
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
            this.btnBackWard = new System.Windows.Forms.Button();
            this.btnFoward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGameTime
            // 
            this.lblGameTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTime.Location = new System.Drawing.Point(292, 486);
            this.lblGameTime.Name = "lblGameTime";
            this.lblGameTime.Size = new System.Drawing.Size(366, 85);
            this.lblGameTime.TabIndex = 1;
            this.lblGameTime.Text = "0:00";
            this.lblGameTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUnitInfo
            // 
            this.txtUnitInfo.Location = new System.Drawing.Point(13, 484);
            this.txtUnitInfo.Multiline = true;
            this.txtUnitInfo.Name = "txtUnitInfo";
            this.txtUnitInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUnitInfo.Size = new System.Drawing.Size(127, 165);
            this.txtUnitInfo.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(146, 484);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 87);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(146, 577);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(140, 152);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "&Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(292, 577);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(366, 152);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rtxtMap
            // 
            this.rtxtMap.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMap.Location = new System.Drawing.Point(13, 27);
            this.rtxtMap.Name = "rtxtMap";
            this.rtxtMap.Size = new System.Drawing.Size(645, 451);
            this.rtxtMap.TabIndex = 6;
            this.rtxtMap.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBackWard
            // 
            this.btnBackWard.Location = new System.Drawing.Point(13, 656);
            this.btnBackWard.Name = "btnBackWard";
            this.btnBackWard.Size = new System.Drawing.Size(60, 73);
            this.btnBackWard.TabIndex = 9;
            this.btnBackWard.Text = "&Back";
            this.btnBackWard.UseVisualStyleBackColor = true;
            this.btnBackWard.Click += new System.EventHandler(this.btnBackWard_Click);
            // 
            // btnFoward
            // 
            this.btnFoward.Location = new System.Drawing.Point(80, 656);
            this.btnFoward.Name = "btnFoward";
            this.btnFoward.Size = new System.Drawing.Size(60, 73);
            this.btnFoward.TabIndex = 10;
            this.btnFoward.Text = "&Foward";
            this.btnFoward.UseVisualStyleBackColor = true;
            this.btnFoward.Click += new System.EventHandler(this.btnFoward_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 741);
            this.Controls.Add(this.btnFoward);
            this.Controls.Add(this.btnBackWard);
            this.Controls.Add(this.rtxtMap);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtUnitInfo);
            this.Controls.Add(this.lblGameTime);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GADE6112 - Task 2";
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
        private System.Windows.Forms.Button btnBackWard;
        private System.Windows.Forms.Button btnFoward;
    }
}

