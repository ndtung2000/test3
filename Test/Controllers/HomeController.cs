using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Test.Models;
namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public static List<DSTaiLieu> dsTaiLieu = new List<DSTaiLieu>()
        {

            new DSTaiLieu() { Id = 1, Img="http://utc2.edu.vn/uploads/img/images/Diemsach_2018_02_image008.jpg", Name = "Giáo trình lập trình Java", Author = "Đoàn Văn Ban - Đoàn Văn Trung", PageNumber=355,
                                Detail="Giáo trình được biên soạn về lập trình Java cho các sinh viên kỹ sư, cử nhân và cho những ai quan tâm đến phương pháp lập trình hướng đối tượng để phát triển những ứng dụng độc lập với môi trường hay để xây dựng các Website trên mạng. Trình bày chi tiết các thành phần cơ bản của Java, hướng đối tượng trong Java, các lớp cơ bản và cấu trúc dữ liệu, Applet và lập trình đồ họa, luồng vào ra và tệp tin, lập trình CSDL với JDBC, bảo mật và an ninh thông tin" },
            new DSTaiLieu() { Id = 2, Img="http://utc2.edu.vn/uploads/img/images/Diemsach_2018_02_image007.gif", Name = "Kỹ nghệ phần mềm nâng cao", Author="TS. Lê Văn Phùng, CN. Lê Hương Giang", PageNumber=235, 
                                Detail="Cuốn sách giới thiệu đến bạn đọc các kiến thức cần thiết trong việc tìm hiểu kỹ nghệ để bảo đảm chất lượng phần mềm, đề cập đến những khái niệm chất lượng phần mềm và chất lượng quá trình và chất lượng sản phẩm, mô hình chất lượng, việc đo chất lượng, các chỉ tiêu tổng hợp đo chất lượng, các hoạt động cốt lõi bảo đảm chất lượng phần mềm cũng như tiến trình triển khai bảo đảm chất lượng phần mềm." },
            new DSTaiLieu() { Id = 3, Img="http://utc2.edu.vn/uploads/img/images/Diemsach_2018_02_image009.jpg", Name = "Giáo trình khám phá dữ liệu Web", Author="Hà Quang Thụy (Chủ biên), Phan Xuân Hiếu, Đoàn Sơn, Nguyễn Trí Thành,…", PageNumber=311,
                                Detail="Giáo trình Khai phá dữ liệu Web bao gồm 10 chương với những nội dung: một số nội dung cơ bản về khai phá dữ liệu, tổng quan về khai phá web, một số kiến thức toán học cho khai phá dữ liệu web, một số vấn đề xử lý ngôn ngữ tiếng Việt cho khai phá văn bản, các phương pháp biểu diễn văn bản, hệ thống tìm kiếm, phân cụm văn bản, phân lớp văn bản, trích chọn thông tin trên web, web ngữ nghĩa." },
            new DSTaiLieu() { Id = 4, Img="http://utc2.edu.vn/uploads/img/images/Diemsach_2018_02_image010.png", Name = "NNLT C++ và cấu trúc dữ liệu", Author="Nguyễn Việt Hương", PageNumber=259,
                                Detail="Là giáo trình giảng dạy của khoa Điện tử - Viễn thông trường ĐH BKHN, nội dung trình bày những ý tưởng của Ngôn ngữ lập trình C++ và hướng dẫn cách ứng dụng những điều vừa học thông qua các ví dụ, giúp người đọc hiểu rõ đầy đủ từ ý tưởng này đến ý tưởng khác (Phần 1:Ngôn ngữ lập trình C++), đồng thời trình bày cách cài đặt một số cấu trúc dữ liệu cơ bản bằng ngôn ngữ C++ ( Phần 2: Cấu trúc dữ liệu) . Mời các bạn tìm đọc." },
        };
        
        
        public ActionResult Index()
        {
            return View(dsTaiLieu.OrderBy(s => s.Id).ToList());
        }

        public ActionResult Detail(int ID)
        {
            var detail = dsTaiLieu.Where(s => s.Id.ToString().ToLower() == ID.ToString().ToLower()).FirstOrDefault();   
            return View(detail);
        }
        
        

        
    }
}