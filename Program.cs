



using UPcastingDowncasting.Models;

Vehichle car = new Car();
Vehichle bus = new Bus();
if (car is Car)
{
    Car car2 = (Car)car;
    Console.WriteLine("Car-dir");
}
else
{
    Console.WriteLine("Car deyil");
}


if (bus is Bus)
{
    Bus bus2 = (Bus)bus;
    Console.WriteLine("Busdur");
}
else
{
    Console.WriteLine("Bus deyil");
}



Car car1 = new Car();
car1.Price = 48234;
Car car3 = new Car();
car3.Price = 56785;
Console.WriteLine(car1>car3);
Console.WriteLine(car1 < car3);
