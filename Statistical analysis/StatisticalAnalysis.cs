using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatisticalAnalysis
{
    public partial class Form1 : Form
    {
        double[] arrayOfNumbers;
        double[] arrayOfNumbers2;
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            label1.Text = "A";
            label7.Text = "Q1";
            label8.Text = "Q2";
            label9.Text = "Q3";
            label10.Text = "B";
            this.chart1.Series["Series1"].Points.Clear();
            string arr0 = textBox1.Text;
            string arr = "";
            for (int i = 0; i < arr0.Length; i++)
            {
                if (arr0[i] == ',' || arr0[i] == '.' || arr0[i] == '-' || arr0[i] >= '0' && arr0[i] <= '9')
                {
                    arr += arr0[i];
                }
                if (arr0[i] == ')' && i != arr0.Length - 1)
                    arr += ",";
            }
            string[] str1 = arr.Split(',');
            int LE =0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != "")
                    LE++;
            }
            arrayOfNumbers = new double[LE];
            if (str1[0] == "")
            {
                return;
            }
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != "")
                arrayOfNumbers[i] = double.Parse(str1[i]);
            }
            Dictionary<double, int> countOfItems = new Dictionary<double, int>();
            foreach (double eachNumber in arrayOfNumbers)
            {
                if (countOfItems.ContainsKey(eachNumber))
                    countOfItems[eachNumber]++;
                else
                    countOfItems[eachNumber] = 1;
            }
            foreach (KeyValuePair<double, int> pair in countOfItems)
            {
                this.chart1.Series["Series1"].Points.AddXY(pair.Key, pair.Value);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mod = "";
            string arr0 = textBox4.Text;
            string arr = "";
            for (int i = 0; i < arr0.Length; i++)
            {
                if (arr0[i] == ',' || arr0[i] == '.' || arr0[i] == '-' || arr0[i] >= '0' && arr0[i] <= '9')
                {
                    arr += arr0[i];
                }
                if (arr0[i] == ')' && i != arr0.Length - 1)
                    arr += ",";
            }
            string[] str1 = arr.Split(',');
            int LE = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != "")
                    LE++;
            }
            arrayOfNumbers = new double[LE];
            if (str1[0] == "")
            {
                return;
            }
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != "")
                arrayOfNumbers[i] = double.Parse(str1[i]);
            }
            Dictionary<double, int> countOfItems = new Dictionary<double, int>();
            foreach (double eachNumber in arrayOfNumbers)
            {
                if (countOfItems.ContainsKey(eachNumber))
                    countOfItems[eachNumber]++;
                else
                    countOfItems[eachNumber] = 1;
            }
            int max = 0;
            foreach (KeyValuePair<double, int> pair in countOfItems)
            {
                if (pair.Value > max)
                    max = pair.Value;
            }
            foreach (KeyValuePair<double, int> pair in countOfItems)
            {
                if (pair.Value == max)
                {
                    mod += pair.Key.ToString() + ",";
                }
            }
            mod = mod.Remove(mod.Length - 1);
            MessageBox.Show("Mode = " + mod.ToString());
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string med = "";
            string arr0 = textBox4.Text;
            string arr = "";
            for (int i = 0; i < arr0.Length; i++)
            {
                if (arr0[i] == ',' || arr0[i] == '.' || arr0[i] == '-' || arr0[i] >= '0' && arr0[i] <= '9')
                {
                    arr += arr0[i];
                }
                if (arr0[i] == ')' && i != arr0.Length - 1)
                    arr += ",";
            }
            string[] str1 = arr.Split(',');
            int LE = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != "")
                    LE++;
            }
            arrayOfNumbers = new double[LE];
            if (str1[0] == "")
            {
                return;
            }
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != "")
                arrayOfNumbers[i] = double.Parse(str1[i]);
            }
            Array.Sort(arrayOfNumbers);
            if (arrayOfNumbers.Length % 2 == 0)
            {
                med = ((arrayOfNumbers[arrayOfNumbers.Length / 2] + arrayOfNumbers[(arrayOfNumbers.Length / 2) - 1]) / 2).ToString();
            }
            else
            {
                med = arrayOfNumbers[arrayOfNumbers.Length / 2].ToString();
            }
            MessageBox.Show("Median = " + med.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double Mean = 0;
            string arr0 = textBox4.Text;
            string arr = "";
            for (int i = 0; i < arr0.Length; i++)
            {
                if (arr0[i] == ',' || arr0[i] == '.' || arr0[i] >= '0' && arr0[i] <= '9')
                {
                    arr += arr0[i];
                }
            }
            string[] str1 = arr.Split(',');
            if (str1[0] == "")
            {
                return;
            }
            int LE = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != "")
                {
                    Mean += double.Parse(str1[i]); LE++;
                }
            }
            if(LE==0)
                return;
            Mean /= LE;
            MessageBox.Show(Mean.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double Mean = 0, Var = 0, R = 0;
            string arr0 = textBox4.Text;
            string arr = "";
            for (int i = 0; i < arr0.Length; i++)
            {
                if (arr0[i] == ',' || arr0[i] == '.' || arr0[i] == '-' || arr0[i] >= '0' && arr0[i] <= '9')
                {
                    arr += arr0[i];
                }

            }
            string[] str1 = arr.Split(',');
            if (str1[0] == "")
            {
                return;
            }
            int LE = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != "")
                {
                    Mean += double.Parse(str1[i]);
                    LE++;
                }
            }
            if (LE == 0)
                return;
            Mean /= LE;
            for (int i = 0; i < str1.Length; i++)
            {
                if(str1[i]!="")
                Var += (double.Parse(str1[i]) - Mean) * (double.Parse(str1[i]) - Mean);
            }

            Var /= LE;
            MessageBox.Show(Var.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Mean = 0, Var = 0, R = 0;
            string arr0 = textBox4.Text;
            string arr = "";
            for (int i = 0; i < arr0.Length; i++)
            {
                if (arr0[i] == ',' || arr0[i] == '.' || arr0[i] == '-' || arr0[i] >= '0' && arr0[i] <= '9')
                {
                    arr += arr0[i];
                }
            }
            string[] str1 = arr.Split(',');
            if (str1[0] == "")
            {
                return;
            }
            int LE = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != "")
                {
                    Mean += double.Parse(str1[i]); LE++;
                }
            }
            if (LE == 0)
                return;
            Mean /= LE;
            for (int i = 0; i < str1.Length; i++)
            {
                if(str1[i]!="")
                Var += (double.Parse(str1[i]) - Mean) * (double.Parse(str1[i]) - Mean);
            }

            Var /= LE;
            MessageBox.Show(Math.Sqrt(Var).ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Steem");
            dt.Columns.Add("Leaf");
            dt.Columns.Add("Freq");

            tableLayoutPanel1.Visible = true;
            label1.Text = "A";
            label7.Text = "Q1";
            label8.Text = "Q2";
            label9.Text = "Q3";
            label10.Text = "B";
            label18.Text = label19.Text = label20.Text = "";
            
            this.chart1.Series["Series1"].Points.Clear();
            string arr0 = textBox1.Text;
            string arr = "";
            for (int i = 0; i < arr0.Length; i++)
            {
                if (arr0[i] == ',' || arr0[i] == '.' || arr0[i] == '-' || arr0[i] >= '0' && arr0[i] <= '9')
                {
                    arr += arr0[i];
                }
                if (arr0[i] == ')' && i != arr0.Length - 1)
                    arr += ",";
            }
            string[] str1 = arr.Split(',');
            int LE = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != "")
                    LE++;
            }
            int[] arrayOfNumbers = new int[LE];
            int[] arrayOfNumbers0 = new int[LE];
            if (str1[0] == "")
            {
                return;
            }
            for (int i = 0; i < str1.Length; i++)
            {
                char[] chars = str1[i].ToCharArray();
                str1[i] = new string(chars);
                if (str1[i] != "")
                {
                    arrayOfNumbers0[i] = (int)double.Parse(str1[i]);
                    //
                    chars[str1[i].Length - 1] = '0';
                    str1[i] = new string(chars);
                    arrayOfNumbers[i] = (int)double.Parse(str1[i]);
                }
            }
            Array.Sort(arrayOfNumbers);
            Dictionary<int, int> countOfItems = new Dictionary<int, int>();
            int max = 0;
            foreach (int eachNumber in arrayOfNumbers)
            {
                if (countOfItems.ContainsKey(eachNumber/10))
                    countOfItems[eachNumber/10]++;
                else
                    countOfItems[eachNumber/10] = 1;
                if (countOfItems[eachNumber / 10] > max)
                    max = countOfItems[eachNumber / 10];
                
            }
            foreach (KeyValuePair<int, int> pair in countOfItems)
            {
                DataRow _ravi = dt.NewRow();
                _ravi["Steem"] = pair.Key;
                _ravi["Freq"] = pair.Value;
                string Leaf = "";
                for (int i = 0; i < arrayOfNumbers0.Length; i++)
                {
                    if (arrayOfNumbers0[i] / 10 == pair.Key)
                    {
                        Leaf += (arrayOfNumbers0[i]%10).ToString() + ",";
                    }
                }
                Leaf=Leaf.Remove(Leaf.Length - 1);
                _ravi["Leaf"] = Leaf;
                dt.Rows.Add(_ravi);
            }
            string A = "", B = "", C = "";
            foreach (DataRow row in dt.Rows)
            {
                
                A += row[0].ToString() ;
                A += '\n';
                B += row[1].ToString() ;
                B += '\n';
                C += row[2].ToString() ;
                C += '\n';
            }
            label18.Text = A;
            label19.Text = B;
            label20.Text = C;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double Q1, Q2, Q3, IQR, A, B;
            this.chart1.Series["Series1"].Points.Clear();
            string arr0 = textBox1.Text;
            string arr = "";
            for (int i = 0; i < arr0.Length; i++)
            {
                if (arr0[i] == ',' || arr0[i] == '.' || arr0[i] == '-' || arr0[i] >= '0' && arr0[i] <= '9')
                {
                    arr += arr0[i];
                }
                if (arr0[i] == ')' && i != arr0.Length - 1)
                    arr += ",";
            }
            string[] str1 = arr.Split(',');
            int LE = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != "")
                    LE++;
            }
            arrayOfNumbers = new double[LE];
            if (str1[0] == "")
            {
                return;
            }
            for (int i = 0; i < str1.Length; i++)
            {
                if(str1[i]!="")
                 arrayOfNumbers[i] = double.Parse(str1[i]);
            }
            Array.Sort(arrayOfNumbers);
            int L = arrayOfNumbers.Length;
            int f = L / 2;
            if (L % 2 == 0)
            {
                if (L < 4)
                    return;
                Q2 = (arrayOfNumbers[L / 2] + arrayOfNumbers[(L / 2) - 1]) / 2;
                if (f % 2 == 0)
                {
                    Q1 = (arrayOfNumbers[(L / 4) - 1] + arrayOfNumbers[L / 4]) / 2;
                    Q3 = (arrayOfNumbers[L - (L / 4)] + arrayOfNumbers[(L - (L / 4)) - 1]) / 2;
                }
                else
                {
                    Q1 = arrayOfNumbers[(L / 4)];
                    Q3 = arrayOfNumbers[L - (L / 4) - 1];
                }
                
            }
            else
            {
                if (L < 3)
                    return;
                if (L == 3)
                {
                    Q1 = arrayOfNumbers[0];
                    Q2 = arrayOfNumbers[1];
                    Q3 = arrayOfNumbers[2];
                }
                else
                {

                    Q2 = arrayOfNumbers[L / 2];
                    if (f % 2 == 0)
                    {
                        Q1 = (arrayOfNumbers[(L / 4) - 1] + arrayOfNumbers[L / 4]) / 2;
                        Q3 = (arrayOfNumbers[L - (L / 4)] + arrayOfNumbers[(L - (L / 4)) - 1]) / 2;
                    }
                    else
                    {
                        Q1 = arrayOfNumbers[(L / 4)];
                        Q3 = arrayOfNumbers[L - (L / 4) - 1];
                    }
                }
            }
            IQR = Q3 - Q1;
            A = Q1 - (1.5 * IQR);
            B = Q3 + (1.5 * IQR);
            label1.Text = A.ToString();
            label7.Text = Q1.ToString();
            label8.Text = Q2.ToString();
            label9.Text = Q3.ToString();
            label10.Text = B.ToString();

            //this.chart1.Series["Series1"].Points.AddXY(A, 1);
            //this.chart1.Series["Series1"].Points.AddXY(Q1, 1);
            //this.chart1.Series["Series1"].Points.AddXY(Q2, 1);
            //this.chart1.Series["Series1"].Points.AddXY(Q3, 1);
            //this.chart1.Series["Series1"].Points.AddXY(B, 1);


            //this.chart1.Series["Series1"].Points.DataBindY(arrayOfNumbers);

            //// Specify data series name for the Box Plot.
            //this.chart1.Series["Series1"]["BoxPlotSeries"] = "Series1";

            //// Set other custom attributes
            //this.chart1.Series["Series1"]["BoxPlotWhiskerPercentile"] = "15";
            //this.chart1.Series["Series1"]["BoxPlotShowAverage"] = "true";
            //this.chart1.Series["Series1"]["BoxPlotShowMedian"] = "true";
            //this.chart1.Series["Series1"]["BoxPlotShowUnusualValues"] = "true";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string arr0 = textBox3.Text;
            string arr = "";
            for (int i = 0; i < arr0.Length; i++)
            {
                if (arr0[i] == ',' || arr0[i] == '.' || arr0[i] == '-' || arr0[i] >= '0' && arr0[i] <= '9')
                {
                    arr += arr0[i];
                }
                if (arr0[i] == ')' && i != arr0.Length - 1)
                    arr += ",";
            }
            string[] str1 = arr.Split(',');
            arrayOfNumbers = new double[str1.Length];
            string arr1 = textBox2.Text;
            string arr2 = "";
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == ',' || arr1[i] == '.' || arr1[i] == '-' || arr1[i] >= '0' && arr1[i] <= '9')
                {
                    arr2 += arr1[i];
                }
                if (arr1[i] == ')' && i != arr1.Length - 1)
                    arr2 += ",";
            }
            string[] str2 = arr2.Split(',');
            arrayOfNumbers2 = new double[str2.Length];

            if (str1.Length != str2.Length)
            {
                MessageBox.Show("Wrong Input");
                return;
            }
            if (str1[0] == "" || str2[0] == "")
            {
                return;
            }
            for (int j = 0; j < str1.Length; j++)
            {
                if(str1[j]!="")
                arrayOfNumbers[j] = double.Parse(str1[j]);
            }

            for (int j = 0; j < str1.Length; j++)
            {
                if (str2[j] != "")
                arrayOfNumbers2[j] = double.Parse(str2[j]);
            }
            for (int i = 0; i < str1.Length; i++)
            {
                this.chart2.Series["Correlation"].Points.AddXY(arrayOfNumbers[i], arrayOfNumbers2[i]);
            }
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            double Sum_X = 0, Sum_Y = 0, Sum_XX = 0, Sum_YY = 0, Sum_XY = 0, N = 0, R = 0;
            string arr0 = textBox3.Text;
            string arr = "";
            for (int i = 0; i < arr0.Length; i++)
            {
                if (arr0[i] == ',' || arr0[i] == '.' || arr0[i] == '-' || arr0[i] >= '0' && arr0[i] <= '9')
                {
                    arr += arr0[i];
                }
                if (arr0[i] == ')' && i != arr0.Length - 1)
                    arr += ",";
            }
            string[] str1 = arr.Split(',');
            arrayOfNumbers = new double[str1.Length];//X
            string arr1 = textBox2.Text;
            string arr2 = "";
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == ',' || arr1[i] == '.' || arr1[i] == '-' || arr1[i] >= '0' && arr1[i] <= '9')
                {
                    arr2 += arr1[i];
                }
                if (arr1[i] == ')' && i != arr1.Length - 1)
                    arr2 += ",";
            }
            string[] str2 = arr2.Split(',');
            arrayOfNumbers2 = new double[str2.Length];//Y

            if (str1.Length != str2.Length)
            {
                MessageBox.Show("Wrong Input");
                return;
            }
            if (str1[0] == "" || str2[0] == "")
            {
                return;
            }
            int LE1 = 0,LE2=0;
            for (int j = 0; j < str1.Length; j++)
            {
                if (str1[j] != "")
                {
                    LE1++;
                    arrayOfNumbers[j] = double.Parse(str1[j]);//X
                    Sum_X += arrayOfNumbers[j];
                    Sum_XX += arrayOfNumbers[j] * arrayOfNumbers[j];
                }
                //////
                if (str2[j] != "")
                {
                    LE2++;
                    arrayOfNumbers2[j] = double.Parse(str2[j]);//Y
                    Sum_Y += arrayOfNumbers2[j];
                    Sum_YY += arrayOfNumbers2[j] * arrayOfNumbers2[j];

                    //////
                    Sum_XY += arrayOfNumbers[j] * arrayOfNumbers2[j];
                }
            }
            if (LE1 != LE2)
                return;
            N = LE1;
            R = ((N * Sum_XY) - (Sum_X * Sum_Y)) / (Math.Sqrt(((N * Sum_XX) - (Sum_X * Sum_X)) * ((N * Sum_YY) - (Sum_Y * Sum_Y))));
            MessageBox.Show("The correlation coefficient = " + R.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double Sum_X = 0, Sum_Y = 0, Sum_XX = 0, Sum_YY = 0, Sum_XY = 0, N = 0, A = 0, B = 0;
            string arr0 = textBox3.Text;
            string arr = "";
            for (int i = 0; i < arr0.Length; i++)
            {
                if (arr0[i] == ',' || arr0[i] == '.' || arr0[i] == '-' || arr0[i] >= '0' && arr0[i] <= '9')
                {
                    arr += arr0[i];
                }
                if (arr0[i] == ')' && i != arr0.Length - 1)
                    arr += ",";
            }
            string[] str1 = arr.Split(',');
            arrayOfNumbers = new double[str1.Length];//X
            string arr1 = textBox2.Text;
            string arr2 = "";
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == ',' || arr1[i] == '.' || arr1[i] == '-' || arr1[i] >= '0' && arr1[i] <= '9')
                {
                    arr2 += arr1[i];
                }
                if (arr1[i] == ')' && i != arr1.Length - 1)
                    arr2 += ",";
            }
            string[] str2 = arr2.Split(',');
            arrayOfNumbers2 = new double[str2.Length];//Y

            if (str1.Length != str2.Length)
            {
                MessageBox.Show("Wrong Input");
                return;
            }
            if (str1[0] == "" || str2[0] == "")
            {
                return;
            }
            int LE1 = 0, LE2 = 0;
            for (int j = 0; j < str1.Length; j++)
            {
                if (str1[j] != "")
                {
                    LE1++;
                    arrayOfNumbers[j] = double.Parse(str1[j]);//X
                    Sum_X += arrayOfNumbers[j];
                    Sum_XX += arrayOfNumbers[j] * arrayOfNumbers[j];
                }
                //////
                if (str2[j] != "")
                {
                    LE2++;
                    arrayOfNumbers2[j] = double.Parse(str2[j]);//Y
                    Sum_Y += arrayOfNumbers2[j];
                    Sum_YY += arrayOfNumbers2[j] * arrayOfNumbers2[j];

                    //////
                    Sum_XY += arrayOfNumbers[j] * arrayOfNumbers2[j];
                }
            }
            if (LE1 != LE2)
            {
                MessageBox.Show("Wrong Input");
                return;
            }
            N = LE1;
            A = ((Sum_Y * Sum_XX) - (Sum_X * Sum_XY)) / ((N * Sum_XX) - (Sum_X * Sum_X));
            B = ((N * Sum_XY) - (Sum_X * Sum_Y)) / ((N * Sum_XX) - (Sum_X * Sum_X));
            MessageBox.Show("The Linear Regression Equation =>  Y = " + A.ToString() + " + " + B.ToString() + " X ");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
