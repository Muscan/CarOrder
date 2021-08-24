using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarOrder.Car;
using static CarOrder.Color;
using static CarOrder.Engine;
using static CarOrder.Utils;

namespace CarOrder
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void grpBoxEngine_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            Car carObject = new Car();
            carObject.CarName = "VW";
            carObject.CarPrice = 100000;
            Car carObject1 = new Car();
            carObject1.CarName = "Audi";
            carObject1.CarPrice = 5000;

            Color colorObject = new Color();
            colorObject.ColorName = "Red";
            colorObject.ColorPrice = 500;
            Color colorObject1 = new Color();
            colorObject1.ColorName = "White";
            colorObject1.ColorPrice = 251;

            Engine engineObject = new Engine();
            engineObject.EngineCombustion = "Diesel";
            engineObject.EnginePrice = 300;
            Engine engineObject1 = new Engine();
            engineObject1.EngineCombustion = "Benzin";
            engineObject1.EnginePrice = 111;


            rdoBtnAudi.Text   = carObject1.CarName; //+ " " + carObject1.CarPrice;
            rdoBtnVW.Text     = carObject.CarName;
            rdoBtnBenzin.Text = engineObject1.EngineCombustion;
            rdoBtnDiesel.Text = engineObject.EngineCombustion;
            rdoBtnRed.Text    = colorObject.ColorName;
            rdoBtnWhite.Text  = colorObject1.ColorName;

            string[] Cities = { "Cluj", "Iasi", "Brasov", "Arad" };


            if (IsChecked(rdoBtnAudi, rdoBtnVW) == false)
            {
                MessageBox.Show("Pick a car");
            }
            else if (IsChecked(rdoBtnDiesel, rdoBtnBenzin) == false)
            {
                MessageBox.Show("Pick a combustion");
            }
            else if (IsChecked(rdoBtnRed, rdoBtnWhite) == false)
            {
                MessageBox.Show("Pick a color");
            }
            else if (CityIsSelected(cmbBoxCity) == false)
            {
                MessageBox.Show("Pick a city");
            }
            else
            {
                double sumOfCar = 0;
                string result = "        ---Your configuration---\n";
                string totalPrice = "Total price is: ";

                result   += DisplayCarOption(rdoBtnAudi, carObject1);
                result   += DisplayCarOption(rdoBtnVW, carObject);
                result   += DisplayColorOption(rdoBtnRed, colorObject);
                result   += DisplayColorOption(rdoBtnWhite, colorObject1);
                result   += DisplayCombustionOption(rdoBtnDiesel, engineObject);
                result   += DisplayCombustionOption(rdoBtnBenzin, engineObject1);
                result   += DisplayCity(cmbBoxCity, Cities);
                sumOfCar += CalculateOptions(rdoBtnVW, carObject);
                sumOfCar += CalculateOptions(rdoBtnAudi, carObject1);
                sumOfCar += CalculateOptions1(rdoBtnDiesel, engineObject);
                sumOfCar += CalculateOptions1(rdoBtnBenzin, engineObject1);
                sumOfCar += CalculateOptions2(rdoBtnRed, colorObject);
                sumOfCar += CalculateOptions2(rdoBtnWhite, colorObject1);


                result += totalPrice + sumOfCar;

                lblResults.Visible = true;
                lblResults.Text = result;

            }
        }

        private void rdoBtnVW_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearResult(lblResults);
            ClearButtons(rdoBtnBenzin);
            ClearButtons(rdoBtnDiesel);
            ClearButtons(rdoBtnVW);
            ClearButtons(rdoBtnAudi);
            ClearButtons(rdoBtnRed);
            ClearButtons(rdoBtnWhite);
            ClearCity(cmbBoxCity);

        }
    }
}
