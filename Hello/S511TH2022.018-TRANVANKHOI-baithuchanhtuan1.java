import java.util.Scanner;
/*
Họ tên : Trần Văn Khởi
Lớp : 2210A04
 */
class TinhTong2so {
    private int x;
    private float y;
    private final int z = 10;

    public void showX() {
        Scanner sr = new Scanner(System.in);
        System.out.print("x= ");
        x = sr.nextInt();

    }

    public void showY() {
        Scanner sa = new Scanner(System.in);
        System.out.print("y= ");
        y = sa.nextFloat();
    }

    public double total() {
        float s;
        s = x + y;
        System.out.println("x + y = " + (s));
        return s;
    }

    public static void main(String[] args) {
        TinhTong2so abs = new TinhTong2so();
        abs.showX();
        abs.showY();
        System.out.println("x = " + abs.x);
        System.out.println("y = " + abs.y);
        System.out.println("z = " + abs.z);
        abs.total();
    }
}
