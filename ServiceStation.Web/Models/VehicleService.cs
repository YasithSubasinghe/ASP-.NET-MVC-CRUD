namespace ServiceStation.Web.Models
{
    public class VehicleService
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public Boolean IsDeleted { get; set; } = false; //default value
    }
}
