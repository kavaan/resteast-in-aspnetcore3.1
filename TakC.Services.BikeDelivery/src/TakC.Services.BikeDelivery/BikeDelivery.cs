using System;

namespace TakC.Services.BikeDelivery {
    public class BikeDelivery {
        public int Id { get; set; }
        public string MotorcycleModelName { get; set; }
        public string DriverFullName { get; set; }
        public long CostPerKilometer { get; set; }
    }
}