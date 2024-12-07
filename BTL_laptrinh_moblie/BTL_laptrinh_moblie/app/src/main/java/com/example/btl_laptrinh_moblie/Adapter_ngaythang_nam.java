package com.example.btl_laptrinh_moblie;

import android.R.layout;
import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.BaseAdapter;
import android.widget.LinearLayout;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.constraintlayout.widget.ConstraintLayout;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Adapter_ngaythang_nam extends ArrayAdapter<Group> {
    Context context;
    int layout;
    List<Group> list_thThong_tin_chi_tieu_thu_nhaps;
    static int vitri_a;
    LayoutInflater inflater;
//    public static List<List<chitiet_chiphi_thu_nhap>> arrayList_chiphi_thunhap = new ArrayList<>();
    public static Adapter_chiphi_thunhap arrayAdapter;
    public Adapter_ngaythang_nam(Context context, int layout,List<Group> list_thThong_tin_chi_tieu_thu_nhaps) {
        super(context,0);
        this.context = context;
        this.layout = layout;
        this.list_thThong_tin_chi_tieu_thu_nhaps = list_thThong_tin_chi_tieu_thu_nhaps;

    }

    @Override
    public int getCount() {
        return list_thThong_tin_chi_tieu_thu_nhaps.size();
    }


    @Override
    public long getItemId(int i) {
        return 0;
    }
    public class ViewHolder {
        private TextView textView_ngay,textView_thu,textView_chiphi,textView_thunhap,textView_thang;
        private ListView listView;
        private ConstraintLayout constraintLayout;
    }
    @Override
    public View getView(int i, View view, ViewGroup viewGroup) {
        ViewHolder viewHolder = null;
        if(view == null) {
            inflater = (LayoutInflater) context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            view = inflater.inflate(layout,null);
            viewHolder = new ViewHolder();

            viewHolder = new ViewHolder();
            viewHolder.textView_ngay= (TextView) view.findViewById(R.id.textView_ngay);
            viewHolder.textView_thang = (TextView) view.findViewById(R.id.textView_thag);
            viewHolder.textView_thu = (TextView) view.findViewById(R.id.textView_thu);
            viewHolder.textView_chiphi = (TextView) view.findViewById(R.id.textView_chiphi_listview);
            viewHolder.textView_thunhap = (TextView) view.findViewById(R.id.textView_thunhap_listview);
            viewHolder.listView = (ListView) view.findViewById(R.id.listView_custom_listView);
            viewHolder.constraintLayout = (ConstraintLayout) view.findViewById(R.id.linearLayout_ghichep);
            view.setTag(viewHolder);
        }
        else {
            viewHolder = (ViewHolder) view.getTag();
        }

       Group thong_tin_chi_tieu_thu_nhap = list_thThong_tin_chi_tieu_thu_nhaps.get(i);
        viewHolder.textView_ngay.setText(thong_tin_chi_tieu_thu_nhap.getNgay());
        viewHolder.textView_thang.setText(thong_tin_chi_tieu_thu_nhap.getThang());
        viewHolder.textView_thu.setText(thong_tin_chi_tieu_thu_nhap.getThu());
        viewHolder.textView_chiphi.setText(thong_tin_chi_tieu_thu_nhap.getChiphi());
        viewHolder.textView_thunhap.setText(thong_tin_chi_tieu_thu_nhap.getThu_nhap());


        arrayAdapter = new Adapter_chiphi_thunhap(this.context,thong_tin_chi_tieu_thu_nhap.getMembers(),R.layout.custom_chiphi_thunhap);
        viewHolder.listView.setAdapter(arrayAdapter);
        arrayAdapter.notifyDataSetChanged();
        viewHolder.listView.setNestedScrollingEnabled(true);



        return view;

    }
}
