using System;
using System.Collections.Generic; using System.Linq;
using  System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
class Program
{
static bool[] mark; static int[] A,B;
static void ChinhHopKLap(int n, int k, int i)
{

if (i == k)
 
{



}
else
{
 

for (int j = 0; j < k; j++) Console.Write(A[j] + " ");
Console.WriteLine();



for (int j = 1; j <= n; j++)
{
 
if (mark[j - 1] == false)
{
A[i] = B[j];
mark[j - 1] = true; ChinhHopKLap(n, k, i + 1); mark[j - 1] = false;
}
}
}
}
static void ChinhHopLap(int n, int k, int i)
{
if (i == k)
{
 



}
else
{
 
for (int j = 0; j < k; j++) Console.Write(A[j] + " ");
Console.WriteLine();



for (int j = 1; j <= n; j++)
{
 
A[i] = B[j];
ChinhHopLap(n, k, i + 1);
}
}
}
static void ToHop(int n, int k, int i)
{

if (i == k + 1)
{
 



}
else
{
 
for (int j = 1; j <= k; j++) Console.Write(A[j] + " ");
Console.WriteLine();
 

for  (int  j  =  1  +  A[i  -  1];  j  <=  n;  j++)
{
if (mark[j] == false)
{
A[i] = B[j];
mark[j] = true; ToHop(n, k, i + 1); mark[j] = false;
}
}
 
}
}

static void Main(string[] args)
{
int n, k;
var  l  =  Console.ReadLine().Split('  '); n = int.Parse(l[0]);
k = int.Parse(l[1]); mark = new  bool[n]; A = new  int[k  +  1]; B = new int[n + 1];
l  =  Console.ReadLine().Split('  '); for (int i = 1; i <= n; i++)
B[i] = int.Parse(l[i-1]); int a = n;
for (int i = 1; i < k; i++) a *= a;
Console.WriteLine(a); ChinhHopLap(n, k, 0); Console.WriteLine();  a = 1;
int b = 1;
for (int i = 2; i <= n; i++) a *= i;
for (int i = 2; i <= n  - k; i++) b *= i;
Console.WriteLine(a / b);
ChinhHopKLap(n, k, 0); Console.WriteLine();    a = 1;
b  = 1;
int c = 1;
for (int i = 2; i <= n; i++) a *= i;
for (int i = 2; i <= n  - k; i++) b *= i;
for (int i = 2; i <= k; i++) c *= i;
Console.WriteLine(a / (c * b));
for (int i = 0; i < A.Length; i++) A[i] = 0;
for  (int  i  =  0;  i  <  mark.Length;  i++) mark[i] = false;
ToHop(n, k, 1);
}
}
}
