package com.example.btl_laptrinh_moblie;

import static android.app.PendingIntent.getActivity;

import androidx.appcompat.app.ActionBar;
import androidx.appcompat.app.AppCompatActivity;

import android.app.Dialog;
import android.content.SharedPreferences;
import android.database.Cursor;
import android.graphics.Color;
import android.graphics.drawable.ColorDrawable;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.view.View;
import android.widget.Adapter;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.CheckBox;
import android.widget.ListAdapter;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.Toolbar;

import java.util.ArrayList;
import java.util.List;

public class Activity_chon_tien extends AppCompatActivity {
    ListView listView_chon_tien;
    TextView textView_loai_tien_te,textView_chitiet_loai_tien_te;
    ArrayList<Tien_te> tien_tes = MainActivity.tien_tes;
    float giatriquydoitiente;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_chon_tien);
        setTitle("Tiền tệ");


        Anhxa();
        textView_loai_tien_te.setText(tien_tes.get(MainActivity.position).getTien());
        textView_chitiet_loai_tien_te.setText(tien_tes.get(MainActivity.position).getChi_tiet_tien());
        Adapte_chon_tien adapte_chon_tien = new Adapte_chon_tien(this,R.layout.custom_listview_chon_tien,tien_tes);
        listView_chon_tien.setAdapter( adapte_chon_tien);
        adapte_chon_tien.notifyDataSetChanged();

        listView_chon_tien.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                // đổ dữ liệu từ database vào mảng chứa toàn bộ danh sách
                MainActivity.arrayList1.clear();
                MainActivity.chitiet_chiphi_thu_nhapArrayList.clear();
                MainActivity.groupArrayList.clear();
                Cursor dataGroup = MainActivity.database.GetData("SELECT * FROM Group1");
                Cursor dataChitiet_chiphi_thunhap = MainActivity.database.GetData("SELECT * FROM Chitiet_chiphi_thunhap");
                List<chitiet_chiphi_thu_nhap> list4 =null;
                List<chitiet_chiphi_thu_nhap> list5 = null;
                while (dataChitiet_chiphi_thunhap.moveToNext()) {
                    int icon = dataChitiet_chiphi_thunhap.getInt(1);
                    int vitri_group_chitiet = dataChitiet_chiphi_thunhap.getInt(2);
                    String ten = dataChitiet_chiphi_thunhap.getString(3);
                    String so_tien = dataChitiet_chiphi_thunhap.getString(4);
                    int tablayout = dataChitiet_chiphi_thunhap.getInt(5);
                    MainActivity.chitiet_chiphi_thu_nhapArrayList.add(new chitiet_chiphi_thu_nhap(icon, vitri_group_chitiet, ten, so_tien, tablayout));
                }
                while (dataGroup.moveToNext()) {
                    int vitri_group = dataGroup.getInt(0);
                    String ngay = dataGroup.getString(1);
                    String thang = dataGroup.getString(2);
                    String thu = dataGroup.getString(3);
                    String chiphi = dataGroup.getString(4);
                    String thu_nhap = dataGroup.getString(5);
                    int nam = dataGroup.getInt(6);
                    list4 = new ArrayList<>();
                    list4.add(new chitiet_chiphi_thu_nhap(R.drawable.giaithuong,0,"fjfjf","0",0));
                    MainActivity.groupArrayList.add(new Group(vitri_group, ngay, thang, thu, chiphi, thu_nhap, list4, nam));
                    list4 = null;
                }
                dataGroup.close();
                dataChitiet_chiphi_thunhap.close();
                for (int q = 0;q<MainActivity.groupArrayList.size();q++) {
                    list5 = new ArrayList<>();
                    for (int k = 0;k< MainActivity.chitiet_chiphi_thu_nhapArrayList.size();k++) {
                        if(MainActivity.groupArrayList.get(q).getVitri_group()==MainActivity.chitiet_chiphi_thu_nhapArrayList.get(k).getVitri_group()) {
                            list5.add(new chitiet_chiphi_thu_nhap(MainActivity.chitiet_chiphi_thu_nhapArrayList.get(k).getIcon(),MainActivity.chitiet_chiphi_thu_nhapArrayList.get(k).getVitri_group(),MainActivity.chitiet_chiphi_thu_nhapArrayList.get(k).getTen(),MainActivity.chitiet_chiphi_thu_nhapArrayList.get(k).getSo_tien(),MainActivity.chitiet_chiphi_thu_nhapArrayList.get(k).getTablayout()));
                        }
                    }
                    MainActivity.arrayList1.add(new Group(MainActivity.groupArrayList.get(q).getVitri_group(), MainActivity.groupArrayList.get(q).getNgay(), MainActivity.groupArrayList.get(q).getThang(), MainActivity.groupArrayList.get(q).getThu(), MainActivity.groupArrayList.get(q).getChiphi(), MainActivity.groupArrayList.get(q).getThu_nhap(), list5, MainActivity.groupArrayList.get(q).getNam()));
                    list5 =null;
                }

                // kết thúc đổ dữ liệu
                textView_loai_tien_te.setText(tien_tes.get(i).getTien());
                textView_chitiet_loai_tien_te.setText(tien_tes.get(i).getChi_tiet_tien());
                MainActivity.position = i;
                if(MainActivity.arrayList1.size()!=0&&(MainActivity.tong_thunhap!=0||MainActivity.tong_chiphi!=0)) {
                    if (MainActivity.textView_ten_tien_te.getText().toString().trim().equals("VND (đ)")) {
                        if (MainActivity.position == 1) {
                            float a = (float) 24375;
                            MainActivity.tong_chiphi = MainActivity.tong_chiphi / a;
                            MainActivity.tong_thunhap = MainActivity.tong_thunhap / a;
                            giatriquydoitiente = a;
                        }
                        if (MainActivity.position == 2) {
                            float a = (float) 25927;
                            MainActivity.tong_chiphi = MainActivity.tong_chiphi / a;
                            MainActivity.tong_thunhap = MainActivity.tong_thunhap / a;
                            giatriquydoitiente = a;
                        }
                        if (MainActivity.position == 3) {
                            float a = (float) 30066;
                            MainActivity.tong_chiphi = MainActivity.tong_chiphi / a;
                            MainActivity.tong_thunhap = MainActivity.tong_thunhap / a;
                            giatriquydoitiente = a;
                        }
                        if (MainActivity.position == 4) {
                            float a = (float) 3349;
                            MainActivity.tong_chiphi = MainActivity.tong_chiphi / a;
                            MainActivity.tong_thunhap = MainActivity.tong_thunhap / a;
                            giatriquydoitiente = a;
                        }
                        if(MainActivity.position==0) {
                            finish();
                            return;
                        }
                        String tnhap = String.format("%.2f", MainActivity.tong_thunhap);
                        String cphi = String.format("%.2f", MainActivity.tong_chiphi);
                        String du = String.format("%.2f", (MainActivity.tong_thunhap - MainActivity.tong_chiphi));
                        MainActivity.textView_tien_thunhap.setText(tnhap);
                        MainActivity.textView_tien_chiphi.setText(cphi);
                        MainActivity.textView_tien_sodu.setText(du);
                    }
                    if (MainActivity.textView_ten_tien_te.getText().toString().trim().equals("USD ($)")) {
                        if (MainActivity.position == 0) {
                            float a = (float) 24375;
                            MainActivity.tong_chiphi = MainActivity.tong_chiphi * a;
                            MainActivity.tong_thunhap = MainActivity.tong_thunhap * a;
                            giatriquydoitiente = a;
                        }
                        if (MainActivity.position == 2) {
                            float a = (float) 0.94;
                            MainActivity.tong_chiphi = MainActivity.tong_chiphi * a;
                            MainActivity.tong_thunhap = MainActivity.tong_thunhap * a;
                            giatriquydoitiente = a;
                        }
                        if (MainActivity.position == 3) {
                            float a = (float) 0.81;
                            MainActivity.tong_chiphi = MainActivity.tong_chiphi * a;
                            MainActivity.tong_thunhap = MainActivity.tong_thunhap * a;
                            giatriquydoitiente = a;
                        }
                        if (MainActivity.position == 4) {
                            float a = (float) 7.3;
                            MainActivity.tong_chiphi = MainActivity.tong_chiphi * a;
                            MainActivity.tong_thunhap = MainActivity.tong_thunhap * a;
                            giatriquydoitiente = a;
                        }
                        if(MainActivity.position==1) {
                            finish();
                            return;
                        }
                        String tnhap = String.format("%.2f", MainActivity.tong_thunhap);
                        String cphi = String.format("%.2f", MainActivity.tong_chiphi);
                        String du = String.format("%.2f", (MainActivity.tong_thunhap - MainActivity.tong_chiphi));
                        MainActivity.textView_tien_thunhap.setText(tnhap);
                        MainActivity.textView_tien_chiphi.setText(cphi);
                        MainActivity.textView_tien_sodu.setText(du);
                    }
                    if (MainActivity.textView_ten_tien_te.getText().toString().trim().equals("EUR (€)")) {
                        if (MainActivity.position == 0) {
                            float a = (float) 25934;
                            MainActivity.tong_chiphi = MainActivity.tong_chiphi * a;
                            MainActivity.tong_thunhap = MainActivity.tong_thunhap * a;
                            giatriquydoitiente = a;
                        }
                        if (MainActivity.position == 1) {
                            float a = (float) 1.06;
                            MainActivity.tong_chiphi = MainActivity.tong_chiphi * a;
                            MainActivity.tong_thunhap = MainActivity.tong_thunhap * a;
                            giatriquydoitiente = a;
                        }
                        if (MainActivity.position == 3) {
                            float a = (float) 0.86;
                            MainActivity.tong_chiphi = MainActivity.tong_chiphi * a;
                            MainActivity.tong_thunhap = MainActivity.tong_thunhap * a;
                            giatriquydoitiente = a;
                        }
                        if (MainActivity.position == 4) {
                            float a = (float) 7.74;
                            MainActivity.tong_chiphi = MainActivity.tong_chiphi * a;
                            MainActivity.tong_thunhap = MainActivity.tong_thunhap * a;
                            giatriquydoitiente = a;
                        }
                        if(MainActivity.position==2) {
                            finish();
                            return;
                        }
                        String tnhap = String.format("%.2f", MainActivity.tong_thunhap);
                        String cphi = String.format("%.2f", MainActivity.tong_chiphi);
                        String du = String.format("%.2f", (MainActivity.tong_thunhap - MainActivity.tong_chiphi));
                        MainActivity.textView_tien_thunhap.setText(tnhap);
                        MainActivity.textView_tien_chiphi.setText(cphi);
                        MainActivity.textView_tien_sodu.setText(du);
                    }
                    if (MainActivity.textView_ten_tien_te.getText().toString().trim().equals("GBP (£)")) {
                        if (MainActivity.position == 0) {
                            float a = (float) 29779;
                            MainActivity.tong_chiphi = MainActivity.tong_chiphi * a;
                            MainActivity.tong_thunhap = MainActivity.tong_thunhap * a;
                            giatriquydoitiente = a;
                        }
                        if (MainActivity.position == 1) {
                            float a = (float) 1.22;
                            MainActivity.tong_chiphi = MainActivity.tong_chiphi * a;
                            MainActivity.tong_thunhap = MainActivity.tong_thunhap * a;
                            giatriquydoitiente = a;
                        }
                        if (MainActivity.position == 2) {
                            float a = (float) 1.16;
                            MainActivity.tong_chiphi = MainActivity.tong_chiphi * a;
                            MainActivity.tong_thunhap = MainActivity.tong_thunhap * a;
                            giatriquydoitiente = a;
                        }
                        if (MainActivity.position == 4) {
                            float a = (float) 8.90;
                            MainActivity.tong_chiphi = MainActivity.tong_chiphi * a;
                            MainActivity.tong_thunhap = MainActivity.tong_thunhap * a;
                            giatriquydoitiente = a;
                        }
                        if(MainActivity.position==3) {
                            finish();
                            return;
                        }
                        String tnhap = String.format("%.2f", MainActivity.tong_thunhap);
                        String cphi = String.format("%.2f", MainActivity.tong_chiphi);
                        String du = String.format("%.2f", (MainActivity.tong_thunhap - MainActivity.tong_chiphi));
                        MainActivity.textView_tien_thunhap.setText(tnhap);
                        MainActivity.textView_tien_chiphi.setText(cphi);
                        MainActivity.textView_tien_sodu.setText(du);
                    }
                    if (MainActivity.textView_ten_tien_te.getText().toString().trim().equals("CNY (元)")) {
                        if (MainActivity.position == 0) {
                            float a = (float) 3349;
                            MainActivity.tong_chiphi = MainActivity.tong_chiphi * a;
                            MainActivity.tong_thunhap = MainActivity.tong_thunhap * a;
                            giatriquydoitiente = a;
                        }
                        if (MainActivity.position == 1) {
                            float a = (float) 0.14;
                            MainActivity.tong_chiphi = MainActivity.tong_chiphi * a;
                            MainActivity.tong_thunhap = MainActivity.tong_thunhap * a;
                            giatriquydoitiente = a;
                        }
                        if (MainActivity.position == 2) {
                            float a = (float) 0.13;
                            MainActivity.tong_chiphi = MainActivity.tong_chiphi * a;
                            MainActivity.tong_thunhap = MainActivity.tong_thunhap * a;
                            giatriquydoitiente = a;
                        }
                        if (MainActivity.position == 3) {
                            float a = (float) 0.11;
                            MainActivity.tong_chiphi = MainActivity.tong_chiphi * a;
                            MainActivity.tong_thunhap = MainActivity.tong_thunhap * a;
                            giatriquydoitiente = a;
                        }
                        if(MainActivity.position==4) {
                            finish();
                            return;
                        }
                        String tnhap = String.format("%.2f", MainActivity.tong_thunhap);
                        String cphi = String.format("%.2f", MainActivity.tong_chiphi);
                        String du = String.format("%.2f", (MainActivity.tong_thunhap - MainActivity.tong_chiphi));
                        MainActivity.textView_tien_thunhap.setText(tnhap);
                        MainActivity.textView_tien_chiphi.setText(cphi);
                        MainActivity.textView_tien_sodu.setText(du);
                    }

                    if (MainActivity.textView_ten_tien_te.getText().toString().trim().equals("VND (đ)")) {
                        Cursor dataChitiet_chiphi_thunhapf = MainActivity.database.GetData("SELECT * FROM Chitiet_chiphi_thunhap");
                        Cursor datagroupf = MainActivity.database.GetData("SELECT * FROM Group1");
                        String so_tienfff = "123";
                        float sotien = 1;
                        float  so_tien_sau_quydoi = 1;
                        while (dataChitiet_chiphi_thunhapf.moveToNext()) {
                            int id = dataChitiet_chiphi_thunhapf.getInt(0);
                            so_tienfff = dataChitiet_chiphi_thunhapf.getString(4);
                            sotien = Float.valueOf(so_tienfff);
                            so_tien_sau_quydoi = sotien / giatriquydoitiente;
                            String tien = String.format("%.2f", so_tien_sau_quydoi);
                                MainActivity.database.QueryData("UPDATE Chitiet_chiphi_thunhap set so_tien = '" +tien + "' WHERE id = '" +id+ "' ");
                            }
                        float tongthu = 0;
                        float tongchi = 0;
                        Cursor chiphi_thunhap =  MainActivity.database.GetData("SELECT * FROM Chitiet_chiphi_thunhap");
                        while (datagroupf.moveToNext()) {
                            int vitri_group = datagroupf.getInt(0);

                            while ((chiphi_thunhap.moveToNext())) {
                                int vitri_group_chitiet = chiphi_thunhap.getInt(2);
                                String so_tien = chiphi_thunhap.getString(4);
                                int tablayout = chiphi_thunhap.getInt(5);
                                if(vitri_group == vitri_group_chitiet && tablayout==0) {
                                    tongchi+=Float.valueOf(so_tien);

                                }
                                if(vitri_group== vitri_group_chitiet && tablayout == 1) {
                                    tongthu+= Float.valueOf(sotien);
                                }
                            }
                            MainActivity.database.QueryData("UPDATE Group1 set chiphi = '"+String.format("%.2f",tongchi)+"' , thu_nhap = '"+String.format("%.2f",tongthu)+"' WHERE vitrigroup = '"+vitri_group+"' ");
                            tongchi = 0;
                            tongthu = 0;
                        }
                    }

                    if (!MainActivity.textView_ten_tien_te.getText().toString().trim().equals("VND (đ)")) {
                        Cursor dataChitiet_chiphi_thunhapf = MainActivity.database.GetData("SELECT * FROM Chitiet_chiphi_thunhap");
                        Cursor datagroupf = MainActivity.database.GetData("SELECT * FROM Group1");
                        String so_tienfff = "";
                        float sotien = 1;
                        float  so_tien_sau_quydoi = 1;
                        while (dataChitiet_chiphi_thunhapf.moveToNext()) {
                            int id = dataChitiet_chiphi_thunhapf.getInt(0);
                            so_tienfff = dataChitiet_chiphi_thunhapf.getString(4);
                            sotien = Float.valueOf(so_tienfff);
                            so_tien_sau_quydoi = sotien * giatriquydoitiente;
                            String tien = String.format("%.2f", so_tien_sau_quydoi);
                            MainActivity.database.QueryData("UPDATE Chitiet_chiphi_thunhap set so_tien = '" +tien+ "' WHERE id = '" +id+ "' ");

                        }
                        float tongthu = 0;
                        float tongchi = 0;
                        Cursor chiphi_thunhap =  MainActivity.database.GetData("SELECT * FROM Chitiet_chiphi_thunhap");
                        while (datagroupf.moveToNext()) {
                            int vitri_group = datagroupf.getInt(0);

                            while ((chiphi_thunhap.moveToNext())) {
                                int vitri_group_chitiet = chiphi_thunhap.getInt(2);
                                String so_tien = chiphi_thunhap.getString(4);
                                int tablayout = chiphi_thunhap.getInt(5);
                                if(vitri_group == vitri_group_chitiet && tablayout==0) {
                                    tongchi+=Float.valueOf(so_tien);

                                }
                                if(vitri_group== vitri_group_chitiet && tablayout == 1) {
                                    tongthu+= Float.valueOf(sotien);
                                }
                            }
                            MainActivity.database.QueryData("UPDATE Group1 set chiphi = '"+String.format("%.2f",tongchi)+"' , thu_nhap = '"+String.format("%.2f",tongthu)+"' WHERE vitrigroup = '"+vitri_group+"' ");
                            tongchi = 0;
                            tongthu = 0;
                        }
                    }
                }
                    MainActivity.adapter_ngaythang_nam.notifyDataSetChanged();
                    // hiển thị loại tiền tệ

                    MainActivity.textView_ten_tien_te.setText(tien_tes.get(MainActivity.position).getTien());
                SharedPreferences.Editor edit = MainActivity.sharedPreferences.edit();
                edit.putString("loai_tien", tien_tes.get(MainActivity.position).getTien());
                edit.commit();

                finish();
            }
        });
    }

    private void Anhxa() {
        listView_chon_tien = (ListView) findViewById(R.id.listView_chon_tien);
        textView_chitiet_loai_tien_te = (TextView) findViewById(R.id.textViewchitiet_loai_tien_te);
        textView_loai_tien_te = (TextView) findViewById(R.id.textView_ten_tien_loaitiente);
    }
    public void huy() {
        finish();
    }
}