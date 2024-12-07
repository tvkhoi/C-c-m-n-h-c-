#include<bits/stdc++.h>
using namespace std;
struct sinhvien {
  string name;
  string lop;
  string masinh;

};
void danhsachsv(int &n) {
//  struct sinhvien {
//   string name;
//   string lop;
//   string masinh;

// };
  for(int i = 0;i<=n-1;++i) {
    cout<<"sinhvien : "<<i<<endl;
    
    cout<<"Ho va ten : ";
    sinhvien svi;
    cin.ignore();
    getline(cin,svi.name);
    cout<<endl<<"Lop : ";
    cin>>svi.lop;
    cout<<endl<<"Ma sinh vien : ";
    cin>>svi.masinh;
  }
}
void hiendanhsachsv(int n) {
 
  cout<<setw(4)<<left<<"Stt";
  cout<<setw(30)<<left<<"Ho va ten";
  cout<<setw(50)<<left<<"Lop";
  cout<<setw(70)<<left<<"Ma sinh vien"<<endl;
     for(int i = 0;i<=n-1;++i) {
      sinhvien svi;
      cout<<setw(4)<<left<<i;
      //cin.ignore();
      cout<<setw(30)<<left<<svi.name;
      cout<<setw(50)<<left<<svi.lop;
      cout<<setw(70)<<left<<svi.masinh<<endl;
     }


}
int main() {
  int a;
  cout<<"n = ";
  cin>>a;
    danhsachsv(a);
    hiendanhsachsv(a);
}