#include <stdio.h>
#include <iostream>
#include <cmath>
using namespace std;
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

/* poj 1061
������ʵ������չŷ������㷨����ⲻ�����̣�����ͬ�෽�̡�

��	 ���s��������������������������µ�ʽ��

 ��������(x+m*s)-(y+n*s)=k*l(k=0,1,2....)

	 ��΢��һ���εã�

	  ��������(n-m)*s+k*l=x-y

	��n-m=a,k=b,x-y=c,��

		  ��������a*s+b*l=c

	ֻҪ��ʽ���������⣬���������������������ܡ�

		��a * x + b * y = n�������⡣

	1���ȼ���Gcd(a,b)����n���ܱ�Gcd(a,b)�������򷽳��������⣻�����ڷ�������ͬʱ����Gcd(a,b)���õ��µĲ�������a' * x + b' * y = n'����ʱGcd(a',b')=1;

	2������������˵��ŷ������㷨�������a' * x + b' * y = 1��һ��������x0,y0����n' * x0,n' * y0�Ƿ���a' * x + b' * y = n'��һ�������⣻

	3�����������е���ض����ɵ÷���a' * x + b' * y = n'������������Ϊ��

		x = n' * x0 + b' * t
		y = n' * y0 - a' * t
		(tΪ����)

	����Ľ�Ҳ����a * x + b * y = n ��ȫ�������⡣

*/
long long int gcd(long long int a, long long int b) {  
    if(b==0)
	{
		return a;
	} 
	return gcd(b, a%b);
}  

void exgcd(long long int a, long long int b, long long int &x, long long int &y)
{
	if(b==0)
	{
		x=1;
		y=0;
		return ;
	}
	exgcd(b, a%b, x, y);
	long long int t;
	t=x;
	x=y;
	y=t-a/b*y;
}


int main(int argc, char** argv) {
	
	long long int x, y, m, n, l;
	long long int a, b, c, k1, k2, r, t;
	cin>> x >> y>> m>>n>>l;
	
	/*
	int xx=x;
	int yy=y;
	
	int count=0;
	for ( int i=1; i<=l; i ++)	
	{	
		x=(x+m)%l;
		y=(y+n)%l;
		count=i;
		if (x==y)
		{
			cout<<count;
			break;
		}
		if (x==xx&&y==yy)
		{
			cout<<"Impossible"<<endl;
			break;
		}		
	}
	
	if(count==l)
	{
		cout<< "Impossible" ;
	}
	*/
	
	a=n-m;
	b=l;
	c=x-y;
	r=gcd(a, b);
	if(c%r)
	{
		cout<<"Impossible"<<endl;
		return 0;
	}
	a/=r; // a'
	b/=r; // b'
	c/=r; // c'
	exgcd(a, b, k1, k2); // a'*k1+b'*k2=gcd(a', b'), gcd(a', b')=1, k1=x0, k2=y0, c'=n'
	t=-c*k1/b;  // x=c'*k1+b'*t, set x=0, so t= -c'*k1/b
	k1=c*k1+t*b; // 
	if(k1<0)  // k1 should be greater than 0
	{
		k1+=b;		
	}
	
	cout<<k1<<endl;
	
	return 0;
}
