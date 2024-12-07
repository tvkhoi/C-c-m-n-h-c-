// #include<bits/stdc++.h>
// using namespace std;

// struct danhsachsv 
// {
// 	/* data */
// 	string name;
// 	string masv;
// 	string lop;
// };
// danhsachsv a[100];
// int n;
// void nhap()  {
// 	cout<<"Nhap so phan tu n : ";
// 	cin>>n;
// 	cin.ignore();
//     for(int i = 0; i< n;i++) {
// 		cout<<"Ten : ";
// 		//cin.ignore();
// 		getline(cin,a[i].name);
		
// 		cout<<"Ma sv : ";
// 		//cin.ignore();
// 		cin>>a[i].masv;
		
// 		cout<<"Lop : ";
// 		//cin.ignore();
// 		cin>>a[i].lop;
// 	}
// }
 
// void xuat() {
// 	cout<<"\n____________________________________________________________________________________\n";
//     cout<<"Ten";
//     cout<<right<<setw(40)<<"Ma sv";
// 	cout<<right<<setw(10)<<"Lop";
// 	//cout<<endl;
// for(int i = 0;i<n;i++) {
// 	cout<<a[i].name;
// 	cout<<right<<setw(40)<<a[i].masv;
// 	cout<<right<<setw(10)<<a[i].lop<<endl;

// }

// }


// int main() {
// // freopen("nhap.in","r",stdin);
// // freopen("xuat.out","w",stdout);
// 	nhap();
// 	//xuat();
// 	cout<<a[0].name;
// }
// #include<bits/stdc++.h>
// using namespace std;

// fstream tep("nghich.txt");
// int a[100];
// int main() {
// string n;
// cout<<"Nhap : ";
// getline(cin,n);
// tep<<n;
//   fstream doc("nghich.txt");
//   for(int i =0;i<5;i++)
//   doc>>a[i];
  
//   for(int i = 0;i<5;i++) {
//     cout<<a[i];
//   }
// }
// #include<iostream>
// #include<string.h>
// #include<iomanip>
// #include<fstream>
// using namespace std;
// typedef struct{
// 	char tensach[30];
// 	char tentgia[30];
// 	char nsban[100];
// 	int namsb;}dulieu;
// typedef dulieu m[100][200];
// void nhap(dulieu a[ ],int &n){
// 	int i;
// 	cout<<"nhap so nguoi:";
// 	cin>>n;

// 	for(i=1;i<=n;i++){
// 	//	for(int j=0;j<n;j++){
// 		fflush(stdin);
// 		cout<<"nhap ten sach:";
// 		gets(a[i].tensach);		
// 		cout<<"nhap ten tac gia:";
// 		gets(a[i].tentgia);
// 		cout<<"nha xuat ban:";
// 		gets(a[i].nsban);
// 		cout<<"nam xuat ban:";
// 		cin>>a[i].namsb;
// 	}
// }				
// void xuat(dulieu a[ ],int &n){
// 	int i;
// 	cout<<"xuat danh sach:";
// 		cout<<"\nten sach"<<setw(15)<<"ten tac gia"<<setw(15);
// 	cout<<"nha xuat ban"<<setw(20)<<"nam xuat ban"<<endl;
// 	for(i=1;i<=n;i++){
// 		//for(j=0;j<n;j++){
// 		//fflush(stdin);
// 		cout<<a[i].tensach;
// 		cout<<setw(15)<<a[i].tentgia;
// 		cout<<setw(15)<<a[i].nsban;
// 		cout<<setw(20)<<a[i].namsb<<endl;
	
// 	}
// }
// void xep(dulieu a[ ],int &n){
// 	int i,j;
// 	int dem;
// 	char t[20];
// 	  for (i = 1; i <=n; i++) {
//        for (j = i; j <n; j++) {
//          if (strcmp(a[j].tensach, a[j+1].tensach) > 0) {
//             strcpy(t, a[j].tensach);
//             strcpy(a[j].tensach, a[j+1].tensach);
//             strcpy(a[j+1].tensach, t);
//             strcpy(t, a[j].tentgia);
//             strcpy(a[j].tentgia, a[j+1].tentgia);
//             strcpy(a[j+1].tentgia, t);
//             strcpy(t, a[j].nsban);
//             strcpy(a[j].nsban, a[j+1].nsban);
//             strcpy(a[j+1].nsban, t);
//             dem=a[j].namsb;
//             a[j].namsb=a[j+1].namsb;
//             a[j+1].namsb=dem;  }  
//                }    
//             }
//    fstream ghitep("sach1.txt");
//    if(ghitep.is_open()){
//   	ghitep<<"danh sach sach sau khi xep:";
//    	for(i=1;i<=n;i++){		
// 		ghitep<<"\n-ten sach:"<<a[i].tensach;
// 		ghitep<<"\nten tacgia:"<<a[i].tentgia;
// 		ghitep<<"\nnha xuat ban:"<<a[i].nsban; 
// 		ghitep<<"\nnam xuat ban:"<<a[i].namsb;}
// 		ghitep.close(); 
//    		}
//    else cout<<"ko dc";	
// }   
// int main()
// {dulieu a[100];
//  int  n;
//  int dem=1;
// nhap(a,n);
// system("pause");
// system("cls");
// while(dem!=0){
// 	cout<<"he thong menu:";
// 	cout<<"\n1.hien danh sach:";
// 	cout<<"\n2.xep danh sach theo chu cai";
// 	cout<<"\n3.thong ke sach X in o nsb Y";
// 	cout<<"\n0.thoat ctrinh";
// 	cout<<"\nmoi nhap lua chon:";
// 	cin>>dem;
// //	systeam("cls");
// 	if (dem==1){
// 		xuat(a,n);
// 		cout<<endl;
// 	}
// 	else if(dem==2){
// 		xep(a,n);
// 		cout<<endl;
// 	}
// 	else if(dem==3){
// 		cout<<"chua co:("<<endl;
// 	}
// 	else {break;}
// 	system("pause");
// 	system("cls");
//      }		
// //xuat(a,n);
// //xep(a,n);
// //xuat(a,n);
// }
#include<bits/stdc++.h>
using namespace std;


//tentep.close();
int main() {
 fstream nhap("nghich.txt",ios::out);
int a[100],dem=0,i=0;
int n[100];
while (1>0)
{
	/* code */
	cout<<"n["<<i<<"] = ";
	cin>>n[i];
	
	nhap<<n[i];
	nhap<<" ";
	dem++;
	if(n[i]==0) 
	break;
	i++;
}


	
 	nhap.close();
fstream doc("nghich.txt",ios::in);
// do {
// doc.read((char*)&a[i],sizeof(a[i]));
// i++;
// }while (i<dem);
// cout<<a[0];
// cout<<a[1];
// for(int i =0;i<dem;i+++) {
   for(i = 0 ;i<5;i++) {
	doc>>a[i];
   }
cout<<a[1]<<endl;
cout<<a[1]<<endl;
cout<<a[1];
//}
}