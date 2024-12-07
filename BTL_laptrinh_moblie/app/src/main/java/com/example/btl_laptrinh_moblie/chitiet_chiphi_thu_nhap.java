package com.example.btl_laptrinh_moblie;

public class chitiet_chiphi_thu_nhap {
    int icon;
    int vitri_group;
    String ten;
    String so_tien;
    int tablayout;


    public chitiet_chiphi_thu_nhap(int icon, int vitri_group, String ten, String so_tien, int tablayout) {
        this.icon = icon;
        this.vitri_group = vitri_group;
        this.ten = ten;
        this.so_tien = so_tien;
        this.tablayout = tablayout;
    }

    public int getVitri_group() {
        return vitri_group;
    }

    public void setVitri_group(int vitri_group) {
        this.vitri_group = vitri_group;
    }

    public int getIcon() {
        return icon;
    }

    public String getTen() {
        return ten;
    }

    public String getSo_tien() {
        return so_tien;
    }

    public void setIcon(int icon) {
        this.icon = icon;
    }

    public void setTen(String ten) {
        this.ten = ten;
    }

    public void setSo_tien(String so_tien) {
        this.so_tien = so_tien;
    }

    public int getTablayout() {
        return tablayout;
    }

    public void setTablayout(int tablayout) {
        this.tablayout = tablayout;
    }
}
