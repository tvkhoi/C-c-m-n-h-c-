#include<bits/stdc++.h>
using namespace std;
int dem=0;
struct Sach
{
    char tensach[100];
    char masach[100];
    char theloai[100];
    char tentgia[100];
    char NXB[100];
    double gia;
    int soluong;
    int namxb;
};
// cấu trúc của 1 node sách
struct nodeSach
{
    Sach sach;
    nodeSach *pnext;
};
// cấu trúc của 1 ngăn xếp trong sách
struct StackSach
{
    nodeSach *ptop;
};
// khởi tạo 1 node sách
nodeSach *khoitaonodeSach(Sach sach) {
     nodeSach *p = new nodeSach;
     if(p==NULL) {
        cout<<"Khong du bo nho";
        return NULL;
     }
     else {
        p->sach =sach; // lưu giá trị vào node
        p->pnext = NULL;
     }
    return p;
}
// khởi tạo danh sách ngăn xếp sách 
void khoitaoStackSach(StackSach &stacksach) {
    stacksach.ptop=NULL;
}
// hàm xem ngăn xếp có rỗng hay không
bool xetxemnganxepSach(StackSach &stacksach) {
    // danh sách nếu rỗng trả về true
      if(stacksach.ptop==NULL) {
        return true;
      }
    // danh sách không rỗng trả về false
      return false;
}
// thêm 1 node vào ngăn xếp sách
bool addSach(StackSach &stacksach,nodeSach *p) {
    // nếu không khởi tạo được node thì trả về false
    if(p==NULL) {
        return false;
    }
    // nếu danh sách ban đầu rỗng thì con trỏ đầu của của ngăn xếp = node mới thêm
    if(xetxemnganxepSach(stacksach)==true) {
        stacksach.ptop=p;
    }
    // nếu ngược lại danh sách không rỗng mà có phần tử rồi
    else {
        p->pnext = stacksach.ptop;
        stacksach.ptop = p;
    }
    return true;
}  
// 23.Nhập danh sách ngăn xếp với n phần tử ban đầu
void nhapDanhSachSach(StackSach &stacksach,int n) {
      for (int i = 0; i < n; i++)
      {
        Sach s;
        cout<<"Ten sach:";
        cin.getline(s.tensach,100);
        cout<<"Ma sach:";
        cin.getline(s.masach,100);
        cout<<"The loai:";
        cin.getline(s.theloai,100);
        cout<<"Ten tac gia:";
        cin.getline(s.tentgia,100);
        cout<<"Nha xuat ban:";
        cin.getline(s.NXB,100);
        cout<<"So luong:";
        cin>>s.soluong;
        cout<<"Gia:";
        cin>>s.gia;
        cin.ignore();
        nodeSach *p = khoitaonodeSach(s);
        addSach(stacksach,p);
      }
      
}

void nhapSach(ifstream &file,Sach &s) {
    char g[1];
   file.getline(s.tensach,100,',');
   file.getline(s.masach,100,',');
   file.getline(s.theloai,100,',');
   file.getline(s.tentgia,100,',');
   file.getline(s.NXB,100,',');
   file>>s.soluong;
   file.getline(g,1,',');
   file>>s.gia;
   file.getline(g,1,',');
   file>>s.namxb;
    dem++;
}
//1.Hàm nhập ngăn xếp sách với dữ liệu ban đầu
void docDSfileSach(StackSach &stacksach,string tenfile) {
    ifstream file;
    file.open(tenfile,ios::in);
    if(file.is_open()) {
         while (!file.eof())
    {  
        Sach s;
        nhapSach(file,s); 
        nodeSach *p = khoitaonodeSach(s);
        addSach(stacksach,p); 
        
    }
    file.close();
     nodeSach *p= stacksach.ptop;
     stacksach.ptop = stacksach.ptop->pnext;
     delete p;
     dem--;
    }
    else {
        cout<<"Khong mo duoc file."<<endl;
    }
}
// 21.hàm đọc file binary để ghi vào danh sách
void docDSfileSachBinary(StackSach &stacksach,string tenfile) {
    ifstream file;
    file.open(tenfile,ios::in|ios::binary);
    if(file.is_open()) {
         while (!file.eof())
    {  
        Sach s;
       file.read((char*)&s,sizeof(s));
        nodeSach *p = khoitaonodeSach(s);
        addSach(stacksach,p); 
    }
    file.close();
     nodeSach *p= stacksach.ptop;
     stacksach.ptop = stacksach.ptop->pnext;
     delete p;
     dem--;
    }
    else {
        cout<<"Khong mo duoc file."<<endl;
    }
}
// 22.Hàm ghi dữ liệu dưới dạng binary
void ghidsvaoFileBinary(StackSach stacksach,string tenfile) {
      fstream file;
      file.open(tenfile,ios::out|ios::binary);
      if(file.is_open()){
        for (nodeSach *i = stacksach.ptop; i != NULL; i=i->pnext) 
      {
        file.write((char*)&i->sach,sizeof(i->sach));
      }
      }
      else {
        cout<<"khong the mo file"<<endl;
      }
      file.close();
}
void hien1doituongsachngsach(nodeSach *p) {
    //  cout<<"________________________________________________________________"<<
    // "________________Danh sach : sach______________________________________"<<
    // "__________________________________________"<<endl<<endl;
    // cout<<left<<setw(25)<<"Ten sach"
    // <<left<<setw(25)<<"Ma sach"
    // <<left<<setw(25)<<"The loai"
    // <<left<<setw(25)<<"Ten tac gia"
    // <<left<<setw(25)<<"Nha suat ban"
    // <<left<<setw(25)<<"So luong"
    // <<left<<setw(25)<<"Gia sach"<<endl;
     cout<<left<<setw(25)<<p->sach.tensach
       <<left<<setw(25)<<p->sach.masach
       <<left<<setw(25)<<p->sach.theloai
       <<left<<setw(25)<<p->sach.tentgia
       <<left<<setw(25)<<p->sach.NXB
       <<left<<setw(25)<<p->sach.soluong
       <<left<<setw(25)<<p->sach.gia
       <<left<<setw(25)<<p->sach.namxb<<endl;
}

// 2. hiện danh sách sách ra màn hình
void hienSach(StackSach sach) {
    StackSach s = sach;
    cout<<"________________________________________________________________"<<
    "________________Danh sach : sach______________________________________"<<
    "__________________________________________"<<endl<<endl;
    cout<<left<<setw(7)<<"STT"
    <<left<<setw(25)<<"Ten sach"
    <<left<<setw(20)<<"Ma sach"
    <<left<<setw(20)<<"The loai"
    <<left<<setw(20)<<"Ten tac gia"
    <<left<<setw(20)<<"Nha suat ban"
    <<left<<setw(20)<<"So luong"
    <<left<<setw(20)<<"Gia sach"
    <<left<<setw(20)<<"Nam xuat ban"<<endl;
    int i = 0;
    while (s.ptop !=NULL )
    {
       cout<<left<<setw(7)<<i+1
       <<left<<setw(25)<<s.ptop->sach.tensach
       <<left<<setw(20)<<s.ptop->sach.masach
       <<left<<setw(20)<<s.ptop->sach.theloai
       <<left<<setw(20)<<s.ptop->sach.tentgia
       <<left<<setw(20)<<s.ptop->sach.NXB
       <<left<<setw(20)<<s.ptop->sach.soluong
       <<left<<setw(20)<<s.ptop->sach.gia
       <<left<<setw(20)<<s.ptop->sach.namxb<<endl;
       i++;
    s.ptop = s.ptop->pnext;
    }
}
//3.sắp xếp theo tên sách dựa vào bảng chữ cái (a -> z)
void sapxep(StackSach &stacksach) {
    StackSach s = stacksach; 
  
    for (nodeSach *j = s.ptop;j != NULL;j = j->pnext)
    {
        
       
       for (nodeSach *k = j->pnext;k!=NULL;k = k->pnext)
       {
        
        if(strcmp(j->sach.tensach,k->sach.tensach)>0) {
        Sach ac = k->sach;
        k->sach = j->sach;
        j->sach = ac; 
        }
       }
       
    }
    hienSach(stacksach);
}
// 4.hàm tìm kiến thông tin sách dựa vào tác giả
void timkiemTheoTenTacGia(StackSach sach) {
   char tacgia[100];
    cin.ignore();
    cout<<"Nhap ten tac gia can tim:";
    cin.getline(tacgia,100);
   // int b = atoi(tensach1);
   cout<<"________________________________________________________________"<<
    "________________Danh sach : sach______________________________________"<<
    "__________________________________________"<<endl<<endl;
    cout<<left<<setw(15)<<"STT"
    <<left<<setw(25)<<"Ten sach"
    <<left<<setw(25)<<"Ma sach"
    <<left<<setw(25)<<"The loai"
    <<left<<setw(25)<<"Ten tac gia"
    <<left<<setw(25)<<"Nha suat ban"
    <<left<<setw(25)<<"So luong"
    <<left<<setw(25)<<"Gia sach"<<endl;
    int i =0;
     for (nodeSach *j = sach.ptop; j != NULL; j = j->pnext) 
     {
     //  int ab = atoi(j->sach.tensach);
        if(strcmp(j->sach.tentgia,tacgia)==0) {
            cout<<left<<setw(15)<<i+1
            <<left<<setw(25)<<j->sach.tensach
            <<left<<setw(25)<<j->sach.masach
            <<left<<setw(25)<<j->sach.theloai
            <<left<<setw(25)<<j->sach.tentgia
            <<left<<setw(25)<<j->sach.NXB
            <<left<<setw(25)<<j->sach.soluong
            <<left<<setw(25)<<j->sach.gia<<endl; 
            i++;
        }
     }
}
//5. Thêm sách vào vị trí k
void themsachvaovitri(StackSach &sach,int vitri) {
    if(vitri == 1) {
         Sach s;
    cin.ignore();
    cout<<"Ten sach:";
    cin.getline(s.tensach,100);
    cout<<"Ma sach:";
    cin.getline(s.masach,100);
    cout<<"The loai:";
    cin.getline(s.theloai,100);
    cout<<"Ten tac gia:";
    cin.getline(s.tentgia,100);
    cout<<"Nha xuat ban:";
    cin.getline(s.NXB,100);
    cout<<"so luong:";
    cin>>s.soluong;
    cout<<"Gia:";
    cin>>s.gia;
    nodeSach *p = khoitaonodeSach(s);
     p->pnext = sach.ptop;
          sach.ptop = p;
    }
    if(vitri>1 && vitri<=dem ) {
    Sach s;
    cin.ignore();
    cout<<"Ten sach:";
    cin.getline(s.tensach,100);
    cout<<"Ma sach:";
    cin.getline(s.masach,100);
    cout<<"The loai:";
    cin.getline(s.theloai,100);
    cout<<"Ten tac gia:";
    cin.getline(s.tentgia,100);
    cout<<"Nha xuat ban:";
    cin.getline(s.NXB,100);
    cout<<"so luong:";
    cin>>s.soluong;
    cout<<"Gia:";
    cin>>s.gia;
    nodeSach *p = khoitaonodeSach(s);
    if(p==NULL) {
        cout<<"Khong du bo nho!";
    }
    else {
        while (vitri>0 && vitri<=dem )
       {
       if(vitri == 1) {
          p->pnext = sach.ptop;
          sach.ptop = p;
          break;
       }
       else {
        nodeSach *e = sach.ptop;
        for (int i =1; i < vitri-1; i++)
        {
            e = e->pnext;
                                    
            }
            p->pnext = e->pnext;
            e->pnext = p; 
            break;
        }
       }
      }
   }
   if(vitri<0&&vitri>dem+1) {
    cout<<"Vi tri them ngoai danh sach!!"<<endl;
   }
  
 }
void xoaThongTindausach(StackSach &sach) {
     nodeSach *p= sach.ptop;
     sach.ptop = sach.ptop->pnext;
     delete p;
}
// 6.Xóa thông tin sách theo thể loại
void xoaThongTinSachTheoTheLoai(StackSach &sach,char theloai[]) {  
    if (sach.ptop == NULL) {
        cout << "Danh sach dang rong!" << endl;
        return;
    }
      // Xóa các sách có thể loại trùng với tham số đầu vào
     while (sach.ptop != NULL && strcmp(sach.ptop->sach.theloai,theloai)==0 )
     {
       xoaThongTindausach(sach);
     }
    // Duyệt danh sách để tìm và xóa các sách có thể loại trùng với tham số đầu vào
    nodeSach* u = sach.ptop;
    while (u != NULL && u->pnext != NULL) {
        if (strcmp(u->pnext->sach.theloai, theloai) == 0) {
            nodeSach* q = u->pnext;
            u->pnext = q->pnext;
            delete q;
        } else {
            u = u->pnext;
        }
    }
    
    if (u == NULL) {
        cout << "Danh sach dang rong!" << endl;
    } else {
        hienSach(sach); // Hiển thị danh sách sau khi xóa 
    }
}
// 7.Đếm số lượng sách của nhà sản xuất x;
int demSoLuongSachNhaSanXuatX(StackSach sach) {
    StackSach s = sach;
    int dem=0;
    char NXB[100];
    cout<<"Nhap ten nha san xuat :";
    cin.ignore();
    cin.getline(NXB,sizeof(NXB));
    for (nodeSach *j = s.ptop;j != NULL;j = j->pnext)
    {
        if(strcmp(j->sach.NXB,NXB)==0) {
             dem+=j->sach.soluong;
        }
    }
    return dem;
}
// kiểm tra xem sách có rỗng hay ko
bool isempty(StackSach &sach) {
    if(sach.ptop==NULL) {
        return true;
    }
    else return false;
}
// 8. Sửa thông tin sách dựa vào mã sách
void suathongtinSach(StackSach &sach,char masach[]) {

       if(isempty(sach)==true) {
        // Sach s;
        //     cout<<"Ten sach:";
        //    cin.getline(s.tensach,100);
        //    cout<<"Ma sach:";
        //    cin.getline(s.masach,100);
        //    cout<<"The loai:";
        //    cin.getline(s.theloai,100);
        //    cout<<"Ten tac gia:";
        //    cin.getline(s.tentgia,100);
        //    cout<<"Nha xuat ban:";
        //    cin.getline(s.NXB,100);
        //    cin.ignore();
        //    cout<<"Gia:";
        //    cin>>s.gia;
        //    cout<<"So luong:";
        //    cin>>s.soluong;
        //    cin.ignore();
        //    nodeSach *p = khoitaonodeSach(s);
        //    addSach(sach,p);
       }
       else {
        for(nodeSach *i = sach.ptop;i != NULL;i = i->pnext) {
            if((string)masach==(string)i->sach.masach) {
                Sach s;
           cout<<"Ten sach:";
           cin.getline(s.tensach,100);
           cout<<"Ma sach:";
           cin.getline(s.masach,100);
           cout<<"The loai:";
           cin.getline(s.theloai,100);
           cout<<"Ten tac gia:";
           cin.getline(s.tentgia,100);
           cout<<"Nha xuat ban:";
           cin.getline(s.NXB,100);
           cout<<"Gia:";
           cin>>s.gia;
           cout<<"So luong:";
           cin>>s.soluong;
           cin.ignore();
           i->sach = s;
            }
        }
        }
        hienSach(sach);
} 
// Ghi dữ liệu vào file nhập từ bàn phím
// void ghidlieuvaofile(StackSach sach,string tenfile,int luachon) {
//     fstream file;
//     file.open(tenfile,ios::out);
//     // if(file.fail()) {
//     //     cout<<"Mo file khong thanh cong!.";
       
//     // }
//     // else {
//     //     file<<"________________________________________________________________"<<
//     // "________________Danh sach : sach______________________________________"<<
//     // "__________________________________________"<<endl<<endl;
//     // file<<left<<setw(15)<<"STT"
//     // <<left<<setw(25)<<"Ten sach"
//     // <<left<<setw(25)<<"Ma sach"
//     // <<left<<setw(25)<<"The loai"
//     // <<left<<setw(25)<<"Ten tac gia"
//     // <<left<<setw(25)<<"Nha suat ban"
//     // <<left<<setw(25)<<"So luong"
//     // <<left<<setw(25)<<"Gia sach"<<endl;  
//     // int i = 0; 
//     // while (sach.ptop !=NULL )
//     // {
//     //    file<<left<<setw(15)<<i+1
//     //    <<left<<setw(25)<<sach.ptop->sach.tensach
//     //    <<left<<setw(25)<<sach.ptop->sach.masach
//     //    <<left<<setw(25)<<sach.ptop->sach.theloai
//     //    <<left<<setw(25)<<sach.ptop->sach.tentgia
//     //    <<left<<setw(25)<<sach.ptop->sach.NXB
//     //    <<left<<setw(25)<<sach.ptop->sach.soluong
//     //    <<left<<setw(25)<<sach.ptop->sach.gia<<endl;
//     //    i++;
//     //    sach.ptop = sach.ptop->pnext;
//     //}
//     //}
//     // if(luachon == 2) {
//     //     hienSach(sach)>>file;
//     // }
//     file.close();
    
// }
// 9.Hiện thông tin sách có đơn giá lớn hơn k
void hienThongTinSachTheoDieuKienDonGia(StackSach stacksach,double k) {
      cout<<"________________________________________________________________"<<
    "________________Danh sach : sach______________________________________"<<
    "__________________________________________"<<endl<<endl;
    cout<<left<<setw(25)<<"Ten sach"
    <<left<<setw(25)<<"Ma sach"
    <<left<<setw(25)<<"The loai"
    <<left<<setw(25)<<"Ten tac gia"
    <<left<<setw(25)<<"Nha suat ban"
    <<left<<setw(25)<<"So luong"
    <<left<<setw(25)<<"Gia sach"<<endl;
    for (nodeSach *i = stacksach.ptop; i != NULL; i = i->pnext) 
    {
      if(i->sach.gia > k) {
           hien1doituongsachngsach(i);
      }
    }
    
}
// 10.Tổng số sách còn lại trong kho là.
void tongSoSachConLaiTrongKho(StackSach stacksach) {
    double tong=0;
    for (nodeSach *i = stacksach.ptop; i != NULL; i = i->pnext)
    {
       tong += i->sach.soluong;
    }
    cout<<"Tong so sach con lai trong kho la :"<<tong<<endl;
}

// 107. In ra màn hình các cuốn sách cần hủy.
void hiensachcanhuy(StackSach stacksach) {
    int k = 0;
    int nam = 2023;
    cout<<"________________________________________________________________"<<
    "________________Danh sach : sach______________________________________"<<
    "__________________________________________"<<endl<<endl;
    cout<<left<<setw(7)<<"STT"
    <<left<<setw(20)<<"Ten sach"
    <<left<<setw(16)<<"Ma sach"
    <<left<<setw(20)<<"The loai"
    <<left<<setw(20)<<"Ten tac gia"
    <<left<<setw(20)<<"Nha suat ban"
    <<left<<setw(20)<<"So luong"
    <<left<<setw(20)<<"Gia sach"
    <<left<<setw(20)<<"Nam xuat ban"<<endl;
    for (nodeSach *i = stacksach.ptop; i != NULL; i = i->pnext)
    {
        int namx = i->sach.namxb;
       if((nam-namx)>50) {
            cout<<left<<setw(7)<<k+1
       <<left<<setw(20)<<(string)i->sach.tensach
       <<left<<setw(16)<<(string)i->sach.masach
       <<left<<setw(20)<<(string)i->sach.theloai
       <<left<<setw(20)<<(string)i->sach.tentgia
       <<left<<setw(20)<<(string)i->sach.NXB
       <<left<<setw(20)<<i->sach.soluong
       <<left<<setw(20)<<i->sach.gia
       <<left<<setw(20)<<i->sach.namxb<<endl;
       k++;
       }
    }
    
//    int k = 0;
//     int nam = 2023;
//     cout << "+-----+-------------------------+----------------+--------------------+-------------------+--------------------+---------+-------------+---------------+" << endl
//          << "| STT |         Ten sach         |     Ma sach    |      The loai      |     Ten tac gia   |   Nha suat ban     | So luong |   Gia sach  | Nam xuat ban   |" << endl
//          << "+-----+-------------------------+----------------+--------------------+-------------------+--------------------+---------+-------------+---------------+" << endl;
//     for (nodeSach *i = stacksach.ptop; i != NULL; i = i->pnext)
//     {
//         int namx = i->sach.namxb;
//         if ((nam - namx) > 50) {
//            cout << "|" << left << setw(5) << k + 1 << "|"
//                  << left << setw(25) << i->sach.tensach.substr(0, 24) << "|"
//                  << left << setw(15) << i->sach.masach.substr(0, 14) << "|"
//                  << left << setw(20) << i->sach.theloai.substr(0, 19) << "|"
//                  << left << setw(19) << i->sach.tentgia.substr(0, 18) << "|"
//                  << left << setw(20) << i->sach.NXB.substr(0, 19) << "|"
//                  << left << setw(9) << i->sach.soluong << "|"
//                  << right << setw(12) << i->sach.gia << "|"
//                  << right << setw(15) << i->sach.namxb << "|" << endl;
//             k++;
//         }
//     }
//     cout << "+-----+-------------------------+----------------+--------------------+-------------------+--------------------+---------+-------------+---------------+" << endl;
    
}




// **************************************************//

struct Hoadon
{
    int makh;
    char tensach[100];
    char tenkh[100];
    char ngayban[100];
    char masach[100];
    double dongia;
    int soluong;
};
// cấu trúc của 1 node hóa đơn
struct nodeHoaDon
{
    Hoadon hoadon;
    nodeHoaDon *pnext;
};
// cấu trúc của 1 danh sách ngăn xếp hóa đơn
struct StackHoaDon
{
    nodeHoaDon *ptop;
};
// khởi tạo 1 node Hóa đơn
nodeHoaDon *khoitaonodeHoaDon(Hoadon hoadon) {
    nodeHoaDon *p = new nodeHoaDon;
    if(p==NULL) {
        return NULL;        
    }
    else {
        p->hoadon = hoadon;
        p->pnext=NULL;

    }
    return p;
}
// khởi tạo 1 danh sách ngăn xếp hóa đơn

void khoitaoStackHoaDon(StackHoaDon &stackhoadon) {
      stackhoadon.ptop=NULL;
}
//******************Kết thúc quá trình tạo ra cấu trúc và khởi tạo *******************

//****************Hóa đơn****************
bool xetxemnganxepHoaDon(StackHoaDon &stackhoadon) {
    // danh sách nếu rỗng trả về true
      if(stackhoadon.ptop==NULL) {
        return true;
      }
    // danh sách không rỗng trả về false
      return false;
}
bool addHoaDon(StackHoaDon &stackhoadon,nodeHoaDon *p) {
    // nếu không khởi tạo được node thì trả về false
    if(p==NULL) {
        return false;
    }
    // nếu danh sách ban đầu rỗng thì con trỏ đầu của của ngăn xếp = node mới thêm
    if(xetxemnganxepHoaDon(stackhoadon)==true) {
        stackhoadon.ptop=p;
    }
    // nếu ngược lại danh sách không rỗng mà có phần tử rồi
    else {
        p->pnext = stackhoadon.ptop;
        stackhoadon.ptop = p;
    }
    return true;
}  
//11.nhập danh sách hóa đơn từ file
void nhapHoaDon(StackHoaDon &hoadon,string tenfile) {
    fstream file;
    file.open(tenfile,ios::in);
    if(file.is_open()) {
         char g[1];
   while (!file.eof())
   { 
   Hoadon s;
   file>>s.makh;
   file.getline(g,1,',');
   file.getline(s.tensach,100,',');
   file.getline(s.tenkh,100,',');
   file.getline(s.ngayban,100,',');
   file.getline(s.masach,100,',');
   file>>s.soluong;
   file.getline(g,1,',');
   file>>s.dongia;
   nodeHoaDon *p = khoitaonodeHoaDon(s);
   addHoaDon(hoadon,p);
   }
    // nodeHoaDon *p= hoadon.ptop;
    //  hoadon.ptop = hoadon.ptop->pnext;
    //  delete p;
   file.close();
    }
   else {
    cout<<"Mo file khong thanh cong!!"<<endl;
   }
   
}
void hien1doituonghoadon(nodeHoaDon *p) {
    //  cout<<"_______________________________________________________________________"<<
    // "________________Danh sach : sach______________________________________"<<
    // "______________________________________________________"<<endl<<endl;
    // cout<<left<<setw(25)<<"Ten sach"
    // <<left<<setw(25)<<"Ma sach"
    // <<left<<setw(25)<<"The loai"
    // <<left<<setw(25)<<"Ten tac gia"
    // <<left<<setw(25)<<"Nha suat ban"
    // <<left<<setw(25)<<"So luong"
    // <<left<<setw(25)<<"Gia sach"<<endl;
     cout<<left<<setw(25)<<p->hoadon.makh
       <<left<<setw(25)<<p->hoadon.tensach
       <<left<<setw(25)<<p->hoadon.tenkh
       <<left<<setw(25)<<p->hoadon.ngayban
       <<left<<setw(25)<<p->hoadon.masach
       <<left<<setw(25)<<p->hoadon.soluong
       <<left<<setw(25)<<p->hoadon.dongia<<endl;
}
// 12.Hiện danh sách hóa đơn
void hienHoaDon(StackHoaDon hoadon) {
    StackHoaDon s = hoadon;
     cout<<"___________________________________________________________________"<<
    "________________Danh sach : Hoa Don_______________________________________"<<
    "________________________"<<endl<<endl;
    cout<<left<<setw(15)<<"STT"
    <<left<<setw(25)<<"Ma khach hang"
    <<left<<setw(25)<<"Ten sach"
    <<left<<setw(25)<<"Ten khach hang"
    <<left<<setw(25)<<"Ngay ban"
    <<left<<setw(25)<<"Ma sach"
    <<left<<setw(25)<<"So luong"
    <<left<<setw(25)<<"Don gia"<<endl<<endl;
    int i =0;
    while (s.ptop != NULL )
    {
        cout<<left<<setw(15)<<i+1
        <<left<<setw(25)<<s.ptop->hoadon.makh
        <<left<<setw(25)<<s.ptop->hoadon.tensach
        <<left<<setw(25)<<s.ptop->hoadon.tenkh
        <<left<<setw(25)<<s.ptop->hoadon.ngayban
        <<left<<setw(25)<<s.ptop->hoadon.masach
        <<left<<setw(25)<<s.ptop->hoadon.soluong
        <<left<<setw(25)<<s.ptop->hoadon.dongia<<endl<<endl;
        i++;
        s.ptop = s.ptop->pnext;
    }
    
}
// 13.Sắp xếp hóa đơn giảm dần theo đơn giá
void sapXepHoaDon(StackHoaDon &hoadon) {
    StackHoaDon s = hoadon;
    for (nodeHoaDon *j = s.ptop;j != NULL;j = j->pnext)
    {
       for (nodeHoaDon *k = j->pnext;k!=NULL;k = k->pnext)
       {
        if((j->hoadon.dongia - k->hoadon.dongia) < 0) {
        Hoadon ac = k->hoadon;
        k->hoadon = j->hoadon;
        j->hoadon = ac; 
        }
       }
    }
    hienHoaDon(s);
}
//14.tìm kiếm tên sách tiêu thụ nhiều nhất (dựa vào đơn giá)
void timkiemTheoTenSachTieuThuNhieuNhat(StackHoaDon hoadon) {
    int soluong =hoadon.ptop->hoadon.soluong;
    
 for (nodeHoaDon *j = hoadon.ptop;j != NULL;j = j->pnext)
    {
        if( j->hoadon.soluong > soluong) {
             soluong = j->hoadon.soluong;
            
        }
    }
 for (nodeHoaDon *i = hoadon.ptop; i != NULL; i = i->pnext)
 {
    if(soluong == i->hoadon.soluong) {
        cout<<i->hoadon.tensach<<endl;
    }
 }
 

}

//15. Tìm kiếm thông tin người mua (dựa vào mã sách) hiện ra tên kh, tên sản phẩm và giá trị hóa đơn
void timkiemThongtinnguoimua(StackHoaDon hoadon,int makh) {
    // fstream file1;
    // file1.open("Masach.txt",ios::out);
    cout<<left<<setw(25)<<"Ten khach hang"
    <<left<<setw(25)<<"Ten sach"
    <<left<<setw(25)<<"Don gia"<<endl<<endl;
    StackHoaDon s = hoadon;
 for (nodeHoaDon *j = s.ptop;j != NULL;j = j->pnext)
    {
        if( j->hoadon.makh == makh) {
        cout<<left<<setw(25)<<j->hoadon.tenkh
        <<left<<setw(25)<<j->hoadon.tensach
        <<left<<setw(25)<<j->hoadon.dongia<<endl;
        }
    }
}
//hàm xóa đầu hóa đơn
void xoaThongtindauhoadon(StackHoaDon &hd) {
    nodeHoaDon *p =  hd.ptop;
    hd.ptop = hd.ptop->pnext;
    delete p;
}
//16.Xóa thông tin khách hàng k  (dựa vào mã khách hàng)
void xoaThongTinKhachhangTheoTen(StackHoaDon &hd, int makh) {
    
      // nếu vị trí cần xóa nằm ở đầu
     if(hd.ptop->hoadon.makh-makh==0) { 
          xoaThongtindauhoadon(hd);
      }
      nodeHoaDon *u = new nodeHoaDon;
      // duyệt danh sách để tìm
     for (nodeHoaDon *i = hd.ptop; i != NULL; i = i->pnext)
     {
      // ab = atoi(i->sach.tensach);
     
      if((i->hoadon.makh - makh)==0) {
        nodeHoaDon *q = i;
        u->pnext = i->pnext;
        delete q;
      }
      u = i;
     }
         hienHoaDon(hd);
}
// //    13: Hiện thông tin sách bán chạy nhất của cửa hàng trong thời gian t(theo ngày)
//     void thongtinsachbanchaytaithoidiem(StackHoaDon hd,StackSach sach, char ngay[]) {
//         int soluongbantrongngay;
//         string masach;
//         for(nodeHoaDon *i = hd.ptop;i != NULL;i = i->pnext) {
//             if((string)ngay==(string)i->hoadon.ngayban) {
//                 soluongbantrongngay = i->hoadon.soluong;
//                 masach = (string) i->hoadon.masach;
//             }
//         }
       
//         for(nodeHoaDon *i = hd.ptop;i!=NULL;i=i->pnext) {
//             if(soluongbantrongngay < i->hoadon.soluong && (string)i->hoadon.ngayban == (string)ngay) {
//                 masach = i->hoadon.masach;
//             }
//         }
//         for (nodeSach *j = sach.ptop;j != NULL;j = j->pnext)
//     {
//         if(masach == (string)j->sach.masach) {
//             cout<<left<<setw(25)<<j->sach.tensach
//             <<left<<setw(25)<<j->sach.masach
//             <<left<<setw(25)<<j->sach.theloai
//             <<left<<setw(25)<<j->sach.tentgia
//             <<left<<setw(25)<<j->sach.NXB
//             <<left<<setw(25)<<j->sach.soluong
//             <<left<<setw(25)<<j->sach.gia<<endl; 
//         }
//     }

//     }
//17. Tìm hóa đơn có giá trị min, max 
void timHoaDonCoGiaTriMinMax(StackHoaDon stackhoadon) {
    
     if(stackhoadon.ptop == NULL) {
        cout<<"Danh sach rong!!"<<endl;
        cout<<"Khong tim thay max va min"<<endl;
     }
    
     else {
       cout<<"___________________________________________________________________"<<
    "________________Danh sach : Hoa Don_______________________________________"<<
    "________________________"<<endl<<endl;
    cout<<left<<setw(15)<<"STT"
    <<left<<setw(25)<<"Ma khach hang"
    <<left<<setw(25)<<"Ten sach"
    <<left<<setw(25)<<"Ten khach hang"
    <<left<<setw(25)<<"Ngay ban"
    <<left<<setw(25)<<"Ma sach"
    <<left<<setw(25)<<"So luong"
    <<left<<setw(25)<<"Don gia"<<endl<<endl;
        double max = stackhoadon.ptop->hoadon.dongia;
        for (nodeHoaDon *k = stackhoadon.ptop; k != NULL; k = k->pnext)
        {
             if(k->hoadon.dongia > max) {
                max = k->hoadon.dongia;
             }
        }
        double min = stackhoadon.ptop->hoadon.dongia;
        for (nodeHoaDon *k = stackhoadon.ptop; k != NULL; k = k->pnext)
        {
             if(k->hoadon.dongia < min) {
                min = k->hoadon.dongia;
             }
        }
        for (nodeHoaDon *k = stackhoadon.ptop; k != NULL; k = k->pnext)
        {
             if(k->hoadon.dongia == max) {
                cout<<"Hoa don lon nhat la:"<<endl;
                hien1doituonghoadon(k);
             }
             if(k->hoadon.dongia == min) {
                cout<<"Hoa don nho la:"<<endl;
                hien1doituonghoadon(k);
             }
        }
        
     }
        
        
}
// 19. tính tổng doanh thu trong ngày
double tinhTongDanhThutrongngay(StackHoaDon hd,string ngay) {
    double tong=0;
   for (nodeHoaDon *i = hd.ptop ; i != NULL; i = i->pnext)
   {
       if((string)ngay == (string)i->hoadon.ngayban) {
           tong += i->hoadon.dongia;
       }
   }
    return tong;
}
//18.tính tiền lãi ngày 
void tinhtienlaitheongay(StackHoaDon stackhd,string ngay) {
    double tong = 0;
    tong = (double)tinhTongDanhThutrongngay(stackhd,ngay);
    tong = tong *10/100;
    cout<<"Tong tien lai trong ngay cua cua hang la:"<<tong<<endl;
}

//20.Khuyến mãi N% cho khách hàng có hóa đơn trị giá M
void khuyenMaiHoaDon(StackHoaDon &stackhoadon,double gia,double phantram) {
     for (nodeHoaDon *i = stackhoadon.ptop; i != NULL; i=i->pnext)
         {
           if(i->hoadon.dongia > gia) {
            i->hoadon.dongia = (double)i->hoadon.dongia * (phantram /100);
           }
         }
}
// 24.hàm đọc file binary để ghi vào danh sách
void docDSfileSachBinaryHd(StackHoaDon &stackhoadon,string tenfile) {
    ifstream file;
    file.open(tenfile,ios::in|ios::binary);
    if(file.is_open()) {
         while (!file.eof())
    {  
        Hoadon s;
        file.read((char*)&s,sizeof(s));
        nodeHoaDon *p = khoitaonodeHoaDon(s);
        addHoaDon(stackhoadon,p); 
    }
    file.close();
    //  nodeHoaDon *p= stackhoadon.ptop;
    //  stackhoadon.ptop = stackhoadon.ptop->pnext;
    //  delete p;
    //  dem--;
    }
    else {
        cout<<"Khong mo duoc file."<<endl;
    }
}
// 25.Hàm ghi dữ liệu dưới dạng binary
void ghidsvaoFileBinaryHd(StackHoaDon stackhoadon,string tenfile) {
      fstream file;
      file.open(tenfile,ios::out|ios::binary);
      if(file.is_open()){
        for (nodeHoaDon *i = stackhoadon.ptop; i != NULL; i=i->pnext) 
      {
        file.write((char*)&i->hoadon,sizeof(i->hoadon));
      }
      }
      else {
        cout<<"khong the mo file"<<endl;
      }
      file.close();
}
//  cout<<left<<setw(15)<<"STT"
//     <<left<<setw(25)<<"Ma khach hang"
//     <<left<<setw(25)<<"Ten sach"
//     <<left<<setw(25)<<"Ten khach hang"
//     <<left<<setw(25)<<"Ngay ban"
//     <<left<<setw(25)<<"Ma sach"
//     <<left<<setw(25)<<"So luong"
//     <<left<<setw(25)<<"Don gia"<<endl<<endl;

// 26. Nhập danh sách ngăn xếp với n phần tử ban đầu
void nhapDanhSachHd(StackHoaDon &stackhoadon,int n) {
    // int makh;
    // char tensach[100];
    // char tenkh[100];
    // char ngayban[100];
    // char masach[100];
    // double dongia;
    // int soluong;
      for (int i = 0; i < n; i++)
      {
       
        Hoadon s;
        cout<<"Ma khach hang:";
        cin>>s.makh;
        cin.ignore();
        cout<<"Ten sach:";
        cin.getline(s.tensach,100);
        cout<<"Ten khach hang:";
        cin.getline(s.tenkh,100);
        cout<<"Ngay ban:";
        cin.getline(s.ngayban,100);
        cout<<"Ma sach:";
        cin.getline(s.masach,100);
        cout<<"So luong:";
        cin>>s.soluong;
        cout<<"Don gia:";
        cin>>s.dongia;
        cin.ignore();
        nodeHoaDon *p = khoitaonodeHoaDon(s);
        addHoaDon(stackhoadon,p);
      }
      
}
int main() {
    StackSach l;
    khoitaoStackSach(l); 
    StackHoaDon k;
    khoitaoStackHoaDon(k);
     int luachon = 1;
    
    do{
       cout<<"*_*_*_*_*_*_*_*_*_*_*_*Menu*_*_*_*_*_*_*_*_*_*_*_*"<<endl;
       cout<<"____________________________________________________"<<endl;
       cout<<"***********************Sach*********************"<<endl;
        cout<<"1.Nhap thong tin Sach."<<endl;
        cout<<"2.Hien stack sach ra man hinh."<<endl;
        cout<<"3.Sap xep theo ten sach (bang chu cai a->z)."<<endl;
        cout<<"4.Tim kiem sach theo ten tac gia."<<endl;
        cout<<"5.Them sach vao vi tri k(dsach se chay tu 1)"<<endl;
        cout<<"6.Xoa thong tin sach theo the loai."<<endl;
        cout<<"7.Dem So luong sach cua nha xuat ban k(nhap tu ban phim)."<<endl;
        cout<<"8.Sua thong tin sach dua vao ma sach."<<endl;
        cout<<"9.Hien thong tin sach co don gia > k(k nhap tu ban phim)."<<endl;
        cout<<"10.Tong so sach con lai trong cua hang."<<endl;
        cout<<"21.Doc du lieu duoi dang binary."<<endl;
        cout<<"22.Ghi danh sach duoi dang binary vao file."<<endl;
        cout<<"23.Nhap thong tin sach voi n phan tu ban dau."<<endl;
        cout<<"107.Hien thi sach can huy(sach co tuoi doi hon 50 nam)."<<endl;

        cout<<"***********************Hoa Don*********************"<<endl;
        cout<<"11.Nhap danh sach thong tin hoa don tu file."<<endl;
        cout<<"12.Hien thong tin hoa don."<<endl;
        cout<<"13.Sap xep hoa don giam dan theo (don gia)."<<endl;
        cout<<"14.Tim kiem ten sach tieu thu nhieu nhat(dua vao so luong ban)."<<endl;
        cout<<"15.Tim kiem thong tin nguoi mua (dua vao ma khach hang)."<<endl;
        cout<<"16.Xoa thong tin khach hang k (dua vao ma khach hang)."<<endl;
        cout<<"17.Tim hoa don co gia tri min,max."<<endl;
        cout<<"18.Tinh tien lai theo ngay cua cua hang."<<endl;
        cout<<"19.Tong doanh thu trong ngay."<<endl;
        cout<<"20.Khuyen N % cho khach hang co gia tri tu."<<endl;
        cout<<"24.Doc du lieu duoi dang binary."<<endl;
        cout<<"25.Ghi danh sach duoi dang binary vao file."<<endl;
        cout<<"26.Nhap thong tin hoa don voi n phan tu ban dau."<<endl;
        cout<<"Lua chon:";
        cin>>luachon;
        cout<<endl;
        if(luachon==21) {
            string tenfile;
            cin.ignore();
            cout<<"Nhap ten file muon ghi:";
            cin>>tenfile;
            docDSfileSachBinary(l,tenfile);
            system("pause");
        }
        if(luachon==1) {
            string tenfile;
            cin.ignore();
            cout<<"Nhap ten file muon doc:";
            cin>>tenfile;
            docDSfileSach(l,tenfile);
             system("pause");
        }
        if(luachon == 2) {
           hienSach(l);
           system("pause");
        }
        if(luachon == 3) {
            sapxep(l);
            system("pause");
        }
        if(luachon == 4) {
            timkiemTheoTenTacGia(l);
            system("pause");
        }
        if(luachon ==5) {
            int vitri;
            
            cout<<"vi tri muon them sach:";
            cin>>vitri; 
            themsachvaovitri(l,vitri); 
            hienSach(l);
             system("pause");
           
        }
        if(luachon == 6) {
            char theloai[100];
            cin.ignore();
            cout<<"Nhap the loai muon xoa:";
            cin.getline(theloai,sizeof(theloai));
           xoaThongTinSachTheoTheLoai(l,theloai);
            system("pause");
        }
        if(luachon == 7) {
           cout<<"So luong sach cua nha xuat ban la :"<<endl<<demSoLuongSachNhaSanXuatX(l)<<endl;
           system("pause");
        }
         if(luachon == 8) {
            char masach[100];
            cout<<"Nhap ma sach de sua thong tin sach:";
            cin.ignore();
            cin.getline(masach,100);
             suathongtinSach(l,masach);
             system("pause");
        }
        if(luachon == 9) {
            double k;
            cout<<"Nhap k(k la 1 so):";
            cin>>k;
            hienThongTinSachTheoDieuKienDonGia(l,k);
            system("pause");
        }
        if(luachon == 10) {
            tongSoSachConLaiTrongKho(l);
            system("pause");
        }
        if(luachon == 22) {
            string tenfile;
            cin.ignore();
            cout<<"Nhap ten file muon ghi:";
            cin>>tenfile;
            ghidsvaoFileBinary(l,tenfile);
            system("pause");
        }
        if(luachon == 23) {
            int n;
            cout<<"Nhap n(so phan tu cua danh sach sach):";
            cin>>n;
            nhapDanhSachSach(l,n);
            system("pause");
        }
        if(luachon == 107) {
            hiensachcanhuy(l);
            system("pause");
        }
 
    // ************************************************************Hóa đơn**********************************************
         if(luachon == 11) {
            string tenfile;
            cin.ignore();
            cout<<"Nhap ten file doc :";
            cin>>tenfile;
             nhapHoaDon(k,tenfile);
             system("pause");
        }
        if(luachon ==12) {
             hienHoaDon(k);
             system("pause");
        }if(luachon ==13){
             sapXepHoaDon(k);
             system("pause");
        }
        if(luachon ==14) {
             timkiemTheoTenSachTieuThuNhieuNhat(k);
             system("pause");
        }
        if(luachon ==15) {
             int makh;
             cout<<"Nhap ma khach hang can tim:";
             cin>>makh;
             timkiemThongtinnguoimua(k,makh);
             system("pause");
        }
        if(luachon ==16) {
             int makh;
             cout<<"Nhap ma khach hang can nhap:";
             cin>>makh;
             xoaThongTinKhachhangTheoTen(k,makh);
             system("pause");
        }
        if(luachon == 17) {
            timHoaDonCoGiaTriMinMax(k);
            system("pause");
        }
        if(luachon==18) {
        string ngay;
        cin.ignore();
        cout<<"Nhap vao ngay ban muon tinh tien lai:";
        getline(cin,ngay);
        tinhtienlaitheongay(k,ngay);
        system("pause");
       }
        if(luachon ==19) {
            string ngay;
        cin.ignore();
        cout<<"Nhap vao ngay ban muon tinh tong doanh thu:";
        getline(cin,ngay);
            cout<<"Tong tien lai"<<tinhTongDanhThutrongngay(k,ngay)<<endl;
             system("pause");
        }
      if(luachon==20) {
        double giatri;
        double N;
        cout<<"Nhap giatri:";
        cin>>giatri;
        cout<<"N la so phan tram giam:";
        cin>>N;
       khuyenMaiHoaDon(k,giatri,N);
       hienHoaDon(k);
        system("pause");
       }  
        if(luachon == 24) {
            string tenfile;
            cin.ignore();
            cout<<"Nhap ten file muon doc:";
            cin>>tenfile;
            docDSfileSachBinaryHd(k,tenfile);
            system("pause");
        }
          if(luachon == 25) {
            string tenfile;
            cin.ignore();
            cout<<"Nhap ten file muon ghi:";
            cin>>tenfile;
            ghidsvaoFileBinaryHd(k,tenfile);
            system("pause");
        }
        if(luachon == 26) {
            int n;
            cout<<"Nhap n(so phan tu danh sach hoa don):";
            cin>>n;
            nhapDanhSachHd(k,n);
            system("pause");
        }

}while (luachon != 0);
}