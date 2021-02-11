//Author: Andrew Crossan
//Date Started: 10/02/2021
//Date Finished: 11/02/2021
//Time Elapsed: ~2 Hours
//Description: A simple GUI program which takes a user entered binary number and converts it to a real, human-readable number.
//Perfect for those taking Computing Science or anyone who may get use out of it.

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Conversion
{
    public partial class frmBinaryConversion : Form
    {
        static BinConv bc = new BinConv();
        public frmBinaryConversion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bc.Populate();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string text = "";
            int realnum = 0;
            string binarynumber = "00000000";
            bc.displayNum(textBinNum.TextLength, textBinNum.Text, ref text, ref realnum, ref binarynumber);
            txtRealNum.Text = realnum.ToString();
            num128.Text = binarynumber[0].ToString();
            num64.Text = binarynumber[1].ToString();
            num32.Text = binarynumber[2].ToString();
            num16.Text = binarynumber[3].ToString();
            num8.Text = binarynumber[4].ToString();
            num4.Text = binarynumber[5].ToString();
            num2.Text = binarynumber[6].ToString();
            num1.Text = binarynumber[7].ToString();
        }
        public void setrealnum(int realnum) {
            txtRealNum.Text = realnum.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class BinConv
    {
        protected string binarynum;
        private int RealNum = 0;
        private ArrayList binNums = new ArrayList();
        //Method to populate array with 8 bit binary numbers (Initialised when form loads to ensure numbers are loaded).
        public void Populate() {
            binNums.Add(128);
            binNums.Add(64);
            binNums.Add(32);
            binNums.Add(16);
            binNums.Add(8);
            binNums.Add(4);
            binNums.Add(2);
            binNums.Add(1);
        }
        //Method to validate number entered is definitely a binary number.
        private bool Check(string binnum) {
            foreach (char x in binnum)
            {
                Console.WriteLine(x.ToString());
                if (x == '0' || x == '1')
                {
                }
                else {
                    return true;
                }
            }
            return false;
        }
        //Method to obtain user entered binary number. Validates whether length is equal to 8 and it is actually a binary number.
        private void GetBinNum(int length, string binnum)
        {
            if (length != 8)
            {
                MessageBox.Show("The binary number must be 8 bits! (8 numbers long)", "Invalid Entry");
            }
            else if (!Check(binnum) == false)
            {
                MessageBox.Show("Entry value was not a binary number.", "Invalid Entry");
            }
            else
            {
                binarynum = binnum;
            }
        }
        //Method to calculate real number
        private void calcRealNum()
        {
            int x = 0;
            foreach (char ZeroOrOne in binarynum) {
                switch (ZeroOrOne) {
                    case '0':
                        x++;
                        break;
                    case '1':
                        RealNum += Convert.ToInt32(binNums[x]);
                        x++;
                        break;
                }
            }
        }
        private void displayWorking(ref string text) {
            text = "128 64 32 16 8 4 2 1\n   ";
            foreach (char x in binarynum) {
                text+= (x + "  ");
            }

        }
        private void setRealNum(ref int realnum) {
            realnum = RealNum;
        }
        private void reset() {
            RealNum = 0;
            binarynum = "00000000";
        }
        private void sendbinnum(ref string binarynumber) {
            binarynumber = binarynum;
        }
        public void displayNum(int length, string binnum, ref string text, ref int realnum, ref string binarynumber)
        {
            reset();
            GetBinNum(length, binnum);
            calcRealNum();
            displayWorking(ref text);
            setRealNum(ref realnum);
            sendbinnum(ref binarynumber);
        }
    }
}
