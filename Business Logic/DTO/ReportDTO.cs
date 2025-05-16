namespace Business_Logic.DTO
{
    public class ReportDTO
    {
        public string MedicineName { get; set; }
        public int SoldQuantity { get; set; }
        public int AvailableQuantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
