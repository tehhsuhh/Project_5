using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_5
{
    public partial class MainForm : Form
    {
        int year, monthNumber, birthDay, daysInMonth, generatedNumber = 0;

        public MainForm()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //programmatically add all years between 1900 and the current year
            //to the birth year combo boxy
            for (int i = 0; (DateTime.Now.Year - i) >= 1900; i++)
            {
                birthYearComboBox.Items.Add(DateTime.Now.Year - i);
            }

        }

        private void BirthDayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            birthDay = birthDayComboBox.SelectedIndex + 1;
        }
        private void BirthYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (birthDayComboBox.Enabled == true)
            {
                //set the number of days in the month.
                birthDayComboBox.Items.Clear();
                monthNumber = monthToNumber(birthMonthComboBox.GetItemText(birthMonthComboBox.SelectedIndex));
                year = int.Parse(birthYearComboBox.GetItemText(birthYearComboBox.SelectedIndex));

                //assign the number of days in the month
                daysInMonth = DateTime.DaysInMonth(year, monthNumber);

                for (int i = 1; i <= daysInMonth; i++)
                {
                    birthDayComboBox.Items.Add(i);
                }
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (birthYearComboBox.SelectedIndex != -1 &&
                birthMonthComboBox.SelectedIndex != -1 &&
                birthDayComboBox.SelectedIndex != -1 &&
                favoriteColorTextBox.Text != "")
            {
                //algorithm for generating a number based on the input of the favorite color
                char[] favoriteColorArray = favoriteColorTextBox.Text.ToCharArray();
                int trigger = 0;

                generatedNumber = year / (monthNumber + birthDay);

                int iterations = favoriteColorArray.Length < 4 ? 4 : favoriteColorArray.Length;

                for (int i = 0; i < favoriteColorArray.Length; i++)
                {
                    if (trigger == 0)
                    {
                        generatedNumber += favoriteColorArray[i];
                        trigger++;
                    }
                    else if (trigger == 1)
                    {
                        generatedNumber = Math.Abs(generatedNumber - favoriteColorArray[i]);
                        trigger++;
                    }
                    else if (trigger == 2)
                    {
                        generatedNumber *= favoriteColorArray[i];
                        trigger++;
                    }
                    else if (trigger == 3)
                    {
                        generatedNumber /= favoriteColorArray[i];
                        trigger = 0;
                    }
                }
                luckyNumberForm luckyNumberForm = new luckyNumberForm();
                luckyNumberForm.luckyNumberLabel.Text = generatedNumber.ToString();
                luckyNumberForm.Show();
            }
            else
            {
                MessageBox.Show("Please fill out all forms before attempting to calculate.");
            }
        }

        private void BirthMonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthNumber = monthToNumber(birthMonthComboBox.GetItemText(birthMonthComboBox.SelectedIndex));
            //clear items in the combo box and enable the birth day combo box.
            birthDayComboBox.Items.Clear();
            birthDayComboBox.Enabled = true;

            year = int.Parse(birthYearComboBox.GetItemText(birthYearComboBox.SelectedIndex));
            daysInMonth = DateTime.DaysInMonth(year, monthNumber);

            //populate the days combo box
            for (int i = 1; i <= daysInMonth; i++)
            {
                birthDayComboBox.Items.Add(i);
            }
        }


        //converts the string name of the month to an integer value
        private int monthToNumber(string monthName)
        {
            switch (monthName)
            {
                case "January":
                    return 1;
                case "February":
                    return 2;
                case "March":
                    return 3;
                case "April":
                    return 4;
                case "May":
                    return 5;
                case "June":
                    return 6;
                case "July":
                    return 7;
                case "August":
                    return 8;
                case "September":
                    return 9;
                case "October":
                    return 10;
                case "November":
                    return 11;
                default:
                    return 12;
            }
        }
    }
}
