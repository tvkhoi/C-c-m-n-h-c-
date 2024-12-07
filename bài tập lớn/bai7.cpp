#include<bits/stdc++.h>
using namespace std;
double a[100],n;
void nhapmang() {
  while (1) {
 cout<<"nhap gia tri cua n (0<n<50) : "; cin>>n; 
 if(n<0 || n>50) {
 continue;
 }
 break;
  }
if(0<n<50) {

  for(int i = 0; i<=n-1;++i) {
    cout<<"a["<<i<<"]= "; cin>>a[i];
  }
  }
}
void inmang() {
  cout<<"Hien thi mang 1 chieu : ";
   for(int i =0;i<=n-1;++i) {
    cout<<setw(3)<<a[i];
   }
   cout<<endl;
}
int tinhtong(double tong) {
  for(int i =0;i<=n-1;++i) {
   tong+=a[i];

    }
    cout<<"Tong gia tri cua mang : "<<tong<<endl;
return tong;
  }
int demsoam(int dem) {
  for(int i =0;i<=n-1;++i) {
  if(a[i] < 0)
  dem++;
    }
    cout<<"So phan tu am cua mang  la : "<<dem<<endl;
    return dem;
}
double giatrinho(double min) {
  for(int i =0; i<=n-1;++i) {
     min = a[0];
    
    for(int j = i+1;j<=n-1;++j) {
      if(min>a[j]) {
        min = a[j];
      }
    }
  }
  cout<<"Gia tri nho nhat cua mang so thuc la : "<<min<<endl;
  return min;
}
void sapxep() {
  for(int i =0;i<=n-1;++i) {
    for(int j =i+1;j<=n-1;j++) {
      if(a[j] > a[i]){
      double c = a[i];
      a[i] = a[j];
      a[j] = c;
  } } }
    inmang();
}
int main() {
  nhapmang();
  inmang();
  tinhtong(0);
  demsoam(0);
  giatrinho(0);
  sapxep();
  
}