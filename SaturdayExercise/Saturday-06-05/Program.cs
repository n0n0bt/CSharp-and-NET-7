using Saturday_06_05;

Car car = new Car(50,5);

Truck truck = new Truck(100,10);

Console.WriteLine(car);
Console.WriteLine(truck);

car.Drive(100);
truck.Drive(100);

Console.WriteLine(car);
Console.WriteLine(truck);

car.Refuel(10);
truck.Refuel(10);
car.Drive(10);
Console.WriteLine(car);
Console.WriteLine(truck);