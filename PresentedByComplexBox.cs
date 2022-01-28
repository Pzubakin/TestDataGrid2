using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataGrid2
{
    public class PresentedByComplexBox : BaseObservableObject
    {
        private string _helloWorld;
        private bool _checked;

        public string HelloWorld
        {
            get { return _helloWorld; }
            set
            {
                _helloWorld = value;
                OnPropertyChanged();
            }
        }

        public bool Checked
        {
            get { return _checked; }
            set
            {
                _checked = value;
                OnPropertyChanged();
            }
        }

        public PresentedByComplexBox(string helloWorld, bool isChecked)
        {
            HelloWorld = helloWorld;
            Checked = isChecked;
        }
    }
}
