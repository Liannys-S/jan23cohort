class Horse : Vehicle, INeedFuel
{
    public string FuelType{get;set;}
    public int FuelTotal{get;set;}
    public Horse(string name, int numPassengers, string color) : base(name, numPassengers, color, false)
    {
        FuelType = "Hay";
        FuelTotal = 10;
    }
    public void GiveFuel(int amount){
        FuelTotal += amount;
        Console.WriteLine($"Nom, Nom! Thanks for the {amount} unit(s) of delicious {FuelType}.");
    }
}