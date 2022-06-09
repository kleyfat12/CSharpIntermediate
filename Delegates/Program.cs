namespace Delegates
{
    public delegate void MyDelegate(string m);

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bike bike = new Bike();

            MyDelegate myDelegate = new MyDelegate(car.CarPrintMessage);
            myDelegate("A super duper message");

            myDelegate = new MyDelegate(bike.BikePrintMessage);
            myDelegate("A boring message");

            Console.WriteLine(car.Message);
            Console.WriteLine(bike.Message);
        }
    }
}

