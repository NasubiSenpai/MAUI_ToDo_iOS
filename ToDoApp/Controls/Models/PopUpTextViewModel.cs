using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace ToDoApp.Controls.Models
{
    public partial class PopUpTextViewModel : ObservableObject
    {
        /// <summary>
        /// 変更通知プロパティ。
        /// [NotifyPropertyChangedFor(nameof(hoge))]属性で
        /// 指定したhogeプロパティを仕様する必要がある
        /// *属性付きメンバ変数m_HogeHogeは直接参照不可
        /// </summary>
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(propUpperText))]
        private string m_PopUpText = "hello, world";
        /// <summary>
        /// PopUPTextプロパティを大文字に変換して返す
        /// </summary>
        public string propUpperText => PopUpText.ToUpper();
        /// <summary>
        /// コントロールの高さ
        /// </summary>
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(propTextHeight))]
        private double m_TextHeight = 200.0d;
        /// <summary>
        /// 参照先プロパティ
        /// </summary>
        public double propTextHeight => TextHeight;
        /// <summary>
        /// コントロールの横幅
        /// </summary>
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(propTextWidth))]
        private double m_TextWidth = 200.0d;
        /// <summary>
        /// 参照先プロパティ
        /// </summary>
        public double propTextWidth => TextWidth;
        /// <summary>
        /// フォントサイズ
        /// </summary>
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(propTextFontSize))]
        private double m_TextFontSize = 40.0d;
        /// <summary>
        /// 参照先プロパティ
        /// </summary>
        public double propTextFontSize => TextFontSize;
        /// <summary>
        /// 表示されているテキストを返す
        /// </summary>
        /// <returns>propUpperText</returns>
        public string GetText() => propUpperText;

    }
}
