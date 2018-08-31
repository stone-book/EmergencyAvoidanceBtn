namespace EmergencyAvoidanceBtn
{
    partial class SettingForm
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonWinM = new System.Windows.Forms.RadioButton();
            this.radioButtonWinD = new System.Windows.Forms.RadioButton();
            this.checkBoxForeDisp = new System.Windows.Forms.CheckBox();
            this.checkBoxMute = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBtnText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(112, 194);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(193, 193);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonWinM);
            this.groupBox1.Controls.Add(this.radioButtonWinD);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "最小化に使用するショートカット";
            // 
            // radioButtonWinM
            // 
            this.radioButtonWinM.AutoSize = true;
            this.radioButtonWinM.Location = new System.Drawing.Point(135, 28);
            this.radioButtonWinM.Name = "radioButtonWinM";
            this.radioButtonWinM.Size = new System.Drawing.Size(110, 16);
            this.radioButtonWinM.TabIndex = 0;
            this.radioButtonWinM.TabStop = true;
            this.radioButtonWinM.Text = "Windowsキー + M";
            this.radioButtonWinM.UseVisualStyleBackColor = true;
            // 
            // radioButtonWinD
            // 
            this.radioButtonWinD.AutoSize = true;
            this.radioButtonWinD.Location = new System.Drawing.Point(18, 28);
            this.radioButtonWinD.Name = "radioButtonWinD";
            this.radioButtonWinD.Size = new System.Drawing.Size(105, 16);
            this.radioButtonWinD.TabIndex = 0;
            this.radioButtonWinD.TabStop = true;
            this.radioButtonWinD.Text = "Windowsキー+ D";
            this.radioButtonWinD.UseVisualStyleBackColor = true;
            // 
            // checkBoxForeDisp
            // 
            this.checkBoxForeDisp.AutoSize = true;
            this.checkBoxForeDisp.Location = new System.Drawing.Point(12, 94);
            this.checkBoxForeDisp.Name = "checkBoxForeDisp";
            this.checkBoxForeDisp.Size = new System.Drawing.Size(177, 16);
            this.checkBoxForeDisp.TabIndex = 3;
            this.checkBoxForeDisp.Text = "緊急回避ボタンを常に前面表示";
            this.checkBoxForeDisp.UseVisualStyleBackColor = true;
            // 
            // checkBoxMute
            // 
            this.checkBoxMute.AutoSize = true;
            this.checkBoxMute.Location = new System.Drawing.Point(12, 126);
            this.checkBoxMute.Name = "checkBoxMute";
            this.checkBoxMute.Size = new System.Drawing.Size(183, 16);
            this.checkBoxMute.TabIndex = 3;
            this.checkBoxMute.Text = "緊急回避時にミュート切替を実施";
            this.checkBoxMute.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "緊急回避ボタンのラベル :";
            // 
            // textBoxBtnText
            // 
            this.textBoxBtnText.Location = new System.Drawing.Point(144, 155);
            this.textBoxBtnText.Name = "textBoxBtnText";
            this.textBoxBtnText.Size = new System.Drawing.Size(124, 19);
            this.textBoxBtnText.TabIndex = 5;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 226);
            this.Controls.Add(this.textBoxBtnText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxMute);
            this.Controls.Add(this.checkBoxForeDisp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingForm";
            this.Text = "設定";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonWinM;
        private System.Windows.Forms.RadioButton radioButtonWinD;
        private System.Windows.Forms.CheckBox checkBoxForeDisp;
        private System.Windows.Forms.CheckBox checkBoxMute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBtnText;
    }
}