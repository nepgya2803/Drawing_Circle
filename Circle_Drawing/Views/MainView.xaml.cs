using System.Windows;
using System.Windows.Controls;
using Circle_Drawing.Models;
using Circle_Drawing.ViewModels;

namespace Circle_Drawing.Views
{
    public partial class MainView : UserControl
    {
        private double _radius;
        private int _ratio;
        private int _xCoordinator;
        private int _yCoordinator;

        public MainView()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }


        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _radius = Convert.ToDouble(Radius.Text);
            _ratio = Convert.ToInt16(Ratio.Text);
            _xCoordinator = Convert.ToInt16(X.Text);
            _yCoordinator = Convert.ToInt16(Y.Text);

            var circle = new Circle(_radius, _ratio, _xCoordinator, _yCoordinator);
            circle.ConfirmTheParameter();
        }
    }
}
