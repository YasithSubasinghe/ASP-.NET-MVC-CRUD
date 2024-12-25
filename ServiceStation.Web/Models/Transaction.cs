namespace ServiceStation.Web.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int VehicleId { get; set; } // Foreign key
        public int VehicleServiceId { get; set; } // Foreign key
        public int CustomerId { get; set; } // Foreign key
        public int EmployeeId { get; set; } // Foreign key
        public bool IsDeleted { get; set; } = false;
        public TransactionStatus Status { get; set; } = TransactionStatus.New;
    }
}
