package com.example.btl_laptrinh_moblie;

import java.util.ArrayList;

public class Thong_tin_chi_tieu_thu_nhap  {
    private String ngay;
    private String thang;
    private String thu;
    private String chiphi;
    private String thu_nhap;

    public Thong_tin_chi_tieu_thu_nhap(String ngay,String thang, String thu, String chiphi, String thu_nhap) {
        this.ngay = ngay;
        this.thang = thang;
        this.thu = thu;
        this.chiphi = chiphi;
        this.thu_nhap = thu_nhap;
    }

    public void setNgay(String ngay_thang) {
        this.ngay = ngay;
    }

    public void setThu(String thu) {
        this.thu = thu;
    }

    public void setChiphi(String chiphi) {
        this.chiphi = chiphi;
    }

    public void setThu_nhap(String thu_nhap) {
        this.thu_nhap = thu_nhap;
    }

    public String getNgay() {
        return ngay;
    }

    public String getThu() {
        return thu;
    }

    public String getChiphi() {
        return chiphi;
    }

    public String getThu_nhap() {
        return thu_nhap;
    }

    public void setThang(String thang) {
        this.thang = thang;
    }

    public String getThang() {
        return thang;
    }
}
