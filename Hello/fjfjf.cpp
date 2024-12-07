#include <bits\stdc++.h>
using namespace std;
 
struct sinhVien {
    char msv[100], hoten[100], lop[100];
    double diemlt, diemth, diemthi, diemtb;
};
 
struct Node {
   
    Node *next = NULL;
    sinhVien info;
};
 
struct List {
    Node *head = NULL;
    Node *tail = NULL;
};
 
Node* getNode(sinhVien data);
void listHandle(List &L);
void printList(List &L);
void insertFirst(List &L, Node *p);
void insertLast(List &L, Node *p);
void insertAfter(List &L, Node *q, Node *p);
void insertCus(List &L, sinhVien k);
void removeMsv(List &L, char k[]);
void ListSortMsv(List &L);
 
Node* getNode(sinhVien data) {
    Node *p = new Node;
    if(p == NULL) cout << endl << "Khong du bo nho";
    else p->info = data;
    return p;
}
 
void printList(List &L) {
    if(L.head == NULL) cout << endl << "Danh sach trong!";
    else {
        Node *p = L.head;
        int i = 0;
        while(p != NULL)  {
            sinhVien data = p->info;
            cout << endl << "\n> Thong tin sinh vien so " << i
                << endl << "MSV: " << data.msv
                << endl << "Ho ten: " << data.hoten
                << endl << "Lop: " << data.lop
                << endl << "Diem LT: " << data.diemlt
                << endl << "Diem TH: " << data.diemth
                << endl << "Diem thi: " << data.diemthi
                << endl << "Diem TB: " << data.diemtb;
            p = p->next;
            i++;
        }
    }
}
 
void listHandle(List &L) {
    int s;
    do {
        cout << endl << "\n[Thao tac danh sach]"
            << endl << "0. Thoat chuong trinh"
            << endl << "1. Hien danh sach sinh vien"
            << endl << "2. Them 1 sinh vien vao dau ds"
            << endl << "3. Them 1 sinh vien vao cuoi ds"
            << endl << "4. Xoa sinh vien"
            << endl << "5. Sap xep danh sach theo thu tu tang dan cua (ma sinh vien)"
            << endl << "6. Chen sinh vien vao ds sao cho van dam bao danh sach duoc sap xep thu tu tang dan cua ma sinh vien (khong sap xep lai)"
            << endl << "Nhap lua chon: ";
        cin >> s;
        switch(s) {
            case 0: break;
            case 1: printList(L); break;
            case 2: {
                sinhVien x;
                cout << endl << "Nhap ma sinh vien: ";
                fflush(stdin);
                cin.getline(x.msv, 16);
                cout << endl << "Nhap ho ten: ";
                fflush(stdin);
                cin.getline(x.hoten, 64);
                cout << endl << "Nhap lop: ";
                fflush(stdin);
                cin.getline(x.lop, 16);
                cout << endl << "Nhap diem ly thuyet: ";
                cin >> x.diemlt;
                cout << endl << "Nhap diem thuc hanh: ";
                cin >> x.diemth;
                cout << endl << "Nhap diem thi: ";
                cin >> x.diemthi;
                cout << endl << "Nhap diem trung binh: ";
                cin >> x.diemtb;
                insertFirst(L, getNode(x));
                break;
            }
            case 3: {
                sinhVien x;
                cout << endl << "Nhap ma sinh vien: ";
                fflush(stdin);
                cin.getline(x.msv, 16);
                cout << endl << "Nhap ho ten: ";
                fflush(stdin);
                cin.getline(x.hoten, 64);
                cout << endl << "Nhap lop: ";
                fflush(stdin);
                cin.getline(x.lop, 16);
                cout << endl << "Nhap diem ly thuyet: ";
                cin >> x.diemlt;
                cout << endl << "Nhap diem thuc hanh: ";
                cin >> x.diemth;
                cout << endl << "Nhap diem thi: ";
                cin >> x.diemthi;
                cout << endl << "Nhap diem trung binh: ";
                cin >> x.diemtb;
                insertLast(L, getNode(x));
                break;
            }
            case 4: {
                if(L.head == NULL) cout << endl << "Danh sach trong!";
                else {
                    char msv[16];
                    cout << endl << "Nhap ma sinh vien can xoa: ";
                    fflush(stdin);
                    cin.getline(msv, 16);
                    removeMsv(L, msv);
                }
                break;
            }
            case 5: {
                if(L.head == NULL) cout << endl << "Danh sach trong!";
                else ListSortMsv(L);
                break;
            }
            case 6: {
                sinhVien x;
                cout << endl << "Nhap ma sinh vien: ";
                fflush(stdin);
                cin.getline(x.msv, 16);
                cout << endl << "Nhap ho ten: ";
                fflush(stdin);
                cin.getline(x.hoten, 64);
                cout << endl << "Nhap lop: ";
                fflush(stdin);
                cin.getline(x.lop, 16);
                cout << endl << "Nhap diem ly thuyet: ";
                cin >> x.diemlt;
                cout << endl << "Nhap diem thuc hanh: ";
                cin >> x.diemth;
                cout << endl << "Nhap diem thi: ";
                cin >> x.diemthi;
                cout << endl << "Nhap diem trung binh: ";
                cin >> x.diemtb;
                insertCus(L, x);
                break;
            }
        }
    } while(s != 0);
}
 
 
void insertLast(List &L, Node *p) {
    if(L.head == NULL) {
        L.head = p;
        L.tail = L.head;
    }
    else {
        L.tail->next = p;
        L.tail = p;
    }
}
 
void insertFirst(List &L, Node *p) {
    if(L.head == NULL) {
        L.head = p;
        L.tail = L.head;
    }
    else {
        p->next = L.head;
        L.head = p;
    }
}
 
void insertAfter(List &L, Node *q, Node *p) {
    if(q != NULL) {
        p->next = q->next;
        q->next = p;
        if(q == L.tail) L.tail = p;
    }
}
 
void insertCus(List &L, sinhVien k) {
    if(L.head == NULL) {
        L.head = getNode(k);
        L.tail = L.head;
    }
    else {
        Node *p = (L.head)->next;
        Node *q = NULL;
        while(p != NULL) {
            if(strcmp((p->info).msv, k.msv) > 0) q = p;
            p = p->next;
        }
        if(q != NULL) insertAfter(L, q, getNode(k));
    }
}
 
void removeMsv(List &L, char msv[]) {
    if(L.head == NULL) cout << endl << "Danh sach trong!";
    else {
        Node *p = L.head;
        Node *q = p->next;
        while(q != NULL) {
            if(strcmp((q->info).msv, msv) == 0) break;
            else {
                p = q;
                q = q->next;
            }
        }
        if(q == NULL) cout << endl << "Khong tim thay ma sinh vien."; 
        else {
            p->next = q->next;
            free(q);
        }
    }
}
 
void ListSortMsv(List &L) {
    if(L.head == NULL) cout << endl << "Danh sach trong!";
    else {
        Node *p = L.head;
        Node *q = p->next;
        while(p != NULL) {
            while(q != NULL) {
                if(strcmp((p->info).msv, (q->info).msv) > 0) {
                    swap(p->info, q->info);
                }
                q = q->next;
            }
            p = p->next;
        }
        cout << endl << "Da hoan thanh sap xep.";
    }
}
 
int main() {
    List danhSach;
    listHandle(danhSach);
    return 1;
}
