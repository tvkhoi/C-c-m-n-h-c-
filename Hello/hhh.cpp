#include<bits/stdc++.h>
using namespace std;
// tạo cấu trúc node 
struct node
{
    int data;
    node *next;

};
// tạo danh sách liên kết đơn
struct listf
{
    node *head;
    node *tail;
};
// khoi tao danh sach lien ket
void khoitao(listf &l) {
    // cho 2 con tro tro den null vi danh sach chua co lien ket don chua co phan tu
    l.head =NULL;
    l.tail = NULL;
}
// tạo 1 node 
node *newnode(int x) {
    node *p =new node;
    if(p ==NULL)
    {
    cout<<"Khong du bo nho cap phat!!";
    return NULL;
    }
    else {
      p->data=x;
      p->next = NULL;
    }
    return p;
}
// thêm phần tử node vào đầu danh sách là :
void themptuvaodaudanhsach(listf &l,node *p) {
    //node *p = new node;
     if(l.head == NULL) {
       l.head =l.tail=p;
     }
     else {
        p->next = l.head;
        l.head = p;

     }
    
}
// nhap 1 danh sach lien ket
void hien(listf l) {
    for(node *k =l.head;k !=NULL;k=k->next) {
        cout<<k->data;
    }
}
int main() {
    listf l;
    khoitao(l);
     int x;
     for(int i=0;i<5;i++) {
        cout<<"Nhap phan tu:";
        cin>>x;
        node*p =newnode(x);
        themptuvaodaudanhsach(l,p);
     }
     hien(l);
}
