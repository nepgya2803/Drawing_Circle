using System.Windows;

namespace Circle_Drawing
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Startup_Show(object sender, StartupEventArgs ev)
        {
            if (OperatingSystem.IsLinux()) throw new Exception("Os is not compatible");

            var wnd = new MainWindow
            {
                Title = "Circle Drawing",
                Height = 800,
                Width = 600
            };

            wnd.Show();
        }
    }
}
