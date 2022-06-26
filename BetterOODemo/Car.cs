namespace BetterOODemo
{
    public class Car : LandVehicle, IRental //ctrl+. -> implement an interface
    {
        public CarType Style { get; set; }
        public int RentalID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CurrentRenter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal PricePerDay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}