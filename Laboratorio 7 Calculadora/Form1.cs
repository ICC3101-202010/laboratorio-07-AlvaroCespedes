using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_7_Calculadora
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        //Ahora llamamos a las clases que creamos.
        Clases.Suma obj = new Clases.Suma();
        Clases.Resta obj2 = new Clases.Resta();
        Clases.Multiplicacion obj3 = new Clases.Multiplicacion();
        Clases.Division obj4 = new Clases.Division();

        Clases.Ans obj5 = new Clases.Ans();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Es el numero 7
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e) //Es el numero 8 
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void button5_Click(object sender, EventArgs e) //Es el numero 5
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e) // Es el numero 3
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";  //Al momento que presionemos el boton 0 aparecera el 
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void btnPto_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ".";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(Pantalla.Text); //El primero valor lo convierte a double.
            Pantalla.Clear();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(Pantalla.Text); //El primero valor lo convierte a double.
            Pantalla.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(Pantalla.Text); //El primero valor lo convierte a double.
            Pantalla.Clear();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(Pantalla.Text); //El primero valor lo convierte a double.
            Pantalla.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Pantalla.Text);

            //Declaramos las operaciones
            double sum;
            double rest;
            double multi;
            double div;

            switch(operador)
            {
                case "+":
                    sum = obj.Sumar((primero), (segundo));
                    //queremos que aparezca en la pantalla
                    Pantalla.Text = sum.ToString(); //PAra que aparezca en pantalla y transformamos a string
                    break;

                case "-":
                    rest = obj2.Restar(primero, segundo);
                    //queremos que aparezca en la pantalla
                    Pantalla.Text = rest.ToString();
                    break;

                case "*":
                    multi = obj3.Multiplicar(primero, segundo);
                    //queremos que aparezca en la pantalla
                    Pantalla.Text = multi.ToString();
                    break;

                case "/":
                    div = obj4.Dividir(primero, segundo);
                    //queremos que aparezca en la pantalla
                    Pantalla.Text = div.ToString();
                    break;
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            Pantalla.Clear(); // Limpiamos la pantalla.
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length == 1)
                Pantalla.Text = "";
            else
                Pantalla.Text = Pantalla.Text.Substring(0, Pantalla.Text.Length - 1);
        }

        private void btnAns_Click(object sender, EventArgs e)// Tiene que retornar el valor que quedo guardado despues de apretar =.
        {

        }
    }
}
