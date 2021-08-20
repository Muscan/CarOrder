using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CarOrder
{
    class Utils
    {
        public static bool IsChecked(RadioButton rdo1, RadioButton rdo2)
        {
            if (rdo1.Checked == true || rdo2.Checked == true)
            {
                return true;
            }
            return false;
        }

        public static bool CityIsSelected(ComboBox cmb)
        {
            if(cmb.SelectedIndex != -1)//if index is not selected,(lower than 0)
            {
                return true;
            }
            return false;
        }
        public static void ClearResult(Label lbl)
        {
            lbl.Text = "";
            lbl.Visible = false;
        }
        public static void ClearCity(ComboBox cmb)
        {
            cmb.SelectedIndex = -1;
        }

        public static void ClearButtons(RadioButton rdoBtn)
        {
            rdoBtn.Checked = false;
        }

        public static double CalculateOptions(RadioButton rdo1, Car carObject)
        {
            double sumOfCar = 0;
            if (rdo1.Checked == true)
            {
                sumOfCar += carObject.CarPrice;
            }
            return sumOfCar;
        }

        public static double CalculateOptions1(RadioButton rdo1, Engine engineObject)
        {
            double sumOfCar = 0;
            if (rdo1.Checked == true)
            {
                sumOfCar += engineObject.EnginePrice;
            }
            return sumOfCar;
        }

        public static double CalculateOptions2(RadioButton rdo1, Color colorObject)
        {
            double sumOfCar = 0;
            if (rdo1.Checked == true)
            {
                sumOfCar += colorObject.ColorPrice;
            }
            return sumOfCar;
        }

        public static string DisplayCarOption(RadioButton rdo1, Car carObject)
        {
            string result = "";
            if(rdo1.Checked == true)
            {
                result = "Selected car: ";
                result += carObject.CarName + ", Price " + carObject.CarPrice + " Euro\n";
            }
            return result;
        }


        public static string DisplayColorOption(RadioButton rdo1, Color colorObject)
        {
            string result = "";
            if (rdo1.Checked == true)
            {
                result = "Color: ";
                result += colorObject.ColorName + ", Price "+ colorObject.ColorPrice + " Euro\n";
            }
            return result;
        }

        public static string DisplayCombustionOption(RadioButton rdo1, Engine combustionObject)
        {
            string result = "";
            if (rdo1.Checked == true)
            {
                result = "Combustion: ";
                result += combustionObject.EngineCombustion + ", Price " + combustionObject.EnginePrice + " Euro\n";
            }
            return result;
        }

        public static string DisplayCity(ComboBox cmb, String[] CitiesToDeliver)
        {
            string resultCity = "City to deliver: ";
            resultCity += CitiesToDeliver[cmb.SelectedIndex] + "\n";
            /*switch (cmb.SelectedIndex)
            {
                case 0:
                    resultCity += CitiesToDeliver[0];
                    break;
                case 1:
                    resultCity += CitiesToDeliver[1];
                    break;
                
            }*/
            return resultCity;
        }

    }
}
