using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektZespolone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            float real1 = float.Parse(textBox1.Text); // Parse zamienia typ string na float, wpisywane liczby są na początku stingiem
            float imaginary1 = float.Parse(textBox2.Text);

            Zespolone zesp1 = new Zespolone(real1, imaginary1); // tworze nowy obiekt klasy, wiec musi byc new

            float real2 = float.Parse(textBox3.Text);
            float imaginary2 = float.Parse(textBox4.Text);

            Zespolone zesp2 = new Zespolone(real2, imaginary2);

            Zespolone wynik = zesp1.Odejmowanie(zesp2);

            label5.Text = zesp1.Wynik() + " + " + zesp2.Wynik() + " " + wynik.Wynik(); // wyswietlanie wyniku mojego dzialania

        }

        private void button1_Click(object sender, EventArgs e)
        {

            float real1 = float.Parse(textBox1.Text);
            float imaginary1 = float.Parse(textBox2.Text);

            Zespolone zesp1 = new Zespolone(real1, imaginary1);

            float real2 = float.Parse(textBox3.Text);
            float imaginary2 = float.Parse(textBox4.Text);

            Zespolone zesp2 = new Zespolone(real2, imaginary2);

            Zespolone wynik = zesp1.Dodawanie(zesp2);

            label5.Text = zesp1.Wynik() + " + " + zesp2.Wynik() + " " + wynik.Wynik();
        }
    }
}
