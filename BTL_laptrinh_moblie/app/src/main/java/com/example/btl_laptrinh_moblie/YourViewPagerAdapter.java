package com.example.btl_laptrinh_moblie;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentActivity;
import androidx.viewpager2.adapter.FragmentStateAdapter;

public class YourViewPagerAdapter extends FragmentStateAdapter {
    public static int a=0;
    public YourViewPagerAdapter(@NonNull FragmentActivity fragmentActivity) {
        super(fragmentActivity);
    }

    @NonNull
    @Override
    public Fragment createFragment(int position) {
        // Trả về Fragment tương ứng với từng tab
        if(position == 0) {
            a  = 1;
            return new fragment_add_0();
        }
        if(position==1) {
            a = 2;
            return new fragment_add_1();
        }
            a = 0;
        return  new Fragment3();

    }

    @Override
    public int getItemCount() {
        // Trả về số lượng tab
        return 3;
    }
}
