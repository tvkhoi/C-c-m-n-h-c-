#include<bits/stdc++.h>
using namespace std;

int a[100][100];
int n,m;
void nhapmatran() {
    cout<<"Nhap n = "; cin>>n;
    cout<<"Nhap m = "; cin>>m;

    cout<<"Kich thuoc cua mang ma tran la n*m"<<endl;
    for(int i =0;i<n;++i) {
        for(int j = 0;j<m;++j) {
       cout<<"a["<<i<<"]["<<j<<"] = "; cin>>a[i][j];
        }
    }
}
void hienmangmatran() {
    cout<<"Hien mang ma tran : "<<endl;
    for(int i =0;i<n;++i) {
        for(int j = 0;j<m;++j) {
       cout<<a[i][j]<<"\t";
        }
         cout<<endl;
    }
}
void hanglonnhat() {
    int dem = 0,max = 0,tong=0,vitri;
   for(int i =0;i<n;++i) {
    for(int j = 0;j<m;++j) {
        if(a[i][j]<0)
      dem++;
     }
    if(max<dem) {
        vitri = i;
    }
   }

    for(int j = 0;j<m;++j) {
    cout<<a[vitri][j]<<" ";
   }
   cout<<endl;
 }
 void ktra() {
    int dem=0,b;
    for(int i =0;i<n;i++) {
        for(int j = 0;j<m;j++) {
            b = sqrt(a[i][j]);
            if(b*b==a[i][j])
            dem++;
        }
    }
    cout<<"So luong so chinh phuong : "<<dem<<endl;
 }
void lietke() {
    int b;
    for(int i =0;i<n;i++) {
        for(int j = 0; j<m;j++) {
            b = sqrt(a[i][j]);

            if(b*b==a[i][j]) {
            cout<<"("<<i<<","<<j<<") "<<endl;
            }
        }
    }
}
void slpt() {
    int dem=-1;
    for(int i = 0;i<n;i++) {
        for(int j = 0;j<m;j++) {
            if(a[0][0] == a[i][j])
            dem++;
        }
    }
    cout<<"So luong phan tu = phan tu (0,0) : "<<dem<<endl;
}
 int main() {
nhapmatran();
hienmangmatran();
ktra();
lietke();
slpt();
 }
