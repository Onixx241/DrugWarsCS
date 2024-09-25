using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrugWarsCS;

namespace DrugWarsCS
{
    //initial prices implemented, next implement buy/sell forms etc.
    public partial class Form2 : Form
    {
        
        public static Player play = new Player(Form1.Name);

        public Form2()
        {
            //label1=day,label2=money,label3=location
            InitializeComponent();

            label1.Text = 0.ToString();
            label2.Text = play.Money.ToString();
            label3.Text = play.CurrentLocation.ToString();
            //continue here with dictionary

            label6.Text = play.DrugPricePair["w"].ToString();

            label7.Text = play.DrugPricePair["c"].ToString();

            label10.Text = play.DrugPricePair["m"].ToString();

            label12.Text = play.DrugPricePair["h"].ToString();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            //advance day
            play.day += 1;

            label1.Text = play.day.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //buybutton
            BuyForm newbuy = new BuyForm();
            newbuy.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sellbutton
        }
    }

    public class Player
    {
        public string Name;
        public int InventorySpace { get; set; }
        public int day { get; set; }
        public int Money { get; set; }
        
        public Dictionary<string,int> DrugPricePair = new Dictionary<string,int>();


        // 0 = coke , 1 = weed, 2 = heroin, 3 = pills , 4 = meth
        public int[] drugs = { 0, 0, 0, 0 };

        public int Level { get; set; }//Implement this Last

        public Location CurrentLocation { get; set; }

        public Player(string name)
        {

            this.Name = name;
            this.Money = 5000;
            this.day = 0;
            this.CurrentLocation = Location.Bronx; 
            DrugPricePair.Add("w", this.RandomizePriceBetween(111,193));
            DrugPricePair.Add("WAmount", 0);
            DrugPricePair.Add("h", this.RandomizePriceBetween(418, 512));
            DrugPricePair.Add("HAmount", 0);
            DrugPricePair.Add("c", this.RandomizePriceBetween(700, 917));
            DrugPricePair.Add("CAmount", 0);
            DrugPricePair.Add("m", this.RandomizePriceBetween(215, 381));
            DrugPricePair.Add("MAmount", 0);
            Debug.Print("Player Created!\nPrices Generated!");
            
        }

        public void ChangeMoney(int amount)
        {
            this.Money += amount;
        }

        public void UpdateWPrice() 
        {
            this.DrugPricePair["w"] = this.RandomizePriceBetween(111, 193);
        }
        public void UpdateHPrice() 
        {
            this.DrugPricePair["h"] = this.RandomizePriceBetween(418, 512);
        }
        public void UpdateCPrice() 
        {
            this.DrugPricePair["c"] = this.RandomizePriceBetween(700, 917);
        }
        public void UpdateMPrice() 
        {
            this.DrugPricePair["m"] = this.RandomizePriceBetween(215, 381);
        }
        public void SpecificPriceSet(int price, string choice) 
        {
            this.DrugPricePair[choice] = price;
        }

        public int RollDice()
        {
            Random rando = new Random();
            return rando.Next(0, 10);
        }

        public int RandomizePriceBetween(int one,int two) 
        {
            Random price = new Random();
            int pricee = price.Next(one, two);
            return pricee;
        }

        public void LevelUp()
        {
            this.Level += 1;
        }

        public void AdvanceDay()
        {
            this.day += 1;
        }

        public void AddDrug(int index, int amount)
        {
            this.drugs[index] += amount;
        }


    }

    enum Drugs
    {
        Coke,
        Weed,
        Heroin,
        Meth
    }
    public enum Location
    {
        Bronx,
        Brooklyn,
        Manhattan,
        Queens
    }

}
