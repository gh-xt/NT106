using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NT106.O22._2_Lab01_22521619
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            if (Int32.TryParse(textBox1.Text, out num) && num >= 0 && num <= 9 || textBox1.Text == string.Empty) ;
            else
            {
                MessageBox.Show("Vui lòng nhập đúng yêu cầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                num = float.Parse(textBox1.Text);

                switch (num)
                {
                    case 0:
                        textBox2.Text = "Không";
                        break;
                    case 1:
                        textBox2.Text = "Một";
                        break;
                    case 2:
                        textBox2.Text = "Hai";
                        break;
                    case 3:
                        textBox2.Text = "Ba";
                        break;
                    case 4:
                        textBox2.Text = "Bốn";
                        break;
                    case 5:
                        textBox2.Text = "Năm";
                        break;
                    case 6:
                        textBox2.Text = "Sáu";
                        break;
                    case 7:
                        textBox2.Text = "Bảy";
                        break;
                    case 8:
                        textBox2.Text = "Tám";
                        break;
                    case 9:
                        textBox2.Text = "Chín";
                        break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
