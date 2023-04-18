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
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(UpperText))]
        private string m_PopUpText = "hello, world";

        public string UpperText => PopUpText.ToUpper();

    }
}
