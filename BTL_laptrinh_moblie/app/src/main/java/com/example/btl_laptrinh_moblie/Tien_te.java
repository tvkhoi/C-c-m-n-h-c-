package com.example.btl_laptrinh_moblie;

public class Tien_te {
    String tien;
    String chi_tiet_tien;

    public Tien_te(String tien, String chi_tiet_tien) {
        this.tien = tien;
        this.chi_tiet_tien = chi_tiet_tien;
    }

    public String getTien() {
        return tien;
    }

    public String getChi_tiet_tien() {
        return chi_tiet_tien;
    }

    public void setTien(String tien) {
        this.tien = tien;
    }

    public void setChi_tiet_tien(String chi_tiet_tien) {
        this.chi_tiet_tien = chi_tiet_tien;
    }
}
