package com.example.btl_laptrinh_moblie;

import android.app.Dialog;
import android.content.Context;
import android.content.Intent;
import android.database.Cursor;
import android.view.Gravity;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.Window;
import android.view.WindowManager;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

public class Adapter_chiphi_thunhap extends BaseAdapter {
    Context context;
    List<chitiet_chiphi_thu_nhap> list;
    int layout;
    LayoutInflater inflater;
    static int vitri_group;
    static Dialog dialog;
    static int group_sua, vitri_cuaphantu_cansua;
    public Adapter_chiphi_thunhap(Context context,List<chitiet_chiphi_thu_nhap> list, int layout) {
        this.context = context;
        this.list = list;
        this.layout = layout;
        dialog = new Dialog(context);
    }

    @Override
    public int getCount() {
        return list.size();
    }

    @Override
    public Object getItem(int i) {
        return null;
    }

    @Override
    public long getItemId(int i) {
        return 0;
    }
    private class ViewHolder {
        private TextView textView_tenicon,textView_sotien;
        private ImageView imageView_icon;
    }
    @Override
    public View getView(int i, View view, ViewGroup viewGroup) {
         ViewHolder viewHolder = null;
        if(view == null) {
            inflater = (LayoutInflater) context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            view = inflater.inflate(layout,null);
            viewHolder = new ViewHolder();

            viewHolder = new ViewHolder();
            viewHolder.textView_tenicon= (TextView) view.findViewById(R.id.textView_tenicon);
            viewHolder.textView_sotien = (TextView) view.findViewById(R.id.textView_sotien);
            viewHolder.imageView_icon = (ImageView) view.findViewById(R.id.imageView_icon);
            view.setTag(viewHolder);
        }
        else {
            viewHolder = (ViewHolder) view.getTag();
        }
        chitiet_chiphi_thu_nhap chitiet_chiphi_thu_nhap = list.get(i);
        viewHolder.textView_tenicon.setText(chitiet_chiphi_thu_nhap.getTen());
        viewHolder.textView_sotien.setText(chitiet_chiphi_thu_nhap.getSo_tien());
        viewHolder.imageView_icon.setImageResource(chitiet_chiphi_thu_nhap.getIcon());
        view.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                dialog.setContentView(R.layout.custom_dialog_chucnang_xoa_sua);
                // Lấy tham chiếu đến cửa sổ của dialog
                Window window = dialog.getWindow();
                if (window != null) {
                    WindowManager.LayoutParams layoutParams = window.getAttributes();
                    // Điều chỉnh vị trí hiển thị của dialog
                    layoutParams.gravity = Gravity.START | Gravity.TOP;
                    int a[] = new int[2];
                    view.getLocationOnScreen(a);
                    layoutParams.x = a[0];
                    layoutParams.y = a[1];
                    window.setAttributes(layoutParams);
                }
                TextView textView_xoa = dialog.findViewById(R.id.textView_xoa);
                TextView textView_sua = dialog.findViewById(R.id.textView_sua);

                dialog.show();
              textView_xoa.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    float tong_chiphi = 0;
                    float tong_thunhap = 0;
                    float tong_du = 0;

                    //lấy ra vị trí của group trong mảng cần xóa
                    for(int k = 0;k<MainActivity.arrayList_group_trunggian.size();k++ ){
                        if(chitiet_chiphi_thu_nhap.getVitri_group()==MainActivity.arrayList_group_trunggian.get(k).getVitri_group()) {
                            vitri_group = k;
                            break;
                        }
                    }
                    Group group = (Group) MainActivity.arrayList_group_trunggian.get(vitri_group);
                    String cat_chuoi1=group.getThang().substring(0,1);
                    String thang_tg = "";
                    if (group.getThang().length()==2 && cat_chuoi1.equals("0")  ) {
                        thang_tg = group.getThang().substring(1, 2);
                    }
                    if (group.getThang().length() == 2 && !cat_chuoi1.equals("0")) {
                        thang_tg = group.getThang().substring(0, 2);
                    }
                    if(MainActivity.textView_thang_nam_ghi_chep.getText().toString().trim().equals("Thg "+thang_tg)) {
                        List<chitiet_chiphi_thu_nhap> list1 = group.getMembers();
                        MainActivity.database.QueryData("DELETE FROM Chitiet_chiphi_thunhap WHERE vitrigroup = '"+chitiet_chiphi_thu_nhap.getVitri_group()+"' AND ten = '"+list1.get(i).getTen()+"' AND  so_tien = '"+list1.get(i).getSo_tien() +"' AND tablayout = '"+list1.get(i).getTablayout()+"'");
                        list1.remove(i);

                        for(int i = 0;i<list1.size();i++) {
                            if(Integer.valueOf(list1.get(i).getTablayout())==0) {
                                tong_chiphi+=Float.parseFloat(list1.get(i).getSo_tien());
                                Adapter_ngaythang_nam.arrayAdapter.notifyDataSetChanged();
                            }
                            else {
                                tong_thunhap+=Float.parseFloat(list1.get(i).getSo_tien());
                                Adapter_ngaythang_nam.arrayAdapter.notifyDataSetChanged();
                            }
                        }

                        if(list1.isEmpty()!=true) {
                            MainActivity.database.QueryData("UPDATE Group1 SET chiphi = '" + tong_chiphi + "', thu_nhap = '" + tong_thunhap + "' WHERE vitrigroup = '" + group.getVitri_group() + "'");
                     //       MainActivity.arrayList_group_trunggian.get(vitri_group).setChiphi();
                        }
                      //  MainActivity.arrayList_group_trunggian.set(vitri_group,group);
                          MainActivity.arrayList_group_trunggian.get(vitri_group).setMembers(list1);
                          MainActivity.adapter_ngaythang_nam.notifyDataSetChanged();
                          Adapter_ngaythang_nam.arrayAdapter.notifyDataSetChanged();
                        if (MainActivity.arrayList_group_trunggian.get(vitri_group).getMembers().size() == 0) {
                            MainActivity.arrayList_group_trunggian.remove(vitri_group);
                            MainActivity.database.QueryData("DELETE FROM Group1 WHERE vitrigroup = '"+chitiet_chiphi_thu_nhap.getVitri_group()+"'");
                        }


                            tong_chiphi = 0;
                            tong_thunhap = 0;
                            tong_du = 0;
                            String thang_textView = MainActivity.textView_thang_nam_ghi_chep.getText().toString().trim();
                            String cat_chuoi = "";
                            if (thang_textView.length() == 6) {
                                cat_chuoi = thang_textView.substring(4, 6);
                            }
                            if (thang_textView.length() == 5) {
                                cat_chuoi = thang_textView.substring(4, 5);
                                cat_chuoi = "0" + cat_chuoi;
                            }
                        int nam_texView = Integer.parseInt(MainActivity.textView_nam_ghichep.getText().toString().trim());
                        MainActivity.arrayList_group_trunggian.clear();
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
                        for (int i = 0;i<MainActivity.groupArrayList.size();i++) {
                            list5 = new ArrayList<>();
                            for (int k = 0;k< MainActivity.chitiet_chiphi_thu_nhapArrayList.size();k++) {
                                if(MainActivity.groupArrayList.get(i).getVitri_group()==MainActivity.chitiet_chiphi_thu_nhapArrayList.get(k).getVitri_group()) {
                                    list5.add(new chitiet_chiphi_thu_nhap(MainActivity.chitiet_chiphi_thu_nhapArrayList.get(k).getIcon(),MainActivity.chitiet_chiphi_thu_nhapArrayList.get(k).getVitri_group(),MainActivity.chitiet_chiphi_thu_nhapArrayList.get(k).getTen(),MainActivity.chitiet_chiphi_thu_nhapArrayList.get(k).getSo_tien(),MainActivity.chitiet_chiphi_thu_nhapArrayList.get(k).getTablayout()));
                                }
                            }
                            MainActivity.arrayList1.add(new Group(MainActivity.groupArrayList.get(i).getVitri_group(), MainActivity.groupArrayList.get(i).getNgay(), MainActivity.groupArrayList.get(i).getThang(), MainActivity.groupArrayList.get(i).getThu(), MainActivity.groupArrayList.get(i).getChiphi(), MainActivity.groupArrayList.get(i).getThu_nhap(), list5, MainActivity.groupArrayList.get(i).getNam()));
                            list5 =null;
                        }

                        // kết thúc đổ dữ liệu
                        // đổ dữ liệu vào mảng để hiện thị
                        for (int i = 0;i<MainActivity.arrayList1.size();i++) {
                            Group group3 = MainActivity.arrayList1.get(i);
                            if(cat_chuoi.equals(group3.getThang().trim())&&nam_texView==(group3.getNam())) {
                                MainActivity.arrayList_group_trunggian.add(group3);
                                tong_chiphi = tong_chiphi + Float.parseFloat(group3.getChiphi());
                                tong_thunhap = Float.parseFloat(group3.getThu_nhap()) + tong_thunhap;
                            }

                        }
                        Toast.makeText(context, "Xóa thành công", Toast.LENGTH_SHORT).show();
                            tong_du = tong_thunhap - tong_chiphi;
                            MainActivity.textView_tien_thunhap.setText(tong_thunhap + "");
                            MainActivity.textView_tien_chiphi.setText(tong_chiphi + "");
                            MainActivity.textView_tien_sodu.setText(tong_du + "");
                            dialog.cancel();

                        }
                }
            });
            textView_sua.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    context.startActivity(new Intent(context,Activity_add.class));
                    MainActivity.vitri_sua=i;
                    //lấy ra vị trí của group trong mảng cần sửa
                    for(int k = 0;k<MainActivity.arrayList_group_trunggian.size();k++ ){
                        if(chitiet_chiphi_thu_nhap.getVitri_group()==MainActivity.arrayList_group_trunggian.get(k).getVitri_group()) {
                            vitri_group = k;
                            break;
                        }
                    }
                    String thang_textView = MainActivity.textView_thang_nam_ghi_chep.getText().toString().trim();
                    String cat_chuoi = "";
                    if (thang_textView.length() == 6) {
                        cat_chuoi = thang_textView.substring(4, 6);
                    }
                    if (thang_textView.length() == 5) {
                        cat_chuoi = thang_textView.substring(4, 5);
                        cat_chuoi = "0" + cat_chuoi;
                    }
                    int nam_texView = Integer.parseInt(MainActivity.textView_nam_ghichep.getText().toString().trim());
                    MainActivity.arrayList_group_trunggian.clear();
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
                    for (int i = 0;i<MainActivity.groupArrayList.size();i++) {
                        list5 = new ArrayList<>();
                        for (int k = 0;k< MainActivity.chitiet_chiphi_thu_nhapArrayList.size();k++) {
                            if(MainActivity.groupArrayList.get(i).getVitri_group()==MainActivity.chitiet_chiphi_thu_nhapArrayList.get(k).getVitri_group()) {
                                list5.add(new chitiet_chiphi_thu_nhap(MainActivity.chitiet_chiphi_thu_nhapArrayList.get(k).getIcon(),MainActivity.chitiet_chiphi_thu_nhapArrayList.get(k).getVitri_group(),MainActivity.chitiet_chiphi_thu_nhapArrayList.get(k).getTen(),MainActivity.chitiet_chiphi_thu_nhapArrayList.get(k).getSo_tien(),MainActivity.chitiet_chiphi_thu_nhapArrayList.get(k).getTablayout()));
                            }
                        }
                        MainActivity.arrayList1.add(new Group(MainActivity.groupArrayList.get(i).getVitri_group(), MainActivity.groupArrayList.get(i).getNgay(), MainActivity.groupArrayList.get(i).getThang(), MainActivity.groupArrayList.get(i).getThu(), MainActivity.groupArrayList.get(i).getChiphi(), MainActivity.groupArrayList.get(i).getThu_nhap(), list5, MainActivity.groupArrayList.get(i).getNam()));
                        list5 =null;
                    }

                    // kết thúc đổ dữ liệu
                    // đổ dữ liệu vào mảng để hiện thị
                    for (int i = 0;i<MainActivity.arrayList1.size();i++) {
                        Group group3 = MainActivity.arrayList1.get(i);
                        if(cat_chuoi.equals(group3.getThang().trim())&&nam_texView==(group3.getNam())) {
                            MainActivity.arrayList_group_trunggian.add(group3);

                        }

                    }
                    group_sua = chitiet_chiphi_thu_nhap.getVitri_group();
                    vitri_cuaphantu_cansua = i;
                    MainActivity.tinhieu_sua = 1;

                  MainActivity.chuoi_tien = chitiet_chiphi_thu_nhap.getSo_tien();
                  MainActivity.chi_tiet_tien =  chitiet_chiphi_thu_nhap.getTen();
                  MainActivity.icon_sua = chitiet_chiphi_thu_nhap.getIcon();
                  dialog.cancel();

                }
            });
            }
        });

        return view;
    }
}
