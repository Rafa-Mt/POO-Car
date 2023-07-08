namespace CarFactory {
    public class Van : Car {
        // * Private extra properties
        private int extraSeats;
        private double chargeCapacity;
        private bool hasSunroof;

        // * Public extra properties (Getters & Setters)
        public int ExtraSeats { get => this.extraSeats; }
        public double ChargeCapacity { get => this.chargeCapacity; }
        public string HasSunRoof {
            get => $"This van {(this.hasSunroof ? "has" : "doesn't have")} sun roof";
        }

        // * Constructors
        public Van() : base() { 
            this.extraSeats = 4;
            this.chargeCapacity = 100.0f;
            this.hasSunroof = true;
        }

        public Van(string model, string brand, string color, int launchYear, string owner, bool hasAC, double price, int extraSeats, double chargeCapacity, bool hasSunRoof) 

        : base(model, brand, color, launchYear, owner, hasAC, price) {
            this.extraSeats = extraSeats;
            this.chargeCapacity = chargeCapacity;
            this.hasSunroof = hasSunRoof;
        }

        // * Methods
        public override void Drive()
        {
            Console.WriteLine("Driving van...");
        }

        public override string Describe()
        {
            return $"{base.Describe().Replace("Car", "Van")} \n" +
                   $"Extra seats: {this.extraSeats}\n" +
                   $"Charge capacity: {this.chargeCapacity} Kg\n" +
                   $"The van {(this.hasSunroof ? "has" : "doesn't have")} a sun roof";

        }
    }
}