using System.Diagnostics;

namespace DrugWarsCS
{

    public partial class Form1 : Form
    {
        Player player = new Player("Onix");
        public Form1()
        {
            InitializeComponent();

        }

    }

    public class Player
    {
        //starting values
        public string Name;

        public int Money { get; set; }

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
}
