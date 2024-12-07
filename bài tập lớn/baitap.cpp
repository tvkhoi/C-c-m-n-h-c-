// #include<bits/stdc++.h>
// using namespace std;

// int g_n=0,g_a[1000],g_i=0;
// void nhapmang() {
//       while(1) {
//         g_n++;
//       cout<<"g_a["<<g_i<<"]= "; cin>>g_a[g_i];
//       if(g_a[g_i] ==0 ) 
//       break;
//       g_i++;
//       }
      
     
// } 
// void hienthi() {
//      cout<<"Mang ban dau : ";
//      for( g_i =0;g_i<g_n;++g_i) {
//       cout<<setw(3)<<g_a[g_i];

//      }


// }
// int tong(int tong1) {
//     cout<<endl;
//     for(g_i =0;g_i<g_n;g_i++) {
//         if(g_a[g_i]%2==0 &&g_a[g_i]%4==0)
//         tong1+=g_a[g_i];
//     }
//     cout<<"Mang24 : "<<tong1<<endl;
//     return tong1;
// }
// int tinhx(int dem) {
//     int x;
//     cout<<"Nhap x : "; cin>>x;
//     for( g_i =0;g_i<g_n;++g_i) {
//         if(g_a[g_i] / x==1)
//         dem++;
     
//      }
//       cout<<"So luong x : "<<dem<<endl;
//       return dem;
// }
// void chenmang(int &g_n){
//     int k,y;
//     cout<<"k = "; cin>>k;
//     cout<<"y = "; cin>>y;
//  g_n++;
//     for(g_i =g_n-1;g_i>k ;g_i--) {
//         g_a[g_i]=g_a[g_i-1];

           
//     }
//        g_a[k] = y;
// }

// void hienmangchen() {
//     cout<<"Hien mang chen : ";
//   for(g_i=0;g_i<g_n;g_i++) {
//     cout<<setw(3)<<g_a[g_i];
//   }

// }
// void chenmangvaodau() {
//   int q;
//   cout<<"q = "; cin>>q;
//   g_n++;
//    for(g_i = g_n-1;g_i>0;g_i--) {
//     g_a[g_i]=g_a[g_i-1];

//    }
//    g_a[0]=q;

// }
// int main() {
//   freopen("nhap.in","r",stdin);
// freopen("xuat.out","w",stdout);
//     nhapmang();
//     hienthi();
//     tong(0);
//     tinhx(0);
//     chenmang(g_n);
//     hienmangchen();
//    chenmangvaodau();
//    hienmangchen();
// }
// #include<iostream>
// using namespace std;

// class Person {
// private:
// 	int id;
// 	string name;
// 	int age;
// 	string address;
// public :
// 	void geId(int id) {
//   this->id =id;
  
// 	}
// 	void geName(string name) {
//       this->name=name;
	  
// 	}
// 	void geAge(int age) {
      
// 	 this->age=age;
// 	}
// 	void geAddress(string address) {
//       this->address=address;
// 	}


 
// 	int getId() {
    

// 	  return id;
// 	}
// 	string getName() {
      
//       return name;
// 	  // return name;
// 	}
// 	int getAge() {
      
	  
// 	  return age;
// 	}
// 	string getAddress() {
     
// 	 return address;
// 	}
// };

// int main() {
// 	Person p;
// 	p.geAge(24);
// 	p.geId(1001);
// 	p.geAddress("Ha Noi");
// 	p.geName("Quynh");
// 	cout << "Id: " << p.getId() << endl;
// 	cout << "Name: " << p.getName() << endl;
// 	cout << "Age: " << p.getAge() << endl;
// 	cout << "Address: " << p.getAddress() << endl;
// 	return 0;
// }
// #include<bits/stdc++.h>
// using namespace std;
// class pe {
//   private : 
//   string name;
//   public :
//   pe(string name) {
//     this-> name=name;
//   }
//   void nhap() {
//      cout<<name;
//     // return name;
//   }
// };
// int main() { 
//    pe p("gjg");
//   p.nhap();
// }
// #include<bits/stdc++.h>

// using namespace std;


// class Rectangle {
// private:
// 	double length;
// 	double width;

// public:
// 	Rectangle() {

// 	}

// 	Rectangle(double length, double width) {
// 		this->length = length;
// 		this->width = width;
// 	}

// 	double getLength() {
// 		return length;
// 	}

// 	void setLength(double length) {
// 		this->length = length;
// 	}

// 	double getWidth() {
// 		return width;
// 	}

// 	void setWidth(double width) {
// 		this->width = width;
// 	}

// 	double getArea() {
// 		return length * width;
// 	}

// 	double getPerimeter() {
// 		return (length + width) * 2;
// 	}
// };
// int main() {
// 	Rectangle r(4, 5);
// 	cout << "Area: " << r.getArea() << endl;
// 	cout << "Perimeter: " << r.getPerimeter() << endl;
// 	// r.setLength(2);
// 	// r.setWidth(3);
//   Rectangle d(2,3);

// 	cout << "Area: " << d.getArea() << endl;
// 	cout << "Perimeter: " << d.getPerimeter() << endl;
// 	return 0;
// }
// #include<bits/stdc++.h>
// using namespace std;

// class bia
// {
// private:
// string name;
// int tuoi;
// public:
//    bia(string name, int tuoi) {
//        this->tuoi=tuoi;
// 	   this->name = name;
//    }
//    void nhap(string name,int tuoi) {
// 	this-> name=name;
// 	this-> tuoi=tuoi;
//    }
//    void xuat() {
// 	string tuoi = to_string(this->tuoi);
// 	cout<<name<<"/"<<tuoi<<endl;
//    }
// }; 

// int main() {
//  bia p("khoi",19);
//  p.xuat();
//  p.nhap("hfk",20);
//  p.xuat();
// }
// #include<bits/stdc++.h>
// using namespace std;
// class abs {
//    public :
//    int nhap() {
//       int x = 10;
//           return x;
//    }
// };
// int main() {
//    abs* s = new nhap();
//    cout<<s->x;
// }
// #include<bits/stdc++.h>
// using namespace std;
// class Mangsonguyen {
//     private:
//     int a[100];
//     int n;
//     int tong;
//     int vtpt;
//     int luu;
//     public:
//     Mangsonguyen() {
//       cout<<"Nhap n (so phan tu cua mang ):";
//       cin>>n;
//      int i = 0;
//       while (i<n)
//       { 
//         cout<<"a["<<i<<"] = ";
//         cin>>a[i]; 
//          i++;
//       }
//    }
//    void hien() {
//     for(int i = 0;i<n;i++) {
//       cout<<a[i];
//     }
//     cout<<endl;
//    }
//   int tong1() { 
//    tong = 0;
//    for(int i = 0;i<n;i++) {
//     tong+=a[i];
//    }
//    cout<<"Tong phan tu cua mang la :"<<tong<<endl;
//    return tong;
//   }
//    void inpt() {
//       cout<<"Nhung phan tu le trong mang so nguyen la : ";
//       for(int i = 0;i<n;i++) {
//          if(a[i]%3==0||a[i]==1)
//          cout<<"a["<<i<<"]= "<<a[i]<<" ";
//       }
//       cout<<endl;
//    }
//    void gtvt() {
//       vtpt = a[0];
//       luu = 0;
//       for(int i = 1;i<n;i++)  {
//          if(vtpt > a[i]) {
//             luu = i;
//          }
//       }
//       cout<<"Gia tri : "<<a[luu]<<"Vi tri :"<<luu;
//    }
// };
// int main() {
//    Mangsonguyen b;
//    b.hien();
//    b.tong1();
//    b.inpt();
//    b.gtvt();
// }
