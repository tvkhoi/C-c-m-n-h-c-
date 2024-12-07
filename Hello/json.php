<?php
    class SinhVien {
        public $Tuoi; // Declare the property $Tuoi
        public $Hoten; // Declare the property $Hoten
        function __construct($hoten, $tuoi) {
            $this->Hoten = $hoten;
            $this->Tuoi = $tuoi; // Assign the value of $tuoi to $Tuoi
        }
    }
  $mangSV = array();
    array_push($mangSV, new SinhVien("Nguyen Van A", 20));
    array_push($mangSV, new SinhVien("Nguyen Van B", 21));
    echo json_encode($mangSV);
?>