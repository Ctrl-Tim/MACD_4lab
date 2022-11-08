using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MACD_4lab
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dateTimePickerPlus.Visible = false;
            comboBoxOperator.Items.Add("+");
            comboBoxOperator.Items.Add("-");
            comboBoxOperator.SelectedItem = "+";

            comboBoxElement.Items.Add("годы");
            comboBoxElement.Items.Add("месяцы");
            comboBoxElement.Items.Add("дни");
            comboBoxElement.Items.Add("часы");
            comboBoxElement.Items.Add("минуты");
            comboBoxElement.Items.Add("секунды");
            comboBoxElement.Items.Add("дата");
            comboBoxElement.SelectedItem = "годы";
        }

        private void buttonToString_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(dateTimePickerDate.Value.Year, dateTimePickerDate.Value.Month, dateTimePickerDate.Value.Day,
                                     dateTimePickerTime.Value.Hour, dateTimePickerTime.Value.Minute, dateTimePickerTime.Value.Second);
            if (radioButton1.Checked)
            {
                textBoxString.Text = date.ToString();
            }
            else if (radioButton2.Checked)
            {
                textBoxString.Text = date.ToShortDateString();
            }
            else if (radioButton3.Checked)
            {
                textBoxString.Text = date.ToLongDateString();
            }
            else if (radioButton4.Checked)
            {
                textBoxString.Text = date.ToLongTimeString();
            }
            else if (radioButton5.Checked)
            {
                textBoxString.Text = date.ToShortTimeString();
            }
        }

        private void buttonToDate_Click(object sender, EventArgs e)
        {
            dateTimePickerDate.Value = DateTime.Parse(textBoxString.Text);
            dateTimePickerTime.Value = DateTime.Parse(textBoxString.Text);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            decimal number = numericUpDown.Value;
            if (comboBoxOperator.SelectedItem == "-")
            {
                number *= -1;
            }
            if (comboBoxElement.SelectedItem == "годы")
            {
                dateTimePickerDate.Value = dateTimePickerDate.Value.AddYears(Decimal.ToInt32(number));
            }
            if (comboBoxElement.SelectedItem == "месяцы")
            {
                dateTimePickerDate.Value = dateTimePickerDate.Value.AddMonths(Decimal.ToInt32(number));
            }
            if (comboBoxElement.SelectedItem == "дни")
            {
                dateTimePickerDate.Value = dateTimePickerDate.Value.AddDays(Decimal.ToDouble(number));
            }
            if (comboBoxElement.SelectedItem == "часы")
            {
                dateTimePickerTime.Value = dateTimePickerTime.Value.AddHours(Decimal.ToDouble(number));
            }
            if (comboBoxElement.SelectedItem == "минуты")
            {
                dateTimePickerTime.Value = dateTimePickerTime.Value.AddMinutes(Decimal.ToDouble(number));
            }
            if (comboBoxElement.SelectedItem == "секунды")
            {
                dateTimePickerTime.Value = dateTimePickerTime.Value.AddSeconds(Decimal.ToDouble(number));
            }
            if (comboBoxElement.SelectedItem == "дата" && comboBoxOperator.SelectedItem == "+")
            {
                DateTime date = dateTimePickerDate.Value;
                textBoxString.Text = date.ToString();
                date = date.Add(dateTimePickerPlus.Value.TimeOfDay);
                dateTimePickerDate.Value = date;
                dateTimePickerTime.Value = date;
            }
            if (comboBoxElement.SelectedItem == "дата" && comboBoxOperator.SelectedItem == "-")
            {
                //dateTimePickerDate.Value = dateTimePickerDate.Value.Subtract(dateTimePickerPlus.Value);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxString.Text = null;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxElement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxElement.SelectedItem == "дата")
            {
                dateTimePickerPlus.Visible = true;
            }
            else
            {
                dateTimePickerPlus.Visible = false;
            }
        }
    }
}
