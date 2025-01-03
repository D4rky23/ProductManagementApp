namespace ProductManagementApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Estimated_Height { get; set; }
        public float Estimated_Width { get; set; }
        public float Estimated_Weight { get; set; }
        public int BOM_Id { get; set; }
    }
}
