using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmergencyAvoidanceBtn
{
    /// <summary>
    /// 設定フォーム
    /// </summary>
    public partial class SettingForm : Form
    {
        /// <summary>
        /// 設定情報クラス
        /// </summary>
        private SettingInfo setting = null;

        /// <summary>
        /// 設定フォームのコンストラクタ
        /// </summary>
        /// <param name="setting">編集する設定情報</param>
        public SettingForm(SettingInfo setting)
        {
            InitializeComponent();
            this.setting = setting;

            // 設定情報をダイアログに反映
            this.textBoxBtnText.Text = setting.ButtonText;

            this.checkBoxForeDisp.Checked = setting.TopMost;

            this.checkBoxMute.Checked = setting.Mute;

            this.checkBoxSaveFormStyle.Checked = setting.SaveFormStyle;

            if (setting.ShortCut == SettingInfo.KeyCombo.WinD)
            {
                this.radioButtonWinD.Checked = true;
            }
            else
            {
                this.radioButtonWinM.Checked = true;
            }

        }

        /// <summary>
        /// OKボタンの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            // ダイアログの情報から設定に反映する
            setting.ButtonText = this.textBoxBtnText.Text;

            setting.TopMost = this.checkBoxForeDisp.Checked;

            setting.Mute = this.checkBoxMute.Checked;

            setting.SaveFormStyle = this.checkBoxSaveFormStyle.Checked;

            if (this.radioButtonWinD.Checked)
            {
                setting.ShortCut = SettingInfo.KeyCombo.WinD;
            }
            else
            {
                setting.ShortCut = SettingInfo.KeyCombo.WinM;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// キャンセルボタンの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
