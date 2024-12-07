#include <iostream>
using namespace std;
 
 
int main(){
    int n;
    cout << "Nhap n = ";
    cin >> n;
    int dem;
    
    for(int i = 2; i <= n; i++){
        dem = 0;
        while(n % i == 0){
            ++dem;
            n /= i;
            cout<<i;
            if(n>=i){
            cout<<"*";}     
        }
    }
    
}
