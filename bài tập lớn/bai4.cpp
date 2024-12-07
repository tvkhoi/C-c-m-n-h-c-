#include<bits/stdc++.h>
using namespace std;
int main() {
    // Nhập vào n
    //tính và in ra n số hạng của dãy fabinacco
 int n;
 cout<<"n = "; cin>>n;
 int F[n];

 cout<<"Day "<<n<<" so hang cua Fibonaci : "<<endl;
 for(int i = 0;i<n;i++) {
   F[0]=1;
   F[1]=1;
   F[2]=2;
   if(i<=2) {
    cout<<F[i]<<"\t";
   }
    else {
    F[i] = F[i-1] + F[i - 2];
    cout<<F[i]<<"\t";
   }
 }
 return 0;



}