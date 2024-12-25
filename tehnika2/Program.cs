using System;

namespace tehnika2
{
    class BitavoyaTehnika
    {
        private string brand;
        protected double power;
        private string turn;

        public string GetBrand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Turn
        {
            get { return turn; }
            set { turn = value; }
        }

        public void TurnOn(string action)
        {
            Turn = action;
            Console.WriteLine("Turn on : " + Turn);
        }

        public void TurnOff(string action)
        {
            Turn = action;
            Console.WriteLine("Turn off: "+Turn);
        }
    }

    class Holodelnik : BitavoyaTehnika
    {
        public Holodelnik()
        {
            GetBrand = "Samsung";
            power = 20;
            TurnOn("on");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Бренд: {GetBrand}, Мощность: {power}, Состояние: {Turn}");
        }
    }

    class St : BitavoyaTehnika
    {
        public St()
        {
            GetBrand = "LG";
            power = 10;
            TurnOff("off");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Бренд: {GetBrand}, Мощность: {power}, Состояние: {Turn}");
        }
    }

    
        
    

    class Program
    {
        static void Main(string[] args)
        {
            Holodelnik holodelnik = new Holodelnik();
            holodelnik.ShowInfo();
            
            
            Console.WriteLine();
            
            St st = new St();
            st.ShowInfo();
            
            
            
        }
    }
}