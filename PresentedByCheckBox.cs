using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataGrid2
{
    public class PresentedByCheckBox : BaseObservableObject
    {
        private bool _isChecked;

        public bool IsChecked
        {
            get { return _isChecked; }
            set
            {
                _isChecked = value;
                OnPropertyChanged();
            }
        }

        public PresentedByCheckBox(bool isChecked)
        {
            IsChecked = isChecked;
        }
    }
}
