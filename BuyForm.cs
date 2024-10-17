using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugWarsCS
{
    public partial class BuyForm : Form
    {

        public BuyForm()
        {
            InitializeComponent();
            label3.Text = $"Cash: {Form2.play.Money}";
            label7.Text = Form2.play.DrugAmountPair["w"].ToString();
            label6.Text = Form2.play.DrugAmountPair["c"].ToString();
            label5.Text = Form2.play.DrugAmountPair["m"].ToString();
            label4.Text = Form2.play.DrugAmountPair["h"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuyDrug("w");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //convertible not working !
            try
            {
                BuyDrug("c");
            }
            //fix Iconvertible/Casting issue. 
            catch
            {
                Debug.WriteLine("Not Working");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuyDrug("m");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuyDrug("h");
        }

        private void BuyDrug(string DrugLetter)
        {
            //fix going to zero issue, if not add a debt system or something.
            try 
            {
                if (textBox1 != null && Convert.ToInt32(textBox1.Text) > 0 && Form2.play.Money > Form2.play.DrugPricePair[DrugLetter] && Form2.play.Money != 0 && Form2.play.Money > 0)
                {

                    switch (DrugLetter)
                    {
                        case "h":
                            //if(Drugpricepair * amount > money or money not enough do not run , try wrapping every case in this if else statement)
                            try
                            {
                                Form2.play.DrugAmountPair["h"] += Convert.ToUInt32(textBox1.Text);
                                Form2.play.Money -= Form2.play.DrugPricePair["h"] * Convert.ToInt32(textBox1.Text);
                                Form2.label2.Text = $"Cash: {Form2.play.Money}";
                                label3.Text = $"Cash: {Form2.play.Money}";
                                label4.Text = Form2.play.DrugAmountPair["h"].ToString();
                            }

                            catch
                            {
                            }

                            break;

                        case "c":
                            try
                            {
                                Form2.play.DrugAmountPair["c"] += Convert.ToUInt32(textBox1.Text);
                                Form2.play.Money -= Form2.play.DrugPricePair["c"] * Convert.ToInt32(textBox1.Text);
                                Form2.label2.Text = $"Cash: {Form2.play.Money}";
                                label3.Text = $"Cash: {Form2.play.Money}";
                                label6.Text = Form2.play.DrugAmountPair["c"].ToString();
                            }
                            catch
                            {
                            }

                            break;

                        case "m":

                            try
                            {
                                Form2.play.DrugAmountPair["m"] += Convert.ToUInt32(textBox1.Text);
                                Form2.play.Money -= Form2.play.DrugPricePair["m"] * Convert.ToInt32(textBox1.Text);
                                Form2.label2.Text = $"Cash: {Form2.play.Money}";
                                label3.Text = $"Cash: {Form2.play.Money}";
                                label5.Text = Form2.play.DrugAmountPair["m"].ToString();
                            }
                            catch
                            {
                            }

                            break;

                        case "w":

                            try
                            {
                                Form2.play.DrugAmountPair["w"] += Convert.ToUInt32(textBox1.Text);
                                Form2.play.Money -= Form2.play.DrugPricePair["w"] * Convert.ToInt32(textBox1.Text);
                                Form2.label2.Text = $"Cash: {Form2.play.Money}";
                                label3.Text = $"Cash: {Form2.play.Money}";
                                label7.Text = Form2.play.DrugAmountPair["w"].ToString();
                            }
                            catch
                            {
                                Debug.WriteLine("Catch Exception Working !");
                                Debug.WriteLine("Text in amount box detected!");
                            }

                            break;
                    }
                }
            }
            catch 
            {
            }
        }

        
    }
}
