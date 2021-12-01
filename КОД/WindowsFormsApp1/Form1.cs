using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.IO.Stream;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            ulong Summa = Convert.ToUInt64(textBox1.Text);
            ushort Month = Convert.ToUInt16(textBox2.Text);
            double percent = 1.18;
            double number = Summa * percent;
            textBox3.Text = Convert.ToString(number);
            double EverMonth = number / Month;
            textBox4.Text = Convert.ToString(EverMonth);

        }

        public void textBox1_TextChanged(object sender, EventArgs e) //сумма
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e) //срок
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e) //проценты
        {

        }

        public void textBox4_TextChanged(object sender, EventArgs e) //сумма кредита с процентами
        {

        }

        public void textBox5_TextChanged(object sender, EventArgs e) //ежемесячный платёж
        {

        }
        public void button2_Click(object sender, EventArgs e)
        {
            ulong Summa = Convert.ToUInt64(textBox1.Text);
            ushort Month = Convert.ToUInt16(textBox2.Text);
            double percent = 1.18;
            double number = Summa * percent;
            textBox3.Text = Convert.ToString(number);
            double EverMonth = number / Month;
            textBox4.Text = Convert.ToString(EverMonth);

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Текстовый файл (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = (Stream)saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    using (StreamWriter sw = new StreamWriter(myStream))
                    {
                        sw.WriteLine("Сумма кредита с процентами" + number + "Ежемесячный платеж" + EverMonth);
                    }
                    myStream.Close();
                }
            }
        }
    }
}
