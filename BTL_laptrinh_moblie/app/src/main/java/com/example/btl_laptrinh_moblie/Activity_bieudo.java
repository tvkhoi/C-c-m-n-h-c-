package com.example.btl_laptrinh_moblie;

import androidx.appcompat.app.AppCompatActivity;

import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.github.mikephil.charting.charts.BarChart;
import com.github.mikephil.charting.components.XAxis;
import com.github.mikephil.charting.data.BarData;
import com.github.mikephil.charting.data.BarDataSet;
import com.github.mikephil.charting.data.BarEntry;
import com.github.mikephil.charting.formatter.IndexAxisValueFormatter;

import java.util.ArrayList;
import java.util.List;

public class Activity_bieudo extends AppCompatActivity {
    Button button_chi,button_thu;
    BarChart barChart;
    EditText editText_nam;
    float thu_thang1,thu_thang2,thu_thang3,thu_thang4,thu_thang5,thu_thang6,thu_thang7,thu_thang8,thu_thang9,thu_thang10,thu_thang11,thu_thang12;
    float chi_thang1,chi_thang2,chi_thang3,chi_thang4,chi_thang5,chi_thang6,chi_thang7,chi_thang8,chi_thang9,chi_thang10,chi_thang11,chi_thang12;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_bieudo);

        Anhxa();
        button_chi.setBackgroundResource(R.drawable.custom_chi_thu_cua_bieu_do);
        button_thu.setBackgroundResource(R.drawable.custom_chi_thu_cua_bieu_do);
        List<BarEntry> entries1 = new ArrayList<>();
        entries1.add(new BarEntry(0, chi_thang1));
        entries1.add(new BarEntry(1f, chi_thang2));
        entries1.add(new BarEntry(2f, chi_thang3));
        entries1.add(new BarEntry(3f, chi_thang4));
        entries1.add(new BarEntry(4f, chi_thang5));
        entries1.add(new BarEntry(5f, chi_thang6));
        entries1.add(new BarEntry(6f, chi_thang7));
        entries1.add(new BarEntry(7f, chi_thang8));
        entries1.add(new BarEntry(8f, chi_thang9));
        entries1.add(new BarEntry(9f, chi_thang10));
        entries1.add(new BarEntry(10f, chi_thang11));
        entries1.add(new BarEntry(11f, chi_thang12));

        // Tạo dataset cho biểu đồ
        BarDataSet dataSet1 = new BarDataSet(entries1, "Chi");
        dataSet1.setColor(Color.RED);

        // Tạo dữ liệu cho biểu đồ
        BarData barData = new BarData(dataSet1);
        barData.setBarWidth(0.4f);
        // Thiết lập các thuộc tính cho biểu đồ
        barChart.setData(barData);
        barChart.getDescription().setEnabled(false);
        barChart.getXAxis().setValueFormatter(new IndexAxisValueFormatter(new String[]{"Thg 1", "Thg 2", "Thg 3", "Thg 4","Thg 5",
                "Thg 6","Thg 7","Thg 8","Thg 9","Thg 10","Thg 11","Thg 12"}));
        barChart.getXAxis().setPosition(XAxis.XAxisPosition.BOTTOM);

        barChart.getAxisRight().setEnabled(false);
        barChart.getLegend().setEnabled(true);
        barChart.setTouchEnabled(true);
        barChart.setDragEnabled(true);
        barChart.setScaleEnabled(true);
        barChart.setPinchZoom(true);
        barChart.setDoubleTapToZoomEnabled(true);
        barChart.setHighlightPerDragEnabled(true);
        barChart.animateY(1000);
        // Hiển thị biểu đồ
        barChart.invalidate();
            button_thu.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    if (!editText_nam.getText().toString().trim().equals("")) {
                        button_chi.setBackgroundResource(R.drawable.custom_chi_thu_cua_bieu_do);
                        button_thu.setBackgroundResource(R.drawable.custom_chi_phi_bieu_do_hai);
                        thu_thang1 = 0;
                        thu_thang2 = 0;
                        thu_thang3 = 0;
                        thu_thang4 = 0;
                        thu_thang5 = 0;
                        thu_thang6 = 0;
                        thu_thang7 = 0;
                        thu_thang8 = 0;
                        thu_thang9 = 0;
                        thu_thang10 = 0;
                        thu_thang11 = 0;
                        thu_thang12 = 0;
                        String nam = editText_nam.getText().toString();
                        if (MainActivity.arrayList1.size() != 0) {
                            for (int i = 0; i < MainActivity.arrayList1.size(); i++) {
                                int namarray = MainActivity.arrayList1.get(i).getNam();
                                if (namarray == Integer.parseInt(nam)) {
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("01")) {
                                        thu_thang1 = thu_thang1 + Float.parseFloat(MainActivity.arrayList1.get(i).getThu_nhap());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("02")) {
                                        thu_thang2 = thu_thang2 + Float.parseFloat(MainActivity.arrayList1.get(i).getThu_nhap());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("03")) {
                                        thu_thang3 = thu_thang3 + Float.parseFloat(MainActivity.arrayList1.get(i).getThu_nhap());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("04")) {
                                        thu_thang4 = thu_thang4 + Float.parseFloat(MainActivity.arrayList1.get(i).getThu_nhap());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("05")) {
                                        thu_thang5 = thu_thang5 + Float.parseFloat(MainActivity.arrayList1.get(i).getThu_nhap());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("06")) {
                                        thu_thang6 = thu_thang6 + Float.parseFloat(MainActivity.arrayList1.get(i).getThu_nhap());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("07")) {
                                        thu_thang7 = thu_thang7 + Float.parseFloat(MainActivity.arrayList1.get(i).getThu_nhap());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("08")) {
                                        thu_thang8 = thu_thang8 + Float.parseFloat(MainActivity.arrayList1.get(i).getThu_nhap());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("09")) {
                                        thu_thang9 = thu_thang9 + Float.parseFloat(MainActivity.arrayList1.get(i).getThu_nhap());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("10")) {
                                        thu_thang10 = thu_thang10 + Float.parseFloat(MainActivity.arrayList1.get(i).getThu_nhap());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("11")) {
                                        thu_thang11 = thu_thang11 + Float.parseFloat(MainActivity.arrayList1.get(i).getThu_nhap());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("12")) {
                                        thu_thang12 = thu_thang12 + Float.parseFloat(MainActivity.arrayList1.get(i).getThu_nhap());
                                    }

                                }
                            }

                        }
                        List<BarEntry> entries2 = new ArrayList<>();
                        entries2.add(new BarEntry(0, thu_thang1));
                        entries2.add(new BarEntry(1f, thu_thang2));
                        entries2.add(new BarEntry(2f, thu_thang3));
                        entries2.add(new BarEntry(3f, thu_thang4));
                        entries2.add(new BarEntry(4f, thu_thang5));
                        entries2.add(new BarEntry(5f, thu_thang6));
                        entries2.add(new BarEntry(6f, thu_thang7));
                        entries2.add(new BarEntry(7f, thu_thang8));
                        entries2.add(new BarEntry(8f, thu_thang9));
                        entries2.add(new BarEntry(9f, thu_thang10));
                        entries2.add(new BarEntry(10f, thu_thang11));
                        entries2.add(new BarEntry(11f, thu_thang12));

                        // Tạo dataset cho biểu đồ
                        BarDataSet dataSet2 = new BarDataSet(entries2, "Thu");
                        dataSet2.setColor(Color.BLUE);

                        // Tạo dữ liệu cho biểu đồ
                        BarData barData = new BarData(dataSet2);
                        barData.setBarWidth(0.4f);
// Thiết lập các thuộc tính cho biểu đồ
                        barChart.setData(barData);
                        barChart.getDescription().setEnabled(false);
                        barChart.getXAxis().setValueFormatter(new IndexAxisValueFormatter(new String[]{"Thg 1", "Thg 2", "Thg 3", "Thg 4", "Thg 5",
                                "Thg 6", "Thg 7", "Thg 8", "Thg 9", "Thg 10", "Thg 11", "Thg 12"}));
                        barChart.getXAxis().setPosition(XAxis.XAxisPosition.BOTTOM);

                        barChart.getAxisRight().setEnabled(false);
                        barChart.getLegend().setEnabled(true);
                        barChart.setTouchEnabled(true);
                        barChart.setDragEnabled(true);
                        barChart.setScaleEnabled(true);
                        barChart.setPinchZoom(true);
                        barChart.setDoubleTapToZoomEnabled(true);
                        barChart.setHighlightPerDragEnabled(true);
                        barChart.animateY(1000);
                        // Hiển thị biểu đồ
                        barChart.invalidate();

                    }
                    else {
                        Toast.makeText(Activity_bieudo.this, "Vui lòng nhập năm", Toast.LENGTH_SHORT).show();
                    }
                }
            });
            button_chi.setOnClickListener(new View.OnClickListener() {

                @Override
                public void onClick(View view) {
                    if (!editText_nam.getText().toString().trim().equals("")) {
                        button_thu.setBackgroundResource(R.drawable.custom_chi_thu_cua_bieu_do);
                        button_chi.setBackgroundResource(R.drawable.custom_chi_phi_bieu_do_hai);
                        chi_thang1 = 0;
                        chi_thang2 = 0;
                        chi_thang3 = 0;
                        chi_thang4 = 0;
                        chi_thang5 = 0;
                        chi_thang6 = 0;
                        chi_thang7 = 0;
                        chi_thang8 = 0;
                        chi_thang9 = 0;
                        chi_thang10 = 0;
                        chi_thang11 = 0;
                        chi_thang12 = 0;
                        String nam = editText_nam.getText().toString();
                        if (MainActivity.arrayList1.size() != 0) {
                            for (int i = 0; i < MainActivity.arrayList1.size(); i++) {
                                int namarray = MainActivity.arrayList1.get(i).getNam();
                                if (namarray == Integer.parseInt(nam)) {
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("01")) {
                                        chi_thang1 = chi_thang1 + Float.parseFloat(MainActivity.arrayList1.get(i).getChiphi());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("02")) {
                                        chi_thang2 = chi_thang2 + Float.parseFloat(MainActivity.arrayList1.get(i).getChiphi());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("03")) {
                                        chi_thang3 = chi_thang3 + Float.parseFloat(MainActivity.arrayList1.get(i).getChiphi());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("04")) {
                                        chi_thang4 = chi_thang4 + Float.parseFloat(MainActivity.arrayList1.get(i).getChiphi());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("05")) {
                                        chi_thang5 = chi_thang5 + Float.parseFloat(MainActivity.arrayList1.get(i).getChiphi());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("06")) {
                                        chi_thang6 = chi_thang6 + Float.parseFloat(MainActivity.arrayList1.get(i).getChiphi());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("07")) {
                                        chi_thang7 = chi_thang7 + Float.parseFloat(MainActivity.arrayList1.get(i).getChiphi());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("08")) {
                                        chi_thang8 = chi_thang8 + Float.parseFloat(MainActivity.arrayList1.get(i).getChiphi());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("09")) {
                                        chi_thang9 = chi_thang9 + Float.parseFloat(MainActivity.arrayList1.get(i).getChiphi());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("10")) {
                                        chi_thang10 = chi_thang10 + Float.parseFloat(MainActivity.arrayList1.get(i).getChiphi());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("11")) {
                                        chi_thang11 = chi_thang11 + Float.parseFloat(MainActivity.arrayList1.get(i).getChiphi());
                                    }
                                    if (MainActivity.arrayList1.get(i).getThang().trim().equals("12")) {
                                        chi_thang12 = chi_thang12 + Float.parseFloat(MainActivity.arrayList1.get(i).getChiphi());
                                    }

                                }
                            }
                        }
                        // Tạo danh sách các cột
                        List<BarEntry> entries1 = new ArrayList<>();
                        entries1.add(new BarEntry(0, chi_thang1));
                        entries1.add(new BarEntry(1f, chi_thang2));
                        entries1.add(new BarEntry(2f, chi_thang3));
                        entries1.add(new BarEntry(3f, chi_thang4));
                        entries1.add(new BarEntry(4f, chi_thang5));
                        entries1.add(new BarEntry(5f, chi_thang6));
                        entries1.add(new BarEntry(6f, chi_thang7));
                        entries1.add(new BarEntry(7f, chi_thang8));
                        entries1.add(new BarEntry(8f, chi_thang9));
                        entries1.add(new BarEntry(9f, chi_thang10));
                        entries1.add(new BarEntry(10f, chi_thang11));
                        entries1.add(new BarEntry(11f, chi_thang12));

                        // Tạo dataset cho biểu đồ
                        BarDataSet dataSet1 = new BarDataSet(entries1, "Chi");
                        dataSet1.setColor(Color.RED);

                        // Tạo dữ liệu cho biểu đồ
                        BarData barData = new BarData(dataSet1);
                        barData.setBarWidth(0.4f);
                        // Thiết lập các thuộc tính cho biểu đồ
                        barChart.setData(barData);
                        barChart.getDescription().setEnabled(false);
                        barChart.getXAxis().setValueFormatter(new IndexAxisValueFormatter(new String[]{"Thg 1", "Thg 2", "Thg 3", "Thg 4", "Thg 5",
                                "Thg 6", "Thg 7", "Thg 8", "Thg 9", "Thg 10", "Thg 11", "Thg 12"}));
                        barChart.getXAxis().setPosition(XAxis.XAxisPosition.BOTTOM);

                        barChart.getAxisRight().setEnabled(false);
                        barChart.getLegend().setEnabled(true);
                        barChart.setTouchEnabled(true);
                        barChart.setDragEnabled(true);
                        barChart.setScaleEnabled(true);
                        barChart.setPinchZoom(true);
                        barChart.setDoubleTapToZoomEnabled(true);
                        barChart.setHighlightPerDragEnabled(true);
                        barChart.animateY(1000);
                        // Hiển thị biểu đồ
                        barChart.invalidate();

                    }
                    else {
                        Toast.makeText(Activity_bieudo.this, "Vui lòng nhập năm", Toast.LENGTH_SHORT).show();
                    }
                }
            });

    }

    private void Anhxa() {
        // Khởi tạo biểu đồ
        barChart = findViewById(R.id.bar_chart);
        button_chi = findViewById(R.id.button_chi);
        button_thu = findViewById(R.id.button_thu);
        editText_nam =findViewById(R.id.editTextText_namff);
    }

    public void onClickDong(View view) {
        finish();
    }
}