#include <stdio.h>
#include <iostream>
#include <cmath>
using namespace std;
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

/* poj 1061
此题其实就是扩展欧几里德算法－求解不定方程，线性同余方程。

　	 设过s步后两青蛙相遇，则必满足以下等式：

 　　　　(x+m*s)-(y+n*s)=k*l(k=0,1,2....)

	 稍微变一下形得：

	  　　　　(n-m)*s+k*l=x-y

	令n-m=a,k=b,x-y=c,即

		  　　　　a*s+b*l=c

	只要上式存在整数解，则两青蛙能相遇，否则不能。

		求a * x + b * y = n的整数解。

	1、先计算Gcd(a,b)，若n不能被Gcd(a,b)整除，则方程无整数解；否则，在方程两边同时除以Gcd(a,b)，得到新的不定方程a' * x + b' * y = n'，此时Gcd(a',b')=1;

	2、利用上面所说的欧几里德算法求出方程a' * x + b' * y = 1的一组整数解x0,y0，则n' * x0,n' * y0是方程a' * x + b' * y = n'的一组整数解；

	3、根据数论中的相关定理，可得方程a' * x + b' * y = n'的所有整数解为：

		x = n' * x0 + b' * t
		y = n' * y0 - a' * t
		(t为整数)

	上面的解也就是a * x + b * y = n 的全部整数解。

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
