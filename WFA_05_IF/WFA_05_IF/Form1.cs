using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_05_IF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (coin())
            {
                textBox1.Text = "승리";
            }
            else
            {
                textBox1.Text = "패배";
            }





        }
      

        int Add(int num)
        {
            int a = num % 2;
            return a;
        }

        bool coin()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(); //난수 생성
            int result = randomNumber % 2; // 0 or 1

            if( result == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
