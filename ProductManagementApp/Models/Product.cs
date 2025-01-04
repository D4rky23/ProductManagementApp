namespace ProductManagementApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Estimated_Height { get; set; } // Schimbat din float în double
        public double Estimated_Width { get; set; }  // Schimbat din float în double
        public double Estimated_Weight { get; set; } // Schimbat din float în double
        public int BOM_Id { get; set; }
    }
}
