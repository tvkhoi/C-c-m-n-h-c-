#include<bits/stdc++.h>
using namespace std;
struct sach
{
    char tensach[128];
    char maSach[128];
    char theLoai[128];
    char tenTacGia[128];
    char NXB[64];
    float donGia;
    int soLuong;
};
// lop hoa don
struct hoaDon
{
    char tenKH[128];
    int makh;
    char ngayBan[16];
    char maSach[128];
    float donGia;
    int soLuong;
};
//Khai báo cấu trúc một node sach mới
struct NodeS{
sach dataS;
NodeS *next;
};
// khai báo một cấu trúc node hóa đơn mới
struct NodeHD
{
    hoaDon dataHD;
    NodeHD *next;
};
//Khai báo cấu trúc danh sách 
struct LISTS{
    NodeS *headS; // node quản lý đầu danh sách 
    NodeS *tailS; // node quản lý cuối danh sách
};
// khai báo danh sách hóa đơn
struct LISTHD
{
    NodeHD *headHD;
    NodeHD *tailHD;
};


// Khởi tạo một node mới
NodeS *KhoiTaoNodeS(sach x){
    NodeS *p=new NodeS; // cấp phát vùng nhớ cho node p
    if(p==NULL){
        cout<<"khong du bo nho!!!";
        exit(1);
    }
    p->dataS=x;
    p->next=NULL;
    return p; //trả về node p vừa khởi tạo 
}
// khởi tạo danh sách hóa đơn
NodeHD *khoiTaoNodehHD(hoaDon x){
    NodeHD *p=new NodeHD;
    if(p==NULL){
        cout<<"khong du bo nho: ";
        exit(1);
    }
    p->dataHD=x;
    p->next=NULL;
    return p;
}
// Khởi tạo danh sách sách
void khoiTaoDanhSachS(LISTS &S){
    S.headS=NULL;
    S.tailS=NULL;
}
// khoi tạo danh sách hóa đơn
NodeHD khoiTaoDanhSachHD(LISTHD &HD){
    HD.headHD=NULL;
    HD.tailHD=NULL;
}
//Them vao cuoi danh sach sach
void themCuoiS(LISTS &S,NodeS *p){
    if(S.headS==NULL){
        S.headS=S.tailS=p;
    }
    else{
        S.tailS->next=p;
        S.tailS=p;
    }
} 
//Them vao cuoi danh sach
void themCuoiHD(LISTHD &HD,NodeHD *p){
    if(HD.headHD==NULL){
        HD.headHD=HD.tailHD=p;
    }
    else{
        HD.tailHD->next=p;
        HD.tailHD=p;
    }
} 
// doc file sach
void docFileS(ifstream &filein,sach s){
    string g;
    filein>>s.tensach;
    getline(filein,g,',');
    filein>>s.maSach;
    getline(filein,g,',');
    filein>>s.theLoai;
    getline(filein,g,',');
    filein>>s.tenTacGia;
    getline(filein,g,',');
    filein>>s.NXB;
    getline(filein,g,',');
    filein>>s.soLuong;
    getline(filein,g,',');
    filein>>s.donGia;
    getline(filein,g);
}
void docFileHD(ifstream &filein,hoaDon hd){
    string g;
    filein>>hd.tenKH;
    getline(filein,g,',');
    filein>>hd.makh;
    getline(filein,g,',');
    filein>>hd.ngayBan;
    getline(filein,g,',');
    filein>>hd.maSach;
    getline(filein,g,',');
    filein>>hd.donGia;
    getline(filein,g,',');
    filein>>hd.soLuong;
    getline(filein,g);
}
void docDSSach(ifstream &filein,LISTS &S){
    while (!filein.eof())
    {
        sach s;
        docFileS(filein,s);
        NodeS *p=KhoiTaoNodeS(s);
        themCuoiS(S,p);
    }
}
void docDSHD(ifstream &filein,LISTHD &HD){
    while (!filein.eof())
    {
        hoaDon hd;
        docFileHD(filein,hd);
        NodeHD *p=khoiTaoNodehHD(hd);
        themCuoiHD(HD,p);
    }
}
void xuatSach(sach s){
    cout<<s.tensach<<endl;
    cout<<s.maSach<<endl;
    cout<<s.theLoai<<endl;
    cout<<s.NXB<<endl; 
    cout<<s.tenTacGia<<endl;
    cout<<s.donGia<<endl;
    cout<<s.soLuong<<endl;
}
void xuatDSSach(LISTS S){
    int dem=1;
    for(NodeS *k=S.headS;k!=NULL;k=k->next){
        cout<<"___________Sach thu:"<<dem++<<endl;
        xuatSach(k->dataS);
    }
}
void xuatHD(hoaDon hd){
    cout<<hd.tenKH<<',';
    cout<<hd.makh<<',';
    cout<<hd.ngayBan<<',';
    cout<<hd.maSach<<',';
    cout<<hd.donGia<<',';
    cout<<hd.soLuong;
}
void xuatDSHD(LISTHD HD){
    int dem=1;
    for(NodeHD *k=HD.headHD;k!=NULL;k=k->next){
        cout<<"___________Hoa Don Thu: "<<dem++<<endl;
        xuatHD(k->dataHD);
    }
}
void GhiFileS(ofstream &fileout,sach s){
    fileout<<s.tensach<<',';
    fileout<<s.maSach<<',';
    fileout<<s.theLoai<<',';
    fileout<<s.tenTacGia<<',';
    fileout<<s.NXB<<',';
    fileout<<s.soLuong<<',';
    fileout<<s.donGia;
}
void ghiFileHD(ofstream &fileout,hoaDon hd){
    fileout<<hd.tenKH<<',';
    fileout<<hd.makh<<',';
    fileout<<hd.ngayBan<<',';
    fileout<<hd.maSach<<',';
    fileout<<hd.soLuong<<',';
    fileout<<hd.donGia;
}
void giaiPhongVungNhoSach(LISTS S){
    NodeS *p=NULL;
    while (S.headS!=NULL)
    {
        p=S.headS;
        S.headS=S.headS->next;
        delete p;
    }
}
void giaiPhongVungNhoHD(LISTHD HD){
    NodeHD *p=NULL;
    while (HD.headHD!=NULL)
    {
        p=HD.headHD;
        HD.headHD=HD.headHD->next;
        delete p;
    }
}
int main(){
    LISTS S;
    LISTHD HD;
    khoiTaoDanhSachS(S);
    khoiTaoDanhSachHD(HD);
    sach s;
    hoaDon hd;
    ifstream filein;
    ifstream fio;
    filein.open("thongTinSach.txt",ios::in);
    fio.open("thongTinHoaDon.txt",ios::in);
    docDSSach(filein,S);
    docDSHD(filein,HD);
    xuatDSSach(S);
    xuatDSHD(HD);
    
    giaiPhongVungNhoSach(S);
    giaiPhongVungNhoHD(HD);
    filein.close();

    return 0;
}