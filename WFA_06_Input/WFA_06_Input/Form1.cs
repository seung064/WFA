using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_06_Input
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }

        #region #1-3 실습) 사용자 입력 받기 - 이벤트 처리
        private void button_input_Click(object sender, EventArgs e)
        {
            textBox_result.Text = textBox_input.Text; // 입력값을 결과창에 먼저 복사

            bool input = false;

            if (textBox_input.Text.Length > 0)
            {
                string inputText = textBox_input.Text;

                if (!(inputText == "true" || inputText == "false"))
                {
                    MessageBox.Show("true 또는 false를 입력하세요.");
                    return;
                }
                else
                {
                    input = bool.Parse(inputText);
                }
            }

            else if (radioButton_true.Checked)
            {
                input = true;
            }
            else if (radioButton_false.Checked)
            {
                input = false;
            }

            textBox_result.Text = "입력하신 값은 " + input.ToString() + "입니다! \r\n";
            textBox_result.Text += "동전 던지기 결과... \r\n";

            string gameResultMessage;

            if (CoinMatch(input))
            {
                gameResultMessage = "승리 ~!";
            }
            else
            {
                gameResultMessage = "패배 ..ㅠ";
            }

            textBox_result.Text += gameResultMessage + "\r\n";
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_input_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private bool CoinMatch(bool userInput)
        {
            Random rnd = new Random();
            bool coin = rnd.Next(2) == 0; // true 또는 false 랜덤 생성
            return userInput == coin;
        }
    }
}

