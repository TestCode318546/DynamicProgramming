using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 50; // เปลี่ยนค่า n ตามต้องการ
            Console.WriteLine("Fibonacci of " + n + " is: " + FibonacciDP(n));

            Console.ReadKey();
        }

        // ฟังก์ชัน Fibonacci แบบ Recursive
        static long FibonacciR(int n)
        {
            if (n <= 1) return n;  // ถ้า n เป็น 0 หรือ 1 ให้คืนค่า n ตรง ๆ
            return FibonacciR(n - 1) + FibonacciR(n - 2);  // คำนวณ Fibonacci โดยใช้ฟังก์ชันตัวเอง
        }


        // ตัวอย่าง 1: Fibonacci - Top-Down (Memoization)
        static Dictionary<int, long> memo = new Dictionary<int, long>();
        static long FibonacciDP(int n)
        {
            if (n <= 1) return n;

            if (memo.ContainsKey(n)) return memo[n];

            // คำนวณแล้วเก็บไว้ใน dictionary
            memo[n] = FibonacciDP(n - 1) + FibonacciDP(n - 2);
            return memo[n];
        }

        // ตัวอย่าง 2: Fibonacci - Bottom-Up (Tabulation)
        static long FibonacciDP_(int n)
        {
            if (n <= 1) return n;

            long[] dp = new long[n + 1];
            dp[0] = 0;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }
    }
}
