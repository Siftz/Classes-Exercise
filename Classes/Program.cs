namespace Classes
{
    public class Program
    {
        static void Main()
        {
            Car myCar = new Car(); //wifes car
            myCar.Make = "Toyota";
            myCar.Model = "Yaris";
            myCar.Year = 2009;

            Console.WriteLine("Make: " + myCar.Make);
            Console.WriteLine("Model: " + myCar.Model);
            Console.WriteLine("Year: " + myCar.Year);
        }
    }
}
