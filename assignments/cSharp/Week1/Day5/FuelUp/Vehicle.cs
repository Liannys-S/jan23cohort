abstract class Vehicle {
    public string Name;
    int NumPassengers;
    string Color;
    bool HasEngine;
    int MilesTraveled;

    public Vehicle(string name, int numPassengers, string color, bool hasEngine){
        Name = name;
        NumPassengers = numPassengers;
        Color = color;
        HasEngine = hasEngine;
        MilesTraveled = 0;
    }
    public Vehicle(string name, string color){
        Name = name;
        Color = color;
        NumPassengers = 4;
        HasEngine = false;
        MilesTraveled = 0;
    }
    public void ShowInfo(){
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Number of passengers: {NumPassengers}");
        Console.WriteLine($"Vehicle Color: {Color}");
        Console.WriteLine($"Does it have an engine?: {HasEngine}");
        Console.WriteLine($"Mileage: {MilesTraveled}");
    }
    public void Travel(int miles){
        MilesTraveled += miles;
        Console.WriteLine($"Total miles {MilesTraveled}");
    }
}