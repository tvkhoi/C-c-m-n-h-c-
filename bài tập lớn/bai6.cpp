#include<bits/stdc++.h>
using namespace std;
int n;
void thaykitu(char x,char a[]) {
    for(int i = 0;i<strlen(a);i++) {
        a[i] = x;
}
    }

int main() {
  
    char a[100];
     cin>>a;
    char x;
    cout<<"x = "; cin>>x;
  thaykitu(x,a);
  
    cout<<a;
}