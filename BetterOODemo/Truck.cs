namespace BetterOODemo
{
    public class Truck : LandVehicle, IRental
    {
        public TruckType Style { get; set; }
        public int RentalID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CurrentRenter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal PricePerDay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}