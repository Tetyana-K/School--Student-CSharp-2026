using Inheritance_demo;


namespace Try_use_Vehicle_Car__Inheritance_
{
    internal class Bus : Vehicle
    {
        public int Seats { get; set; }
        public Bus(string brand, int year, int seats = 30) : base(brand, year)
        {
            Seats = seats;
        }
        public override void Move()
        {
            Console.WriteLine($"Bus '{Brand}' moves on road...");
        }
        public override string ToString()
        {
            //return $"Bus '{Brand}' {year} with {Seats} seats {speed}"; // помилка, якщо speed - private protected, для чужої збірки як private
            return $"Bus '{Brand}' {year} with {Seats} seats"; // помилка, якщо speed - private protected, для чужої збірки як private
        }
    }
}
