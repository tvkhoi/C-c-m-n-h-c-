// import java.util.Scanner;

// public class nghich {
//     private int a;
//     public void nhap() {
//         Scanner sr = new Scanner(System.in);
//         this.a = sr.nextInt();
//     }
//     public static void main(String[] args) {
//         nghich h = new nghich();
//         h.nhap();
//     }
   
    
// }
import java.util.Scanner;

public class bai4 {
   public String maSoHocSinh;
   private String hoTen;
   private String lop;
   private int soBuoiAnBanTru;

   public static void main(String[] args) {
	   
	   Scanner s = new Scanner(System.in);
	   System.out.print("Nhap n (so sinh vien) : ");
	   int n = s.nextInt();
	   bai4 a[]=  new bai4[n] ;
	   for(int i =1;i<n;i++) {
		
		//System.out.print("Ma sv : ");
		a[i].maSoHocSinh = s.nextLine();
//		System.out.print("Ho ten : ");
//		a[i].hoTen=sc.nextLine();
//		System.out.print("Lop : ");
//		a[i].lop=sc.nextLine();
//		System.out.print("So buoi ban tru : ");
//		a[i].soBuoiAnBanTru=sc.nextInt();
	}
	
}
}
