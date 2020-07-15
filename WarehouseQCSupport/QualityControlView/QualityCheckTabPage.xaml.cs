using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseQCSupport.QualityControlView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QualityCheckTabPage : TabbedPage
    {
        public QualityCheckTabPage()
        {
            InitializeComponent();
        }
    }
}