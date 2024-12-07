package com.example.btl_laptrinh_moblie;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

public class Dangki_activity extends AppCompatActivity {
    ImageView imageView_back;
    EditText editText_tk,editText_mk;
    Button button_dangki;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_dangki);

        Anhxa();
        button_dangki.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Dangnhap_activity.tk = editText_tk.getText().toString();
                Dangnhap_activity.mk = editText_mk.getText().toString();
                Dangnhap_activity.edit.putString("tk_trunggian",Dangnhap_activity.tk);
                Dangnhap_activity.edit.putString("mk_trunggian",Dangnhap_activity.mk);
                finish();
                Toast.makeText(Dangki_activity.this, "Đăng kí thành công", Toast.LENGTH_SHORT).show();
            }
        });
        imageView_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(Dangki_activity.this,Dangnhap_activity.class));
            }
        });
    }

    private void Anhxa() {
        imageView_back = (ImageView) findViewById(R.id.img_quaylaimandangnhap);
        editText_tk = (EditText) findViewById(R.id.edtDK_username);
        editText_mk = (EditText) findViewById(R.id.edtDK_password);
        button_dangki = (Button) findViewById(R.id.btnDK_dangKy);
    }
}