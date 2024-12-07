#include<bits/stdc++.h>
using namespace std;
struct doibongv {
    string namedoibong;
    string namehuanluyenvien;
    string doitruong;
    int slcauthu;
    int sobanthang;
    int sotrandauthamgia;
};
doibongv a[100];
int dem=0;
void danhsachdoibong() {
    int i =0;
    dem = 0;
    while (1>0) {
        cout<<"----Doi bong thu "<<i+1<<"----"<<endl;
        cin.ignore();
        system("pause");
        cout<<"Ten doi bong : ";
        getline(cin,a[i].namedoibong);  
        if(a[i].namedoibong=="*") {
        break;} 
        cout<<"Ten huan luyen vien truong : ";
        getline(cin,a[i].namehuanluyenvien);
        cout<<"Ten doi truong : ";
        getline(cin,a[i].doitruong);
        cout<<"So luong cau thu : ";
        cin>>a[i].slcauthu;
        cout<<"So ban thang duoc ghi : ";
        cin>>a[i].sobanthang;
        cout<<"So tran dau tham gia : ";
        cin>>a[i].sotrandauthamgia;
        cin.ignore();
        dem++;
        i++;
}}
void thongtindb() {
        cout<<setw(15)<<left<<"Ten doi bong"
        
        <<setw(33)<<"Ten huan luyen vien truong"
      
        <<setw(18)<<"Ten doi truong"
       
        <<setw(25)<<"So luong cau thu"
    
        <<setw(30)<<"So ban thang duoc ghi"
    
        <<setw(30)<<"So tran dau tham gia"<<endl;
       for(int i = 0;i<dem;i++) {
        cout<<setw(15)<<left<<a[i].namedoibong<<
        setw(33)<<a[i].namehuanluyenvien<<
        setw(18)<<a[i].doitruong<<
        setw(25)<<a[i].slcauthu<<
        setw(30)<<a[i].sobanthang<<
        setw(30)<<a[i].sotrandauthamgia<<endl;
}} 
double tongdb=0;
int tinhtong() {
    for(int i =0;i<dem;i++) {
        tongdb=tongdb + a[i].sobanthang;                                                                                                                                                                                                                            
    }
    return tongdb;
}
void tyle() {
    fstream doibong;
    doibong.open("doibong.dat",ios::out|ios::binary);
    double dem1,tong; 
    tinhtong();
        cout<<setw(15)<<left<<"Ten doi bong"
        
        <<setw(33)<<"Ten huan luyen vien truong"
      
        <<setw(18)<<"Ten doi truong"
       
        <<setw(25)<<"So luong cau thu"
    
        <<setw(30)<<"So ban thang duoc ghi"
    
        <<setw(30)<<"So tran dau tham gia"<<endl;
    for(int i = 0;i<dem;i++) {
        tong = tongdb/a[i].sotrandauthamgia;
       if(tong > 1.5) {
        cout<<setw(15)<<left<<a[i].namedoibong<<
        setw(33)<<a[i].namehuanluyenvien<<
        setw(18)<<a[i].doitruong<<
        setw(25)<<a[i].slcauthu<<
        setw(30)<<a[i].sobanthang<<
        setw(30)<<a[i].sotrandauthamgia<<endl;
        doibong.write((char*)&a[i],sizeof(a[i]));
}
    }
    doibong.close();
}  
void sapxep() {
    for(int i = 0;i<dem;i++) {
        for(int j =i+1;j<dem;j++) {
            if(a[i].slcauthu > a[j].slcauthu) {
         swap(a[i],a[j]);
        }
        }
    }
        cout<<setw(15)<<left<<"Ten doi bong"
        <<setw(33)<<"Ten huan luyen vien truong"
        <<setw(18)<<"Ten doi truong"
        <<setw(25)<<"So luong cau thu"
        <<setw(30)<<"So ban thang duoc ghi"
        <<setw(30)<<"So tran dau tham gia"<<endl;
    for(int i = 0;i<dem;i++) {
        cout<<setw(15)<<left<<a[i].namedoibong<<
        setw(33)<<a[i].namehuanluyenvien<<
        setw(18)<<a[i].doitruong<<
        setw(25)<<a[i].slcauthu<<
        setw(30)<<a[i].sobanthang<<
        setw(30)<<a[i].sotrandauthamgia<<endl;
}
}
void menu() {
    cout<<"-_-_-_-_-_-_-_-_-_-_-_-_-_-_Menu_-_-_-_-_-_-_-_-_-_-_-_-_\n";
    cout<<"1. Nhap danh doi bong\n";
    cout<<"2. Hien thi thong tin doi bong\n";
    cout<<"3. Tong so ban thang\n";
    cout<<"4. Danh sach doi bong co tong so ban thang ghi duoc / so tran dau tham gia la > 1.5\n";
    cout<<"5. Sap xep doi bong theo thu tu tang dan (so luong cau thu)\n";
    cout<<"6. Thoat chuong trinh !!!\n";
    cout<<"-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-";
}
int chonMenu() {
   int n = 0;
   cout<<"\nVui long chon menu : ";
   cin>>n;
   if(0<n<6)
   return n;
   else
   return chonMenu();
}
void xulymenu() {
int c = chonMenu();
switch (c)
{
case 1:
    cout<<" Nhap danh doi bong\n";
    danhsachdoibong();
    break;

case 2:
    cout<<"Hien thi thong tin doi bong\n";
    thongtindb();
    menu();
    break;
 case 3:
    cout<<"Tong so ban thang\n";
    menu();
    tinhtong();
    break;
case 4:
    cout<<"Danh sach doi bong co tong so ban thang ghi duoc / so tran dau tham gia la > 1.5\n";
     tyle();
     menu();
    break;
case 5:
    cout<<"Sap xep doi bong theo thu tu tang dan (so luong cau thu)\n";
    sapxep();
    menu();
    break;
 case 6:
    cout<<"Thoat chuong trinh !!!\n";
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
return 0;
}