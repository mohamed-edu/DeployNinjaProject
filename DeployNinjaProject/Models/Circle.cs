using System.Security.Principal;

namespace DeployNinjaProject.Models
{
    public class Circle
    {
        public double Radius { get; set; }
        public double GetCircumference() { return 2 * Math.PI * Radius; }

        public double GetArea() { return Math.PI * Math.Pow(Radius, 2); }

    }
}
