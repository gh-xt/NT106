using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.O22._2_Lab01_22521619
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        static void giaithua(string[] args)
        {
            int n, giaithua = 1;
            Console.Write("Nhap vao so can tinh giai thua: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                giaithua *= i;
            }
            Console.WriteLine($"{n}! = {giaithua}");
            Console.WriteLine("\n----Chuong trinh nay duoc dang tai Freetuts.net----\n");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
