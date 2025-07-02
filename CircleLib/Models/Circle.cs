using System.Windows;

namespace Circle_Drawing.Models
{
    public class Circle(double radius, int ratio, int xCoordinator, int yCoordinator)
    {
        private readonly double _radius = radius;
        private readonly int _ratio = ratio;
        private readonly int _xCoordinator = xCoordinator;
        private readonly int _yCoordinator = yCoordinator;

        public int ConfirmTheParameter()
        {
            try
            {
                MessageBox.Show($"{_radius}\n{_ratio}\n{_xCoordinator}\n{_yCoordinator}");
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }
    }
}
