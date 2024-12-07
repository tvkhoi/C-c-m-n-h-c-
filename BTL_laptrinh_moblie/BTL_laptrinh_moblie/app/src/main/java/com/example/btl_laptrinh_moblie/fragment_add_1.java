package com.example.btl_laptrinh_moblie;

import android.graphics.Color;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.view.Gravity;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TableLayout;
import android.widget.TableRow;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;

import java.util.ArrayList;

public class fragment_add_1 extends Fragment {
    TableLayout tableLayout_thu_nhap;
    FragmentTransaction fragmentTransaction;
    FrameLayout_nhapthong_tin fragment_nhapthong_tin = new FrameLayout_nhapthong_tin();
    ArrayList<chiphi> arrayList_thu_nhap = MainActivity.arrayList_thu_nhap;
    //static Fragment fragment = fragment_add_0.fragment;
    ImageView imageView_last = null;
    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_add_1,container,false);
        tableLayout_thu_nhap = (TableLayout) view.findViewById(R.id.tableLayout_thunhap);
        Add_table_layout_thu_nhap(view);


        return view;
    }
    private void Add_table_layout_thu_nhap(View view) {
        int so_cot = 4;
        int so_dong = 1;
        for (int i = 0; i < so_dong; i++) {
            TableRow tableRow = new TableRow(view.getContext());
            TableRow.LayoutParams rowLayoutParams = new TableRow.LayoutParams(ViewGroup.LayoutParams.MATCH_PARENT, ViewGroup.LayoutParams.WRAP_CONTENT);
            rowLayoutParams.setMargins(0, 3000, 0, 300); // Đặt khoảng cách dưới cho các dòng là 10px (có thể điều chỉnh giá trị theo ý muốn)
            tableRow.setLayoutParams(rowLayoutParams);
            for (int j = 0; j < so_cot; j++) {
                LinearLayout layout = new LinearLayout(view.getContext());
                layout.setOrientation(LinearLayout.VERTICAL);
                TextView textView = new TextView(view.getContext());
                ImageView imageView = new ImageView(view.getContext());
                //textView.setBackgroundResource(R.drawable.custom_click_item_tablelayout);
                textView.setTextSize(15);
                textView.setHeight(150);
                textView.setWidth(170);
                int vitri = so_cot * i + j;

                if (vitri < so_cot*so_dong) {
                    imageView.setImageResource(arrayList_thu_nhap.get(vitri).getIcon());
//                    Drawable icon = getResources().getDrawable(arrayList_thu_nhap.get(vitri).getIcon());
//                    textView.setCompoundDrawablesWithIntrinsicBounds(null,icon,null,null);
                    textView.setText(arrayList_thu_nhap.get(vitri).getTen());


                    imageView.setOnClickListener(new View.OnClickListener() {
                        @Override
                        public void onClick(View view) {
                            if(imageView_last !=null) {
                                imageView_last.setBackgroundColor(Color.TRANSPARENT);
                            }
                            FrameLayout_nhapthong_tin.intent.putExtra("vitri_thunhap",vitri);
                            MainActivity.icon_sua=vitri;
                            view.setBackgroundResource(R.drawable.custom_image_button_add);
                            imageView_last = imageView;
                            FragmentManager fragmentManager = requireActivity().getSupportFragmentManager();
                            if (fragmentManager != null) {
                                fragmentTransaction = fragmentManager.beginTransaction();

                               FrameLayout_nhapthong_tin fragment = (FrameLayout_nhapthong_tin) fragmentManager.findFragmentByTag("dialog");
                                if (fragment != null) {
                                    fragmentTransaction.remove(fragment);
                                    fragmentTransaction.show(fragment);
                                }
                                fragmentTransaction.remove(fragment_nhapthong_tin);
                                fragmentTransaction.add(R.id.framelayout_nhapthongtin_2, fragment_nhapthong_tin);
                                fragmentTransaction.commit();

                            }

                        }
                    });
                }
                TableRow.LayoutParams cellLayoutParams = new TableRow.LayoutParams(ViewGroup.LayoutParams.WRAP_CONTENT, ViewGroup.LayoutParams.WRAP_CONTENT);
                cellLayoutParams.setMargins(13, 0, 13, 0); // Đặt khoảng cách trái và phải của mỗi ô là 10px (có thể điều chỉnh giá trị theo ý muốn)
                layout.setLayoutParams(cellLayoutParams);
                layout.addView(imageView);
                layout.addView(textView);
                textView.setGravity(Gravity.CENTER);
                tableRow.addView(layout);
            }
            tableLayout_thu_nhap.addView(tableRow);

        }
    }

}
