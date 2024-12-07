#include <bits\stdc++.h>
using namespace std;
void ngto(int n) {
    int count = 0;
    for(int i = 2;i<=sqrt(n);i++) {
        if(n%i==0) {
            count++;
        }
    }
    if(count == 0) {
        cout<<"Day la so nguyen to"<<endl;

    }
    else {
        cout<<"Day ko phai so nguyen to"<<endl;
    }
}
    int main()
    {
       int n;
       cout<<"Nhap so nguyen to:";
       cin>>n;
       if(n<2) {
        cout<<"n khong phai so nguyen to";
        return 0;
       }
       ngto(n);
        return 0;
    }
    
