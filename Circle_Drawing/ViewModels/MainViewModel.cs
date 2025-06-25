using System.Windows;
using System.Windows.Input;
using Circle_Drawing.Commands;

namespace Circle_Drawing.ViewModels
{
    public class MainViewModel
    {
        public ICommand ShowMessageCommand { get; }

        public MainViewModel()
        {
            ShowMessageCommand = new RelayCommand(_ => ShowMessage());
        }

        private void ShowMessage()
        {
            MessageBox.Show("You clicked the button!");
        }
    }
}