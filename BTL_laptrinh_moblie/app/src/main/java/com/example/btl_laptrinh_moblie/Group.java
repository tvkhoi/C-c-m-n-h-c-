package com.example.btl_laptrinh_moblie;

import java.util.List;

public class Group {
    int vitri_group;
    private String ngay;
    private String thang;
    private String thu;
    private String chiphi;
    private String thu_nhap;
    private List<chitiet_chiphi_thu_nhap> members;
    private int nam;

    public Group(int vitri_group,String ngay, String thang, String thu, String chiphi, String thu_nhap, List<chitiet_chiphi_thu_nhap> members, int nam) {
        this.ngay = ngay;
        this.thang = thang;
        this.thu = thu;
        this.chiphi = chiphi;
        this.thu_nhap = thu_nhap;
        this.members = members;
        this.nam = nam;
        this.vitri_group = vitri_group;
    }

    public void setVitri_group(int vitri_group) {
        this.vitri_group = vitri_group;
    }

    public int getVitri_group() {
        return vitri_group;
    }

    public void setNgay(String ngay) {
        this.ngay = ngay;
    }

    public void setThang(String thang) {
        this.thang = thang;
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

    public void setMembers(List<chitiet_chiphi_thu_nhap> members) {
        this.members = members;
    }

    public String getNgay() {
        return ngay;
    }

    public String getThang() {
        return thang;
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

    public List<chitiet_chiphi_thu_nhap> getMembers() {
        return members;
    }

    public int getNam() {
        return nam;
    }

    public void setNam(int nam) {
        this.nam = nam;
    }
}
