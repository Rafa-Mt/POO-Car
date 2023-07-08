namespace CarFactory {
    internal class Program {
        public static void Main(string[] args) {
            Car optra = new();

            Car cruze = new(
                brand: "Chevrolet",
                model: "Cruze",
                launchYear: 2016,
                color: "White",
                owner: "Rafael",
                hasAC: true,
                price: 8000f
            );

            Van camry = new(
                brand: "Toyota",
                model: "Camry Hybrid",
                color: "Black",
                launchYear: 2019,
                owner: "Marlon",
                hasAC: true,
                price: 8000f,
                extraSeats: 6,
                chargeCapacity: 3000f,
                hasSunRoof: true
            );

            Console.WriteLine("============================");
            Console.WriteLine(cruze.Describe());
            Console.WriteLine("============================");
            Console.WriteLine(optra.Describe());
            Console.WriteLine("============================");
            Console.WriteLine(camry.Describe());
            Console.WriteLine("============================");

            camry.TurnAC();
            camry.TurnAC();

        }
    }
}
