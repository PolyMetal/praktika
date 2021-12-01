using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int s = Convert.ToInt32(textBox1.Text);
            }
            catch (System.FormatException)
            {
                DialogResult dialogResult = MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int s = Convert.ToInt32(textBox1.Text);
            }
            catch (System.FormatException)
            {
                DialogResult dialogResult = MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int s = Convert.ToInt32(textBox1.Text);
            }
            catch (System.FormatException)
            {
                DialogResult dialogResult = MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
            }
        }
        public void button1_Click(object sender, EventArgs e)
        {
            int Summa = Convert.ToInt32(textBox1.Text);
            int Month = Convert.ToInt32(textBox2.Text);
            double percent = 1.18;
            double number = Summa * percent;
            textBox4.Text = Convert.ToString(number);
            double EverMonth = number / Month;
            textBox5.Text = Convert.ToString(EverMonth);

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Текстовый файл (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    using (StreamWriter sw = new StreamWriter(myStream))
                    {
                        sw.WriteLine($"Сумма кредита " + Summa + " умножается на ставку" + percent + " и получается: сумма кредита с процентами =  " + number + " далее, делим её " + number + " на количестов месяцев " + Month + " и получаем: ежемесячный платёж =  " + EverMonth);
                    }
                    myStream.Close();
                }
            }

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int s = Convert.ToInt32(textBox1.Text);
            }
            catch (System.FormatException)
            {
                DialogResult dialogResult = MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int s = Convert.ToInt32(textBox1.Text);
            }
            catch (System.FormatException)
            {
                DialogResult dialogResult = MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}