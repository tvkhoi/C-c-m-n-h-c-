#include<bits/stdc++.h>
using namespace std;
int a[99];
int n=0;
void nhap() {
    cout<<"Nhap n so phan tu trong mang: ";
    cin>>n;
    for(int i =0;i<n;i++) {
        cout<<"a["<<i<<"]=";
        cin>>a[i];
    }
}
void sapxepchon() {
    int min;
     for(int i =0;i<n;i++) {
         min =i;
        for(int j=i+1;j<n;j++) {
            if(a[j]<a[min]) {
                min = j;
                 int tg = a[min];
                 a[min]=a[i];
                 a[i]=tg;
            }
            }
        }
}
 
 void sapxepchen() {
    int j;
      for(int i =1;i<n;i++) {
        j = i;
        while (j>0&&a[j]<a[j-1])
        {
          int pos = a[j];
          a[j]=a[j-1];
          a[j-1]=pos;
          j--;
        }
        
      }

 }
 void sapxepnoibot() {
    for(int i =0;i<n-1;i++) {
        for(int j =0;j<n-1;j++) {
            if(a[j]>a[j+1]) {
                int tem = a[j];
                a[j] = a[j+1];
                a[j+1]=tem;      
                      }
        }
    }
 }


void quickSort(int l, int r){
	int p = a[(l+r)/2];
	int i = l, j = r;
	while (i < j){
		while (a[i] < p){
			i++;
		}
		while (a[j] > p){
			j--;
		}
		if (i <= j){
			int temp = a[i];
			a[i] = a[j];
			a[j] = temp;
			i++;
			j--;
		}
	}
	if (i < r){
		quickSort(i, r);
	}
	if (l < j){
		quickSort(l, j);
	}
}
void merge(int l, int m, int r) 
{ 
    int n1 = m - l + 1; 
    int n2 = r - m; 
  
   
    int L[n1], R[n2]; 
  
 
    for(int i = 0; i < n1; i++) 
        L[i] = a[l + i]; 
    for(int j = 0; j < n2; j++) 
        R[j] = a[m + 1 + j]; 
    int i = 0;  
    int j = 0;  
    int k = l; 
      
    while (i < n1 && j < n2) 
    { 
        if (L[i] <= R[j])  
        { 
            a[k] = L[i]; 
            i++; 
        } 
        else 
        { 
            a[k] = R[j]; 
            j++; 
        } 
        k++; 
    } 
    while (i < n1)  
    { 
        a[k] = L[i]; 
        i++; 
        k++; 
    } 
    while (j < n2) 
    { 
        a[k] = R[j]; 
        j++; 
        k++; 
    } 
} 
void mergeSort(int l, int r) 
{ 
    if (l < r) 
    { 
        int m = l + (r - l) / 2; 
        mergeSort(l, m); 
        mergeSort(m + 1, r); 
        merge(l, m, r); 
    } 
} 
void hien() {
    for(int i =0;i<n;i++) {
        cout<<a[i]<<" ";
    }
    cout<<endl;
}
void danhSachMenu() {
    cout<<"_____________________Menu_______________________"<<endl;
    cout<<"1.Nhap danh sach mang 1 chieu."<<endl;
    cout<<"2.Sap xep day so tang dan (sap xep chon)."<<endl;
    cout<<"3.Sap xep day so tang dan (sap xep chen)."<<endl;
    cout<<"4.Sap xep day so tang dan (sap xep noi bot)."<<endl;
    cout<<"5.Sap xep nhanh(Quick Sort)."<<endl;
    cout<<"6.Sap xep tron(MergeSort)."<<endl;
    cout<<"7.Hien danh sach mang sau sap xep."<<endl;
    cout<<"8.Thoat chuong trinh!!!"<<endl;
}
int chonMenu() {
    int chon;
    cout<<"************Chon menu************ : ";
    cin>>chon;
    if(0<chon<6)
    return chon;
    else    
    return chonMenu();
}
void xulyMenu() {
    int c = chonMenu();
    switch (c)
{
    case 1:
    {
        nhap();
         break;
    }
    case 2:
    {
       sapxepchon();
        break;
    }
    case 3:
    {
        sapxepchen();
        break;
    }
    case 4:
    {
        sapxepnoibot();
        break;
    }
    case 7:
    {
        hien();
        break;
    }
    case 5: 
    {
        quickSort(0,n-1);
        break;
    }
    case 6:
    {
        mergeSort(0,n-1);
        break;
    }
    case 8: 
    {
        exit(0);
        break;
    }
}
}
int main() {
danhSachMenu();
while (true)
{
    xulyMenu();
}
}