<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThemSP.aspx.cs" Inherits="BtlWebBasic.ThemSP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
		<div class="row">
			<div>
				<div>
					<center><h3><b>Mặt Hàng</b></h3></center>						
					<center>
					<form>
						<div>
							<label for="inputTen1">Tên mặt hàng</label>
							<div>
								<input type="text" class="form-control" id="inputTen1" placeholder="Tên Hàng" name="txtTen">
							</div>
						</div>
						<div>
							<label for="inputGia1">Giá</label>
							<div>
								<input type="number" class="form-control" id="inputGia1" placeholder="100000000" name="txtGia">
							</div>
						</div>
					
						<div >
							<label for="inputAnh1" >Ảnh</label>
							<div>
                                <asp:FileUpload ID="inputAnh1" runat="server" name="myImage" CssClass="form-control" />
                                <asp:Button ID="btnUpLoad" runat="server" Text="Upload" OnClick="btnUpload_Click" CssClass="btn btn-basic"/>
                                <asp:Image ID="Image1" runat="server" Width="150px" />
							</div>
						</div>
						<div >
							<div>									
								<br>
								<center> 
                                    <asp:button text="Thêm" runat="server" CssClass="btn btn-success" ID="btnAddProd" nClick="btnThem_Click" />
								</center>
							</div>

						</div>
					</form>
					</center>
				</div>
			</div>
		</div>
		<div id="listProduct" name="listProduct" runat="server"></div>
	</div>
    </form>
</body>
</html>
