# <p align="center">BÀI TẬP LỚN CSHARP QUẢN LÝ CỬA HÀNG BÁN TẠP HOÁ </p>
### <p align="center">NHÓM SINH VIÊN CÔNG NGHỆ THÔNG TIN TRƯỜNG ĐHCN HÀ NỘI THỰC HIỆN! </p>
<p align="center">
  <img width="300" height="150" src="https://thichchiase.com/wp-content/uploads/2020/04/fa9d4f7cf28b6f009570751504b5fbe1-1200x675.png">
</p>
<p align="center">
  <img width="150" height="150" src="https://img2.pngio.com/castsoftware-extend-entity-framework-png-260_260.png">
</p>

# TÍNH NĂNG:
- Quản lý sản phẩm.
- Quản lý tài khoản.
- Quản lý danh mục sản phẩm.
- Quản lý nhà cung cấp.
- Quản lý nhập sản phẩm.
- Giao diện bán hàng.
- Xem chi tiết hoá đơn.
- Xuất hoá đơn dạng pdf.
- Nhập xuất dữ liệu qua file excel.

# HƯỚNG DẪN SỬ DỤNG:
### Bước 1:
- Mở SQL Server sau đó chạy nội dung trong file db_store_management.sql
### Bước 2:
- Sao chép Server name trên máy bạn hoặc online.
### Bước 3:
- Dán nội dung vừa sao chép vào file App.config để cấu hình kết nối cơ sở dữ liệu cho phần mềm.
```
<connectionStrings>
    <add name="StoreEntities" connectionString="metadata=res://*/StoreModel.csdl|res://*/StoreModel.ssdl|res://*/StoreModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=<NỘI DUNG VỪA SAO CHÉP>;initial catalog=store_management;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>
```
### Bước 4: Tiến hành khởi động và trải nghiệm. 

# NHÓM SINH VIÊN THỰC HIỆN
- Duy Khánh
- Đức Điệp
- Bá Hoàng
- Hữu Hoàng
