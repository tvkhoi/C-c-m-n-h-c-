package com.example.btl_laptrinh_moblie;


import android.annotation.SuppressLint;
import android.app.DatePickerDialog;
import android.content.Intent;
import android.content.res.Configuration;
import android.content.res.Resources;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.view.Gravity;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.TableLayout;
import android.widget.TableRow;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.core.content.ContextCompat;
import androidx.fragment.app.DialogFragment;


import java.text.NumberFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.GregorianCalendar;
import java.util.List;
import java.util.Locale;


public class FrameLayout_nhapthong_tin extends DialogFragment {
    TableLayout tableLayout_nhap_thog_tin;

    public static ConstraintLayout constraintLayout;
    TextView textView_huy_bo_nhap_thong_tin, textView_so_tien_dialog;
    EditText editText;
    public static String chuoi = "";
    String data = "";
    String[] mangff = {"7", "8", "9", "Hôm nay", "4", "5", "6", "1", "2", "3","0", "", "   "};
    public static Intent intent = new Intent();

    ArrayList<chiphi> arrayList = MainActivity.arrayList_chi_phi;
    ArrayList<chiphi> arrayList1 = MainActivity.arrayList_thu_nhap;
    Calendar calendar = Calendar.getInstance();
    SimpleDateFormat simpleDateFormat_thang = new SimpleDateFormat("MM");
    SimpleDateFormat simpleDateFormat_ngay = new SimpleDateFormat("dd");
    SimpleDateFormat simpleDateFormat_thu = new SimpleDateFormat("EEEE");
    SimpleDateFormat simpleDateFormat_nam = new SimpleDateFormat("yyyy");
    String thu = simpleDateFormat_thu.format(calendar.getTime());
    String ngay = simpleDateFormat_ngay.format(calendar.getTime());
    String thang = simpleDateFormat_thang.format(calendar.getTime());;
    int nam = Integer.parseInt(simpleDateFormat_nam.format(  calendar.getTime()));
    Long so;
    NumberFormat currencyFormat;
    int ngayf;
    int thangf;
    int namf;
    int vitri_icon;
    ArrayList<Integer> columnCounts = new ArrayList<>();
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setStyle(DialogFragment.STYLE_NO_TITLE, R.style.CustomDialogTheme);
    }

    @SuppressLint("MissingInflatedId")
    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.dialog_nhap_thong_tien, container, false);
        tableLayout_nhap_thog_tin = (TableLayout) view.findViewById(R.id.tableLayout_nhap_thong_tien);
        constraintLayout = (ConstraintLayout) view.findViewById(R.id.Constraintlayout_nhap_thong_tin);
        textView_huy_bo_nhap_thong_tin = (TextView) view.findViewById(R.id.textView_huybo_nhap_thong_tin);
        textView_so_tien_dialog = (TextView) view.findViewById(R.id.textView_sotien_dialog);
        editText = (EditText) view.findViewById(R.id.editTextText_chitiet_thog_tin);
        // Tạo một đối tượng NumberFormat với định dạng tiền tệ
        currencyFormat = NumberFormat.getCurrencyInstance(new Locale("vi","VN"));
        columnCounts.add(4); // Số cột của dòng đầu tiên
        columnCounts.add(3); // Số cột của dòng thứ hai
        columnCounts.add(3); // Số cột của dòng thứ ba
        columnCounts.add(3); // số cột của dòng thứ tư
        // khi sửa 1 đối tượng trong listView
        Add_table_layout_thong_tin(view);
        textView_huy_bo_nhap_thong_tin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                chuoi = "";
                data = "";
                editText.setText("");
                dismiss();
            }
        });

        return view;
    }

    private void Add_table_layout_thong_tin(View view) {

        if(MainActivity.chuoi_tien.isEmpty()!=true&&MainActivity.chi_tiet_tien.isEmpty()!=true) {
            Toast.makeText(getActivity(), ""+MainActivity.vitri_sua, Toast.LENGTH_SHORT).show();
            chuoi = MainActivity.chuoi_tien;
            textView_so_tien_dialog.setText(chuoi);
            editText.setText(MainActivity.chi_tiet_tien);
            Group group = (Group) MainActivity.arrayList1.get(Adapter_ngaythang_nam.vitri_a);
            namf = group.getNam();
            thangf = Integer.parseInt(group.getThang());
            ngayf = Integer.parseInt(group.getNgay());
     }
        int so_cot = 4;
        int so_dong = 4;
        int kich_thuoc_bang = 100; // Kích thước chung của bảng (tùy chỉnh)
        int vitri=0;
        int kich_thuoc_ong = kich_thuoc_bang / so_cot;
        int kich_thuoc_cot = kich_thuoc_bang / so_dong;
        for (int i = 0; i < columnCounts.size(); i++) {
            TableRow tableRow = new TableRow(view.getContext());
            tableRow.setGravity(Gravity.CENTER);
            TableRow.LayoutParams layoutParams = new TableRow.LayoutParams(ViewGroup.LayoutParams.MATCH_PARENT, ViewGroup.LayoutParams.WRAP_CONTENT);
            layoutParams.weight = 1;
            // Đặt khoảng cách giữa các ô
            layoutParams.setMargins(5, 5, 5, 5);
            for (int j = 0; j < columnCounts.get(i); j++) {
                TextView textView = new TextView(view.getContext());
                textView.setBackgroundResource(R.drawable.custom_bogoc_button);
                textView.setMaxLines(10);
                textView.setTextSize(15);
                textView.setHeight(kich_thuoc_cot);
                textView.setWidth(kich_thuoc_ong);

                if (vitri == 3) {
                    Drawable icon = getResources().getDrawable(R.drawable.baseline_calendar_today_24);
                    textView.setCompoundDrawablesRelativeWithIntrinsicBounds(icon, null, null, null);
                    textView.setTextColor(ContextCompat.getColor(view.getContext(), R.color.my_light_primary));
                    textView.setTextSize(13);
                }
                if (vitri == 12) {
                    Drawable icon = getResources().getDrawable(R.drawable.baseline_check_24);
                    textView.setCompoundDrawablesRelativeWithIntrinsicBounds(null, icon, null, null);
                }
                if (vitri == 11) {
                    Drawable icon = getResources().getDrawable(R.drawable.baseline_backspace_24);
                    textView.setCompoundDrawablesRelativeWithIntrinsicBounds(null, icon, null, null);
                }
                if (vitri < 13) {
                    textView.setText(mangff[vitri]);
                    vitri++;
                    textView.setOnClickListener(new View.OnClickListener() {

                        @Override
                        public void onClick(View view) {
                            Activity_add activity_add1 = (Activity_add) getActivity();
                            int tab_layout2 = activity_add1.tabLayout.getSelectedTabPosition();
                            if (tab_layout2 == 0) {
                               vitri_icon = arrayList.get(MainActivity.icon_sua).getIcon();
                            }
                            if (tab_layout2==1) {
                                vitri_icon = (int) arrayList1.get(MainActivity.icon_sua).getIcon();
                            }
                            textView_so_tien_dialog.setText(" ");
                            data = textView.getText().toString();
                            switch (data) {
                                case "Hôm nay":
                                    chonngay();
                                    break;
                                case "   ":

                                    if (chuoi != "") {
                                        Activity_add activity_add = (Activity_add) getActivity();
                                       int tab_layout = activity_add.tabLayout.getSelectedTabPosition();

                                        if (tab_layout == 0) {
                                            intent.putExtra("chi_phi", chuoi);
                                        }
                                        if (tab_layout == 1) {
                                            intent.putExtra("thu_nhap", chuoi);
                                        }
                                        if (MainActivity.chuoi_tien.isEmpty() != true && MainActivity.chi_tiet_tien.isEmpty() != true) {
                                            Group group = (Group) MainActivity.arrayList_group_trunggian.get(Adapter_chiphi_thunhap.vitri_group);
                                            List<chitiet_chiphi_thu_nhap> list1 = group.getMembers();

                                            if(MainActivity.tinhieu_sua==1) {
                                                MainActivity.database.QueryData("UPDATE Chitiet_chiphi_thunhap  SET ten = '"+editText.getText().toString().trim()+"', so_tien = '"+chuoi+"', icon = '"+vitri_icon+"' WHERE vitrigroup = '"+Adapter_chiphi_thunhap.group_sua+"' AND ten = '"+list1.get(Adapter_chiphi_thunhap.vitri_cuaphantu_cansua).getTen()+"' AND so_tien = '"+list1.get(Adapter_chiphi_thunhap.vitri_cuaphantu_cansua).getSo_tien()+"' AND icon = '"+list1.get(Adapter_chiphi_thunhap.vitri_cuaphantu_cansua).getIcon()+"' AND tablayout = '"+list1.get(Adapter_chiphi_thunhap.vitri_cuaphantu_cansua).getTablayout()+"'  ");
                                            }
                                            chitiet_chiphi_thu_nhap chitiet_chiphi_thu_nhap = list1.get(MainActivity.vitri_sua);
                                            chitiet_chiphi_thu_nhap.setSo_tien(chuoi);
                                            chitiet_chiphi_thu_nhap.setTen(editText.getText().toString().trim());
                                            chitiet_chiphi_thu_nhap.setIcon(vitri_icon);
                                            chitiet_chiphi_thu_nhap.setTablayout(tab_layout);
                                            list1.set(MainActivity.vitri_sua, chitiet_chiphi_thu_nhap);
                                            float tong_thu=0;
                                            float tong_chi=0;
                                            for(int i = 0;i<list1.size();i++) {
                                                chitiet_chiphi_thu_nhap chitiet_chiphi_thu_nhap1 = list1.get(i);

                                                if(chitiet_chiphi_thu_nhap1.getTablayout()==0) {
                                                    tong_chi = Float.parseFloat(chitiet_chiphi_thu_nhap1.getSo_tien())+tong_chi;
                                                }
                                                if(chitiet_chiphi_thu_nhap1.getTablayout()==1) {
                                                    tong_thu= Float.parseFloat(list1.get(i).getSo_tien())+tong_thu;
                                                }
                                            }
                                            group.setChiphi(tong_chi+"");
                                            group.setThu_nhap(tong_thu+"");
                                            if(MainActivity.tinhieu_sua == 1) {
                                                MainActivity.database.QueryData("UPDATE Group1 SET chiphi = '" + tong_chi + "', thu_nhap = '" + tong_thu + "' WHERE vitrigroup = '" + group.getVitri_group() + "'");
                                            }
                                            MainActivity.tinhieu_sua = 0;
                                            MainActivity.arrayList_group_trunggian.set(Adapter_chiphi_thunhap.vitri_group, group);
                                            MainActivity.adapter_ngaythang_nam.notifyDataSetChanged();
                                            float tong_chiphi = 0;
                                            float tong_thunhap = 0;
                                            float tong_du = 0;
                                            String thang_textView =  MainActivity.textView_thang_nam_ghi_chep.getText().toString().trim();
                                            String cat_chuoi="";
                                            if (thang_textView.length() == 6) {
                                                cat_chuoi = thang_textView.substring(4, 6);
                                            }
                                            if (thang_textView.length() == 5) {
                                                cat_chuoi = thang_textView.substring(4, 5);
                                                cat_chuoi = "0"+cat_chuoi;
                                            }
                                            int nam_texView = Integer.parseInt(MainActivity.textView_nam_ghichep.getText().toString().trim());
                                            for (int i = 0;i<MainActivity.arrayList_group_trunggian.size();i++) {
                                                Group group1 = MainActivity.arrayList_group_trunggian.get(i);
                                                if(cat_chuoi.equals(group1.getThang().trim())&&nam_texView==(group1.getNam())) {
                                                    tong_chiphi = tong_chiphi + Float.parseFloat(group1.getChiphi());
                                                    tong_thunhap = Float.parseFloat(group1.getThu_nhap()) + tong_thunhap;
                                                }

                                            }
                                            tong_du = tong_thunhap - tong_chiphi;
                                            MainActivity.textView_tien_thunhap.setText(tong_thunhap+"");
                                            MainActivity.textView_tien_chiphi.setText(tong_chiphi+"");
                                            MainActivity.textView_tien_sodu.setText(tong_du+"");
                                            MainActivity.chuoi_tien = "";
                                            MainActivity.chi_tiet_tien = "";
                                            ngayf = calendar.get(Calendar.DATE);
                                            thangf = calendar.get(Calendar.MONTH);
                                            namf = calendar.get(Calendar.YEAR);
                                        }
                                        if (!editText.equals("")) {
                                            intent.putExtra("thong_tin", editText.getText().toString().trim());
                                        }

                                        intent.putExtra("Thu", thu);
                                        intent.putExtra("Ngay", ngay);
                                        intent.putExtra("Thang", thang);
                                        intent.putExtra("Nam", nam);
                                        activity_add.setResult(Activity_add.RESULT_OK, intent);
                                        activity_add.finish();
                                    }
                                    if (chuoi.isEmpty() == true) {
                                        dismiss();
                                    }
                                    dismiss();
                                    chuoi = "";
                                    break;
                                default: {

                                    if (!textView.getText().toString().trim().equals("")) {
                                        if (chuoi.length() < 10) {
                                            chuoi += data;
                                        }
                                        if (chuoi.length() == 10) {
                                            chuoi = chuoi.substring(0, 9) + data;
                                        }
                                    }
                                    if (chuoi.isEmpty() != true) {
                                        if (textView.getText().toString().trim().equals("")) {
                                            chuoi = chuoi.substring(0, chuoi.length() - 1);
                                        }
                                    }
                                }
                            }
                            if (chuoi.isEmpty() != true) {
                                so = Long.parseLong(chuoi);
                            }
                            if (chuoi.equals("")) {
                                so = Long.valueOf(0);
                            }
                            String ff = currencyFormat.format(so).replaceAll("[^0-9.,]+", "");
                            textView_so_tien_dialog.setText(ff);
                            if (chuoi.equals("")) {
                                textView_so_tien_dialog.setText("0");
                            }
                        }
                    });
            }

                textView.setLayoutParams(layoutParams);
                textView.setGravity(Gravity.CENTER);
                tableRow.addView(textView);
            }

            tableLayout_nhap_thog_tin.addView(tableRow);
        }
    }
    private void chonngay() {
        Calendar calendar = Calendar.getInstance();
        ngayf = calendar.get(Calendar.DATE);
        thangf = calendar.get(Calendar.MONTH);
        namf = calendar.get(Calendar.YEAR);
        Locale locale = new Locale("vi", "VN");
        Locale.setDefault(locale);
        Configuration config = new Configuration();
        config.locale = locale;
        getActivity().getBaseContext().getResources().updateConfiguration(config, getActivity().getBaseContext().getResources().getDisplayMetrics());
        DatePickerDialog datePickerDialog = new DatePickerDialog(getActivity(), new DatePickerDialog.OnDateSetListener() {
            @Override
            public void onDateSet(DatePicker datePicker, int i, int i1, int i2) {
                calendar.set(i,i1,i2);
                SimpleDateFormat simpleDateFormat_thang = new SimpleDateFormat("MM");
                SimpleDateFormat simpleDateFormat_ngay = new SimpleDateFormat("dd");
                SimpleDateFormat simpleDateFormat_thu = new SimpleDateFormat("EEEE");
                SimpleDateFormat simpleDateFormat_nam = new SimpleDateFormat("yyyy");
                int namf = Integer.parseInt(simpleDateFormat_nam.format(calendar.getTime()));
                thu = simpleDateFormat_thu.format(calendar.getTime());
                ngay = simpleDateFormat_ngay.format(calendar.getTime());
                thang =simpleDateFormat_thang.format(calendar.getTime());
                nam = namf;
            }
        },namf,thangf,ngayf);
        datePickerDialog.show();

    }

}
