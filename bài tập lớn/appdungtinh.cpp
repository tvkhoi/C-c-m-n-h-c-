//Tính S(n) = 1 + 2 + 3 + … + n.
//Tính S(n) = 12 + 22 + 32 + … + n2
//Tính S(n) = 1 + 1/2 + 1/3 + 1/4 + ... + 1/n
//Tinh S(n) = 1/2 +1/4 + ... + 1/2n
//tinh S(n) = 1 + 1/3 + 1/5 + ... + 1/2n + 1;
// tính D(n) = 1 / 1 * 2 + ... + 1/(n*(n+1))
// tính C(n) = 1 /2 + 2/3+....+n/(n+1)
// tính E(n) = Tính S(n) = 1/2 + 3/4 + 5/6 + .....+ (2n+1) / (2n +2)
//tinh S = x mũ n;
// tính tongx = 1 + 1*2 + 1*2*3 + 1*2*3*4 +.....
// tính tong Tính S(n) = 𝑥 + 𝑥 mũ 2 + x mũ 2 +.....
//bai15
//bai16
//18
//20 liệt kê các ước số của số nguyên dương
// #include<bits/stdc++.h>
// #include<iostream>
// using namespace std;
// int g_n = 3;
// int g_x = 3;
// int tinh_tong( int s_sum1) {
// for(int i = 1; i<=g_n;i++) {
//   s_sum1 = s_sum1 + i;

// }
// cout<<"Tong cac so hang : "<<s_sum1<<endl;
// return s_sum1;
// }
// int tinhtong(int s_sum2) {
// for(int i = 1;i<=g_n;i++) {
//  s_sum2 = s_sum2 + i*i;

// }
// cout<<"Tong gia tri cac so hang la : "<<s_sum2<<endl;
// return s_sum2;
// }
// int tongdayso(double sum2) {
//     for(int i = 1;i<=g_n;i++) {
//         sum2 = sum2 + 1.00 / i;
//     }
//     cout<<"Tong day so la : "<<sum2<<endl;
//     return sum2;
//     }
// int tongsn(double sum2) {
// for(int i =1;i<=g_n;i++) {
//     sum2 = sum2 + 1.0/(2*i);

// }
// cout<<"Tong S(n) la : "<<sum2<<endl;
// return sum2;
// }
// int tongn(double sum2) {
//     for(int i =0;i<=g_n;i++) {
//         sum2 = sum2 + 1.0/(2*i+1);
//     }
//     cout<<"Tong day S(n) la : "<<sum2<<endl;
//     return sum2;
// }
// int tongD(double sum2) {
//    for(int i = 1;i<=g_n;i++) {
//     sum2 = sum2 + 1.0 / (i*(i+1));
//    }
//     cout<<"Tong D(n) = "<<sum2<<endl;
//     return sum2;
// }
// int tongC(double sum2) {

//     for(double i = 1;i<=g_n;++i) {
//         sum2 = sum2 + i/(i+1);
//     }
//     cout<<"Tong C(n) = "<<sum2<<endl;
//     return sum2;
// }
// int tongE(double sum2) {
//   for(double i = 0;i<=g_n;i++) {
//     sum2 = sum2 + (2*i+1)/(2*i+2);
//   }
//   return sum2;
// }
// int tichA(double tich1) {
//     for(int i = 1;i<=g_n;i++) {
//         tich1 = tich1*i;
//     }
//     cout<<"Tich 1 = "<<tich1<<endl;
//     return tich1;
// }
// int giaithua(double sum2){
//   sum2 = pow(4,g_n) + sum2;
//   cout<<"Sum2 = "<<sum2<<endl;
//   return sum2;
// }
// int tongv(double sum2) {
//     int tong = 0,dem=1;
//     for(int i = 1;i<=g_n;i++) {
//         sum2 = sum2 *dem; 
//         tong = tong + sum2;
//         dem++;
//     }
//     cout<<"Tong day so : "<<tong<<endl;
//     return tong;
// }
// int tongmu(double sum2) {
//   for(int i = 1;i<=g_n;i++) {
//    sum2 = sum2 + pow(g_x,i);

//   }
//   cout<<"Tong cap so : "<<sum2<<endl;
// return sum2;
// }
// int tongd(double sum2);
// int tongd(double sum2) {
//  int dem =1,tong = 0;
//     for(int i =1;i<=g_n;i++) {
//         tong =tong + dem;
//         sum2 =sum2 + 1.0 /tong;
//         dem++;
//     }
//     cout<<"Tong bai 15 : "<<sum2<<endl;
// return sum2;
// }
// int tongs(double tong2) {
//    double dem1 =1,tong1 =1,dem = 1;
    
//     for(int i = 0;i<=g_n;i++) {
//         double sum2 =0;
//         if(i == 0)
//             tong1 = tong1*dem;
//         if(i % 2==0) {   
//             sum2 = sum2 + pow(g_x,i);        
//           tong2 = tong2 + sum2/tong1;
//         }  
//         tong1 = tong1 * (dem1); 
//         dem1++;
      
//     }
    
//    cout<<"tong gia tri la : "<<tong2<<endl;
   
// return tong2;
// }
// int tong19(double tong2) {
//     int tong1 = 1,dem1=0,dem=0;
//     for(int i = 0; i<=g_n;i++ ) {
//         double sum2 = 0;
//         dem++;
//         if(i==0) {
//             tong1 = tong1*dem;
//             tong2 = tong2 + pow(g_x,i)/tong1;
//         }
       
        
//         if(i%2!=0) {
//             sum2 = sum2 + pow(g_x,i);
//             tong2 = tong2 + sum2/tong1;

//         }
//  dem1++;
//         tong1 = tong1* (dem1);
//     }
//     cout<<"Tong bai 19 la : "<<tong2<<endl;
//     return tong2;
// }
// int tongr(int i)
//  {
//     int dem = 0;
//     cout<<"Uoc chung cua n la : ";
//    for(;i<=g_n;++i){
//     if(g_n %i==0)  {
//     cout<<i <<" ";
//     dem ++;
//    }
//    }
//    cout<<endl;
//    cout<<"So luong uoc so la :"<<dem<<endl;

//    return i;
//  }
// int tonguoc(double tongv) {
    
//     cout<<"Tong cac uoc cua n : ";
//   for(int i =1;i<=g_n;++i){
//     if(g_n %i==0)  {
//      tongv = tongv + i;
//    }
//    } 
//    cout<<tongv<<endl;
//     return tongv;
// }
// int tongcan(double tong) {
//     double a;
//    for(int i = 1;i<=g_n;++i) {
//     a=2;
//    tong = sqrt(a + tong);  
    
//    }
//    cout<<"Tong can 2 la : "<<tong<<endl;
//    return tong;

// }
// int tonggh(double tong) {
//     double a =0;
//     for(int i =1;i<=g_n;++i) {
       
//         a++;
//         tong = sqrt(tong + a);
    
       
        
//     }
//     cout<<"Tong can n la : "<<tong<<endl;
//     return tong;
// }
// int tonhcf(double tong) {
//     double a;
//     for(int i = 0; i<g_n;++i) {
//         a= g_n - i;
//         tong=sqrt(tong + a);

//     }
//     cout<<"Tong : "<<tong<<endl;
//     return tong;
// }
// int toncf(double tong) {
//     double a=0;
   
//    for(double i =1;i<=g_n;++i) {
//      a = a+1;
//      double c=1;
//      for(double j=1;j<=a;++j) { 
//         c = c*j;
        
//      }
//    tong = sqrt(tong + c);
//    }
//    cout<<"tong c : "<<tong<<endl;
//    return tong;
// }
// double tinhtoan(double b);
// int main() {
//   tinh_tong(0);
//     tinhtong(0);
//     tongdayso(0);
//     tongsn(0);
//     tongn(0);
//     tongD(0);
//     tongC(0);
//     tongE(0);
//     tichA(1);
//     giaithua(0);
//     tongv(1);
//     tongmu(0);
//     tongd(0);
//    tongs(0);
//    tong19(0); 
//   tinhtoan(0);
//    //vector<int>array;
//    array<int,4>item {2,3,4,5};
//    //cout<<item.at();
//    //for each
//    for(int mag:item) {
//     cout<<"Nhap phan tu : "<<mag;
  
//    }
// return 0;
// }
// double tinhtoan(double b) {
//     int a,n = 7;
//        for(int i =2;i<=n;i+=2) {
//         a =i;
//         b = pow(a+b,1.0/i) + i + 1;
//         b = pow(b,1.00 /(i+1)); 
        
//     }
//     cout<<b<<endl;
//     return b;
// }
// #include<bits/stdc++.h>
// using namespace std;
// int main() {
    
//     fstream tep("hoclamj.txt",ios::binary);
//     //char a[3]= { '7','u','s'};
//     int a[3]= {97,57,6};
//     for(int i =0;i<3;i++) {
//     tep.write((char*)&a[i],sizeof(a[i]));
//     }
//     tep.close();
// }

// #include<bits/stdc++.h>
// #define MAX 100
// using namespace std;

// void nhapmang(int arr[],int &n)
// {
//     cout<<"nhap so phan tu cua mang:";
//     cin>>n;
//     for(int i=0;i<n;i++)
//     {
//         cout<<"arr["<<i<<"]=";
//         cin>>arr[i];
//     }
// }
// void xuatmang(int arr[],int n)
// {
//     for(int i=0;i<n;i++)
//     {
//         cout<<"arr["<<i<<"]="<<arr[i]<<endl;

//     }   
// }
// void timkiempt(int arr[], int n)
//     { 
//       int dem;  
//       int x; 
//       cout<<"nhap gia tri can tim ";
//       cin>>x;
//       cout<<"phan tu co gia tri=x la ";
//         for(int i=n;i>=0;i--)
//         {
//             if(arr[i]==x)
//             {  dem=i;
//                 cout<<"arr["<<i<<"]";
//             }
//         }
//         cout<<"\nvi tri xuat hien dau tien la "<<dem<<endl;
//     }
//     void tong(int a[],int n){
//         int x;
//         int tong=0;
//         cout<<"nhap so bat ky de tinh tong so lon hon :";
//         cin>>x;
//         for(int i=0;i<n;i++)
//         {  
//             if(a[i]>x)
//             { tong=tong+a[i];

//             }
//         }
//     cout<<"tong cac so lon hon x tong="<<tong<<endl;
//     }
// void hoanvi(int &d,int &e)
//     {
//         int temp=d;
//         d=e;
//         e=temp;
//     }
//     void xapxeptang(int arr[],int n)
//     {
//         for(int i=0;i<n-1;i++)
//         {
//             for(int j=i+1;j<n;j++)
//             {
//                 if(arr[i]>arr[j])
//                 hoanvi(arr[i], arr[j]);
//             }
//         }
//     }
// int main()
// {
//     int a[MAX];
//     int b;
//     nhapmang(a,b);
//     cout<<"mang sau khi nhap:"<<endl;
//     xuatmang(a,b);
//     timkiempt(a,b);
//     tong(a,b);
//     xapxeptang(a,b);
//     cout<<"mang sau khi sap xep:"<<endl;
//     xuatmang(a,b);
//     return 0;
// }
// #include<bits/stdc++.h>
// using namespace std;
// #define MAX 100
// void nhapmang(int a[][MAX],int &m,int &n)
// {
    
//     cout<<"nhap dong va cot";
//     cin>>n;
//     m=n;
//     for(int i=0;i<m;i++)
//     {
//         for(int j=0;j<n;j++)
//         {
//             cout<<"a["<<i<<"]["<<j<<"]=";
//             cin>>a[i][j];
//         }
//     }
// }
// void xuatmang(int a[][MAX],int m, int n)
// {
//     for(int i=0;i<m;i++)
//     {
//         for(int j=0;j<n;j++)
//         {
//             cout<<a[i][j]<<"\t";
//         }cout<<endl;
//     }
// }
// double tbcong(int arr[][MAX],int m,int n)
// {
//     double tong=0;
//     cout<<"trung binh cong duong cheo chinh la ";
//     for(int i=0;i<m;i++)
//     {
//         for(int j=0;j<n;j++)
//         {
//             if(i==j)
//             {
//                 tong=tong+arr[i][j];
//             }
//         }
//     } cout<<tong/2<<endl;
//       return tong;
// }
// double tong(int a[][MAX], int i, int n)
// {
//     double s=0;
//     for(int j=0;j<n;j++)
//         s=s+a[i][j];
//     return s;
// }
// int tonglonnhat(int a[][MAX], int m, int n)
// {
//     int i,d;
//     double max=tong(a,0,n);
//     for( i=1;i<m;i++)
//     {
//         double t=tong(a,i,n);
//         if(max<t)
//         {
//             max=t;
//             d=i;
//         }
//     }
//     cout<<"tong hang lon nhat la hang thu "<<d+1<<endl;
//     return d;
// }
// double tonghang(int a[][MAX],int n,int d)
// {
//     double sum=0;
//     for(int j=0;j<n;j++)
//     {
//         sum+=a[d][j];
//     }
//     return sum;
// }
// void incot(int a[][MAX],int m,int c)
// {
//     for(int i=0;i<m;i++)
//     {
//         cout<<a[i][c]<<"\t";
//     }   cout<<endl;
// }

// int main()
// {
//     int a[MAX][MAX];
//     int dong,cot;
    
//     nhapmang(a,dong,cot);
//     xuatmang(a,dong,cot);
//     tbcong(a,dong,cot);
//     tong(a,dong,cot);
//     tonglonnhat(a,dong,cot);
//     int hang;
//     cout<<"nhap hang can tinh tong ";
//     cin>>hang;
//     int k=hang-1;
//     int sumhang=tonghang(a,cot,k);
//     cout<<sumhang<<endl;
//     int col;
//     cout<<"nhap cot bat ky:";
//     cin>>col;
//     int h=col-1;
//     incot(a,dong,h);
//     return 0;
// }
// #include<bits/stdc++.h>
// using namespace std;
// int dem=0;
// struct honda
// {
//     /* data */
//     string maxe ;
//     string tenxe;
//     string mausac;
//     int dongia;
// };
// honda ds[100];
// void nhap() {
//     fstream honda;
//     honda.open("honda.dat",ios::out|ios::binary);
//     int i = 0;
//     while (1 > 0)
//     {
      
//         cout<<"Ma xe : ";
//         cin.ignore();
//         getline(cin,ds[i].maxe);
//         if(ds[i].maxe !="0") {
//         cout<<"Ten xe : ";
//         getline(cin,ds[i].tenxe);
//         cout<<"Mau sac : ";
//         getline(cin,ds[i].mausac);
//         cout<<"Don gia : ";
//         cin>>ds[i].dongia;
//         dem++;
//        honda.write((char*)&ds[i],sizeof(ds[i]));
//         i++;
//         }

//         if(ds[i].maxe=="0") {
//         break;
//     }
//     }
//     honda.close();
// }
// honda ds1[100];
// void hien() {
//     int i = 0;
// fstream doc;
// cout<<setw(13)<<left<<"Ma xe"<<setw(10)<<left<<"Ten xe"<<setw(10)<<left<<"Mau sac"<<setw(10)<<left<<"Don gia"<<endl;
//  doc.open("honda.dat",ios::in|ios::binary);
 
 
// for(int i = 0;i<dem;i++) {
//     doc.read((char*)&ds1[i],sizeof(ds1[i]));
//     cout<<setw(13)<<left<<ds1[i].maxe;
//     cout<<setw(10)<<left<<ds1[i].tenxe;
//     cout<<setw(10)<<left<<ds1[i].mausac;
//     cout<<setw(10)<<left<<ds1[i].dongia<<endl;
// }
// doc.close();
// }
// void timkiem() {
//     string tim;
//     cout<<"Nhap ten xe can tim : ";
//     getline(cin,tim);
//     for(int i = 0;i<dem;i++) {
//         if(ds1[i].tenxe==tim) {
//             cout<<ds1[i].mausac<<"   "<<ds1[i].dongia<<endl;
//         }
//     }
// }
// void sapxep() {
//     for(int i = 0;i<dem;i++) {
//         if(ds1[i].dongia < ds1[i+1].dongia)
//         swap(ds1[i],ds1[i+1]);
//     }
//    cout<<setw(10)<<left<<"Ma xe"<<setw(10)<<left<<"Ten xe"<<setw(10)<<left<<"Mau sac"<<setw(10)<<left<<"Don gia"<<endl;
//  for(int i = 0;i<dem;i++) {
//     cout<<setw(10)<<left<<ds1[i].maxe;
//     cout<<setw(10)<<left<<ds1[i].tenxe;
//     cout<<setw(10)<<left<<ds1[i].mausac;
//     cout<<setw(10)<<left<<ds1[i].dongia<<endl;
// }
// }
// int main() {
//     nhap();
//     hien();
//     timkiem();
//     sapxep();
 
//  #include<bits/stdc++.h>
//  using namespace std;
//  int a=1,dem=0,n[100];
//  void nhap() {
//     fstream mang;
//     mang.open("mang.in",ios::out|ios::binary);
//     while(a!=0) {
//         cin>>a;
//         dem++;
//         mang.write((char*)&a,sizeof(a));
//     }
//     mang.close();
//  }
//  void doc() {
//     fstream doc;
//     doc.open("mang.in",ios::in|ios::binary);
//     for(int i = 0;i<dem;i++) {
//         doc.read((char*)&n[i],sizeof(n[i]));
//         cout<<n[i]<<" ";
//     }
//     doc.close();
//  }
//  void sapxep () {
//     int dem1 = 0;
//     for(int j = 0;j<dem;j++) {
//     for(int i = dem-1;i>0;i--) {
//         if(n[i]%3==0) {
//             int c =n[i];
//             n[i] = n[i-1];
//            n[i-1]=c;
//         }
//     }}
//       for(int i =0;i<dem-1;i++) {
// 		if(n[i]%3==0)
// 		dem1++;
// }   
//     for(int j = 0;j<dem;j++) {
//         for(int i = dem-1;i>dem1-1;i--) {
//             if(n[i]%2==0&&i-1>dem1-1) {
//                 int d = n[i-1];
//                 n[i-1]= n[i];
//                 n[i]=d;
//             }
//         }

//     }
//      for(int i = 0;i<dem;i++) {
//         cout<<n[i]<<" ";
//     }
//  }
//  void vitri() {
//     int max,ma,min,mi;
//     for(int i = 0;i<dem;i++) {
//         max = n[i];
//         for(int j = i+1;j<dem;j++) {
//             if(max < n[j]) {
//                 max =n[j];
//                 ma = j;
//             }
//         }
//     }
//     for(int i = 0;i<dem;i++) {
//         min = n[i];
//         for(int j = i+1;j<dem;j++) {
//             if(max < n[j]) {
//                 min = n[j];
//                 mi = j;
//             }
//         }
//     }
//     fstream vitri;
//     vitri.open("vitri.out",ios::out|ios::binary);
//      vitri.write((char*)&ma,sizeof(ma));
//      vitri.write((char*)&mi,sizeof(mi));
//  vitri.close();
//  }
//  void menu() {
//     cout<<"1. Nhap 1 day so nguyen vao tep mang.in"<<endl;
//     cout<<"2. Doc noi dung tep mang.in luu vao mang so nguyen roi hien ra man hinh"<<endl;
//     cout<<"3. Sap Xep mang theo yeu cau so chia het cho 3 len dau day , so chia het cho 2 giua va con lai"<<endl;
//     cout<<"4. Ghi vao tep vitri.out phan tu lon nhat va nho nhat tim duoc trong mang"<<endl;
//     cout<<"5. Thoat chuong trinh"<<endl;
//  }
//  int chonmenu() {
//     int t;
//     cout<<"Vui long chon menu : ";
//     cin>>t;
//     if(0<t<6)
//     return t;
//     else return chonmenu();
//  }
//  void xulymenu() {
//     int c= chonmenu();
//     switch (c)
//     {
//     case 1 :
//     nhap();
//     cout<<endl;
       
//         break;
//       case 2 :
//     doc();
//      cout<<endl;
       
       
//         break;
//           case 3 :
//     sapxep();
//         cout<<endl;
       
//         break;
//       case 4 :
//    vitri();
//         cout<<endl;
       
//         break;
//         case 5 :
//         exit(1);
//         break;
//     }
//  }
 
     
//  int main() {
//     // nhap();
//     // doc();
//     //  sapxep();
//     //  vitri();
//     menu();
//     while(1>0) {
//    //chonmenu();
//     xulymenu();
//     }
//  }
// #include<bits/stdc++.h>
// using namespace std;
// int main() {
//     int F[100],n;
//     cout<<"Nhap n (n la so so hang cua day ) : ";
//     cin>>n;
//     for(int i =0;i<n;i++) {
//         F[0]=1;
//         F[1]=1;
//         F[2]=2;
//         if(i>2) {
//             F[i]=F[i-1]+F[i-2];
//         }
//     }
//     for(int i =0;i<n;i++) {
//         cout<<F[i]<<" ";
//     }
// }
// #include<bits/stdc++.h>
// using namespace std;
// void thay(char a[]) {
//     for(int i = 0;i<strlen(a);i++) {
//         if(a[i]=='x')
//         a[i] = 'y';
//     }
// }
//     int main() {
//         char a[100];
//         cin>>a;
//         thay(a);
//         cout<<a;
//     }
// #include<bits/stdc++.h>
// using namespace std;
// struct doibong {
//   string ten;
//   string tenhl;
//   string tendt;
//   int slcauthu;
//   int slbanthang;
//   int sltrandauthamgia;
// };
// doibong a[100];
// int dem = 0;
// void nhap() {
//     int i= 0;
//      while(1>0) {
//         cout<<"Ten doi bong : ";
//        // cin.ignore();
//         getline(cin,a[i].ten);
//       if(a[i].ten =="*") {
//         break;
//          }
//          cout<<"Huan luyen vien : ";
//         getline(cin,a[i].tenhl);
//          cout<<"Doi truong : ";
//         getline(cin,a[i].tendt);
//         cout<<"So luong cua thu :";
//         cin>>a[i].slcauthu;
//         cout<<"So luong ban thang :";
//         cin>>a[i].slbanthang;
//         cout<<"So luong tran dau tham gia :";
//         cin>>a[i].sltrandauthamgia;
//         cin.ignore();
//         dem++;
//           i++;
//      } 
     
// }
//  void doc() {
//     //  cout<<setw(14)<<left<<"Doi bong"<<left<<"Huan luyen vien"<<setw(23)<<left<<"Doi truong"<<setw(23)<<left<<"so luong cau thu"<<setw(23)<<left<<"so luong ban thang"
//     //     <<setw(30)<<left<<"so luong tran dau tham gia"<<endl;
//     for(int i = 0;i<dem;i++ ) {
//         cout<<setw(13)<<left<<a[i].ten<<setw(23)<<left<<a[i].tenhl<<setw(23)<<left<<a[i].tendt<<setw(23)<<left<<a[i].slcauthu<<setw(23)<<left<<a[i].slbanthang
//         <<setw(30)<<left<<a[i].sltrandauthamgia<<endl;
        
//     }
//  }
//   int  tong() {
//     int tong = 0;
//     for(int i = 0;i<dem;i++) {
//         tong = a[i].slbanthang + tong;
//     }
//     return tong;
//   }
// void tyle() {
//     double c = tong();
//     fstream doibong;
//     doibong.open("doibong.dat",ios::out|ios::binary);
//     cout<<"Danh sach sau khi tinh :"<<endl;
//       for(int i =0;i<dem;i++) {
//         if(c/a[i].sltrandauthamgia > 1.5) {
//            cout<<setw(13)<<left<<a[i].ten<<setw(23)<<left<<a[i].tenhl<<setw(23)<<left<<a[i].tendt<<setw(23)<<left<<a[i].slcauthu<<setw(23)<<left<<a[i].slbanthang
//         <<setw(30)<<left<<a[i].sltrandauthamgia<<endl; 
//         doibong.write((char*)&a[i],sizeof(a[i]));
//         }
//       }
//       doibong.close();
// }
// void sapxep() {
//     for(int i = 0;i<dem;i++) {
//         for(int j = i+1;j<dem;j++) {
//             if(a[i].slcauthu>a[i].slcauthu)
//             swap(a[i],a[j]);
//         }
//     }
// }

// int main() {
//     nhap();
//     doc();
//     tong();
//     tyle();
//     sapxep();
// }
// #include<bits/stdc++.h>
// using namespace std;
// void dao(char a[]) {
//     int d = strlen(a);
//     for(int i=0;i<d;i++) {
//         int c = a[i];
//         a[i]=a[d-1];
//         a[d-1]=c;
//         if(i+1==d||i==d) 
//         break;
//         d--;
//     }
// }
// int main() {
//     char a[100];
//     cout<<"Nhap chuoi : ";
//     cin>>a;
//     dao(a);
//     cout<<"Chuoi sau khi dao nguoc : "<<a;
// }
// #include<bits/stdc++.h>
// using namespace std;
// int n,a[100],dem=0;

// void nhap() {
// fstream mang;
// mang.open("mang.in",ios::out|ios::binary);
//     cout<<"Nhap 1 day so nguyen : "<<endl;
//     while (1>0)
//     {
//         cin>>n;
//         dem++;
//         mang.write((char*)&n,sizeof(n));
//         if(n==0)
//         break;
//     }
//     mang.close();
//     cout<<endl;
// }
// void doc() {
//     fstream doc;
//     doc.open("mang.in",ios::in|ios::binary);
//     cout<<"Mang sau khi doc : ";
//     for(int i=0;i<dem;i++) {
//         doc.read((char*)&a[i],sizeof(a[i]));
//         cout<<a[i];
//     }
//     cout<<endl;
// }
// void sapxep() {
//     int dem1=0;
//   for(int j = 0;j<dem;j++) {
//     for(int i = dem -1;i>0;i--) {
//         if(a[i]% 3==0) {
//             int c = a[i];
//             a[i]=a[i-1];
//             a[i-1] = c;

//         }
//     }
//   }
//   for(int i =0;i<dem;i++) {
//     if(a[i]% 3==0) {
//         dem1++;
//     }
//   }
//   for(int j =0;j<dem;j++) {
//     for(int i =dem-1;i>dem1;i--) {
//         if(a[i]%2==0) {
//         int d = a[i];
//         a[i]=a[i-1];
//         a[i-1]=d;
//     }
//     }
//   }
//   cout<<"Mang sau khi sap xep : ";
//   for(int i=0;i<dem;i++) {
//     cout<<a[i];
//   }
//   cout<<endl;
// }
// void vitri() {
//     fstream vitri;
//     vitri.open("vitri.out",ios::out|ios::binary);
//     int max=a[0],min=a[0],ma=0,mi=0;
//     for(int i = 0;i<dem;i++) {
//         for(int j = i+1;j<dem;j++) {
//            if(max<a[j]) {
//             max = a[j];
//             ma=j;
//            }
//         }
        
//     }
//     for(int i = 0;i<dem;i++) {
//         for(int j = i+1;j<dem;j++) {
//             if(min>a[j]) {
//                 min= a[j];
//                 mi=j;
//             }
//         }
//     }
//     cout<<ma<<" "<<mi<<endl;
//     vitri.write((char*)&ma,sizeof(ma));
//     vitri.write((char*)&mi,sizeof(mi));
//     vitri.close();
    
// }
// void menu() {
//     cout<<"---------------------------------Menu----------------------------------"<<endl;
//     cout<<"1. Nhap lien tiep 1 day so nguyen"<<endl;
//     cout<<"2. Doc noi dung tep mang.in va hien ra man hinh"<<endl;
//     cout<<"3. Sap xep mang theo yeu cau"<<endl;
//     cout<<"4. Ghi vi tri lon nhat va nho nhat tim duoc dau tien vao tep vitri.out"<<endl;
//     cout<<"5. Thoat chuong trinh !!"<<endl;
//     cout<<"---------------------------------------------------------------------------------"<<endl;
// }
// int chonmenu() {
//     int n;
//     cout<<"Chon menu : ";
//     cin>>n;
//     if(0<n<6) 
//     return n;
//     else return chonmenu();
// }
// void xulymenu() {
//     int c= chonmenu();
//     switch (c)
//     {
//         case 1:
//         dem = 0;
//         nhap();
//         break;
//     case 2:
//     doc();
//         break;
//   case 3:
//   sapxep();
//         break;
//         case 4:
//         vitri();
//         break;
//         case 5:
//         exit(1);
//         break;
//     }
// }
// int main() {
//     // nhap();
//     // doc();
//     // sapxep();
//     // vitri();
//     menu();
//     while (true)
//     {
//        xulymenu();
//     }
    
// }
// #include<bits/stdc++.h>
// using namespace std;
// int main()  {
//     double a,b,c;
//     cout<<"Nhap a : ";
//     cin>>a;
//     cout<<"Nhap b : ";
//     cin>>b;
//     cout<<"Nhap c : ";
//     cin>>c;
//     cout<<"Trung binh cong : "<<(a+b+c)/3<<endl;
//     cout<<"Trung binh nhan : "<<pow(a*b*c,1.0/3);
    
    
// }
// #include<bits/stdc++.h>
// using namespace std;
// void dao(char a[]) {
//    int  d = strlen(a);
//     for(int i =0;i<d;i++) {
        
//         int c = a[i];
//         a[i] = a[d-1];
//         a[d-1]=c;
//         if(i+1==d||i==d) 
//         break;
//         d--;

//     }

// }
// int main() {
//     char a[100];
//     cout<<"Nhap vao 1 chuoi : ";
//     cin>>a;
//     dao(a);
//     cout<<"Chuoi sau khi : "<<a;
// }
// #include<bits/stdc++.h>
// using namespace std;
// int main() {
//     int n;
//     cout<<"Nhap n ( la so cac so hang cua chuoi ) : ";
//     cin>>n;
//     int F[n];
//     for(int i = 0;i<n;i++) {
//         F[0]=F[1]=1;
//         F[2]=2;
//         if(i>2) {
//             F[i]=F[i-1] + F[i-2];
//         }
//     }
//     for(int i =0;i<n;i++) {
//         cout<<F[i]<<" ";
//     }
// }
// #include<bits/stdc++.h>
// using namespace std;
// void thay(char a[]) {
//     for(int i = 0;i<strlen(a);i++) {
//         if(a[i]=='x')
//         a[i]='y';
//     }
// }
// int main() {
//     char a[100];
//     cout<<"Nhap 1 chuoi : ";
//     cin>>a;
//     thay(a);
//     cout<<a;
// }
// #include<bits/stdc++.h>
// using namespace std;
// int n=1,a[100],dem=0;
// void nhap() {
//     fstream mang;
//     mang.open("mang.in",ios::out|ios::binary);
//     int i = 0;
//     cout<<"Nhap day so nguyen : ";
//     while(1>0) {
       
//         cin>>n;
//         dem++;
//      if(n==0)
//         break;
        
//         mang.write((char*)&n,sizeof(n));
//     }
//     mang.close();
// }
// void doc() {
//     fstream doc;
//     doc.open("mang.in",ios::in|ios::binary);
//     cout<<"Hien mang sau khi doc : ";
//     for(int i = 0;i<dem;i++) {
//         doc.read((char*)&a[i],sizeof(a[i]));
//         cout<<a[i]<<" ";
//     }
//     doc.close();
//     cout<<endl;
// }
// void sapxep() {
//     int dem1=0;
//     for(int j=0;j<dem;j++) {
//         for(int i =dem-1;i>0;i--) {
//             if(a[i]%3==0){
//                 int c= a[i];
//                 a[i]=a[i-1];
//                 a[i-1]=c;
//             }
//         }
//     }
//     for(int i =0;i<dem;i++) {
//         if(a[i]%3==0)
//         dem1++;
//     }
//     for(int j=0;j<dem;j++) {
//         for(int i =dem-1;i>dem1;i--) {
//             if(a[i]%2==0){
//                 int d= a[i];
//                 a[i]=a[i-1];
//                 a[i-1]=d;
//             }
//         }
//     }
//     cout<<"Mang sau khi sap xep : ";
//      for(int i =0;i<dem;i++) {
//         cout<<a[i];
        
//     }
//     cout<<endl;
// }
// void vitri() {
//     fstream vitri;
//     vitri.open("vitri.out",ios::out|ios::binary);
//     int max =a[0],min = a[0],mi,ma;
//     for(int i = 0;i<dem;i++) {
//         for(int j = i+1;j<dem;j++) {
//             if(max<a[j]) {
//             max = a[j];
//             ma = j;
//             }
//         }
//     }
//     for(int i = 0;i<dem;i++) {
//         for(int j = i+1;j<dem;j++) {
//             if(min>a[j]) {
//              min = a[j];
//              mi = j;
//             }
//         }
//     }
//     vitri.write((char*)&ma,sizeof(ma));
//     vitri.write((char*)&mi,sizeof(mi));
//     cout<<ma<<" "<<mi<<endl;
// }
// void menu() {
//     cout<<"_______________________________Menu_________________________________"<<endl;
//     cout<<"1. Nhap day so nguyen luu vao file mang.in"<<endl;
//     cout<<"2. Doc nd tep mang.in roi luu vao mang so nguyen va hien ra man hinh"<<endl;
//     cout<<"3. Sap xep mang theo yeu cau"<<endl;
//     cout<<"4. Ghi vi tri lon nhat va nho nhat tim duoc dau tien tim duoc vao file vitri.out "<<endl;
//     cout<<"5. thoat chuong trinh!!"<<endl;
//     cout<<"_____________________________________________________________________"<<endl;
// }
// int chonmenu() {
//     int n;
//     cout<<"Chon menu : "; cin>>n;
//     if(0<n<6)
//     return n;
//     else return chonmenu();
// }
// void xulymenu() {
//     int c= chonmenu();
//     switch(c) {
//         case 1:
//         dem = 0;
//         nhap();
//         break;
//          case 2:
//          doc();
//         break;
//          case 3:
//          sapxep();
//         break;
//          case 4:
//          vitri();
//         break;
//          case 5:
//          cout<<"Thoat chuong trinh!!";
//          exit(1);
//         break;
//     }
// }
// int main() {
//     // nhap();
//     // doc();
//     // sapxep();
//     // vitri();
//     menu();
//     while (true)
//     {
//         xulymenu();
//     }
    
// }
// #include<bits/stdc++.h>
// using namespace std;
// struct doibong {
//     string ten;
//     string tenhl;
//     string tendt;
//     int slbanthang;
//     int slcauthu;
//     int sltrandau;
// };
// doibong a[100];
// int dem=0;
// void nhap() {
//     int i =0;
//     cin.ignore();
//     while(1>0) {
        
//          cout<<"Ten doi bong : ";
//          getline(cin,a[i].ten);
//          if(a[i].ten=="*") 
//         break;
//           cout<<"Ten huan luyen vien : ";
//          getline(cin,a[i].tenhl);
//           cout<<"Ten doi truong  : ";
//          getline(cin,a[i].tendt);
//          cout<<"So luong cau thu : ";
//          cin>>a[i].slcauthu;
//          cout<<"So luong ban thang : ";
//          cin>>a[i].slbanthang;
//          cout<<"So luong tran dau : ";
//          cin>>a[i].sltrandau;
         
//          dem++;
//          i++; 
//          cin.ignore();
//     }    
//     }
// void hien() {
//     cout<<setw(13)<<left<<"Ten"
//     <<setw(20)<<left<<"Huan luyen vien"
//     <<setw(20)<<left<<"Doi truong"
//     <<setw(20)<<left<<"So luong cau thu"
//     <<setw(20)<<left<<"So luong ban thang"
//     <<setw(20)<<left<<"So luong tran dau"<<endl;
//     for(int i =0;i<dem;i++) {
//  cout<<setw(13)<<left<<a[i].ten<<setw(20)<<left<<a[i].tenhl<<setw(20)<<left<<a[i].tendt<<setw(20)<<left<<a[i].slcauthu<<setw(20)<<left<<setw(20)<<left<<a[i].slbanthang<<setw(20)<<left<<a[i].sltrandau<<endl;
        
//           }
// }
// int tong() {
//     double tong;
//     for(int i =0;i<dem;i++) {
//         tong = tong + a[i].slbanthang;
//     }
//     return tong;
// }
// void tyle() {
//     fstream doibong;
//     double d = tong();
//     doibong.open("doibong.dat",ios::out|ios::binary);
//     for(int i=0;i<dem;i++) {
//      if(d/a[i].sltrandau > 1.5) {
//         doibong.write((char*)&a[i],sizeof(a[i]));
//         cout<<setw(13)<<left<<a[i].ten<<setw(20)<<left<<a[i].tenhl<<setw(20)<<left<<a[i].tendt<<setw(20)<<left<<a[i].slcauthu<<setw(20)<<left<<setw(20)<<left<<a[i].slbanthang<<setw(20)<<left<<a[i].sltrandau<<endl;
//      }
//     }
//     doibong.close();
// }
// void sapxep() {
//     for(int i =0;i<dem;i++) {
//         for(int j =i+1;j<dem;j++) {
//               if(a[i].slcauthu > a[j].slcauthu) 
//               swap(a[i],a[j]);
//         }
//     }
// }
// void menu() {
//     cout<<"____________________________________Menu_____________________________"<<endl;
//     cout<<"1. Nhap danh sach cac doi bong"<<endl;
//     cout<<"2. Hien thi thong tin doi bong"<<endl;
//     cout<<"3.Hien ra man hinh doi co ty so ban thang va file doibong.dat"<<endl;
//     cout<<"4. Sap xep theo danh sach doi bong tang dan"<<endl;
//     cout<<"5. Thoat chuong trinh!!"<<endl;
//     cout<<"____________________________________________________"<<endl;
// }
// int chonmenu() {
//     int n;
//     cout<<"Chon menu : "; cin>>n;
//     if(0<n<6) 
//     return n;
//     else return chonmenu();
// }
// void xulymenu() {
//     int c=chonmenu();
//     switch (c) {
//         case 1:
//          cout<<"Nhap danh sach cac doi bong"<<endl;
//          dem = 0;
//          nhap();
//         break;
//         case 2:
//         cout<<"Hien thi thong tin doi bong"<<endl;
//         hien();
//         break;
//         case 3:
//         cout<<"Hien ra man hinh doi co ty so ban thang va file doibong.dat"<<endl;
//         tyle();
//         break;
//         case 4:
//         cout<<"Sap xep theo danh sach doi bong tang dan"<<endl;
//         sapxep();
//         break;
//         case 5:
//           cout<<"Thoat chuong trinh!!"<<endl;
//           exit(1);
//         break;
//     }
// }
// int main() {
//     // nhap();
//     // hien();
//     // tong();
//     // tyle();
//     // sapxep();
//     menu();
//     while(true) {
//         xulymenu();
//     }
// }
// #include<bits/stdc++.h>
// using namespace std;
// void dao(char a[]) {
//    int d = strlen(a);
//    for(int i = 0;i<d;i++) {
//       int c= a[i];
//       a[i]=a[d-1];
//       a[d-1]=c;
//       if(i+1==d || i==d)
//       break;
//       d--;
//    }
// }
// int main() {
//     char a[100];
//     cout<<" Nhap chuoi : ";
//     cin>>a;
//     dao(a);
//     cout<<a;
// }
// #include<bits/stdc++.h>
// using namespace std;
// void thay(char a[]) {
//     int d = strlen(a);
//     for(int i =0;i<d;i++) {
//         if(a[i]=='x') {
//             a[i]='y';
//         }
//     }
// }
// int main() {
//     char a[100];
//     cout<<"Nhap chuoi : ";
//     cin>>a;
//     thay(a);
//     cout<<a;
// }
// #include<bits/stdc++.h>
// using namespace std;
// struct doibong {
//     string ten;
//     string tenhl;
//     string tendt;
//     int slcauthu;
//     int slbanthang;
//     int sltrandau;
// };
// doibong a[100];
// int dem=0,n[100];
// void nhap()  {
//     fstream mang;
//     mang.open("mang.in",ios::out|ios::binary);
//          int i =0;
//          while (1>0)
//          {
//            cout<<"Ten doi bong : ";
//            getline(cin,a[i].ten);
//            if(a[i].ten == "*")
//            break;
//             cout<<"Ten huan luyen vien : ";
//            getline(cin,a[i].tenhl);
//             cout<<"Ten doi truong : ";
//            getline(cin,a[i].tendt);
//            cout<<"So luong cau thu : ";
//            cin>>a[i].slcauthu;
//            cout<<"So luong ban thang : ";
//            cin>>a[i].slbanthang;
//            cout<<"So luong tran dau tham gia : ";
//            cin>>a[i].sltrandau;
//            mang.write((char*)&a[i],sizeof(a[i]));
//            cin.ignore();
//            i++;
//            dem++;
//          }
//    mang.close();       
// }
// int main() {
//     nhap();
// }
// #include<bits/stdc++.h>
// using namespace std;
// // #pragma once
// //#include "Person"
// class Person {
//     private :
//     string name;
//     string address;
//     public:
//     Person(string name,string address) {
//         this->name=name;
//         this->address = address;
//         }
//     // void setName(string name) {
//     //     this->name=name;
//     // }
//     string getName() {
//         return name;
//         }
//     // void setAddress(string address) {
//     //     this->address=address;
//     // }
//     string getAddress() {
//         return address;
//         }
//     virtual void display() = 0;
// };
// //#include "Employee"
// class Employee:public Person {
//    private:
//     int salary;
//      public:
//     Employee(string name,string address,int salary): Person(name,address) {
//         // ' this-> name = name;
//         // ' this-> address = address;
//         this-> salary = salary;
//     }
//     void display() {
//         cout<<"Name = "<<Person::getName()<<endl;
//         cout<<"address = "<<Person::getAddress()<<endl;
//         cout<<"salary = "<<salary<<endl;
//     }
// };
// //#include "Customer"
// class Customer :public Person {
//     private:
//     int balance;
//     public :
//     Customer(string name,string address,int balance): Person(name,address){
//         // ' this-> name = name;
//         // ' this-> address = sddress;
//         this-> balance = balance;
//     }
//     void display() {
//         cout<<"Name = "<<Person::getName()<<endl;
//         cout<<"address = "<<Person::getAddress()<<endl;
//         cout<<"balance = "<<balance<<endl;
//     }
// };



// int main() {
// 	Person *person1 = new Employee("Trung", "HN", 3300);
// 	Person *person2 = new Customer("Linh", "BN", 10400);
// 	person1->display();
// 	person2->display();
// 	return 0;
// }
// #include<bits/stdc++.h>
// using namespace std;
// class Point {
//     private:
//     int x;
//     int y;
//     public:
//     Point() {

//     }
//     Point(int x,int y) {
//         this->x=x;
//         this->y=y;
//     }
//     int setX() {
//         return x;
//     }
//     int setY() {
//         return y;
//     }
//     void getX(){
//         this->x=x;
//     }
//     void getY() {
//          this->y=y;
//     }
  
 
// };
// class Triangle {
//     private:
//     Point vertice1;
//     Point vertice2;
//     Point vertice3;
//     public:
//     Triangle(Point vertice1,Point vertice2,Point vertice3) {
//         this->vertice1=vertice1;
//         this->vertice2=vertice2;
//         this->vertice3=vertice3; 
//     }
//     Triangle(int x1,int y1,int x2,int y2,int x3,int y3) {
//          vertice1 = Point(x1, y1);
// 		vertice2 = Point(x2, y2);
// 		vertice3 = Point(x3, y3);
//     }
//     double getPerimeter() {
//         double cv;

//         return cv;
//     }
// };
// #include<bits/stdc++.h>
// using namespace std;
// class Fibonaci {
//     private:
//     int a[100];
//     int n;
//     public:
//     Fibonaci(int n) {
//         cout<<"Nhap n :";
//         cin>>n;
//         this->n=n;
//     }
//     void tinhxuat() {
       
//         for(int i = 0;i<n;i++) {
//             a[0]=a[1]=1;
//             if(i>=2) {
//                 a[i]=a[i-1]+a[i-2];
//             }
//         }
//         cout<<n<<" so hang dau cua day Fibonaci la : ";
//         for(int i = 0;i<n;i++) {
//             cout<<a[i]<<" ";
//         }
//     }
// };
// int main() {
//     Fibonaci a(0);
//     a.tinhxuat();
// }
// #include<bits/stdc++.h>
// using namespace std;
// class dientich {
//     private:
//     double S;
//     double p;
//     double a;
//     double b;
//     double c;
//     public:
//     dientich(double a,double b,double c) {
//         cout<<"a=";
//         cin>>a;
//         cout<<"b=";
//         cin>>b;
//         cout<<"c=";
//         cin>>c;
//         this->a=a;
//         this->b=b;
//         this->c=c;
//     }
//     void tinh(double p, double S) {
//         p = (a+b+c)/2;
//         S = sqrt(p*(p-a)*(p-b)*(p-c));
//         cout<<"Dien tich : "<<S;
//     }
// };
// int main() {
//     dientich a(0,0,0);
//     a.tinh(0,0);
// }
// #include<bits/stdc++.h>
// using namespace std;
// class thongtin {
//     private:
//     struct sinhvien
//     {
//     string masv;
//     string ten;
//     string lop;
//     int buoian;
//     };
//     sinhvien a[100];
//     int n;
//     int tien;
//     public:
    
//     thongtin(string masv,string ten,string lop,int buoian) {
//         cout<<"Nhap so luong sinh vien : ";
//         cin>>n;
//         for(int i =0;i<n;i++) {
//         cout<<"Ma sinh vien :";
//         cin>>a[i].masv;
//         cout<<"Ten sv : ";
//         cin>>a[i].ten;
//         cout<<"Lop : ";
//         cin>>a[i].lop;
//         cout<<"Buoi an ban tru : ";
//         cin>>a[i].buoian; 
//         this->a[i].masv=a[i].masv;
//         this->a[i].ten=a[i].ten;
//         this->a[i].buoian=a[i].buoian;
//         this->a[i].lop=a[i].lop;
//         }
       
//     }
//     void xuat() {
//          for(int i =0;i<n;i++) {
//         cout<<setw(15)<<left<<a[i].masv
//         <<setw(15)<<left<<a[i].ten<<setw(15)<<left<<a[i].lop
//         <<setw(20)<<left<<a[i].buoian<<endl;
//          }
//          cout<<endl;
//     }
//     int tienbantru(int tien) {
//          for(int i =0;i<n;i++) {
//             tien = a[i].buoian*30 + tien;
//             this->tien=tien;
//          }
//          cout<<"Tong so tien : "<<tien<<"000"<<endl;
//          return tien;
//     }
//     void sapxep() {
//         for(int i = 0;i<n;i++) {
//             for(int j = i+1;j<n;j++) {
//             if(a[i].buoian > a[j].buoian )
//               swap(a[i],a[j]);

//         }
//         }
//       xuat();
//       cout<<endl;
//     }
//     void danhsach() {
//         for(int i = 0;i<n;i++) {
//             if(a[i].buoian>20) {
//         cout<<setw(15)<<left<<a[i].masv
//         <<setw(15)<<left<<a[i].ten<<setw(15)<<left<<a[i].lop
//         <<setw(20)<<left<<a[i].buoian<<endl;
//             }
//         }
//     }
// };
// int main() {
//     thongtin b("0","0","0",0);
//     b.xuat();
//     b.tienbantru(0);
//     b.sapxep();
//     b.danhsach();
// }
