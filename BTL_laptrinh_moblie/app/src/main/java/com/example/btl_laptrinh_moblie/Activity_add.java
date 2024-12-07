package com.example.btl_laptrinh_moblie;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;
import androidx.viewpager2.widget.ViewPager2;

import android.annotation.SuppressLint;
import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.os.TestLooperManager;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;

import com.google.android.material.tabs.TabLayout;
import com.google.android.material.tabs.TabLayoutMediator;

public class Activity_add extends AppCompatActivity {
    TextView textView_huybo_add;
    TabLayout tabLayout;
    public static ViewPager2 viewPager2;
    YourViewPagerAdapter adapter;
    static String chuoi_tien="";
    static String chi_tiet_tien="";
    public  static int  [] tabTitles = new int[] {R.string.tab_chi_phi,R.string.tab_thu_nhap,R.string.tab_thongtin};
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add);

        Anhxa();
        adapter = new YourViewPagerAdapter(this);
        viewPager2.setAdapter(adapter);








        tabLayout.addOnTabSelectedListener(new TabLayout.OnTabSelectedListener() {
            @Override
            public void onTabSelected(TabLayout.Tab tab) {
               int currentTabPosition = tab.getPosition();
                FrameLayout_nhapthong_tin.intent.putExtra("tablayout_position",tab.getPosition());
            }

            @Override
            public void onTabUnselected(TabLayout.Tab tab) {
                // Do nothing
            }

            @Override
            public void onTabReselected(TabLayout.Tab tab) {
                // Do nothing
            }
        });
        new TabLayoutMediator(tabLayout, viewPager2, new TabLayoutMediator.TabConfigurationStrategy() {
            @SuppressLint("ResourceType")
            @Override
            public void onConfigureTab(@NonNull TabLayout.Tab tab, int position) {
                tab.setText(Activity_add.this.getResources().getString(tabTitles[position]));
            }
        }).attach();
    }

    private void Anhxa() {
        tabLayout = (TabLayout) findViewById(R.id.tabLayout);
        viewPager2 = (ViewPager2) findViewById(R.id.viewPager2);
        textView_huybo_add = (TextView) findViewById(R.id.textView_huybo_add);
    }
    public void onClick_huybo_add(View view) {
        MainActivity.chuoi_tien = "";
        MainActivity.chi_tiet_tien = "";
        finish();
    }
}