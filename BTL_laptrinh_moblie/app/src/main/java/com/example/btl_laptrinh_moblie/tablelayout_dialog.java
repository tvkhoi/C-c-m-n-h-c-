package com.example.btl_laptrinh_moblie;



import android.annotation.SuppressLint;
import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.Gravity;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageButton;
import android.widget.TableLayout;
import android.widget.TableRow;
import android.widget.TextView;


import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;

public class tablelayout_dialog extends Activity {
    TableLayout tableLayout;
    TableLayout tableLayout_nam;
    TextView textView_thang_nam_ghi_chep,textView_nam_dialog,textView_thang_nam_dialog,textView_huy_bo_dialog,textView_xac_nhan_dialog
            ,textView_nam_ghichep;
    ImageButton imageButton_luachon_len_dialog,imageButton_luachon_xuong_dialog;
    ArrayList<thang> arrayList = MainActivity.arrayList;
    Calendar calendar;
    SimpleDateFormat simpleDateFormat;
    SimpleDateFormat simpleDateFormat_thang;
    String thag_dialog;
    int nam;
    int nam_de_set_lich;
    @SuppressLint("MissingInflatedId")
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tablelayout_dialog);
        Anhxa();
        // khởi tạo lớp quản lí thời gian
         calendar = Calendar.getInstance();
        // lớp định dạng thời gian
         simpleDateFormat = new SimpleDateFormat("yyyy");
         simpleDateFormat_thang = new SimpleDateFormat("MM");
         thag_dialog = "Thg "+simpleDateFormat_thang.format(calendar.getTime());
         textView_nam_dialog.setText(simpleDateFormat.format(calendar.getTime()));
         textView_thang_nam_dialog.setText(thag_dialog+" "+simpleDateFormat.format(calendar.getTime()));
         nam_de_set_lich = Integer.parseInt(textView_nam_dialog.getText().toString().trim());
         nam = Integer.parseInt(textView_nam_dialog.getText().toString().trim());
            load_Table();


        // onClick vào textView xác nhận
        textView_xac_nhan_dialog.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent();
                intent.putExtra("Thang",thag_dialog);
                intent.putExtra("Nam",textView_nam_dialog.getText());
                setResult(RESULT_OK,intent);
                finish();
            }
        });

        // onClick vào textView năm dialog
        textView_nam_dialog.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                 load_Table_Nam();
                }
        });


        // onClick vào imageButton_luachon_xuong
        imageButton_luachon_xuong_dialog.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(tableLayout_nam.getVisibility()==View.VISIBLE && tableLayout.getVisibility()==View.GONE) {
                tableLayout_nam.removeAllViews();
                nam_de_set_lich = nam - 24;
                load_Table_Nam();
                }


            }
        });
        imageButton_luachon_len_dialog.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(tableLayout_nam.getVisibility()==View.VISIBLE&& tableLayout.getVisibility()==View.GONE) {
                tableLayout_nam.removeAllViews();
                nam_de_set_lich = nam;
                load_Table_Nam();
                }
            }
        });



    }

    private void Anhxa() {
        tableLayout = (TableLayout) findViewById(R.id.tablelayout_dialog_thang);
        textView_nam_dialog = (TextView) findViewById(R.id.textView_nam_dialog);
        textView_thang_nam_dialog = (TextView) findViewById(R.id.textView_thag_nam_dialog);
        imageButton_luachon_xuong_dialog = (ImageButton) findViewById(R.id.imageButton_chon_xuong_nam_dialgo);
        imageButton_luachon_len_dialog = (ImageButton) findViewById(R.id.imageButton_chon_len_nam_dialog);
        textView_huy_bo_dialog = (TextView) findViewById(R.id.textView_huybo_dialog);
        textView_xac_nhan_dialog = (TextView) findViewById(R.id.textView_xac_nhan_dialog);
        tableLayout_nam = (TableLayout) findViewById(R.id.tablelayout_dialog_nam);
    }
    public void onClick_huy(View view) {
        finish();
    }
    public void load_Table() {
        tableLayout.removeAllViews();
        tableLayout_nam.setVisibility(View.VISIBLE);
        int so_cot = 4;
        int so_dong =3;

        for (int i = 0; i < so_dong; i++) {
            TableRow tableRow = new TableRow(tablelayout_dialog.this);
            TableRow.LayoutParams layoutParams = new TableRow.LayoutParams(ViewGroup.LayoutParams.MATCH_PARENT, ViewGroup.LayoutParams.WRAP_CONTENT);
            layoutParams.weight = 1;
            for (int j = 0; j < so_cot; j++) {
                TextView textView = new TextView(tablelayout_dialog.this);
                textView.setBackgroundResource(R.drawable.custom_click_item_tablelayout);
                textView.setTextSize(15);
                textView.setHeight(150);
                textView.setWidth(170);

                int vitri = so_cot * i + j;

                if (vitri < arrayList.size()) {
                    textView.setText("Thg " + arrayList.get(vitri).getThang());

                    textView.setOnClickListener(new View.OnClickListener() {
                        @Override
                        public void onClick(View view) {

                            textView_thang_nam_dialog.setText(textView.getText() + " " + textView_nam_dialog.getText());
                            thag_dialog = (String) textView.getText();
                            tableLayout_nam.setVisibility(View.VISIBLE);
                            tableLayout.removeAllViews();
                            tableLayout.setVisibility(View.GONE);
                            load_Table_Nam();
                        }
                    });
                }

                textView.setLayoutParams(layoutParams);
                textView.setGravity(Gravity.CENTER);
                tableRow.addView(textView);
            }

            tableLayout.addView(tableRow);

        }

    }
    public void load_Table_Nam() {
        tableLayout.setVisibility(View.GONE);
        tableLayout_nam.removeAllViews();
        int so_cot = 4;
        int so_dong = 3;
        nam = nam_de_set_lich;
            for (int i = 0; i < so_dong; i++) {
                TableRow tableRow = new TableRow(tablelayout_dialog.this);
                TableRow.LayoutParams layoutParams = new TableRow.LayoutParams(ViewGroup.LayoutParams.MATCH_PARENT, ViewGroup.LayoutParams.WRAP_CONTENT);
                layoutParams.weight = 1;
                for (int j = 0; j < so_cot; j++) {
                    TextView textView = new TextView(tablelayout_dialog.this);
                    textView.setBackgroundResource(R.drawable.custom_click_item_tablelayout);
                    textView.setTextSize(15);
                    textView.setHeight(150);
                    textView.setWidth(170);

                    int vitri = so_cot * i + j;

                    if (vitri < arrayList.size()) {
                        textView.setText(nam + "");
                        nam++;

                        textView.setOnClickListener(new View.OnClickListener() {
                            @Override
                            public void onClick(View view) {
                                textView_nam_dialog.setText(textView.getText());
                                textView_thang_nam_dialog.setText(thag_dialog + " " + textView.getText());
                                tableLayout.setVisibility(View.VISIBLE);
                                tableLayout_nam.removeAllViews();
                                tableLayout_nam.setVisibility(View.GONE);
                                load_Table();
                            }
                        });
                    }

                    textView.setLayoutParams(layoutParams);
                    textView.setGravity(Gravity.CENTER);
                    tableRow.addView(textView);
                }

                tableLayout_nam.addView(tableRow);

        }
    }


}