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
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        int number = 0;
        int counter = 0;
        public Form2()
        {
            InitializeComponent();
            lblCounter.Text = "Счётчик попыток: " + counter;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            number = rnd.Next(1, 101);
            MessageBox.Show("Я загадал число от 1 до 100. Попробуйте угадать его");
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            counter++;
            lblCounter.Text = "Счётчик попыток: " + counter;
            if (int.Parse(textBoxGuess.Text) < number) lblGuess.Text = "Попробуй побольше";
            else if (int.Parse(textBoxGuess.Text) > number) lblGuess.Text = "Попробуй поменьше";
            else if (int.Parse(textBoxGuess.Text) == number)
            {
                MessageBox.Show($"Вы победили! Сделано попыток: {counter}");
                number = rnd.Next(1, 101);
                counter = 0;
            }
        }
    }
}
