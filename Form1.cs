using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace DrugWarsCS
{
    
    public partial class Form1 : Form
    {
        public static string Name { get; set; }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "hello")
            {
                Debug.WriteLine("Working");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1.Name = textBox1.Text;
            Debug.WriteLine(Form1.Name);
            Debug.WriteLine("Name Changed and assigned to player instance ! Move onto next Form !");
            button1.Enabled = false;
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();

        }
    }

}