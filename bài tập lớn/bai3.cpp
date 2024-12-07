#include<bits/stdc++.h>
using namespace std;
int main() {
   // input : nhập vào 3 số bất kì
   // output : Tính trung bình cộng của 3 số, trung bình nhân của 3 số
   double a,b,c,tbc_3so,tbn_3so;
   cout<<"a = "; cin>>a;
   cout<<"b = "; cin>>b;
   cout<<"c = "; cin>>c;
 
   cout<<"Trung binh cong cua 3 so la : "<<(a+b+c)/3<<endl;
   cout<<"trung binh nhan cua 3 so la : "<<pow((a*b*c),1.0/3);  
return 0;


}