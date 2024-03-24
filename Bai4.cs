using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NT106.O22._2_Lab01_22521619
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double num = 0;
            if (double.TryParse(textBox1.Text, out num) || textBox1.Text == string.Empty) ;
            else
            {
                MessageBox.Show("Vui lòng nhập đúng yêu cầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = string.Empty;
            }
        }


        private static string nText(string numText)
        {
            string numRes = string.Empty;
            switch (numText)
            {
                case "0":
                    numRes = "không";
                    break;
                case "1":
                    numRes = "một";
                    break;
                case "2":
                    numRes = "hai";
                    break;
                case "3":
                    numRes = "ba";
                    break;
                case "4":
                    numRes = "bốn";
                    break;
                case "5":
                    numRes = "năm";
                    break;
                case "6":
                    numRes = "sáu";
                    break;
                case "7":
                    numRes = "bảy";
                    break;
                case "8":
                    numRes = "tám";
                    break;
                case "9":
                    numRes = "chín";
                    break;
            }
            return numRes;
        }

        private static string unitText(string so)
        {
            string unit = "";

            if (so.Equals("1"))
                unit = "";
            if (so.Equals("2"))
                unit = "nghìn";
            if (so.Equals("3"))
                unit = "triệu";
            if (so.Equals("4"))
                unit = "tỷ";
            if (so.Equals("5"))
                unit = "chục tỷ";
            if (so.Equals("6"))
                unit = "trăm tỷ";
            if (so.Equals("7"))
                unit = "triệu tỷ";

            return unit;
        }

        private static string Separate(string Separate3)
        {
            string resSeparate = "";
            if (Separate3.Equals("000"))
                return "";
            if (Separate3.Length == 3)
            {
                string tr = Separate3.Trim().Substring(0, 1).ToString().Trim();
                string ch = Separate3.Trim().Substring(1, 1).ToString().Trim();
                string dv = Separate3.Trim().Substring(2, 1).ToString().Trim();
                if (tr.Equals("0") && ch.Equals("0"))
                    resSeparate = " không trăm lẻ " + nText(dv.ToString().Trim()) + " ";
                if (!tr.Equals("0") && ch.Equals("0") && dv.Equals("0"))
                    resSeparate = nText(tr.ToString().Trim()).Trim() + " trăm ";
                if (!tr.Equals("0") && ch.Equals("0") && !dv.Equals("0"))
                    resSeparate = nText(tr.ToString().Trim()).Trim() + " trăm lẻ " + nText(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    resSeparate = " không trăm " + nText(ch.Trim()).Trim() + " mươi " + nText(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
                    resSeparate = " không trăm " + nText(ch.Trim()).Trim() + " mươi ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
                    resSeparate = " không trăm " + nText(ch.Trim()).Trim() + " mươi lăm ";
                if (tr.Equals("0") && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    resSeparate = " không trăm mười " + nText(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && ch.Equals("1") && dv.Equals("0"))
                    resSeparate = " không trăm mười ";
                if (tr.Equals("0") && ch.Equals("1") && dv.Equals("5"))
                    resSeparate = " không trăm mười lăm ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    resSeparate = nText(tr.Trim()).Trim() + " trăm " + nText(ch.Trim()).Trim() + " mươi " + nText(dv.Trim()).Trim() + " ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
                    resSeparate = nText(tr.Trim()).Trim() + " trăm " + nText(ch.Trim()).Trim() + " mươi ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
                    resSeparate = nText(tr.Trim()).Trim() + " trăm " + nText(ch.Trim()).Trim() + " mươi lăm ";
                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    resSeparate = nText(tr.Trim()).Trim() + " trăm mười " + nText(dv.Trim()).Trim() + " ";
                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("0"))
                    resSeparate = nText(tr.Trim()).Trim() + " trăm mười ";
                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("5"))
                    resSeparate = nText(tr.Trim()).Trim() + " trăm mười lăm ";
            }
            return resSeparate;
        }

        public static string So_chu(double gNum)
        {
            if (gNum == 0)
                return "không";

            string lso_chu = "";
            string Separate_mod = "";
            string Separate_remain = "";
            double Num = Math.Round(gNum, 0);
            string gN = Convert.ToString(Num);
            int m = Convert.ToInt32(gN.Length / 3);
            int mod = gN.Length - m * 3;
            string dau = "[+]";

            if (gNum < 0)
                dau = "[-]";
            dau = "";

            if (mod.Equals(1))
                Separate_mod = "00" + Convert.ToString(Num.ToString().Trim().Substring(0, 1)).Trim();
            if (mod.Equals(2))
                Separate_mod = "0" + Convert.ToString(Num.ToString().Trim().Substring(0, 2)).Trim();
            if (mod.Equals(0))
                Separate_mod = "000";

            if (Num.ToString().Length > 2)
                Separate_remain = Convert.ToString(Num.ToString().Trim().Substring(mod, Num.ToString().Length - mod)).Trim();

            int im = m + 1;
            if (mod > 0)
                lso_chu = Separate(Separate_mod).ToString().Trim() + " " + unitText(im.ToString().Trim());

            int i = m;
            int _m = m;
            int j = 1;
            string Separate3 = "";
            string Separate3_ = "";

            while (i > 0)
            {
                Separate3 = Separate_remain.Trim().Substring(0, 3).Trim();
                Separate3_ = Separate3;
                lso_chu = lso_chu.Trim() + " " + Separate(Separate3.Trim()).Trim();
                m = _m + 1 - j;
                if (!Separate3_.Equals("000"))
                    lso_chu = lso_chu.Trim() + " " + unitText(m.ToString().Trim()).Trim();
                Separate_remain = Separate_remain.Trim().Substring(3, Separate_remain.Trim().Length - 3);

                i = i - 1;
                j = j + 1;
            }
            if (lso_chu.Trim().Length > 0)
                lso_chu = dau.Trim() + " " + lso_chu.Trim().Substring(0, 1).Trim().ToUpper() + lso_chu.Trim().Substring(1, lso_chu.Trim().Length - 1).Trim();

            return lso_chu.ToString().Trim();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double num;
                num = double.Parse(textBox1.Text);
                textBox2.Text = So_chu(num).ToString();
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
