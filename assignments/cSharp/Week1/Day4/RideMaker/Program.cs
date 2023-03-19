Vehicle car = new Vehicle("Car",2,"Red",true);
Vehicle bike = new Vehicle("Bike",1,"Blue",false);
Vehicle truck = new Vehicle("Truck",2,"White",true);
Vehicle skateboard = new Vehicle("Skateboard", "Black");

List<Vehicle> vehicleList = new List<Vehicle>();
vehicleList.Add(car);
vehicleList.Add(bike);
vehicleList.Add(truck);
vehicleList.Add(skateboard);

foreach(var vehicle in vehicleList){
    vehicle.ShowInfo();
    Console.WriteLine("----------------");
}

car.Travel(100);
car.ShowInfo();
