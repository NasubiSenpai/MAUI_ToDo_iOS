using System;
using ToDoApp.Controls.Models;
namespace ToDoApp
{
	public class MainWindowViewModel
	{
		public PopUpTextViewModel propPopUpTextViewModel { get; private set; }

		public MainWindowViewModel()
		{
			#region 初期化
			propPopUpTextViewModel = new PopUpTextViewModel();
            #endregion
        }
    }
}

