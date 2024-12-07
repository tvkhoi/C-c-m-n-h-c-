#include<bits/stdc++.h>
using namespace std;
   char a[100];
void daonguocchuoi() {
    int d=strlen(a);
   int i = 0;
   //  while(1>0)
   //   {
   //   
   //       d--;
   //      i++;
   //       if(i+1==d||i==d) { 
   //      break;
   //      }
   //   }
   for(int i = 0;i<d;i++) {
     int c =a[i];
     a[i] = a[d-1];
     a[d-1]=c;
     if(i+1==d||i==d) 
     break;
     d--;
   }
}
int main() {
cin>>a;
daonguocchuoi();
cout<<a;
}