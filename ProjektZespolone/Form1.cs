﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private int potegaI(int potega) //nazwa metody, nazwa zmiennej przekazywanej do tej metody
        {
            int modulo = potega % 4;
            if (modulo == 1)
                return 1;
            else if (modulo == 2)
                return -1;
            else if (modulo == 3)
                return -1;
            else
                return 1;
        }

        private void button2_Click_1(object sender, EventArgs e) 
        {
            string imagText1 = textBox2.Text; // .Text odnosi się do wartości, która jest tam wpisana
            string imagText2 = textBox4.Text;
            if (!imagText1.Contains('i') || !imagText2.Contains('i')) //equal w javie
            {
                MessageBox.Show("Pole liczby urojonej musi zawierać i", "UWAGA!"); 
                return;
            }
            float real1 = float.Parse(textBox1.Text); // Parse zmienia typ string na float 
            string[] ri = textBox2.Text.Split('i'); // tak jakby dzieli nam na 2 obszary, split dzieli mi na real i imaginary (po lewej od i/ po prawej od i)

            int liczba = int.Parse(ri[0]);// 0 to moja liczba urojona, 1 to potęga i
            int potega = 1; // defaultowo i 
            if (ri[1].Length >= 1) //  pokazuje czy jest jakas potega 
                potega = int.Parse(ri[1]); 
            int znakpotegi = potegaI(potega); // zwraca czy to jest 1 czy -1
            Zespolone zesp1; // bez tego obiekt w ifie nie jest widoczny, nie działało mi coś
            if (potega % 2 == 0)
            {
                real1 += int.Parse(ri[0]) * znakpotegi; // znak potęgi musi być intem, bo inaczej lipka
                zesp1 = new Zespolone(real1, 0); // 0, bo wartosc urojona sie uprościła do rzeczywistej,  
            }
            else
            {
                zesp1 = new Zespolone(real1, liczba * znakpotegi);
            }
            float real2 = float.Parse(textBox3.Text);
            string[] ri2 = textBox4.Text.Split('i');

            int liczba2 = int.Parse(ri2[0]);
            int potega2 = 1;
            if (ri2[1].Length >= 1)
                potega2 = int.Parse(ri2[1]);
            int znakpotegi2 = potegaI(potega2);
            Zespolone zesp2;
            if (potega2 % 2 == 0) // jeśli potega przy i jest parzysta, tzn. ze nie ma czesci urojonej, bo zostala zredukowana
            {
                real2 += int.Parse(ri2[0]) * znakpotegi2;
                zesp2 = new Zespolone(real2, 0);
            }
            else 
                zesp2 = new Zespolone(real2, liczba2 * znakpotegi2);

            Zespolone wynik = zesp1.Odejmowanie(zesp2); // zwracamy nowy obiekt, ktory jest wynikiem odejmowania tych dwóch poprzednich
            label5.Text = zesp1.Wynik() + " - " + zesp2.Wynik() + " = " + wynik.Wynik();
            File.AppendAllText("Wynik.txt", "Wynik odejmowania: " + wynik.Wynik() + " ");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string imagText1 = textBox2.Text; 
            string imagText2 = textBox4.Text;
            if (!imagText1.Contains('i') || !imagText2.Contains('i')) 
            {
                MessageBox.Show("Pole liczby urojonej musi zawierać i", "UWAGA!"); 
                return;
            }
            float real1 = float.Parse(textBox1.Text); 
            string[] ri = textBox2.Text.Split('i'); 

            int liczba = int.Parse(ri[0]);
            int potega = 1; 
            if (ri[1].Length >= 1) 
                potega = int.Parse(ri[1]); 
            int znakpotegi = potegaI(potega); 
            Zespolone zesp1; 
            if (potega % 2 == 0)
            {
                real1 += int.Parse(ri[0]) * znakpotegi;
                zesp1 = new Zespolone(real1, 0);   
            }
            else
            {
                zesp1 = new Zespolone(real1, liczba * znakpotegi);
            }
            float real2 = float.Parse(textBox3.Text);
            string[] ri2 = textBox4.Text.Split('i');

            int liczba2 = int.Parse(ri2[0]);
            int potega2 = 1;
            if (ri2[1].Length >= 1)
                potega2 = int.Parse(ri2[1]);
            int znakpotegi2 = potegaI(potega2);
            Zespolone zesp2;
            if (potega2 % 2 == 0)
            {
                real2 += int.Parse(ri2[0]) * znakpotegi2;
                zesp2 = new Zespolone(real2, 0);
            }
            else
                zesp2 = new Zespolone(real2, liczba2 * znakpotegi2);

            Zespolone wynik = zesp1.Dodawanie(zesp2); // zwracamy nowy obiekt, ktory jest wynikiem dodawania tych dwóch poprzednich
            label5.Text = zesp1.Wynik() + " + " + zesp2.Wynik() + " = " + wynik.Wynik();
            File.AppendAllText("Wynik.txt", "Wynik dodawania: " + wynik.Wynik()+ " ");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string imagText1 = textBox2.Text; 
            string imagText2 = textBox4.Text;
            if (!imagText1.Contains('i') || !imagText2.Contains('i')) 
            {
                MessageBox.Show("Pole liczby urojonej musi zawierać i", "UWAGA!");
                return;
            }
            float real1 = float.Parse(textBox1.Text); 
            string[] ri = textBox2.Text.Split('i'); 

            int liczba = int.Parse(ri[0]);
            int potega = 1; 
            if (ri[1].Length >= 1) 
                potega = int.Parse(ri[1]); 
            int znakpotegi = potegaI(potega); 
            Zespolone zesp1; 
            if (potega % 2 == 0)
            {
                real1 += int.Parse(ri[0]) * znakpotegi;
                zesp1 = new Zespolone(real1, 0); 
            }
            else
            {
                zesp1 = new Zespolone(real1, liczba * znakpotegi);
            }
            float real2 = float.Parse(textBox3.Text);
            string[] ri2 = textBox4.Text.Split('i');

            int liczba2 = int.Parse(ri2[0]);
            int potega2 = 1;
            if (ri2[1].Length >= 1)
                potega2 = int.Parse(ri2[1]);
            int znakpotegi2 = potegaI(potega2);
            Zespolone zesp2;
            if (potega2 % 2 == 0)
            {
                real2 += int.Parse(ri2[0]) * znakpotegi2;
                zesp2 = new Zespolone(real2, 0);
            }
            else
                zesp2 = new Zespolone(real2, liczba2 * znakpotegi2);

            Zespolone wynik = zesp1.Mnozenie(zesp2); // zwracamy nowy obiekt, ktory jest wynikiem mnożenia tych dwóch poprzednich
            label5.Text = zesp1.Wynik() + " * " + zesp2.Wynik() + " = " + wynik.Wynik();
            File.AppendAllText("Wynik.txt", "Wynik mnożenia: " + wynik.Wynik() + " ");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string imagText1 = textBox2.Text; 
            string imagText2 = textBox4.Text;
            if (!imagText1.Contains('i') || !imagText2.Contains('i')) 
            {
                MessageBox.Show("Pole liczby urojonej musi zawierać i", "UWAGA!");
                return;
            }
            float real1 = float.Parse(textBox1.Text); 
            string[] ri = textBox2.Text.Split('i'); 

            int liczba = int.Parse(ri[0]);
            int potega = 1; 
            if (ri[1].Length >= 1) 
                potega = int.Parse(ri[1]); 
            int znakpotegi = potegaI(potega); 
            Zespolone zesp1; 
            if (potega % 2 == 0)
            {
                real1 += int.Parse(ri[0]) * znakpotegi;
                zesp1 = new Zespolone(real1, 0); 
            }
            else
            {
                zesp1 = new Zespolone(real1, liczba * znakpotegi);
            }
            float real2 = float.Parse(textBox3.Text);
            string[] ri2 = textBox4.Text.Split('i');

            int liczba2 = int.Parse(ri2[0]);
            int potega2 = 1;
            if (ri2[1].Length >= 1)
                potega2 = int.Parse(ri2[1]);
            int znakpotegi2 = potegaI(potega2);
            Zespolone zesp2;
            if (potega2 % 2 == 0)
            {
                real2 += int.Parse(ri2[0]) * znakpotegi2;
                zesp2 = new Zespolone(real2, 0);
            }
            else
                zesp2 = new Zespolone(real2, liczba2 * znakpotegi2);

            Zespolone wynik = zesp1.Mnozenie(zesp2); // zwracamy nowy obiekt, ktory jest wynikiem mnożenia tych dwóch poprzednich
            label5.Text = zesp1.Wynik() + " * " + zesp2.Wynik() + " = " + wynik.Wynik();
            File.AppendAllText("Wynik.txt", "Wynik mnożenia: " + wynik.Wynik() + " ");
        }
        
    }
}
