namespace ProductManagementApp.Models
{
    public class BOM_Material
    {
        public int Material_Number { get; set; }
        public int BOM_Id { get; set; }
        public double Qty { get; set; }             // Schimbat din float în double
        public string Unit_Measure_Code { get; set; }
    }
}
