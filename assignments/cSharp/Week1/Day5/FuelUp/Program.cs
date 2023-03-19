Car toyota = new Car("Toyota","Red");
Bicycle mountainBike = new Bicycle("Mountain Bike", 1,"Blue");
Horse mustafa = new Horse("Mustafa", 1, "Brown");

//Vehicle test = new Vehicle(); // ERROR cannot create instance of the abstract type Vehicle
List<Vehicle> vehicleList = new List<Vehicle>();
vehicleList.Add(toyota);
vehicleList.Add(mountainBike);
vehicleList.Add(mustafa);

List<INeedFuel> needFuel = new List<INeedFuel>();

foreach(var vehicle in vehicleList){
    if(vehicle is INeedFuel){
        // needFuel.Add(vehicle); //ERROR this doesn't work. says vehicle is of type Vehicle
        // Console.WriteLine(vehicle); //shows Vehicle is type Horse or Car
        needFuel.Add((INeedFuel)vehicle); //chatGPT helped me realize that i needed to cast it like this in order to add it to the list 
    }
}
foreach(var vehicle in needFuel){
    vehicle.GiveFuel(10);
    Vehicle test = (Vehicle)vehicle; // needed to create in order to print name 
    Console.WriteLine($"{test.Name} has been fueled up. They now have {vehicle.FuelTotal} unit(s) of {vehicle.FuelType}.");
}
