package com.example.btl_laptrinh_moblie;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

public class Dangnhap_activity extends AppCompatActivity {
    Button button_dangnhap;
    EditText editText_ten,editText_matkhau;
    CheckBox checkBox_nho_mk;
    static String tk,mk="";
    TextView textView_dangki;
    static SharedPreferences.Editor edit;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_dangnhap);

        Anhxa();
        SharedPreferences sharedPreferences = getSharedPreferences("MY_mk_dangnhap", Context.MODE_PRIVATE);
        edit = sharedPreferences.edit();
        //boolean isLoggedIn = sharedPreferences.getBoolean("isLoggedIn", false);
        editText_ten.setText(sharedPreferences.getString("tk",""));
        editText_matkhau.setText(sharedPreferences.getString("mk",""));
        checkBox_nho_mk.setChecked(sharedPreferences.getBoolean("nho_mat_khau",false));
        tk = sharedPreferences.getString("tk_trunggian","");
        mk = sharedPreferences.getString("mk_trunggian","");
        button_dangnhap.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(editText_matkhau.getText().toString().trim().equals(mk) &&
                        editText_ten.getText().toString().trim().equals(tk)) {
                    Toast.makeText(Dangnhap_activity.this, "Đăng nhập thành công", Toast.LENGTH_SHORT).show();
                    if(checkBox_nho_mk.isChecked()==true) {
                        edit.putString("tk", String.valueOf(editText_ten.getText()));
                        edit.putString("mk", String.valueOf(editText_matkhau.getText()).trim());
                        edit.putBoolean("nho_mat_khau",true);
                        edit.commit();
                    }
                    else {
                        SharedPreferences.Editor edit = sharedPreferences.edit();
                        edit.remove("tk");
                        edit.remove("mk");
                        edit.remove("nho_mat_khau");
                        edit.commit();
                    }
                    startActivity(new Intent(Dangnhap_activity.this,MainActivity.class));
                    finish();
                }
                else {
                    Toast.makeText(Dangnhap_activity.this, "Đăng nhập không thành công", Toast.LENGTH_SHORT).show();
                }
            }
        });
        textView_dangki.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(Dangnhap_activity.this,Dangki_activity.class));
            }
        });





    }

    private void Anhxa() {
        button_dangnhap = (Button) findViewById(R.id.btnDN_dangNhap);
        editText_ten = (EditText) findViewById(R.id.edtDN_username);
        editText_matkhau = (EditText) findViewById(R.id.edtDN_password);
        checkBox_nho_mk = (CheckBox) findViewById(R.id.imglove);
        textView_dangki = (TextView) findViewById(R.id.txtDN_dangKy);
    }
}