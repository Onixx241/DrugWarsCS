namespace DrugWarsCS
{
    public class Player 
    {
        public string Name;

        public int Money {  get; set; }

        public int Level { get; set; }//Implement this Last

        public Player(string name) 
        {

            this.Name = name;
            this.Money = 0;

        }

        public void ChangeMoney(int amount) 
        {
            this.Money += amount;
        }

        public int RollDice() 
        {
            Random rando = new Random();
            return rando.Next(0, 10);
        }
    }
    public static class Program
    {
        
        [STAThread]

        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}