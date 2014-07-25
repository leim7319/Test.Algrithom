#include <stdio.h>
#include <iostream>
#include <cmath>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;
// POJ 1067: 取石子游戏
int main() {
	
    int a,b,dif;
    double p=(sqrt((double)5)+1)/double(2);
    while(cin>>a>>b)
    {
    dif=abs(a-b);
    a=a<b?a:b;
    if(a==(int)(p*dif))
      cout<<0<<endl;
    else cout<<1<<endl;
    }
    
	return 0;
}
