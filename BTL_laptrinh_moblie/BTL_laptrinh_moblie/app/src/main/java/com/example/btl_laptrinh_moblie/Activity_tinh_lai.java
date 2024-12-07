package com.example.btl_laptrinh_moblie;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Dialog;
import android.os.Bundle;
import android.view.Gravity;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import java.text.NumberFormat;
import java.util.Currency;
import java.util.Locale;

public class Activity_tinh_lai extends AppCompatActivity {
    TextView textView_dong,textView_hien_thi_lai,textView_chon;
    EditText editText_nhapso_tien,editText_nhap_lai_xuat,editText_nhapky_han;
    Button button_tinhlai;
    float tong_lai=0;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tinh_lai);

        Anhxa();
        NumberFormat currencyFormat = NumberFormat.getCurrencyInstance(new Locale("vi","VN"));
//        Tính theo ngày: Tiền lãi = Số tiền gửi x Lãi suất năm x Số ngày gửi thực/365.
//        Tính theo tháng: Tiền lãi = Số tiền gửi x Lãi suất năm x Số tháng gửi thực/12.
//        Tính theo năm: Tiền lãi = Số tiền gửi x Lãi suất năm x Số năm gửi thực.
        button_tinhlai.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(editText_nhapky_han.getText().toString().trim().isEmpty()!=true
                        &&editText_nhapso_tien.getText().toString().trim().isEmpty()!=true
                        &&editText_nhap_lai_xuat.getText().toString().trim().isEmpty()!=true) {
                    if (textView_chon.getText().toString().trim().equals("Tháng ^")) {
                        float so_tien_gui = Float.parseFloat(editText_nhapso_tien.getText().toString().trim());
                        float laixuat_nam = Float.parseFloat(editText_nhap_lai_xuat.getText().toString().trim());
                        float ky_han = Float.parseFloat(editText_nhapky_han.getText().toString().trim());
                        tong_lai = so_tien_gui * laixuat_nam/100 * ky_han / 12;
                        String ff = currencyFormat.format(tong_lai).replaceAll("[^0-9.,]+", "");
                        textView_hien_thi_lai.setText(ff+ " VND");
                    }
                    if (textView_chon.getText().toString().trim().equals("Ngày ^")) {
                        float so_tien_gui = Float.parseFloat(editText_nhapso_tien.getText().toString().trim());
                        float laixuat_nam = Float.parseFloat(editText_nhap_lai_xuat.getText().toString().trim());
                        float ky_han = Float.parseFloat(editText_nhapky_han.getText().toString().trim());
                        tong_lai = so_tien_gui * laixuat_nam/100 * ky_han / 365;
                        String ff = currencyFormat.format(tong_lai).replaceAll("[^0-9.,]+", "");
                        textView_hien_thi_lai.setText(ff+ " VND");                    }
                    if (textView_chon.getText().toString().trim().equals("Năm ^")) {
                        float so_tien_gui = Float.parseFloat(editText_nhapso_tien.getText().toString().trim());
                        float laixuat_nam = Float.parseFloat(editText_nhap_lai_xuat.getText().toString().trim());
                        float ky_han = Float.parseFloat(editText_nhapky_han.getText().toString().trim());
                        tong_lai = so_tien_gui * laixuat_nam/100 * ky_han;
                        String ff = currencyFormat.format(tong_lai).replaceAll("[^0-9.,]+", "");
                        textView_hien_thi_lai.setText(ff+ " VND");                    }
                }
                else {
                    Toast.makeText(Activity_tinh_lai.this, "Vui lòng nhập đủ thông tin", Toast.LENGTH_SHORT).show();
                }
            }
        });
        textView_chon.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Dialog dialog = new Dialog(Activity_tinh_lai.this);
                dialog.setContentView(R.layout.chon_tinh_lai);
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
                TextView textView_thang = dialog.findViewById(R.id.textView_chon_thang);
                TextView textView_ngay = dialog.findViewById(R.id.textView_chon_ngay);
                TextView textView_nam = dialog.findViewById(R.id.textView_chon_nam);
                textView_thang.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View view) {
                        textView_chon.setText(textView_thang.getText()+" ^");
                        dialog.cancel();
                    }
                });
                textView_ngay.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View view) {
                        textView_chon.setText(textView_ngay.getText()+" ^");
                        dialog.cancel();
                    }
                });
                textView_nam.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View view) {
                        textView_chon.setText(textView_nam.getText()+" ^");
                        dialog.cancel();
                    }
                });
                dialog.show();
            }
        });
    }

    private void Anhxa() {
        textView_dong = (TextView) findViewById(R.id.textView_dong_lai_xuat);
        textView_hien_thi_lai = (TextView) findViewById(R.id.textView_hien_so_tien_lai);
        textView_chon = (TextView) findViewById(R.id.textView_chon_thang_nam_ngay);
        editText_nhap_lai_xuat = (EditText) findViewById(R.id.editTextText_nhap_lai_suat);
        editText_nhapso_tien = (EditText) findViewById(R.id.editTextText_nhap_tien);
        editText_nhapky_han = (EditText) findViewById(R.id.editTextText_ky_han_tinh_lai);
        button_tinhlai = (Button) findViewById(R.id.button_tinh_lai);
    }
    public void onClickdong_laixuat(View view) {
        finish();
    }
}