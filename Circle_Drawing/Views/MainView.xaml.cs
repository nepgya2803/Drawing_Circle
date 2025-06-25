using System.Windows.Controls;
using Circle_Drawing.ViewModels;

namespace Circle_Drawing.Views
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
