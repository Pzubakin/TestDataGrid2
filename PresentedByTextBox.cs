using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataGrid2
{
    public class PresentedByTextBox : BaseObservableObject
    {
        private string _helloWorld;

        public string HelloWorld
        {
            get { return _helloWorld; }
            set
            {
                _helloWorld = value;
                OnPropertyChanged();
            }
        }

        public PresentedByTextBox(string helloWorld)
        {
            HelloWorld = helloWorld;
        }
    }
}
