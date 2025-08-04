namespace prjICE_2_Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars cars = new Cars(100000, 1000, 230, "Porsche", "Blue");

            cars[3] = "Bugatti"; 

            Console.WriteLine("Cars price: R" + cars[0]);
            Console.WriteLine("Cars power: " + cars[1] + " Kw");
            Console.WriteLine("Cars speed: " + cars[2] + " Km");
            Console.WriteLine("Cars name: " + cars[3]);
            Console.WriteLine("Cars colour: " + cars[4]);
            Console.WriteLine("---------------------------------------");

            cars["power"] = 330;
            

            Console.WriteLine("Cars price: R" + cars["price"]);
            Console.WriteLine("Cars power: " + cars["power"] + " Kw");
            Console.WriteLine("Cars speed: " + cars["speed"] + " Km");
            Console.WriteLine("Cars name: " + cars["name"]);
            Console.WriteLine("Cars colour: " + cars["colour"]);
            Console.WriteLine("---------------------------------------");

            Cars car = new Cars(200000, 900, 330, "Bugatti", "Red");

            car[1] = 800;

            Console.WriteLine("Cars price: R" + car[0]);
            Console.WriteLine("Cars power: " + car[1] + " Kw");
            Console.WriteLine("Cars speed: " + car[2] + " Km");
            Console.WriteLine("Cars name: " + car[3]);
            Console.WriteLine("Cars colour: " + car[4]);
            Console.WriteLine("---------------------------------------");

            car["speed"] = 340;

            Console.WriteLine("Cars price: R" + car["price"]);
            Console.WriteLine("Cars power: " + car["power"] + " Kw");
            Console.WriteLine("Cars speed: " + car["speed"] + " Km");
            Console.WriteLine("Cars name: " + car["name"]);
            Console.WriteLine("Cars colour: " + car["colour"]);
        }
    }
}
