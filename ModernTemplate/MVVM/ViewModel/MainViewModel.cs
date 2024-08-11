using ModernTemplate.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernTemplate.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public readonly string Title;

        public MainViewModel(string _title)
        {
            Title = _title;
        }
    }
}
