namespace ProductManagementApp.Models
{
    public class Material
    {
        public int Material_Number { get; set; }
        public string Material_Description { get; set; }
        public double Weight { get; set; }  // Schimbat din float în double
        public double Width { get; set; }   // Schimbat din float în double
        public double Height { get; set; }  // Schimbat din float în double
    }
}
