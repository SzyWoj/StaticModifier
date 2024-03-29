namespace StaticModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Ferrari");
            Car car2 = new Car("Porsche");
            Car car3 = new Car("Ford");
            
            Console.WriteLine(Car.numberOfCars);

            Car.StartRace();



            Console.ReadKey();
        }
    }

    class Car
    {
        string model;
        public static int numberOfCars;

        public Car(string model)
        {
            this.model = model;
            numberOfCars++;
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
}
