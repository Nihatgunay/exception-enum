namespace enum_car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("mercedes", "23", Type.Sedan);
            Car car2 = new Car("bmw", "3", Type.SUV);
            Console.WriteLine(car1);
            Console.WriteLine(car2);
        }
    }
}
