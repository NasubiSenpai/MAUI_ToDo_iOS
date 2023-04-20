using System;
using ToDoApp.Controls.Models;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ToDoApp
{
	public partial class MainWindowViewModel : ObservableObject
	{
        #region 依存関係プロパティ

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(propSelectedDate))]
        private DateTime m_SelectedDate;

        public DateTime propSelectedDate => SelectedDate = DateTime.Now;

        #endregion

        public PopUpTextViewModel propPopUpTextViewModel { get; private set; }

		public MainWindowViewModel()
		{
			#region 初期化
			propPopUpTextViewModel = new PopUpTextViewModel();
            #endregion
        }
    }
}

