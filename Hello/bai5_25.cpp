#include<bits/stdc++.h>
using namespace std;
// Phiếu khảo sát
struct phieukhaosat
{
   char hovaten[100];
   unsigned int ykien;
};
struct nodephieukhaosat
{
    /* data */
    phieukhaosat nv;
    nodephieukhaosat *pnext;

};

// khai báo 1 stack để lưu trữ
struct StackPhieukhaosat
{
    nodephieukhaosat *ptop;
};
// tạo 1 node 
nodephieukhaosat * khoitaonodephieukhaosat(phieukhaosat nv) {
    nodephieukhaosat *p = new nodephieukhaosat;
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
// khởi tạo 1 stack phiếu khảo sát
void khoitaostackPhieukhaosat(StackPhieukhaosat &s) {
     s.ptop=NULL;
}

// chức năng
bool IsEmpty(StackPhieukhaosat &s) {
    if(s.ptop==NULL) {
        return true;
    }
    return false;
}
bool themvaodaustackphieukhaosat(StackPhieukhaosat &s,nodephieukhaosat*p) {
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

void nhapthongtinphieukhaosat(StackPhieukhaosat &s) {
        phieukhaosat pks;
        fstream file1;
        file1.open("phieukhaosat.txt",ios::in);
        int n;
        file1>>n;
        for (int i = 0; i < n; i++)
        {
           file1.getline(pks.hovaten,100,',');
        
           file1>>pks.ykien;
           nodephieukhaosat *p = khoitaonodephieukhaosat(pks);
           themvaodaustackphieukhaosat(s,p);
        }
        file1.close();
}
void xuatstackPhieukhaosat(StackPhieukhaosat s)  {
    StackPhieukhaosat p = s;
     while (p.ptop!=NULL )
     {
          cout<<s.ptop->nv.hovaten<<" "<<s.ptop->nv.ykien<<endl;
          s.ptop = s.ptop->pnext;
     } 
}
void sapxepphieukhaosat(StackPhieukhaosat &s) {
    StackPhieukhaosat p = s;
    for (nodephieukhaosat *i = p.ptop; i!=NULL; i = i->pnext)
    {
        for (nodephieukhaosat *k = i->pnext; k!=NULL; k = k->pnext)
    {
        if(i->nv.ykien > k->nv.ykien) {
            phieukhaosat psk = i->nv;
            i->nv = k->nv;
            k->nv = psk;
        }
        
    }
        
    }
    

}
void timkiemphieugiamgia(StackPhieukhaosat s) {
	//StackPhieukhaosat p = s;
	char hovaten[100];
	cout<<"Nhap ho va ten:"<<endl;
	cin.ignore();
	cin.getline(hovaten,100);
	for (nodephieukhaosat *q = s.ptop;q != NULL;q = q->pnext)
	{
		if (strcmp(q->nv.hovaten,hovaten)==0)
		{
			cout<<q->nv.hovaten<<" "<<q->nv.ykien<<endl;
		}
		
	}
	
}
int main()
{
   StackPhieukhaosat k;
    khoitaostackPhieukhaosat(k);
	int luachon = 0;
     do{
       
        cout<<"1.Them 1 node vao stack sach"<<endl;
        cout<<"2.Hien stack sach ra man hinh"<<endl;
        cout<<"4.Tim kiem theo ten sach"<<endl;
        cin>>luachon;
        cout<<endl;
        if(luachon==1) {
             nhapthongtinphieukhaosat(k);
             system("pause");
        }
        if(luachon == 2) {
          xuatstackPhieukhaosat(k);
           system("pause");
        }
        if(luachon == 4) {
           timkiemphieugiamgia(k);
            system("pause");
        }
    }while (luachon != 0);
    return 0;
}