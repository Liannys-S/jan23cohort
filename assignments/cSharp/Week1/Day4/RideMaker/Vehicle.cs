class Vehicle {
    string Name;
    int NumPassengers;
    string Color;
    bool HasEngine;
    int MilesTraveled = 0;

    public Vehicle(string name, int numPassengers, string color, bool hasEngine){
        Name = name;
        NumPassengers = numPassengers;
        Color = color;
        HasEngine = hasEngine;
    }
    public Vehicle(string name, string color){
        Name = name;
        Color = color;
        NumPassengers = 0;
        HasEngine = false;
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