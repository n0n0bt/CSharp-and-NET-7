using Saturday_06_05;

Car car = new Car(10,5);

Truck truck = new Truck(100,10);

Console.WriteLine(car);
Console.WriteLine(truck);

car.Drive(10);
truck.Drive(10);

Console.WriteLine(car);
Console.WriteLine(truck);

car.Refuel(10);
truck.Refuel(10);

Console.WriteLine(car);
Console.WriteLine(truck);