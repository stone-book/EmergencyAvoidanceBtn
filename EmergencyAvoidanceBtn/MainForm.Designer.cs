namespace EmergencyAvoidanceBtn
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button.ContextMenuStrip = this.contextMenuStrip;
            this.button.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button.Location = new System.Drawing.Point(4, 12);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(183, 108);
            this.button.TabIndex = 0;
            this.button.Text = "緊急回避";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemClose,
            this.toolStripItemSetting,
            this.toolStripItemHelp});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(104, 70);
            // 
            // toolStripItemClose
            // 
            this.toolStripItemClose.Name = "toolStripItemClose";
            this.toolStripItemClose.Size = new System.Drawing.Size(103, 22);
            this.toolStripItemClose.Text = "終了";
            this.toolStripItemClose.Click += new System.EventHandler(this.toolStripItemClose_Click);
            // 
            // toolStripItemSetting
            // 
            this.toolStripItemSetting.Name = "toolStripItemSetting";
            this.toolStripItemSetting.Size = new System.Drawing.Size(103, 22);
            this.toolStripItemSetting.Text = "設定";
            this.toolStripItemSetting.Click += new System.EventHandler(this.toolStripItemSetting_Click);
            // 
            // toolStripItemHelp
            // 
            this.toolStripItemHelp.Name = "toolStripItemHelp";
            this.toolStripItemHelp.Size = new System.Drawing.Size(103, 22);
            this.toolStripItemHelp.Text = "ヘルプ";
            this.toolStripItemHelp.Click += new System.EventHandler(this.toolStripItemHelp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 132);
            this.Controls.Add(this.button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemSetting;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemClose;
    }
}

