using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ковалёв_Н.ДЗ_Урок_7
{
    public partial class Form1 : Form
    {
        int counter = 0;
        int number = 0;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Удвоитель";
            lblCounter.Text = "Счётчик команд: " + counter;
            lblFindNumb.Text = String.Empty;
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            counter++;
            lblCounter.Text = "Счётчик команд: " + counter;
            if (number == int.Parse(lblNumber.Text)) MessageBox.Show($"Вы победили! Сделано ходов: {counter}");
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            counter++;
            lblCounter.Text = "Счётчик команд: " + counter;
            if (number == int.Parse(lblNumber.Text)) MessageBox.Show($"Вы победили! Сделано ходов: {counter}");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            counter = 0;
            lblCounter.Text = "Счётчик команд: " + counter;
            lblFindNumb.Text = String.Empty;
            number = 0;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            number = rnd.Next(2, 1000);
            MessageBox.Show($"Попробуйте получить число {number}");
            lblFindNumb.Text = $"Получить:{number}";
        }
    }
}
