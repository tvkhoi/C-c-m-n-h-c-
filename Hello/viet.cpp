#include<bits/stdc++.h>
using namespace std;
// cấu trúc của sinh viên
struct sinhvien{
   char masv[30];
   char hoten[30];
   char lop[20];
   double diemLyThuyet;
   double diemThucHanh;
   double diemThi;
   double diemTb;
};
// cấu trúc của 1 node 
struct node{
    sinhvien sv;
    node *next;
};
// cấu trúc của 1 danh sách liên kết các node
struct listf
{
   node *phead;
   node *ptail;
};
// khởi tạo 1 node sinh viên
node *khoitaoNode(sinhvien sv) {
    node * p = new node;
    if(p == NULL) {
        cout<<"Bo nho khong du de cap phat!!";
        return NULL;
    }
    else {
        p->sv=sv;
        p->next=NULL;
    }
    return p;
}
// khởi tạo 1 danh sách liên kết
void khoitaods(listf &l) {
    l.phead =NULL;
    l.ptail =NULL;
}

// thêm phần tử vào đầu danh sách khi tạo danh sách
void add(listf &l,node*p) {
      if(l.phead==NULL) {
        l.phead=l.ptail=p;
      }
      else {
        p->next=l.phead;
        l.phead = p;
      }
}
// tìm kiếm phần tử mã sinh viên và xóa
void seachMaSV(listf &l){
    string masv;
    
    cout<<"Nhap ma sinh vien can tim(xoa):";
    cin>>masv;
    string a =l.phead->sv.masv;
    string b = l.ptail->sv.masv; 
    
    if(a==masv) {
        node *p = new node;
        p = l.phead;
        l.phead=l.phead->next;
        delete p;
    }
    node *p =new node;
    if(b==masv) {
        for(node *k =l.phead;k!=NULL;k=k->next) 
    {
        string a=k->sv.masv;
         if(a==masv) {
           node* q= new node;
           q=k;
            delete q; 
            l.ptail = p;
           
            return;
        }                                           
         p = k;
    }
        
        delete l.ptail; 
    } 
   
    for(node *k =l.phead;k!=NULL;k=k->next) 
    {
        string a = k->sv.masv;
        if(a==masv) {
            p->next=k->next;
            delete k; 
            return;
        }
         p = k;
    }
}  
void nhap(listf &l) {
    int n;
    cout<<"So phan tu cua danh sach lien ket: ";
    cin>>n;

    for(int i=0;i<n;++i) {
         cout<<"****Nhap sinh vien******:"<<i+1<<endl;
         sinhvien sv;
         cout<<"Ma sv:";
         cin>>sv.masv;
         cout<<"Ho va ten:";
         cin>>sv.hoten;
         cout<<"Lop:";
         cin>>sv.lop;
         cout<<"Diem ly thuyet:";
         cin>>sv.diemLyThuyet;
         cout<<"Diem thuc hanh:";
         cin>>sv.diemThucHanh;
         cout<<"Diem thi:";
         cin>>sv.diemThi;
         cout<<"Diem trung binh:";
         cin>>sv.diemTb;
         node * p=khoitaoNode(sv);
         add(l,p);
    }
}      
void hien(listf l) {
         while (l.phead !=NULL)
    {
        cout<<l.phead->sv.masv
        <<l.phead->sv.hoten
        <<l.phead->sv.lop
        <<l.phead->sv.diemLyThuyet
        <<l.phead->sv.diemThucHanh
        <<l.phead->sv.diemThi
        <<l.phead->sv.diemThucHanh<<endl;
        cout<<"______________________________"<<endl;
        l.phead=l.phead->next;
    }
    
    }
void menu() {
    cout<<"1.Nhap danh sach lien ket."<<endl;
    cout<<"2.Xoa phan tu khoa k trong danh sach"<<endl;
    cout<<"3.Hien danh sach lien ket."<<endl;
    cout<<"0.Thoat khoi chuong trinh!!.";
}
int main() {
    listf l;
    khoitaods(l);
    int luaChon;
    do
    {   menu();
    cout<<endl;
        cout<<"Chon menu :";
        cin>>luaChon;
        if(luaChon == 1 ) {
            nhap(l);
        }
        
        if(luaChon == 2) {
            seachMaSV(l);
        }
        if(luaChon == 3) {
            hien(l);
        }
    } while (luaChon!=0);

    
  
    
   
}