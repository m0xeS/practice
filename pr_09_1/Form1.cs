using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr_09_1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    Random rnd = new Random();
    Point tmpLocation;
    int w = SystemInformation.PrimaryMonitorSize.Width;
    int h = SystemInformation.PrimaryMonitorSize.Height;
    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
      // переводим координату X в строку и записывает в поля ввода
      textBox1.Text = e.X.ToString();
      // переводим координату Y в строку и записывает в поля ввода
      textBox2.Text = e.Y.ToString();
      // если координата по оси X и по оси Y лежит в очерчиваемом вокруг кнопки "да, конечно" квадрате
      if (e.X > 80 && e.X < 195 && e.Y > 100 && e.Y < 135)
      {
        // запоминаем текущее положение окна
        tmpLocation = this.Location;
        // генерируем перемещения по осям X и Y и прибавляем их к хранимому значению текущего положения окна
        // числа генерируются в диапазоне от -100 до 100
        tmpLocation.X += rnd.Next(-100, 100);
        tmpLocation.Y += rnd.Next(-100, 100);
        // если окно вылезло за пределы экрана по одной из осей
        if (tmpLocation.X < 0 || tmpLocation.X > (w - this.Width / 2) || tmpLocation.Y < 0 || tmpLocation.Y > (h - this.Height / 2))
        { // новыми координатами станет центр окна
          tmpLocation.X = w / 2;
          tmpLocation.Y = h / 2;
        }
        // обновляем положение окна, на новое сгенерированное
        this.Location = tmpLocation;
      }

      private void button2_Click(object sender, EventArgs e)
      {
        // Вывести сообщение с текстом "Вы усердны"
        MessageBox.Show("Вы усердны!!");
        // Завершить приложение
        Application.Exit();
      }

      private void button1_Click(object sender, EventArgs e)
      {
        MessageBox.Show("Тогда в армию", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }
  }
}
