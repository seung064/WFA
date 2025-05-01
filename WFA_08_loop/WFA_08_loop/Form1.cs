using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WFA_08_loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #region 반복문 강의

            #region #1. 일반 반복문 강의 & 예제
            /*
            어떤 코드를 정해진 횟수만큼 반복 실행할 때 사용
              
            구조
            for (초기식; 조건식; 증감식)
            {
                반복할 코드
            }

            초기식 : 변수 선언 or 초기화
            조건식 : 반복할 조건 -> true면 계속 실행
            증감식 : 변수 값을 변화시켜 반복 실행 제어 -> ++/--
            */

            //ex1) 0-5 출력
            for(int i = 0; i<5; i++)
            {
                Console.WriteLine(i); // i를 줄바꿈으로 출력
            }

            Console.WriteLine("------------------------------");

            //ex2) 5-1출력
            for(int i = 5; i>=1; i--)
            {
                Console.WriteLine(i); // i를 줄바꿈으로 출력
            }

            Console.WriteLine("------------------------------");

            //ex3) 1-n까지의 합
            int n = 10;
            int sum = 0;

            for (int i =1; i<=n; i++)
            {
                sum = sum + i; // = sum += i;
                Console.WriteLine("현재 i의 값 :" + i + "\r\n" + "현재합계 :" +sum + "\r\n");
            }

            Console.WriteLine("------------------------------");

            // Quiz 1~20 중에 짝수 일 때의 합 구하기
            // Hint 1) 1- 20까지 숫자를 반복
            // hint 2) 현재 반복 숫자가 짝수라면 (변수)에 더하기
            // hint 3) for문 안에 if문 조합을 해보세요

            int num = 20;
            int sums = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    sums += i;
                }
                else
                { sums += 0; }
                
            }
            Console.WriteLine(sums);


            Console.WriteLine("------------------------------");

            /*
             * Quiz2)
             * 1부터 100까지의 수중
             * 3의 배수이지만 5의 배수는 아닌 수" 만 모두 출력,
             * 마지막에 그 개수와 총합 출력
             * */

            int d = 100;
            int count = 0;
            for(int i = 1; i <= d; i++)
            {
                if (i % 3 == 0 && !(i % 5 == 0))
                {
                    Console.WriteLine(i);
                    count++;               // 개수 증가
                    sum += i;              // 총합에 더하기
                }
            }
            Console.WriteLine($"개수 : {count}");
            Console.WriteLine($"총합 : {sum}");


            Console.WriteLine("------------------------------");

            //ex4) 중첩 for문
            for (int i = 1; i<=3; i++)
            {
                for(int j =1; j <=2; j++)
                {
                    Console.WriteLine($"i = {i}, j = {j}");
                }
            }

            Console.WriteLine("------------------------------");

            // Quiz 3) 구구단 2단부터 9단까지 출력
            for (int i = 2; i<=9; i++)
            {
                for(int j =1; j<=9; j++)
                {
                    Console.WriteLine($"{i}x{j}={i * j}");
                }
            }

            Console.WriteLine("------------------------------");

            
            // Quiz 4) 별찍기
            // *이 4개 까지 반복
            for (int i = 1; i <=4; i++) // i가 칸수
            {
                for (int j = 3; j >=i ; j--)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j<=i; j++) //j가 별수
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------");

            //Quiz 5) 별 찍기 lv.2
            // 피라미드식
            for(int i = 1; i <=4; i++)
            {
                for(int j = 3; j >= i; j--) // 공백출력
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2*i-1); j++)
                {
                    Console.Write("*");
                }
                for(int j = i; j <=3; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
              
        }
            #endregion
            #endregion
    }
}
