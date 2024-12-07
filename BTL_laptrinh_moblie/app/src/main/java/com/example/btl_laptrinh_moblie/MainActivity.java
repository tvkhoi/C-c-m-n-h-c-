package com.example.btl_laptrinh_moblie;


import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.fragment.app.DialogFragment;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;


import android.app.Dialog;
import android.content.Intent;

import android.content.SharedPreferences;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;

import android.view.Gravity;
import android.view.View;


import android.view.ViewGroup;
import android.view.Window;
import android.view.WindowManager;
import android.widget.ArrayAdapter;

import android.widget.ImageButton;

import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import java.text.SimpleDateFormat;
import java.util.ArrayList;

import java.util.Calendar;

import java.util.List;
import java.util.Random;

public class MainActivity extends AppCompatActivity {
    int RESULT_CODE_TABLE_LAYOUT = 123;
    int RESULT_CODE_ADD = 1234;
    int RESULT_CODE_BIEUDO = 12345;
    int RESULT_CODE_CHONTIEN = 123456;
    public static ArrayList arrayList = new ArrayList();
    public static ArrayList arrayList_chi_phi = new ArrayList();
    public static ArrayList arrayList_thu_nhap = new ArrayList();
    static TextView textView_thang_nam_ghi_chep,textView_nam_ghichep,textView_tien_chiphi,textView_tien_thunhap,textView_tien_sodu;
    static TextView  textView_ten_tien_te;
    ImageButton imageButton_add,imageButton_bieudo,imageButton_ghichep,imageButton_laixuat;
    ImageView imageView_chon_tien_te;
    ConstraintLayout constraintLayout;
    static ArrayList arrayList_thoThong_tin_chi_tieu_thu_nhaps = new ArrayList();
    public static Adapter_ngaythang_nam adapter_ngaythang_nam;
    int nam;
    static ArrayList arrayList_trung_gian = new ArrayList();
    List<List<chiphi>> arrayList_chiphi_thunhap_trung_gian = new ArrayList<>();
    static String chuoi_tien="";
    static String chi_tiet_tien="";
    static int vitri_sua,tinhieu_sua = 0;
    static int icon_sua = 0;
    String thangf = null;
    ListView listView;
    ArrayList<String> arrayList_monHoc = new ArrayList<>();
    static ArrayList<Group> arrayList1 = new ArrayList<>();
    static ArrayList<Group> arrayList_group_trunggian = new ArrayList<>();
    ArrayList chiphiList = new ArrayList<>();
    ArrayAdapter arrayAdapter;
    static float tong_chiphi=0;
    static float tong_thunhap = 0;
    static int position;
    static  ArrayList<Tien_te> tien_tes = new ArrayList();
    int vitri_group;
    static Database database;
    static ArrayList<Group> groupArrayList = new ArrayList<>();
    static ArrayList<chitiet_chiphi_thu_nhap> chitiet_chiphi_thu_nhapArrayList = new ArrayList<>();
    static SharedPreferences sharedPreferences;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Calendar calendar = Calendar.getInstance();
        sharedPreferences = (SharedPreferences) getSharedPreferences("data_tien",MODE_PRIVATE);
        SimpleDateFormat simpleDateFormat = new SimpleDateFormat("MM");
        SimpleDateFormat simpleDateFormat_nam = new SimpleDateFormat("yyyy");
        thangf = simpleDateFormat.format(calendar.getTime());
        add_vaoMang();
        add_vaoMang_chiphi();
        add_vaoMang_thunhap();
        add_tien_te();
        Anhxa();
        textView_ten_tien_te.setText(tien_tes.get(0).getTien());
        textView_nam_ghichep.setText(simpleDateFormat_nam.format(calendar.getTime()));
        textView_thang_nam_ghi_chep.setText("Thg "+thangf);
        database = new Database(MainActivity.this,"ghi11.sqlite",null,1);
      //  int vitri_group,String ngay, String thang, String thu, String chiphi, String thu_nhap, List<chitiet_chiphi_thu_nhap> members, int nam
        database.QueryData("CREATE TABLE IF NOT EXISTS Group1(vitrigroup INTEGER PRIMARY KEY, ngay VARCHAR(30) , thang VARCHAR(30), thu VARCHAR(100), chiphi VARCHAR(100), thu_nhap VARCHAR(100), nam INTEGER)");
      // int icon, int vitri_gro up, String ten, String so_tien, int tablayout
        database.QueryData("CREATE TABLE IF NOT EXISTS Chitiet_chiphi_thunhap(id INTEGER PRIMARY KEY AUTOINCREMENT ,  icon  INTEGER, vitrigroup INTEGER , ten VARCHAR(200),  so_tien VARCHAR(100),  tablayout INTEGER)");


//        database.QueryData("DELETE FROM Chitiet_chiphi_thunhap");
//        database.QueryData("DELETE FROM Group1");
//        database.QueryData("DROP TABLE Group1");
//        database.QueryData("DROP TABLE Chitiet_chiphi_thunhap");
      //  database.close();
  // database.QueryData("DROP DATABASE ghi1");
        adapter_ngaythang_nam = new Adapter_ngaythang_nam(this,R.layout.custom_listview_ghichep, arrayList_group_trunggian);
        listView.setAdapter(adapter_ngaythang_nam);
        arrayList_group_trunggian.clear();
        arrayList1.clear();
        add_toan_bo_vao_mang();
        // hiển thị danh sách theo tháng và năm hiện tại
        tong_chiphi = 0;
        tong_thunhap = 0;
        float tong_du = 0;
        String thang_textView =  textView_thang_nam_ghi_chep.getText().toString().trim();
        String cat_chuoi="";
        if (thang_textView.length() == 6) {
            cat_chuoi = thang_textView.substring(4, 6);
        }
        if (thang_textView.length() == 5) {
            cat_chuoi = thang_textView.substring(4, 5);
            cat_chuoi = "0"+cat_chuoi;
        }
        int nam_texView = Integer.parseInt(textView_nam_ghichep.getText().toString().trim());
        // đổ dữ liệu vào mảng để hiện thị
        for (int i = 0;i<arrayList1.size();i++) {
            Group group = arrayList1.get(i);
            if(cat_chuoi.equals(group.getThang().trim())&&nam_texView==(group.getNam())) {
                arrayList_group_trunggian.add(group);
                tong_chiphi = tong_chiphi + Float.parseFloat(group.getChiphi());
                tong_thunhap = Float.parseFloat(group.getThu_nhap()) + tong_thunhap;
            }

        }
        tong_du = tong_thunhap - tong_chiphi;
        textView_tien_thunhap.setText(tong_thunhap+"");
        textView_tien_chiphi.setText(tong_chiphi+"");
        textView_tien_sodu.setText(tong_du+"");
        adapter_ngaythang_nam.notifyDataSetChanged();
        // hiển thị loại tiền tệ được lưu trữ vào share
        textView_ten_tien_te.setText(sharedPreferences.getString("loai_tien",tien_tes.get(0).getTien()));
        imageView_chon_tien_te.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(MainActivity.this,Activity_chon_tien.class);
                startActivityForResult(intent,RESULT_CODE_CHONTIEN);
            }
        });

    }
    public  void add_toan_bo_vao_mang() {
        chitiet_chiphi_thu_nhapArrayList.clear();
        groupArrayList.clear();
        Cursor dataGroup = database.GetData("SELECT * FROM Group1");
        Cursor dataChitiet_chiphi_thunhap = database.GetData("SELECT * FROM Chitiet_chiphi_thunhap");
        int soluongdong_group = database.getRowCount("Group1");
        int soluongdong_chitiet = database.getRowCount("Chitiet_chiphi_thunhap");
        List<chitiet_chiphi_thu_nhap> list =null;
        List<chitiet_chiphi_thu_nhap> list1 = null;
        while (dataChitiet_chiphi_thunhap.moveToNext()) {
            int icon = dataChitiet_chiphi_thunhap.getInt(1);
            int vitri_group_chitiet = dataChitiet_chiphi_thunhap.getInt(2);
            String ten = dataChitiet_chiphi_thunhap.getString(3);
            String so_tien = dataChitiet_chiphi_thunhap.getString(4);
            int tablayout = dataChitiet_chiphi_thunhap.getInt(5);
            chitiet_chiphi_thu_nhapArrayList.add(new chitiet_chiphi_thu_nhap(icon, vitri_group_chitiet, ten, so_tien, tablayout));
        }
        while (dataGroup.moveToNext()) {
            int vitri_group = dataGroup.getInt(0);
            String ngay = dataGroup.getString(1);
            String thang = dataGroup.getString(2);
            String thu = dataGroup.getString(3);
            String chiphi = dataGroup.getString(4);
            String thu_nhap = dataGroup.getString(5);
            int nam = dataGroup.getInt(6);
            list = new ArrayList<>();
            list.add(new chitiet_chiphi_thu_nhap(R.drawable.giaithuong,0,"fjfjf","0",0));
            groupArrayList.add(new Group(vitri_group, ngay, thang, thu, chiphi, thu_nhap, list, nam));
            list = null;
        }
        dataGroup.close();
        dataChitiet_chiphi_thunhap.close();
        for (int i = 0;i<groupArrayList.size();i++) {
            list1 = new ArrayList<>();
            for (int k = 0;k< chitiet_chiphi_thu_nhapArrayList.size();k++) {
                if(groupArrayList.get(i).getVitri_group()==chitiet_chiphi_thu_nhapArrayList.get(k).getVitri_group()) {
                    list1.add(new chitiet_chiphi_thu_nhap(chitiet_chiphi_thu_nhapArrayList.get(k).getIcon(),chitiet_chiphi_thu_nhapArrayList.get(k).getVitri_group(),chitiet_chiphi_thu_nhapArrayList.get(k).getTen(),chitiet_chiphi_thu_nhapArrayList.get(k).getSo_tien(),chitiet_chiphi_thu_nhapArrayList.get(k).getTablayout()));
                }
            }
            arrayList1.add(new Group(groupArrayList.get(i).getVitri_group(), groupArrayList.get(i).getNgay(), groupArrayList.get(i).getThang(), groupArrayList.get(i).getThu(), groupArrayList.get(i).getChiphi(), groupArrayList.get(i).getThu_nhap(), list1, groupArrayList.get(i).getNam()));
            list1 =null;
        }
        adapter_ngaythang_nam.notifyDataSetChanged();
    }
    private  void add_tien_te() {
        tien_tes.add(new Tien_te("VND (đ)","đồng Việt Nam"));
        tien_tes.add(new Tien_te("USD ($)","Đô la Mĩ"));
        tien_tes.add(new Tien_te("EUR (€)","Euro"));
        tien_tes.add(new Tien_te("GBP (£)","Bảng Anh"));
        tien_tes.add(new Tien_te("CNY (元)","Nhân dân tệ Trung Quốc"));
    }
    private void add_vaoMang_thunhap() {
        arrayList_thu_nhap.add(new chiphi(R.drawable.luong,"Lương"));
        arrayList_thu_nhap.add(new chiphi(R.drawable.dautu,"Đầu tư"));
        arrayList_thu_nhap.add(new chiphi(R.drawable.banthoigian,"Bán thời gian"));
        arrayList_thu_nhap.add(new chiphi(R.drawable.giaithuong,"Giải thưởng"));
        arrayList_thu_nhap.add(new chiphi(R.drawable.khac,"Khác"));
    }
    private void add_vaoMang_chiphi() {
        arrayList_chi_phi.add(new chiphi(R.drawable.monmonan,"Món ăn"));
        arrayList_chi_phi.add(new chiphi(R.drawable.cuahang,"Mua sắm"));
        arrayList_chi_phi.add(new chiphi(R.drawable.dienthoai,"Điện thoại"));
        arrayList_chi_phi.add(new chiphi(R.drawable.hat,"Giải trí"));
        arrayList_chi_phi.add(new chiphi(R.drawable.giaoduc,"Giáo dục"));
        arrayList_chi_phi.add(new chiphi(R.drawable.lamtoc,"Sắc đẹp"));
        arrayList_chi_phi.add(new chiphi(R.drawable.thethao,"Thể thao"));
        arrayList_chi_phi.add(new chiphi(R.drawable.xahoi,"Xã hội"));
        arrayList_chi_phi.add(new chiphi(R.drawable.vanchuyen,"Vận chuyển"));
        arrayList_chi_phi.add(new chiphi(R.drawable.quanao,"Quần áo"));
        arrayList_chi_phi.add(new chiphi(R.drawable.car,"Xe hơi"));
        arrayList_chi_phi.add(new chiphi(R.drawable.ruou,"Rượu"));
        arrayList_chi_phi.add(new chiphi(R.drawable.thuocla,"Thuốc lá"));
        arrayList_chi_phi.add(new chiphi(R.drawable.thietbidientu,"Thiết bị điện tử"));
        arrayList_chi_phi.add(new chiphi(R.drawable.dulich,"Du lịch"));
        arrayList_chi_phi.add(new chiphi(R.drawable.suc_khoe,"Sức khỏe"));
        arrayList_chi_phi.add(new chiphi(R.drawable.thu_cung,"Thú cưng"));
        arrayList_chi_phi.add(new chiphi(R.drawable.sua_chua,"Sửa chữa"));
        arrayList_chi_phi.add(new chiphi(R.drawable.nha_o,"Nhà ở"));
        arrayList_chi_phi.add(new chiphi(R.drawable.nha,"Nhà"));
        arrayList_chi_phi.add(new chiphi(R.drawable.quatang,"Quà tặng"));
        arrayList_chi_phi.add(new chiphi(R.drawable.tu_thien,"Quyên góp"));
        arrayList_chi_phi.add(new chiphi(R.drawable.ve_so,"Vé số"));
        arrayList_chi_phi.add(new chiphi(R.drawable.do_an_nhe,"Đồ ăn nhẹ"));
        arrayList_chi_phi.add(new chiphi(R.drawable.dua_be,"Đứa bé"));
        arrayList_chi_phi.add(new chiphi(R.drawable.rau_qua,"Rau quả"));
        arrayList_chi_phi.add(new chiphi(R.drawable.trai_cay,"Trái cây"));
        arrayList_chi_phi.add(new chiphi(R.drawable.diennuoc,"Điện nước"));
    }

    private void add_vaoMang() {
        arrayList.add(new thang(01));
        arrayList.add(new thang(02));
        arrayList.add(new thang(03));
        arrayList.add(new thang(04));
        arrayList.add(new thang(05));
        arrayList.add(new thang(06));
        arrayList.add(new thang(07));
        arrayList.add(new thang(8));
        arrayList.add(new thang(9));
        arrayList.add(new thang(10));
        arrayList.add(new thang(11));
        arrayList.add(new thang(12));

    }

    private void Anhxa() {
        textView_thang_nam_ghi_chep =(TextView) findViewById(R.id.textView_thang_nam);
        textView_nam_ghichep = (TextView) findViewById(R.id.textView_nam_soghi);
        imageButton_add = (ImageButton) findViewById(R.id.imageButton_add);
        constraintLayout = (ConstraintLayout) findViewById(R.id.container);
        listView = (ListView) findViewById(R.id.listview_ghi_chep);
        textView_tien_chiphi = (TextView) findViewById(R.id.textView_tien_chi_phi);
        textView_tien_thunhap = (TextView) findViewById(R.id.textView_tien_thu_nhap);
        textView_tien_sodu = (TextView) findViewById(R.id.textView_tien_so_du);
        imageButton_bieudo = (ImageButton) findViewById(R.id.imageButton_bieudo);
        imageView_chon_tien_te = (ImageView) findViewById(R.id.imageView_chon_tien_te);
        textView_ten_tien_te = (TextView) findViewById(R.id.textView_ten_tien_te);
        imageButton_ghichep = (ImageButton) findViewById(R.id.imageButton_ghichep);
        imageButton_laixuat = (ImageButton) findViewById(R.id.imageButton_laixuat);
    }
    public  void  onClick_laixuat(View view) {
        startActivity(new Intent(MainActivity.this,Activity_tinh_lai.class));
    }
    public void onClick_thag_nam_ghichep(View view) {
        Intent intent = new Intent(MainActivity.this,tablelayout_dialog.class);
        startActivityForResult(intent,RESULT_CODE_TABLE_LAYOUT);

    }
    public void onClick_add_ghichep(View view) {
        Intent intent = new Intent(MainActivity.this,Activity_add.class);
        startActivityForResult(intent,RESULT_CODE_ADD);


    }
    public void onClick_bieudo(View view) {
        Intent intent = new Intent(MainActivity.this,Activity_bieudo.class);
        startActivityForResult(intent,RESULT_CODE_BIEUDO);
    }


    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        arrayList1.clear();
        add_toan_bo_vao_mang();
        String ngay="";
        Random random = new Random();
        int nam = 2023;
        int a;
        if(requestCode == RESULT_CODE_ADD && resultCode == RESULT_OK && data!=null) {
            String thang = (String) data.getExtras().get("Thang");
            String thu = (String) data.getExtras().get("Thu");
            ngay = (String) data.getExtras().get("Ngay");
            String chiphi = (String) data.getExtras().get("chi_phi");
            String thunhap = (String) data.getExtras().get("thu_nhap");
            String thongtin = data.getStringExtra("thong_tin");
            int vitri_chiphi = (int) data.getIntExtra("vitri_chiphi",0);
            int vitri_thunhap = (int) data.getIntExtra("vitri_thunhap",0);
            int tablayout_position = (int) data.getIntExtra("tablayout_position",0);
            nam = (int) data.getIntExtra("Nam",2023);
            chiphi chiphi1 = (com.example.btl_laptrinh_moblie.chiphi) arrayList_chi_phi.get(vitri_chiphi);
            chiphi chiphi2 = (com.example.btl_laptrinh_moblie.chiphi) arrayList_thu_nhap.get(vitri_thunhap);
            ArrayList<chiphi> chiphiList1 = new ArrayList<>();
            boolean ton_tai = false;
            boolean tontai_trong_mang = false;

//                if(chiphi==""||thunhap=="") {
//
//                }
                if(tablayout_position==0) {
                    if (thongtin.isEmpty() == true) {
                        thongtin = chiphi1.getTen();
                    }
                    chiphiList = null;
                    chiphiList = new ArrayList();

                        // Nếu mảng arrayList_thoThong_tin_chi_tieu_thu_nhaps rỗng
                        if (arrayList1.size() == 0) {
                            a = random.nextInt(5000);
                            vitri_group = a;
                            tong_chiphi = Float.parseFloat(chiphi);
                            // vitri_group=arrayList1.size();
                            //chiphiList.add(new chitiet_chiphi_thu_nhap(chiphi1.getIcon(),vitri_group,thongtin,chiphi+"",tablayout_position));
                            // arrayList1.add(new Group(vitri_group,ngay,thang,thu,String.valueOf(tong_chiphi),"0", chiphiList,nam));
                            database.QueryData("INSERT INTO Group1 VALUES ('" + vitri_group + "','" + ngay + "','" + thang + "','" + thu + "','" + tong_chiphi + "','" + "0" + "','" + nam + "')");
                            database.QueryData("INSERT INTO Chitiet_chiphi_thunhap VALUES(null,'" + chiphi1.getIcon() + "','" + vitri_group + "','" + thongtin + "','" + chiphi + "','" + tablayout_position + "')");
                            add_toan_bo_vao_mang();
                            chiphiList = null;
                            chiphiList = new ArrayList();
                            // vitri_group = arrayList1.size()-1;

                        }
                        // Nếu mảng arrayList_thoThong_tin_chi_tieu_thu_nhaps ko rỗng
                        else {
                            for (int i = 0; i < arrayList1.size(); i++) {
                                Group thong_tin_chi_tieu_thu_nhap = (Group) arrayList1.get(i);
                                // khi ngày của 1 dòng trong listView chính bằng với ngày thêm vào của 1 phần tử thuộc listview con
                                if (thong_tin_chi_tieu_thu_nhap.getNgay().trim().equals(ngay.trim()) && thong_tin_chi_tieu_thu_nhap.getThang().equals(thang.trim())
                                        && thong_tin_chi_tieu_thu_nhap.getNam() == nam) {
                                    chiphiList = (ArrayList<chitiet_chiphi_thu_nhap>) thong_tin_chi_tieu_thu_nhap.getMembers();
                                    // chiphiList.add(new chitiet_chiphi_thu_nhap(chiphi1.getIcon(),thong_tin_chi_tieu_thu_nhap.getVitri_group(),thongtin,chiphi,tablayout_position));
                                    database.QueryData("INSERT INTO Chitiet_chiphi_thunhap VALUES(null,'" + chiphi1.getIcon() + "','" + thong_tin_chi_tieu_thu_nhap.getVitri_group() + "','" + thongtin + "','" + chiphi + "','" + tablayout_position + "')");
                                    //  thong_tin_chi_tieu_thu_nhap.setMembers(chiphiList);
                                    float chiphi_trung_gian = Float.parseFloat(chiphi);
                                    tong_chiphi = Float.parseFloat(thong_tin_chi_tieu_thu_nhap.getChiphi()) + chiphi_trung_gian;
                                    // thong_tin_chi_tieu_thu_nhap.setChiphi(String.valueOf(tong_chiphi));
                                    database.QueryData("UPDATE Group1 SET chiphi = '" + tong_chiphi + "' WHERE vitrigroup = '" + thong_tin_chi_tieu_thu_nhap.getVitri_group() + "'");
                                    arrayList1.clear();
                                    add_toan_bo_vao_mang();
                                    //  arrayList1.set(i,thong_tin_chi_tieu_thu_nhap);
                                    chiphiList = null;
                                    chiphiList = new ArrayList();
                                    tontai_trong_mang = true;
                                    break;
                                }
                            }
                            for (int j = 0; j < arrayList1.size(); j++) {
                                Group thong_tin_chi_tieu_thu_nhap1 = (Group) arrayList1.get(j);
                                if (thong_tin_chi_tieu_thu_nhap1.getNgay().equals(ngay.trim()) && thong_tin_chi_tieu_thu_nhap1.getThang().equals(thang.trim())) {
                                    ton_tai = true;
                                    break;
                                }
                            }
                            if (ton_tai == false) {
                                // nếu id_group tồn tại thì tạo 1 cái mới
                                for (int i = 0; i < arrayList1.size(); i++) {
                                    if (vitri_group == arrayList1.get(i).getVitri_group()) {
                                        vitri_group = random.nextInt(5000);
                                    }
                                }
                                //vitri_group = arrayList1.size();
                                tong_chiphi = Float.parseFloat(chiphi);
                                //  chiphiList.add(new chitiet_chiphi_thu_nhap(chiphi1.getIcon(),vitri_group,thongtin,chiphi,tablayout_position));
                                // arrayList1.add(new Group(vitri_group,ngay,thang,thu,String.valueOf(tong_chiphi),"0", chiphiList,nam));
                                database.QueryData("INSERT INTO Group1 VALUES ('" + vitri_group + "','" + ngay + "','" + thang + "','" + thu + "','" + tong_chiphi + "','" + "0" + "','" + nam + "')");
                                database.QueryData("INSERT INTO Chitiet_chiphi_thunhap VALUES(null,'" + chiphi1.getIcon() + "','" + vitri_group + "','" + thongtin + "','" + chiphi + "','" + tablayout_position + "')");
                                arrayList1.clear();
                                add_toan_bo_vao_mang();
                                chiphiList = null;
                                chiphiList = new ArrayList();
                            }
                            ton_tai = false;
                        }
                    }
                    if (tablayout_position == 1) {
                        if (thongtin.isEmpty() == true) {
                            thongtin = chiphi2.getTen();
                        }
                        chiphiList = null;
                        chiphiList = new ArrayList();
                        // Nếu mảng arrayList_thoThong_tin_chi_tieu_thu_nhaps rỗng
                        if (arrayList1.size() == 0) {
                            a = random.nextInt(5000);
                            vitri_group = a;
                            tong_thunhap = Float.parseFloat(thunhap);
                            // chiphiList.add(new chitiet_chiphi_thu_nhap(chiphi2.getIcon(),vitri_group,thongtin,thunhap+"",tablayout_position));
                            // arrayList1.add(new Group(vitri_group,ngay,thang,thu,"0",String.valueOf(tong_thunhap), chiphiList,nam));
                            database.QueryData("INSERT INTO Group1 VALUES ('" + vitri_group + "','" + ngay + "','" + thang + "','" + thu + "','" + "0" + "','" + thunhap + "','" + nam + "')");
                            database.QueryData("INSERT INTO Chitiet_chiphi_thunhap VALUES(null,'" + chiphi2.getIcon() + "','" + vitri_group + "','" + thongtin + "','" + thunhap + "','" + tablayout_position + "')");
                            chiphiList = null;
                            chiphiList = new ArrayList();
                            arrayList1.clear();
                            add_toan_bo_vao_mang();

                        }

                        // Nếu mảng arrayList_thoThong_tin_chi_tieu_thu_nhaps ko rỗng
                        else {

                            for (int i = 0; i < arrayList1.size(); i++) {
                                Group thong_tin_chi_tieu_thu_nhap = (Group) arrayList1.get(i);
                                // khi ngày của 1 dòng trong listView chính bằng với ngày thêm vào của 1 phần tử thuộc listview con
                                if (thong_tin_chi_tieu_thu_nhap.getNgay().trim().equals(ngay.trim()) && thong_tin_chi_tieu_thu_nhap.getThang().equals(thang.trim())
                                        && thong_tin_chi_tieu_thu_nhap.getNam() == nam) {
                                    chiphiList = (ArrayList<chitiet_chiphi_thu_nhap>) thong_tin_chi_tieu_thu_nhap.getMembers();
                                    // chiphiList.add(new chitiet_chiphi_thu_nhap(chiphi2.getIcon(),thong_tin_chi_tieu_thu_nhap.getVitri_group(),thongtin,thunhap+"",tablayout_position));
                                    database.QueryData("INSERT INTO Chitiet_chiphi_thunhap VALUES(null,'" + chiphi2.getIcon() + "','" + thong_tin_chi_tieu_thu_nhap.getVitri_group() + "','" + thongtin + "','" + thunhap + "','" + tablayout_position + "')");
                                    // thong_tin_chi_tieu_thu_nhap.setMembers(chiphiList);
                                    float thunhap_trunggian = Float.parseFloat(thunhap);
                                    tong_thunhap = Float.parseFloat(thong_tin_chi_tieu_thu_nhap.getThu_nhap()) + thunhap_trunggian;
                                    // thong_tin_chi_tieu_thu_nhap.setThu_nhap(String.valueOf(tong_thunhap));
                                    database.QueryData("UPDATE Group1 SET thu_nhap= '" + tong_thunhap + "' WHERE vitrigroup = '" + thong_tin_chi_tieu_thu_nhap.getVitri_group() + "'");
                                    // arrayList1.set(i,thong_tin_chi_tieu_thu_nhap);
                                    arrayList1.clear();
                                    add_toan_bo_vao_mang();
                                    chiphiList = null;
                                    chiphiList = new ArrayList();
                                    tontai_trong_mang = true;
                                    break;
                                }
                            }
                            for (int j = 0; j < arrayList1.size(); j++) {
                                Group thong_tin_chi_tieu_thu_nhap1 = (Group) arrayList1.get(j);
                                if (thong_tin_chi_tieu_thu_nhap1.getNgay().equals(ngay.trim()) && thong_tin_chi_tieu_thu_nhap1.getThang().equals(thang.trim())) {
                                    ton_tai = true;

                                    break;
                                }
                            }
                            if (ton_tai == false) {
                                // nếu id_group tồn tại thì tạo 1 cái mới
                                for (int i = 0; i < arrayList1.size(); i++) {
                                    if (vitri_group == arrayList1.get(i).getVitri_group()) {
                                        vitri_group = random.nextInt(5000);
                                    }
                                }
                                // vitri_group = arrayList1.size();
                                tong_thunhap = Float.parseFloat(thunhap);
                                //chiphiList.add(new chitiet_chiphi_thu_nhap(chiphi2.getIcon(),vitri_group,thongtin,thunhap+"",tablayout_position));
                                //arrayList1.add(new Group(vitri_group,ngay,thang,thu,"0",thunhap, chiphiList,nam));
                                database.QueryData("INSERT INTO Group1 VALUES ('" + vitri_group + "','" + ngay + "','" + thang + "','" + thu + "','" + "0" + "','" + thunhap + "','" + nam + "')");
                                database.QueryData("INSERT INTO Chitiet_chiphi_thunhap VALUES(null,'" + chiphi2.getIcon() + "','" + vitri_group + "','" + thongtin + "','" + thunhap + "','" + tablayout_position + "')");
                                arrayList1.clear();
                                add_toan_bo_vao_mang();
                                chiphiList = null;
                                chiphiList = new ArrayList();
                            }
                            ton_tai = false;
                        }
                    }


      }
        if(requestCode == RESULT_CODE_TABLE_LAYOUT && resultCode==RESULT_OK && data!=null) {
            String thang = (String) data.getExtras().get("Thang");
            if (thang.length() == 6) {
                thangf = thang.substring(4, 6);
            }
            if (thang.length() == 5) {
                thangf = thang.substring(4, 5);
            }
            String namf = (String) data.getExtras().get("Nam");
            textView_thang_nam_ghi_chep.setText(thang);
            textView_nam_ghichep.setText(namf);

        }
        tong_chiphi = 0;
        tong_thunhap = 0;
        float tong_du = 0;
        String thang_textView =  textView_thang_nam_ghi_chep.getText().toString().trim();
        String cat_chuoi="";
        if (thang_textView.length() == 6) {
            cat_chuoi = thang_textView.substring(4, 6);
        }
        if (thang_textView.length() == 5) {
            cat_chuoi = thang_textView.substring(4, 5);
            cat_chuoi = "0"+cat_chuoi;
        }

        arrayList_group_trunggian.clear();
        arrayList1.clear();
        add_toan_bo_vao_mang();
        int nam_texView = Integer.parseInt(textView_nam_ghichep.getText().toString().trim());
        arrayList_group_trunggian.clear();
        // đổ dữ liệu vào mảng để hiện thị
        for (int i = 0;i<arrayList1.size();i++) {
            Group group = arrayList1.get(i);
            if(cat_chuoi.equals(group.getThang().trim())&&nam_texView==(group.getNam())) {
                arrayList_group_trunggian.add(group);
                tong_chiphi = tong_chiphi + Float.parseFloat(group.getChiphi());
                tong_thunhap = Float.parseFloat(group.getThu_nhap()) + tong_thunhap;
            }

        }
        tong_du = tong_thunhap - tong_chiphi;
        textView_tien_thunhap.setText(tong_thunhap+"");
        textView_tien_chiphi.setText(tong_chiphi+"");
        textView_tien_sodu.setText(tong_du+"");
        adapter_ngaythang_nam.notifyDataSetChanged();
        super.onActivityResult(requestCode, resultCode, data);
    }

}