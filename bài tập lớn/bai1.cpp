#include<bits/stdc++.h>
using namespace std;
int main() {
    int a=0,n=0,tong=0,dem = 0,b=0;
    cout<<"Nhap vao 1 so nguyen n : ";
    cin>>n;
if(n!=0) {
  while (n != 0)
  {

    a = n % 10;
       b = n /10;
        n = n  / 10;
        dem ++; 
        tong = tong + a;
        
  }
  }
  else  {
  dem =1;
}
    tong = tong + b;

    cout<<"So co "<<dem<<" chu so"<<" va"<<" tong cac chu so la : "<<tong;
}

