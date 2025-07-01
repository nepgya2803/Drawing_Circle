using System.Windows;

namespace Circle_Drawing.Models
{
    public class Circle(double radius, int ratio, int xCoordinator, int yCoordinator)
    {
        private readonly double radius = radius;
        private readonly int ratio = ratio;
        private readonly int X_coordinator = xCoordinator;
        private readonly int Y_coordinator = yCoordinator;

        public int ConfirmTheParameter()
        {
            try
            {
                MessageBox.Show($"{radius}\n{ratio}\n{X_coordinator}\n{Y_coordinator}");
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
