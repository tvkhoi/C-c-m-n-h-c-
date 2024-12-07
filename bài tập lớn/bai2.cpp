#include<bits/stdc++.h>
using namespace std;
int main() {
// input nhập vào hai số nguyên từ bàn phím
// in ra tổng, tích, hiệu, thương của hai số đó
int a,b;      
cout<<"a = "; cin>>a;
cout<<"b = "; cin>>b;

if(b!=0) {
    
    
         cout<<"a + b = "<<a+b<<endl;
         cout<<"a * b = "<<a*b<<endl;
         cout<<"a - b = "<<a-b<<endl;
         cout<<"a / b = "<<a/b<<endl;
}
    else  {
     cout<<"a + b = "<<a+b<<endl;
         cout<<"a * b = "<<a*b<<endl;
         cout<<"a - b = "<<a-b<<endl;
        cout<<"a  / b : Khong tich duoc"<<endl;
    }
return 0;
}