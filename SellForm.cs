﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugWarsCS
{
    public partial class SellForm : Form
    {
        public SellForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SellDrug("w");
        }
        //try to keep switch totally organized, everything should be clear and serve a clear purpose.
        public void SellDrug(string DrugLetter)
        {
            if (textBox1.Text != null && Convert.ToInt32(textBox1.Text) >= 1 && Form2.play.DrugAmountPair[DrugLetter] >= Convert.ToUInt32(textBox1.Text))
            {
                // weed selling is working , however it is selling for way too much .
                // maybe it has to do with the multiplication of the amount by the price.
                // if i have 2 and im selling each at 150 i should get back 300 so thats amount * price so why isnt it working.
                switch (DrugLetter)
                {

                    case "w":
                        Debug.WriteLine("this is working!");
                        Form2.play.DrugAmountPair[DrugLetter] -= Convert.ToUInt32(textBox1.Text);


                        //unsigned int by signed int multiplication messing it up maybe ?
                        Debug.WriteLine($"");
                        Debug.WriteLine($"{textBox1.Text}");
                        Debug.WriteLine($"{Form2.play.DrugPricePair["w"]}");
                        Debug.WriteLine($"Amount Back: {Convert.ToInt32(textBox1.Text) * Convert.ToInt32(Form2.play.DrugPricePair["w"])}");


                        Form2.play.Money += Convert.ToInt32(textBox1.Text) * Convert.ToInt32(Form2.play.DrugPricePair[DrugLetter]);
                        Form2.label2.Text = $"Cash: {Form2.play.Money}";
                        label3.Text = $"Cash: {Form2.play.Money}";
                        label7.Text = Form2.play.DrugAmountPair[DrugLetter].ToString();
                        break;
                }

            }
        }

        
    }

}
