#include<bits/stdc++.h>
using namespace std;
// khai báo cấu trúc của nhân viên
struct nhanvien
{
    /* data */
    int masNhanVien;
    char hoten[20];
    char ngaysinh[20];
    double tongluong;
};
// khai báo cấu trúc của một nút trong stack
struct node
{
    /* data */
    nhanvien nv;
    node *pnext;

};

// khai báo 1 stack để lưu trữ
struct Stack
{
    node *ptop;
};
// tạo 1 node 
node * khoitaonode(nhanvien nv) {
    node *p = new node;
    if(p==NULL) {
        cout<<"Khong bo nho de khoi tao";
        return NULL;
    }
    else {
        p->nv=nv; // luu giá trị vào node
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
//  thêm 1 nhân viên vào đầu stack
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
bool pop(Stack &s,nhanvien &nv) {
    if(IsEmpty(s)==true) {
        return false;
    }
    else {
        node *p=s.ptop;
        nv = p->nv;
        s.ptop=s.ptop->pnext;
        delete p;
    }
    return true;
}
// hàm xuất
void xuatstack(Stack s)  {
    Stack p =s;
     while (p.ptop!=NULL )
     {
          cout<<p.ptop->nv.masNhanVien<<""<<p.ptop->nv.hoten<<""<<p.ptop->nv.ngaysinh<<p.ptop->nv.tongluong<<endl;
        p.ptop = p.ptop->pnext;
     } 
}
// hàm tính tổng lương của nhân viên
double tinhTong(Stack s) {
    double tong=0;
  while (s.ptop!=NULL)
  {
    tong = tong + s.ptop->nv.tongluong;
    s.ptop = s.ptop->pnext;
  }
  return tong;
  cout<<endl;
}
// hàm hủy nhân viên cuối cùng ra khỏi danh sách
void huyNhanVienCuoi(Stack &s) {
   // Stack p =s; 
    node *q =s.ptop;
    s.ptop=s.ptop->pnext;
    delete q;
}
// hàm tìm kiếm nhân viên có mức lương cao nhất
void timkiem(Stack s) {
    Stack p =s;
    
    if(p.ptop == NULL) {
        return ;
    }
    node *u=p.ptop;
    if(p.ptop != NULL) {
        for (node *k = p.ptop; k !=NULL; k = k->pnext)
        {
            double max = p.ptop->nv.tongluong;
           for(node *j =p.ptop->pnext;j!=NULL;j = j->pnext) {
            if(max < j->nv.tongluong ) {
                u = j;
                max = j->nv.tongluong;
            }
           }
        }
        cout<<u->nv.masNhanVien<<" "<<u->nv.hoten<<" "<<u->nv.ngaysinh<<" "<<u->nv.tongluong<<endl;
    }
}
// hàm in ra  danh sách nhân viên có mức lương trên 2tr
void inDsmucluongtren2tr(Stack s) {
   Stack p =s;
   for(node *j =p.ptop;j!=NULL;j = j->pnext) {
            if(j->nv.tongluong > 2000000.0) {
                 cout<<j->nv.masNhanVien<<" "<<j->nv.hoten<<" "<<j->nv.ngaysinh<<" "<<j->nv.tongluong<<endl;
            }
   }    
}

//hàm sắp xếp danh sách theo thứ tự tăng dần của mã sinh viên dựa vào thuật toán chèn trực tiếp
void sapXep(Stack &s){
    Stack p=s;
	for(node *q=p.ptop;q!=NULL;q = q->pnext){
		
		for(node *k=q->pnext;k!=NULL;k=k->pnext){
            
			if(k->nv.masNhanVien < q->nv.masNhanVien){
				nhanvien i =k->nv;
                k->nv=q->nv;
                q->nv = i;
			}
		}
	}
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
    cout<<"4.Huy nhan vien cuoi cua danh sach"<<endl;
    cout<<"5.Tim nhan vien co muc luong cao nhat."<<endl;
    cout<<"6.Hien ra danh sach nhan vien co muc luong tren 2000000."<<endl;
    cout<<"7.Sap xep danh sach theo thu tu tang dan ma sinh vien."<<endl;
    cout<<"0.Thoat chuong trinh!!."<<endl;
    cout<<"_______________________End__________________________"<<endl;
    cout<<"***Chon Menu*****:";
    cin>>luaChon;
    cout<<endl;
    if(luaChon==1) {
      
        nhanvien nv;
        cout<<"Ma so nhan vien:";
        cin>>nv.masNhanVien;
        cout<<"Ho va ten:";
        cin>>nv.hoten;
        cout<<"Ngay sinh:";
        cin>>nv.ngaysinh;
        cout<<"Tong luong:";
        cin>>nv.tongluong;
        node *p=new node;
        p=khoitaonode(nv);
        themvaodau(s,p);
        
    }
    if(luaChon==2) {
       xuatstack(s);
    
    }
    if(luaChon==3) {
         cout<<"Tong:"<<tinhTong(s);
    }
    if(luaChon==4) {
        huyNhanVienCuoi(s);
    }
    if(luaChon == 5) {
        timkiem(s);
    }
     if(luaChon == 6) {
        inDsmucluongtren2tr(s);
    }
    if(luaChon ==7) {
         
          sapXep(s);
    }
} while (luaChon!=0);

}