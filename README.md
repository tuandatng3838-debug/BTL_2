# Quản lý Hội giảng WinForms (.NET 8)

Dự án WinForms quản lý cán bộ, hội giảng, hội đồng và kết quả cho học viện. Mã nguồn dùng ADO.NET với SQL Server/LocalDB.

## Cấu trúc
- `BTLHoiGiang/BTLHoiGiang.csproj`: dự án WinForms .NET 8.
- `BTLHoiGiang/Data/DatabaseHelper.cs`: tiện ích ADO.NET.
- `BTLHoiGiang/Forms/`: các form chức năng.
- `BTLHoiGiang/Database.sql`: script tạo bảng.

## Hướng dẫn chạy
1. Khôi phục database LocalDB:
   ```sql
   -- chạy trong SQL Server/LocalDB
   CREATE DATABASE HoiGiangDb;
   GO
   USE HoiGiangDb;
   GO
   :r BTLHoiGiang/Database.sql
   ```
2. Cập nhật `ConnectionString` trong `DatabaseHelper.cs` nếu cần.
3. Build và chạy:
   ```bash
   dotnet build BTLHoiGiang/BTLHoiGiang.csproj
   dotnet run --project BTLHoiGiang/BTLHoiGiang.csproj
   ```

## Đẩy mã nguồn lên GitHub từ thư mục này (từng bước thật chậm)
Bạn không cần biết “bash” là gì; chỉ cần mở một cửa sổ dòng lệnh (Terminal trên macOS/Linux hoặc Command Prompt/PowerShell trên Windows) và gõ các lệnh bên dưới y như copy/paste. Các lệnh được viết để chạy trong thư mục chứa dự án này: `/workspace/BTL_2`.

### 0) Mở đúng thư mục dự án
- Nếu đang ở VS Code: View → Terminal, sau đó chạy `cd /workspace/BTL_2` rồi Enter.
- Nếu đang ở Command Prompt/PowerShell: chạy `cd /workspace/BTL_2` rồi Enter.

### 1) Tạo repository trống trên GitHub
- Trên trang GitHub, bấm **New repository** → đặt tên (ví dụ `hoi-giang-winforms`) → *đừng* chọn add README/gitignore/license.
- Sao chép URL dạng `https://github.com/<user>/<repo>.git` (ví dụ `https://github.com/yourname/hoi-giang-winforms.git`).

### 2) Kiểm tra hiện tại đã gắn remote nào chưa
```
git remote -v
```
- Nếu **không thấy dòng nào** bắt đầu bằng `origin`, nghĩa là chưa gắn; sang bước 3 để thêm.
- Nếu đã thấy `origin    https://... (fetch/push)`, bỏ qua bước 3 và đi thẳng tới bước 4.

### 3) Gắn URL GitHub vào remote `origin` (chỉ làm 1 lần)
```
git remote add origin https://github.com/<user>/<repo>.git
```
> Sai URL? Chạy `git remote remove origin` rồi gắn lại.

### 4) Lưu toàn bộ thay đổi thành commit
```
git status -sb                 # xem còn file chưa lưu không
git add .                      # gom tất cả file mới/sửa vào stage
git commit -m "Khoi tao du an hoi giang"   # tạo commit
```

### 5) Đẩy lên GitHub
- Nếu muốn giữ tên nhánh hiện tại (`work`):
  ```
  git push -u origin work
  ```
- Nếu muốn đổi tên nhánh thành `main` trước khi đẩy:
  ```
  git branch -M main
  git push -u origin main
  ```

### 6) Kiểm tra và tải về máy cá nhân
- Mở GitHub: thấy code và commit vừa đẩy là xong.
- Tải về máy khác: `git clone https://github.com/<user>/<repo>.git` hoặc bấm **Code → Download ZIP**.
