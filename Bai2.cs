using System;
using System.Windows.Forms;

namespace NT106.O22._2_Lab01_22521619
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1, num2, num3, maxValue, minValue;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                num1 = float.Parse(textBox1.Text);
                num2 = float.Parse(textBox2.Text);
                num3 = float.Parse(textBox3.Text);
                maxValue = num1;
                minValue = num2;

                if (num2 > maxValue)
                {
                    maxValue = num2;
                }

                if (num3 > maxValue)
                {
                    maxValue = num3;
                }

                if (num1 < minValue)
                {
                    minValue = num1;
                }

                if (num3 < minValue)
                {
                    minValue = num3;
                }
                textBox5.Text = maxValue.ToString();
                textBox4.Text = minValue.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            if (Int32.TryParse(textBox1.Text, out num) || textBox1.Text == "-" || textBox1.Text == "") ;
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = string.Empty;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            if (Int32.TryParse(textBox3.Text, out num) || textBox3.Text == "-" || textBox3.Text == "") ;
            else
                {
                    MessageBox.Show("Vui lòng nhập số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Text = string.Empty;
                }
         }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            if (Int32.TryParse(textBox2.Text, out num) || textBox2.Text == "-" || textBox2.Text == "") ;
            else
                {
                    MessageBox.Show("Vui lòng nhập số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Text = string.Empty;
                }
            }
    }
}