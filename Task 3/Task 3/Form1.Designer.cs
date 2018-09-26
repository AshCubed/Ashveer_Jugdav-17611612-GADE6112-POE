namespace Task_3
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
            this.btninGameEvent = new System.Windows.Forms.Button();
            this.lblUserMapSize = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.pnlUserMapSize = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFoward = new System.Windows.Forms.Button();
            this.pnlUnitInfo = new System.Windows.Forms.Panel();
            this.pnlUserMapSize.SuspendLayout();
            this.pnlUnitInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGameTime
            // 
            this.lblGameTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTime.Location = new System.Drawing.Point(292, 486);
            this.lblGameTime.Name = "lblGameTime";
            this.lblGameTime.Size = new System.Drawing.Size(115, 385);
            this.lblGameTime.TabIndex = 1;
            this.lblGameTime.Text = "0:00";
            this.lblGameTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUnitInfo
            // 
            this.txtUnitInfo.Location = new System.Drawing.Point(3, 5);
            this.txtUnitInfo.Multiline = true;
            this.txtUnitInfo.Name = "txtUnitInfo";
            this.txtUnitInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUnitInfo.Size = new System.Drawing.Size(264, 124);
            this.txtUnitInfo.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
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
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(146, 577);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(140, 72);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "&Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(414, 655);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(239, 213);
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
            // btninGameEvent
            // 
            this.btninGameEvent.Enabled = false;
            this.btninGameEvent.Location = new System.Drawing.Point(12, 484);
            this.btninGameEvent.Name = "btninGameEvent";
            this.btninGameEvent.Size = new System.Drawing.Size(128, 165);
            this.btninGameEvent.TabIndex = 9;
            this.btninGameEvent.Text = "&InGameEvent";
            this.btninGameEvent.UseVisualStyleBackColor = true;
            this.btninGameEvent.Click += new System.EventHandler(this.btninGameEvent_Click);
            // 
            // lblUserMapSize
            // 
            this.lblUserMapSize.Location = new System.Drawing.Point(48, 2);
            this.lblUserMapSize.Name = "lblUserMapSize";
            this.lblUserMapSize.Size = new System.Drawing.Size(145, 36);
            this.lblUserMapSize.TabIndex = 10;
            this.lblUserMapSize.Text = "What Map Size would you like?";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(48, 42);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(21, 17);
            this.lblX.TabIndex = 11;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(48, 73);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(21, 17);
            this.lblY.TabIndex = 12;
            this.lblY.Text = "Y:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(76, 42);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(117, 22);
            this.txtX.TabIndex = 13;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(76, 73);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(117, 22);
            this.txtY.TabIndex = 14;
            // 
            // pnlUserMapSize
            // 
            this.pnlUserMapSize.Controls.Add(this.btnRegister);
            this.pnlUserMapSize.Controls.Add(this.lblUserMapSize);
            this.pnlUserMapSize.Controls.Add(this.txtY);
            this.pnlUserMapSize.Controls.Add(this.lblX);
            this.pnlUserMapSize.Controls.Add(this.txtX);
            this.pnlUserMapSize.Controls.Add(this.lblY);
            this.pnlUserMapSize.Location = new System.Drawing.Point(414, 486);
            this.pnlUserMapSize.Name = "pnlUserMapSize";
            this.pnlUserMapSize.Size = new System.Drawing.Size(239, 163);
            this.pnlUserMapSize.TabIndex = 15;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(45, 114);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(161, 49);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "&Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(4, 135);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 66);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFoward
            // 
            this.btnFoward.Location = new System.Drawing.Point(192, 135);
            this.btnFoward.Name = "btnFoward";
            this.btnFoward.Size = new System.Drawing.Size(75, 66);
            this.btnFoward.TabIndex = 18;
            this.btnFoward.Text = "&Foward";
            this.btnFoward.UseVisualStyleBackColor = true;
            this.btnFoward.Click += new System.EventHandler(this.btnFoward_Click);
            // 
            // pnlUnitInfo
            // 
            this.pnlUnitInfo.Controls.Add(this.txtUnitInfo);
            this.pnlUnitInfo.Controls.Add(this.btnFoward);
            this.pnlUnitInfo.Controls.Add(this.btnBack);
            this.pnlUnitInfo.Enabled = false;
            this.pnlUnitInfo.Location = new System.Drawing.Point(13, 655);
            this.pnlUnitInfo.Name = "pnlUnitInfo";
            this.pnlUnitInfo.Size = new System.Drawing.Size(273, 217);
            this.pnlUnitInfo.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 901);
            this.Controls.Add(this.pnlUnitInfo);
            this.Controls.Add(this.pnlUserMapSize);
            this.Controls.Add(this.btninGameEvent);
            this.Controls.Add(this.rtxtMap);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblGameTime);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GADE6112 - Task 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlUserMapSize.ResumeLayout(false);
            this.pnlUserMapSize.PerformLayout();
            this.pnlUnitInfo.ResumeLayout(false);
            this.pnlUnitInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblGameTime;
        private System.Windows.Forms.TextBox txtUnitInfo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtxtMap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btninGameEvent;
        private System.Windows.Forms.Label lblUserMapSize;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Panel pnlUserMapSize;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFoward;
        private System.Windows.Forms.Panel pnlUnitInfo;
    }
}

