package com.example.btl_laptrinh_moblie;

import static androidx.fragment.app.DialogFragment.STYLE_NORMAL;

import android.annotation.SuppressLint;
import android.app.Dialog;
import android.content.Intent;
import android.graphics.BlendMode;
import android.graphics.Color;
import android.graphics.PorterDuff;
import android.graphics.Rect;
import android.graphics.drawable.Drawable;
import android.graphics.drawable.StateListDrawable;
import android.os.Bundle;
import android.view.Gravity;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.Window;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.RelativeLayout;
import android.widget.ScrollView;
import android.widget.TableLayout;
import android.widget.TableRow;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.core.content.ContextCompat;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;

import java.util.ArrayList;

public class fragment_add_0 extends Fragment {
    TableLayout tableLayout_chiphi;
    ArrayList<chiphi> arrayList = MainActivity.arrayList_chi_phi;
  //  FragmentTransaction fragmentTransaction;
    public static Fragment fragment;
    Intent intent = FrameLayout_nhapthong_tin.intent;
  //  FrameLayout_nhapthong_tin fragment_nhapthong_tin = new FrameLayout_nhapthong_tin();
    ConstraintLayout constraintLayout_fragment_0;
    ImageView imageView_last = null;
    @SuppressLint("MissingInflatedId")
    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_add_0,container,false);
        tableLayout_chiphi = (TableLayout) view.findViewById(R.id.tableLayout_chiphi);
        constraintLayout_fragment_0 = (ConstraintLayout) view.findViewById(R.id.constraint_fragment_0);
        Add_table_layout(view);
        return view;
    }

    private void Add_table_layout(View view) {
        int so_cot = 4;
        int so_dong = 7;
        for (int i = 0; i < so_dong; i++) {
            TableRow tableRow = new TableRow(view.getContext());
            TableRow.LayoutParams rowLayoutParams = new TableRow.LayoutParams(ViewGroup.LayoutParams.MATCH_PARENT, ViewGroup.LayoutParams.WRAP_CONTENT);
            rowLayoutParams.setMargins(0, 3000, 0, 300); // Đặt khoảng cách dưới cho các dòng là 10px (có thể điều chỉnh giá trị theo ý muốn)
            tableRow.setLayoutParams(rowLayoutParams);
            for (int j = 0; j < so_cot; j++) {
                LinearLayout layout = new LinearLayout(view.getContext());
                layout.setOrientation(LinearLayout.VERTICAL);
                ImageView imageView = new ImageView(view.getContext());
                TextView textView = new TextView(view.getContext());
                textView.setGravity(Gravity.CENTER);
                int a=textView.getHeight();
                textView.setHeight(130);
                int vitri = so_cot * i + j;

                if (vitri < 28) {
                    //Drawable icon = ContextCompat.getDrawable(getContext(),arrayList.get(vitri).getIcon());
                   // imageView.setCompoundDrawablesRelativeWithIntrinsicBounds(null,icon, null, null);
                   // textView.setPadding(0, 0, 0, 0); // Set padding thành 0
                    imageView.setImageResource(arrayList.get(vitri).getIcon());
                    textView.setText(""+arrayList.get(vitri).getTen());

                    imageView.setOnClickListener(new View.OnClickListener() {
                        @Override
                        public void onClick(View view) {
                            if(imageView_last !=null) {
                                imageView_last.setBackgroundColor(Color.TRANSPARENT);
                            }
                           view.setBackgroundResource(R.drawable.custom_image_button_add);
                            imageView_last = imageView;
//                            for(int i =0;i<MainActivity.arrayList_thoThong_tin_chi_tieu_thu_nhaps.size();i++) {
//                                Thong_tin_chi_tieu_thu_nhap thong_tin_chi_tieu_thu_nhap = (Thong_tin_chi_tieu_thu_nhap) MainActivity.arrayList_thoThong_tin_chi_tieu_thu_nhaps.get(0);
//                                if (!thong_tin_chi_tieu_thu_nhap.getNgay().trim().equals("29")) {
//                                    // Toast.makeText(this, "fjfjfjfjfjfjfjf"+thong_tin_chi_tieu_thu_nhap.getThang().trim(), Toast.LENGTH_SHORT).show();

//                                }
//                            }
                           // Adapter_ngaythang_nam.arrayList_chiphi_thunhap.add(arrayList.get(vitri));
                            FrameLayout_nhapthong_tin.intent.putExtra("vitri_chiphi",vitri);
                            MainActivity.icon_sua=vitri;
                            //Adapter_ngaythang_nam.arrayList_chiphi_thunhap.add(arrayList.get(vitri));
//                            FragmentManager fragmentManager = requireActivity().getSupportFragmentManager();
//                            if (fragmentManager != null) {
//                                fragmentTransaction = fragmentManager.beginTransaction();
//
//                                FrameLayout_nhapthong_tin fragment = (FrameLayout_nhapthong_tin) fragmentManager.findFragmentByTag("dialog");
//                                if (fragment != null) {
//                                    fragmentTransaction.remove(fragment);
//                                    fragmentTransaction.show(fragment);
//                                }
//                                fragmentTransaction.remove(fragment_nhapthong_tin);
//                                fragmentTransaction.replace(R.id.framelayout_nhapthongtin, fragment_nhapthong_tin,"dialog_0");
//                                fragmentTransaction.commit();
//                            }
                            fragment = new FrameLayout_nhapthong_tin();
                            FragmentManager fragmentManager = getFragmentManager();
                            FragmentTransaction fragmentTransaction = fragmentManager.beginTransaction();
                            fragmentTransaction.replace(R.id.framelayout_nhapthongtin,fragment);
                            fragmentTransaction.commit();
//                            FragmentManager fragmentManager = getActivity().getSupportFragmentManager();
//                            FrameLayout_nhapthong_tin frameLayout_nhapthong_tin = new FrameLayout_nhapthong_tin();
//                            frameLayout_nhapthong_tin.show(fragmentManager,"dialog");
                        }
                    });
                }

              //  textView.setLayoutParams(layoutParams);
                //textView.setGravity(Gravity.CENTER);
                TableRow.LayoutParams cellLayoutParams = new TableRow.LayoutParams(ViewGroup.LayoutParams.WRAP_CONTENT, ViewGroup.LayoutParams.WRAP_CONTENT);
                cellLayoutParams.setMargins(30, 0, 30, 0); // Đặt khoảng cách trái và phải của mỗi ô là 10px (có thể điều chỉnh giá trị theo ý muốn)
                layout.setLayoutParams(cellLayoutParams);
                layout.addView(imageView);
                layout.addView(textView);
                tableRow.addView(layout);

            }

            tableLayout_chiphi.addView(tableRow);
        }
    }

}
