using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EmergencyAvoidanceBtn
{
    public partial class MainForm : Form
    {
        /** 設定情報 */
        SettingInfo setting = null;

        /** Win32APIにキーボードイベントを送信 */
        [DllImport("user32.dll")]
        private static extern uint keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        /** Win32APIにメッセージを送信 */
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        /** WindowsMessage ID */
        private const int WM_APPCOMMAND = 0x319;
        /** WindowsMessage ID */
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;

        /// <summary>
        /// ダイアログサイズ調整のグリップの大きさ
        /// </summary>
        private const int cGrip = 16;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            loadSettingInfo();
            //setForm(this.setting);
        }

        /// <summary>
        /// グリップの描画
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
        }

        /// <summary>
        /// ボタン以外の場所でD＆Dを可能にする
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    // グリップの範囲の時の処理
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
                else if (!this.button.Bounds.Contains(pos))
                {
                    // マウスポインタがボタン以外の時の処理
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// 設定ファイルの読み込み
        /// </summary>
        private void loadSettingInfo()
        {
            SettingInfo setting = new SettingInfo();

            try
            {
                // 設定の読み込みとダイアログにも反映
                setting.ButtonText = this.button.Text = Properties.Settings.Default.ButtanText;
                setting.TopMost = this.TopMost = Properties.Settings.Default.TopMost;
                setting.Mute = Properties.Settings.Default.Mute;
                setting.ShortCut = (SettingInfo.KeyCombo)Properties.Settings.Default.ShortCutKey;
                setting.SaveFormStyle = Properties.Settings.Default.SaveFormStyle;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                // エラー時は次をデフォルト値とする
                setting.ButtonText = this.button.Text = "緊急回避";
                setting.TopMost = this.TopMost = true;
                setting.Mute = true;
                setting.ShortCut = SettingInfo.KeyCombo.WinD;
                setting.SaveFormStyle = false;
            }
            this.setting = setting;
        }

        /// <summary>
        /// 設定ファイルの保存
        /// </summary>
        private void saveSettingInfo()
        {
            try
            {
                // 設定の保存とダイアログにも反映
                Properties.Settings.Default.ButtanText = this.button.Text = setting.ButtonText;
                Properties.Settings.Default.TopMost = this.TopMost = setting.TopMost;
                Properties.Settings.Default.Mute = this.setting.Mute;
                Properties.Settings.Default.ShortCutKey = (int)this.setting.ShortCut;
                Properties.Settings.Default.SaveFormStyle = this.setting.SaveFormStyle;

                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
       
        /// <summary>
        /// 緊急回避ボタンの押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            this.minimizeWindow();

            if (this.setting.Mute)
            {
                this.setMute();
            }
        }

        /// <summary>
        /// ウインドウを最小化にする
        /// </summary>
        private void minimizeWindow()
        {
            // キーボードのショートカットを送信
            keybd_event((byte)Keys.LWin, 0, 0, (UIntPtr)0);
            if (setting.ShortCut == SettingInfo.KeyCombo.WinD)
            {
                keybd_event((byte)Keys.D, 0, 0, (UIntPtr)0);
                keybd_event((byte)Keys.D, 0, 2, (UIntPtr)0);
            }
            else
            {
                keybd_event((byte)Keys.M, 0, 0, (UIntPtr)0);
                keybd_event((byte)Keys.M, 0, 2, (UIntPtr)0);
            }
            keybd_event((byte)Keys.LWin, 0, 2, (UIntPtr)0);
        }

        /// <summary>
        /// ミュートに設定する
        /// </summary>
        private void setMute()
        {
            // Muteを強制的に解除（ボリュームをいじると変わる）
            SendMessage(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
            SendMessage(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
            // Muteにする
            SendMessage(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        /// <summary>
        /// 設定画面の呼び出し
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripItemSetting_Click(object sender, EventArgs e)
        {
            // 設定画面が隠れないように一時的に隠す
            if (this.TopMost) this.TopMost = false;

            SettingForm sf = new SettingForm(this.setting);

            if (sf.ShowDialog() == DialogResult.OK)
            {
                this.saveSettingInfo();
            }
        }

        /// <summary>
        /// 情報ダイアログの表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripItemHelp_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        /// <summary>
        /// プログラムの終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// フォームロード後に画面サイズを変更する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            var formSize = Properties.Settings.Default.FormSize;
            var desktopLocation = Properties.Settings.Default.DesktopLocation;

            if (this.setting.SaveFormStyle && !formSize.IsEmpty && !desktopLocation.IsEmpty)
            { 
                this.Size = formSize;
                this.DesktopLocation = desktopLocation;
            }
        }

        /// <summary>
        /// フォームを閉じる際に画面サイズを覚えておく
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.setting.SaveFormStyle)
            {
                Properties.Settings.Default.FormSize = this.Size;
                Properties.Settings.Default.DesktopLocation = this.DesktopLocation;

                Properties.Settings.Default.Save();
            }
        }


    }
}
