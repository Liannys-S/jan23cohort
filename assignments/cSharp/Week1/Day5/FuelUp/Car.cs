class Car : Vehicle, INeedFuel
{
    public string FuelType {get;set;}
    public int FuelTotal {get;set;}
    public Car(string name, string color) : base(name, color)
    {
        FuelType = "Gasoline";
        FuelTotal = 10;
    }
    public void GiveFuel(int amount){
        FuelTotal += amount;
        Console.WriteLine($"Gulp, Gulp! Thanks for the {amount} unit(s) of {FuelType}.");
    }
}