using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyAvoidanceBtn
{
    /// <summary>
    /// 設定クラス
    /// </summary>
    public class SettingInfo
    {
        /// <summary>
        /// ボタンに表示するテキスト
        /// </summary>
        public string ButtonText;

        /// <summary>
        /// 前面表示設定
        /// </summary>
        public bool TopMost;

        /// <summary>
        /// ショートカットの種類
        /// </summary>
        public enum KeyCombo { WinD , WinM }

        /// <summary>
        /// ショートカットの設定
        /// </summary>
        public KeyCombo ShortCut;

        /// <summary>
        /// ミュート設定
        /// </summary>
        public bool Mute;

        /// <summary>
        /// フォームのスタイルを保存するか
        /// </summary>
        public bool SaveFormStyle;

        /// <summary>
        /// フォームのサイズ
        /// </summary>
        public System.Drawing.Size FormSize;

        /// <summary>
        /// 画面の表示位置
        /// </summary>
        public System.Drawing.Point DesktopLocation;

    }

}
