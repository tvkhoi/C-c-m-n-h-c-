#include<bits/stdc++.h>
using namespace std;
int a[100], n=1,dem =0;
void nhaptep() {
fstream nhap;
dem = 0;
nhap.open("mang.in",ios::out|ios::binary);
while (n!=0)
{
	cin>>n;
  dem++;
//nhap.write((char*)&n,sizeof(n));
nhap<<n;
}
nhap.close();
}
void hienmag() {
   fstream doc;
  doc.open("mang.in",ios::in);
   for(int i = 0;i<dem;i++) {
     doc.read((char*)&a[i],sizeof(a[i]));
     cout<<a[i]<<" ";
} 

 
//for(int i =0;i<dem;i++) {
  
//}
cout<<endl;
 }
void sapxep() {
	int dem1 = 0;
	for(int j = 0;j<dem-1;j++) {
       for(int i = dem-1;i>0;i--) {
		 if(a[i]%3==0) {
		    int c =a[i]; 
		    a[i]=a[i-1];
		    a[i-1]=c;
}}}
     for(int i =0;i<dem-1;i++) {
		if(a[i]%3==0)
		dem1++;
}   
    for(int j = 0;j<dem;j++) {
       for(int i = dem-1;i>dem1-1;i--) {
          if(a[i] % 2 == 0 && i -1 > dem1-1) {
		   int d = a[i-1];
		   a[i-1] = a[i];
		   a[i]  = d;
}}}
    for(int i =0;i<dem;i++) {
		cout<<a[i]<<" ";
}
cout<<endl;
 }
void vitript(int max,int min) {
	fstream vitri;
  vitri.open("vitri.out",ios::out|ios::binary);
     int gtmax = a[0],gtmin = a[0];
		for(int i = 1;i<dem-1;i++) {
		if(gtmax<a[i]) {
		gtmax = a[i];
		max = i;
}}
	 for(int i =1;i<dem-1;i++) {
		if(gtmin > a[i]) {
        gtmin = a[i];
		min = i;
}} 
	vitri.write((char*)&max,sizeof(max));
  vitri.write((char*)&min,sizeof(min));
vitri.close();
}
void menu() {
   cout<<"______________________________Menu____________________________\n";
   cout<<"1. Nhap lien tiep 1 day so nguyen vao tep mang.in(nhi phan)\n";
   cout<<"2. Hien mang so nguyen duoc doc tu tep\n";
   cout<<"3. Sap xep mang\n";
   cout<<"4. Ghi vao tep vitri.out phan tu lon nhat va nho nhat dau tien\n";
   cout<<"5. Thoat chuong trinh !!!\n";
   cout<<"--------------------------------------------------------------\n";
}
int chonmenu() {
  int n = 0;
  cout<<"__________-------Chon menu------_____________ :";
  cin>>n;
  if(0<n<6)
  return n;
  else return chonmenu();
}
void xulymenu() {
	int chon = chonmenu();
  switch (chon)
  {
  case 1:
  cout<<"Nhap lien tiep 1 day so nguyen vao tep mang.in(nhi phan)\n";
  nhaptep();
  break;
  case 2:
  cout<<"Hien mang so nguyen duoc doc tu tep\n";
  hienmag();
  break;
  case 3:
  cout<<"Sap xep mang\n";
  sapxep();
  break;
  case 4:
  cout<<"Ghi vao tep vitri.out phan tu lon nhat va nho nhat dau tien\n";
  vitript(0,0);
  break;
  case 5:
  cout<<"Thoat Chuong trinh !!!\n";
  exit(1);
  break;
  }
}
int main() {
menu();
while (true)
{
	xulymenu();
}
}