using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataGrid2
{
    public class DynamicCellsDataContext : BaseObservableObject
    {
        public DynamicCellsDataContext()
        {
            DataGridSource = new ObservableCollection<object>
            {
                new PresentedByTextBox("Hello world!!!"),
                new PresentedByCheckBox(true),
                new PresentedByComplexBox("Hello world!!!", true),
            };
        }
        public ObservableCollection<object> DataGridSource { get; set; }
    }
}
