#include<bits/stdc++.h>
using namespace std;
// khai báo cấu trúc của nhân viên

// khai báo cấu trúc của một nút trong stack
struct node
{
    /* data */
    int data;
    node *pnext;

};

// khai báo 1 stack để lưu trữ
struct Stack
{
    node *ptop;
};
// tạo 1 node 
node * khoitaonode(int data) {
    node *p = new node;
    if(p==NULL) {
        cout<<"Khong bo nho de khoi tao";
        return NULL;
    }
    else {
        p->data = data; // luu giá trị vào node
        p->pnext=NULL; 
    }
    return p; // trả về địa chỉ node p
}
// khởi tạo 1 stack
void khoitaostack(Stack &s) {
     s.ptop=NULL;
}
// kiểm tra xem danh sách có rổng hay không
bool IsEmpty(Stack &s) {
    if(s.ptop==NULL) {
        return true;
    }
    return false;
}
//  thêm 1 nhân viê n vào đầu stack
bool themvaodau(Stack &s,node*p) {
    if(p == NULL) {
        return false;
    }
    //Nếu danh sách rỗng
    if(IsEmpty(s)==true) {
        s.ptop=p;
    }
    else {
        p->pnext=s.ptop; 
        s.ptop = p;
    }
     
     return true;
}
// hàm duyệt phần tử stack 
bool pop(Stack &s,int &data) {
    if(IsEmpty(s)==true) {
        return false;
    }
    else {
        node *p=s.ptop;
        data = p->data;
        s.ptop=s.ptop->pnext;
        delete p;
    }
    return true;
}
// hàm xuất
void xuatstack(Stack s)  {
   while (IsEmpty(s)==false)
   {
    int data;
    pop(s,data);
     cout<<data<<" ";
   }
   
}
// hàm tính tổng lương của nhân viên
double tinhTong(Stack s) {
    double tong=0;
  while (s.ptop!=NULL)
  {
    /* code */
    tong = tong + s.ptop->data;
    s.ptop = s.ptop->pnext;
  }
  return tong;
}
int main() {
Stack s;
khoitaostack(s);
int luaChon;
do
{   cout<<"_______________________Menu__________________________"<<endl;
    cout<<"1.Them mot nhan vien vao dau danh sach."<<endl;
    cout<<"2.Hien danh sach nhan vien."<<endl;
    cout<<"3.Tinh tong luong cua tat ca nhan vien trong danh sach."<<endl;
    cout<<"0.Thoat chuong trinh!!."<<endl;
    cout<<"_______________________End__________________________"<<endl;
    cout<<"***Chon Menu*****:";
    cin>>luaChon;
    cout<<endl;
    if(luaChon==1) {
      
        int data;
        cout<<"Nhap data : ";
        cin>>data;
        node *p=new node;
        p=khoitaonode(data);
        themvaodau(s,p);
        
    }
    if(luaChon==2) {
        //  nhanvien nv;
        //  pop(s,nv);
    //    xuatstack(s);
       // s.ptop = s.ptop->pnext;
     //  }
     Stack p =s;
     while (p.ptop!=NULL)
     {
        
        cout<<p.ptop->data<<" ";
        p.ptop=p.ptop->pnext;
        
        /* code */
     }
     
       
    }
    if(luaChon==3) {
         cout<<"Tong:"<<tinhTong(s);
    }
} while (luaChon!=0);

}