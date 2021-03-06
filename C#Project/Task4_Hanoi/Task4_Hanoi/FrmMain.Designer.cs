﻿namespace Task4_Hanoi
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panLeft = new System.Windows.Forms.Panel();
            this.panCenter = new System.Windows.Forms.Panel();
            this.panRight = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCnt = new System.Windows.Forms.NumericUpDown();
            this.lblCnt = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCnt)).BeginInit();
            this.SuspendLayout();
            // 
            // panLeft
            // 
            this.panLeft.AllowDrop = true;
            this.panLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panLeft.BackgroundImage")));
            this.panLeft.Location = new System.Drawing.Point(2, 2);
            this.panLeft.Name = "panLeft";
            this.panLeft.Size = new System.Drawing.Size(206, 312);
            this.panLeft.TabIndex = 21;
            this.panLeft.DragDrop += new System.Windows.Forms.DragEventHandler(this.pan_DragDrop);
            this.panLeft.DragEnter += new System.Windows.Forms.DragEventHandler(this.pan_DragEnter);
            // 
            // panCenter
            // 
            this.panCenter.AllowDrop = true;
            this.panCenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panCenter.BackgroundImage")));
            this.panCenter.Location = new System.Drawing.Point(210, 2);
            this.panCenter.Name = "panCenter";
            this.panCenter.Size = new System.Drawing.Size(206, 312);
            this.panCenter.TabIndex = 1;
            this.panCenter.DragDrop += new System.Windows.Forms.DragEventHandler(this.pan_DragDrop);
            this.panCenter.DragEnter += new System.Windows.Forms.DragEventHandler(this.pan_DragEnter);
            // 
            // panRight
            // 
            this.panRight.AllowDrop = true;
            this.panRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panRight.BackgroundImage")));
            this.panRight.Location = new System.Drawing.Point(418, 2);
            this.panRight.Name = "panRight";
            this.panRight.Size = new System.Drawing.Size(206, 312);
            this.panRight.TabIndex = 1;
            this.panRight.DragDrop += new System.Windows.Forms.DragEventHandler(this.pan_DragDrop);
            this.panRight.DragEnter += new System.Windows.Forms.DragEventHandler(this.pan_DragEnter);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(631, 230);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(146, 23);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "다시 시작하기";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(631, 259);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(146, 23);
            this.btnAuto.TabIndex = 4;
            this.btnAuto.Text = "자동 맞추기";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(630, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "블럭갯수";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(630, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "이동횟수 : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudCnt
            // 
            this.nudCnt.Location = new System.Drawing.Point(724, 162);
            this.nudCnt.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudCnt.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudCnt.Name = "nudCnt";
            this.nudCnt.Size = new System.Drawing.Size(53, 25);
            this.nudCnt.TabIndex = 7;
            this.nudCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCnt.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudCnt.ValueChanged += new System.EventHandler(this.nudCnt_ValueChanged);
            // 
            // lblCnt
            // 
            this.lblCnt.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCnt.Location = new System.Drawing.Point(721, 194);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(56, 25);
            this.lblCnt.TabIndex = 8;
            this.lblCnt.Text = "0번";
            this.lblCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(630, 288);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "게임 종료";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 319);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCnt);
            this.Controls.Add(this.nudCnt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.panRight);
            this.Controls.Add(this.panCenter);
            this.Controls.Add(this.panLeft);
            this.Name = "FrmMain";
            this.Text = "하노이탑";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCnt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panLeft;
        private System.Windows.Forms.Panel panCenter;
        private System.Windows.Forms.Panel panRight;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCnt;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.Button btnClose;
    }
}

