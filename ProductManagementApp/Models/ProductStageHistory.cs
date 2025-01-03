namespace ProductManagementApp.Models
{
    public class ProductStageHistory
    {
        public int Stage_Id { get; set; }
        public int Product_Id { get; set; }
        public DateTime Start_Of_Stage { get; set; }
        public int User_Id { get; set; }
    }
}
