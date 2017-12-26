using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;
namespace LoginForm.Services
{

    class OtherDateValidationFunction
    {
        string format = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
        DateTime CurrDate;
        TextBox text;
        /// <summary>
        /// Function for date validation
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="isFormCompany"></param>
        /// <returns></returns>
        public bool DateValidationFunction(TextBox txt, bool isFormCompany)
        {
            // While creating comany no curent date
            DateTime dtcurrentdate;
            if (isFormCompany)
                dtcurrentdate = System.DateTime.Today;
            else
                dtcurrentdate = DateTime.Now.Date;
            bool isValid = true;
            string option = string.Empty;
            string[] date = new string[50];
            this.text = txt;
            try
            {
                foreach (char ch in txt.Text)
                {
                    if (ch == '.')
                    {
                        option = ".";
                    }
                    else if (ch == ',')
                    {
                        option = ",";
                    }
                    else if (ch == '-')
                    {
                        option = "-";
                    }
                    else if (ch == '+')
                    {
                        option = "+";
                    }
                    else if (ch == '*')
                    {
                        option = "*";
                    }
                    else if (ch == '/')
                    {
                        option = "/";
                    }
                    else if (ch == ' ')
                    {
                        option = " ";
                    }
                }
                if (option == "")
                {
                    string s = txt.Text + "/";
                    date = s.Split('/');
                }
                if (option == ".")
                {
                    date = txt.Text.Split('.');
                }
                else if (option == ",")
                {
                    date = txt.Text.Split(',');
                }
                else if (option == "-")
                {
                    date = txt.Text.Split('-');
                }
                else if (option == "+")
                {
                    date = txt.Text.Split('+');
                }
                else if (option == "*")
                {
                    date = txt.Text.Split('*');
                }
                else if (option == "/")
                {
                    date = txt.Text.Split('/');
                }
                else if (option == " ")
                {
                    date = txt.Text.Split(' ');
                }
                if (date.Length == 1)
                {
                    string formatoption = SystemFormat();
                    if (formatoption == "M")
                    {
                        CurrDate = DateTime.Parse(dtcurrentdate.Date.Month + " / " + date[0].ToString() + " / " + dtcurrentdate.Date.Year);
                    }
                    else if (formatoption == "d")
                    {
                        CurrDate = DateTime.Parse(date[0].ToString() + " / " + dtcurrentdate.Date.Month + " / " + dtcurrentdate.Date.Year);
                    }
                    else if (formatoption == "y")
                    {
                        CurrDate = DateTime.Parse(dtcurrentdate.Date.Year + " / " + dtcurrentdate.Date.Month + " / " + date[0].ToString());
                    }
                    isToday(isValid);
                }
                else if (date.Length == 2)
                {
                    if (date[1].ToString() == "")
                    {
                        string formatoption = SystemFormat();
                        if (formatoption == "M")
                        {
                            CurrDate = DateTime.Parse(dtcurrentdate.Date.Month + " / " + date[0].ToString() + " / " + dtcurrentdate.Date.Year);
                        }
                        else if (formatoption == "d")
                        {
                            CurrDate = DateTime.Parse(date[0].ToString() + " / " + dtcurrentdate.Date.Month + " / " + dtcurrentdate.Date.Year);
                        }
                        else if (formatoption == "y")
                        {
                            CurrDate = DateTime.Parse(dtcurrentdate.Date.Year + " / " + dtcurrentdate.Date.Month + " / " + date[0].ToString());
                        }
                        isToday(isValid);
                    }
                    else
                    {
                        string formatoption = SystemFormat();
                        if (formatoption == "M")
                        {
                            CurrDate = DateTime.Parse(date[1].ToString() + " / " + date[0].ToString() + " / " + dtcurrentdate.Date.Year);
                        }
                        else if (formatoption == "d")
                        {
                            CurrDate = DateTime.Parse(date[0].ToString() + " / " + date[1].ToString() + " / " + dtcurrentdate.Date.Year);
                        }
                        else if (formatoption == "y")
                        {
                            CurrDate = DateTime.Parse(dtcurrentdate.Date.Year + " / " + date[1].ToString() + " / " + date[0].ToString());
                        } isToday(isValid);
                    }
                }
                else if (date.Length == 3)
                {
                    if (date[2].ToString() == "")
                    {
                        string formatoption = SystemFormat();
                        if (formatoption == "M")
                        {
                            CurrDate = DateTime.Parse(date[1].ToString() + " / " + date[0].ToString() + " / " + dtcurrentdate.Date.Year);
                        }
                        else if (formatoption == "d")
                        {
                            CurrDate = DateTime.Parse(date[0].ToString() + " / " + date[1].ToString() + " / " + dtcurrentdate.Date.Year);
                        }
                        else if (formatoption == "y")
                        {
                            CurrDate = DateTime.Parse(dtcurrentdate.Date.Year + " / " + date[1].ToString() + " / " + date[0].ToString());
                        }
                        isToday(isValid);
                    }
                    else
                    {
                        string formatoption = SystemFormat();
                        if (formatoption == "M")
                        {
                            CurrDate = DateTime.Parse(date[1].ToString() + " / " + date[0].ToString() + " / " + date[2].ToString());
                        }
                        else if (formatoption == "d")
                        {
                            CurrDate = DateTime.Parse(date[0].ToString() + " / " + date[1].ToString() + " / " + date[2].ToString());
                        }
                        else if (formatoption == "y")
                        {
                            CurrDate = DateTime.Parse(date[2].ToString() + " / " + date[1].ToString() + " / " + date[0].ToString());
                        }
                        isToday(isValid);
                    }
                }
                else
                {
                    isValid = false;
                    txt.Text = "";
                }
            }
            catch (Exception)
            {
                isValid = false;
                txt.Text = "";
            }
            return isValid;
        }
        /// <summary>
        /// Function for date validation
        /// </summary>
        /// <param name="isValid"></param>
        /// <returns></returns>
        public bool isToday(bool isValid)
        {
            text.Text = CurrDate.ToString("dd-MMM-yyyy");
            return isValid;
        }
        /// <summary>
        /// Function for date validation
        /// </summary>
        /// <returns></returns>
        public string SystemFormat()
        {
            string formatoption = string.Empty;
            foreach (char ch in format)
            {
                if (ch == 'M')
                {
                    formatoption = "M";
                    break;
                }
                else if (ch == 'd')
                {
                    formatoption = "d";
                    break;
                }
                else if (ch == 'y')
                {
                    formatoption = "y";
                    break;
                }
            }
            return formatoption;
        }
    }
}
