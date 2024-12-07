package com.example.btl_laptrinh_moblie;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.CheckBox;
import android.widget.TextView;
import android.widget.Toast;

import java.util.List;

public class Adapte_chon_tien extends BaseAdapter {
    Activity_chon_tien context;
    int layout;
    List<Tien_te> list;
    LayoutInflater inflater;
    public Adapte_chon_tien(Activity_chon_tien context, int layout, List<Tien_te> list) {
        this.context = context;
        this.layout = layout;
        this.list = list;
    }

    @Override
    public int getCount() {
        return list.size();
    }

    @Override
    public Object getItem(int i) {

        return 0;
    }

    @Override
    public long getItemId(int i) {
        return 0;
    }
    private class ViewHolder {
        private TextView textView_tentien,textView_chi_tiet_tien;
    }
    @Override
    public View getView(int i, View view, ViewGroup viewGroup) {
       ViewHolder viewHolder = null;
        if(view == null) {
            inflater = (LayoutInflater) context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            view = inflater.inflate(layout,null);
            viewHolder = new ViewHolder();

            viewHolder = new ViewHolder();
            viewHolder.textView_tentien= (TextView) view.findViewById(R.id.textView_ten_loai_tien);
            viewHolder.textView_chi_tiet_tien = (TextView) view.findViewById(R.id.textView_chi_tiet_tien);
          //  viewHolder.checkBox = (CheckBox) view.findViewById(R.id.checkBox_loai_tien);
            view.setTag(viewHolder);
        }
        else {
            viewHolder = (ViewHolder) view.getTag();
        }
         Tien_te tien_te = list.get(i);
         viewHolder.textView_tentien.setText(tien_te.getTien());
         viewHolder.textView_chi_tiet_tien.setText(tien_te.getChi_tiet_tien());


        return view;
    }
}
