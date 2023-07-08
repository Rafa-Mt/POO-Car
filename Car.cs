namespace CarFactory {
    public class Car {
        // * Private Properties
        private string model;
        private string brand;
        private string color;
        private int launchYear;
        private string owner;
        private bool hasAC;
        private double price;
        private bool ACTurned;

        // * Public Properties (Getters & Setters)
        public string Model { get => this.model; }
        public string Brand { get => this.brand; }
        public string Color {
            get => this.color;
            set {
                List<string> Colors = new() {
                    "red", "blue", "green", "yellow", "purple",
                    "black", "white", "orange", "gray"
                };

                string candidate = value.ToLower();
                if (Colors.Contains(candidate)) 
                    this.color = candidate;
            }
        }
        public int LaunchYear { get => this.launchYear; }
        public string Owner { 
            get => this.owner;
            set {
                if (value == null) return;
                this.owner = value;
                Console.WriteLine($"Owner changed to: {value}");
            }
        }
        public string HasAC {
            get => $"This car {(this.hasAC ? "has" : "doesn't have")} an AC";
            set {
                bool prompt = value.ToLower() == "yes";
                this.hasAC = prompt;
                Console.WriteLine($"This car now {(prompt ? "has" : "doesn't have")} an AC");
            }
        }
        public double Price {
            get => this.price + (this.hasAC ? 2000f : -500f);
        }

        // * Constructors
        public Car() {
            this.model = "Optra";
            this.brand = "Toyota";
            this.color = "Gray";
            this.launchYear = 2015;
            this.owner = "Eli Mora"; 
            this.hasAC = false;
            this.price = 5000f;
            this.ACTurned = false;
        }
        public Car(string model, string brand, string color, int launchYear, string owner, bool hasAC, double price) {
            this.model = model;
            this.brand = brand;
            this.color = color;
            this.launchYear = launchYear;
            this.owner = owner;
            this.hasAC = hasAC;
            this.price = price;
            this.ACTurned = false;
        }

        // * Methods
        public virtual void Drive() {
            Console.WriteLine("Driving car...");
        }

        public void TurnAC() {
            if (!this.hasAC) {
                Console.WriteLine("This car doesn't have an AC");
                return;
            }
            this.ACTurned = !this.ACTurned;
            Console.WriteLine($"Turning {this.brand} {this.model}'s AC {(this.ACTurned ? "on" : "off")}...");
        }

        public virtual string Describe() {
            return $"Vehicle: {this.brand} {this.model}\n" +
                   $"Year: {this.launchYear}\n" +
                   $"Color: {this.color}\n" +
                   $"Owner: {this.owner}\n" +
                   "Type: Car";

        }
    }
}