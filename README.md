# Game bầu cua - Hướng dẫn
==========================<br/>
Để phát triển phần mềm các bạn cần tải và cài đặt những phần mềm sau:<br/>
+ Visual Studio 2010 hoặc 2015 Community: https://www.visualstudio.com/en-us/news/releasenotes/vs2015-update3-vs<br/>
+ Git: https://git-scm.com/downloads (chọn Windows - tải bản 32 bit hoặc 64 bit tùy vào hệ điều hành của máy)<br/>
+ TeamViewer (để Bảo có thể Support khi các bạn gặp trục trặc): https://download.teamviewer.com/download/TeamViewerQS.exe<br/>
==========================<br/>
Hướng dẫn tải mã nguồn về:<br/>
+ Dùng lệnh: git clone https://github.com/baobaoit/gamebaucua.git<br/>
==========================<br/>
Di chuyển vào thư mục mã nguồn chương trình:<br/>
+ Dùng lệnh: cd gamebaucua<br/>
Khi thấy xuất hiện (gì đó)/gamebaucua (master) là OK<br/>
==========================<br/>
Khi lấy mã nguồn về ai được phân công việc gì thì tạo 1 nhánh để làm, nhánh là tên việc của mình:<br/>
Ví dụ Long thiết kế giao diện đăng nhập, đăng xuất thì tạo 1 nhánh tên UI (giao diện)<br/>
+ Dùng lệnh: git checkout -b UI<br/>
==========================<br/>
Một số lệnh cơ bản cần biết:<br/>
Khi làm việc xong để tải mã nguồn lên Github dùng các lệnh sau:<br/>
+ Bước 1/ git add .<br/>
+ Bước 2/ git commit -m "Tên nhánh: việc đã làm viết tiếng Việt không dấu" (Ví dụ: git commit -m "UI: Thiet ke xong giao dien")<br/>
+ Bước 3/ git push origin <Tên nhánh> (Ví dụ: git push origin UI)<br/>
Sau khi xong việc của mình thì vào Github > chỗ branch bấm vào và chọn nhánh của mình làm > chọn New pull request > base chọn master > compare chọn tên nhánh mà mình làm việc > nếu hiện Able to merge thì nhấn nút Create pull request.<br/>
Khi có xung đột hay lỗi thì gửi tin nhắn vào nhóm.<br/>
===========================<br/>
Sau khi Bảo merge xong mã nguồn thì trước khi làm các bạn cần lấy dự án về để cập nhật mã nguồn mới nhất<br/>
+ Dùng lệnh: git pull origin master<br/>
===========================<br/>
