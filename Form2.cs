using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            label1.Text = $"Day: {play.day}";
            label2.Text = $"Cash: {play.Money.ToString()}";
            label3.Text = play.CurrentLocation.ToString();
            

            label6.Text = play.DrugPricePair["w"].ToString();

            label7.Text = play.DrugPricePair["c"].ToString();

            label10.Text = play.DrugPricePair["m"].ToString();

            label12.Text = play.DrugPricePair["h"].ToString();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            //buybutton
            BuyForm newbuy = new BuyForm();
            newbuy.ShowDialog();
        }
        //merge these two ?
        private void button3_Click(object sender, EventArgs e)
        {
            //sellbutton
            SellForm newsell = new SellForm();
            newsell.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //bronx
            Debug.WriteLine("Button Pressed");

            play.CurrentLocation = DrugWarsCS.Location.Bronx;



            play.day += 1;

            label1.Text = $"Day: {play.day}";

            play.UpdateWPrice();
            play.UpdateCPrice();
            play.UpdateMPrice();
            play.UpdateHPrice();

            //update labels
            label6.Text = play.DrugPricePair["w"].ToString();

            label7.Text = play.DrugPricePair["c"].ToString();

            label10.Text = play.DrugPricePair["m"].ToString();

            label12.Text = play.DrugPricePair["h"].ToString();

            label3.Text = play.CurrentLocation.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //brooklyn 
            play.CurrentLocation = DrugWarsCS.Location.Brooklyn;

            Debug.WriteLine("Button Pressed");
            play.day += 1;

            label1.Text = $"Day: {play.day}";

            play.UpdateWPrice();
            play.UpdateCPrice();
            play.UpdateMPrice();
            play.UpdateHPrice();

            //update labels
            label6.Text = play.DrugPricePair["w"].ToString();

            label7.Text = play.DrugPricePair["c"].ToString();

            label10.Text = play.DrugPricePair["m"].ToString();

            label12.Text = play.DrugPricePair["h"].ToString();

            label3.Text = play.CurrentLocation.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //manhattan 

            Debug.WriteLine("Button Pressed");

            play.CurrentLocation = DrugWarsCS.Location.Manhattan;



            play.day += 1;

            label1.Text = $"Day: {play.day}";

            play.UpdateWPrice();
            play.UpdateCPrice();
            play.UpdateMPrice();
            play.UpdateHPrice();

            //update labels
            label6.Text = play.DrugPricePair["w"].ToString();

            label7.Text = play.DrugPricePair["c"].ToString();

            label10.Text = play.DrugPricePair["m"].ToString();

            label12.Text = play.DrugPricePair["h"].ToString();

            label3.Text = play.CurrentLocation.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //queens

            Debug.WriteLine("Button Pressed");

            play.CurrentLocation = DrugWarsCS.Location.Queens;



            play.day += 1;

            label1.Text = $"Day: {play.day}";

            play.UpdateWPrice();
            play.UpdateCPrice();
            play.UpdateMPrice();
            play.UpdateHPrice();

            //update labels
            label6.Text = play.DrugPricePair["w"].ToString();

            label7.Text = play.DrugPricePair["c"].ToString();

            label10.Text = play.DrugPricePair["m"].ToString();

            label12.Text = play.DrugPricePair["h"].ToString();

            label3.Text = play.CurrentLocation.ToString();
        }
    }

    public class Player
    {
        public string Name;
        public int InventorySpace { get; set; }
        public int day { get; set; }
        public int Money { get; set; }

        public uint LoanAmount = 0;

        public byte HighScore { get;set; }
        public byte MinScore { get;set; }

        public Dictionary<string,int> DrugPricePair = new Dictionary<string,int>();
        public Dictionary<string, uint> DrugAmountPair = new Dictionary<string, uint>();

        public int Level { get; set; }//Implement this Last, only award xp on drugs sold not bought

        public Location CurrentLocation { get; set; }
        public Player(string name)
        {

            this.Name = name;
            this.Money = 1500;
            this.HighScore = 0;
            this.MinScore = 0;
            this.day = 0;
            this.CurrentLocation = Location.Bronx; 
            DrugPricePair.Add("w", this.RandomizePriceBetween(111,193));

            DrugPricePair.Add("h", this.RandomizePriceBetween(418, 512));

            DrugPricePair.Add("c", this.RandomizePriceBetween(700, 917));

            DrugPricePair.Add("m", this.RandomizePriceBetween(215, 381));

            DrugAmountPair.Add("w", 0);
            DrugAmountPair.Add("h", 0);
            DrugAmountPair.Add("c", 0);
            DrugAmountPair.Add("m", 0);

            Debug.Print("Player Created!\nPrices Generated!");
            
        }

        public void ChangeMoney(int amount)
        {
            this.Money += amount;
        }

        public int UpdateWPrice() 
        {
            return this.DrugPricePair["w"] = this.RandomizePriceBetween(111, 193);
        }
        public int UpdateHPrice() 
        {
            return this.DrugPricePair["h"] = this.RandomizePriceBetween(418, 512);
        }
        public int UpdateCPrice() 
        {
            return this.DrugPricePair["c"] = this.RandomizePriceBetween(700, 917);
        }
        public int UpdateMPrice() 
        {
            return this.DrugPricePair["m"] = this.RandomizePriceBetween(215, 381);
        }
        public int SpecificPriceSet(int price, string choice) 
        {
            return this.DrugPricePair[choice] = price;
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

        //add skyrocket and tank price functions

    }

    
    public enum Location
    {
        Bronx,
        Brooklyn,
        Manhattan,
        Queens
    }

}
