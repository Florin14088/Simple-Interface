using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public int numar =  1;
        public int numar2 = 2;
        public int suma;


        #region Initializare

        public Form1()
        {
            InitializeComponent();
        }

        #endregion


        #region Functii butoane
        private void TextBox_Results_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void btn_doStuff_Click(object sender, EventArgs e)//functia din spatele butonului
        {
            Function_1();
        }
        #endregion



        public void Function_1()
        {
            //Functie_2(numar, numar2);

            suma = Tests.Functie_2(numar, numar2);


            Console.WriteLine("Hi " + "I am Florin");
            Console.WriteLine($"Suma este: { suma.ToString()} ");
            

            this.TextBox_Results.Text ="Suma este: " + suma.ToString();//asta schimba textul din campul de text din fereastra care apare cand day Run la proiect/build
        }
       


        

    }//END - nu scrie nimic mai jos de paranteza asta

}
