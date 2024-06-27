using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
namespace WebBanHang.Models
    
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Product> Products { set; get; }
        //Order
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            //seed data to table Categories
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Rolex", DisplayOrder = 1 },
            new Category { Id = 2, Name = "Omega", DisplayOrder = 2 },
            new Category { Id = 3, Name = "Hublot", DisplayOrder = 3 });
            //seed data to table Product
            modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Đồng hồ Rolex Datejust M126233-0017", Description= "Đồng hồ Oyster Perpetual Datejust 36 bằng thép Oystersteel và vàng kim đi kèm mặt số màu champagne, nạm kim cương và dây đeo Jubilee.", Price = 10000, CategoryId = 1 },
            new Product { Id = 2, Name = "Đồng Hồ Rolex Datejust 31 278381RBR ", Description = "Đồng hồ Oyster Perpetual Datejust 31 bằng thép Oystersteel và vàng Everose đi kèm mặt số slate và dây đeo Jubilee.", Price = 12000, CategoryId = 1 },
            new Product { Id = 3, Name = "Đồng Hồ Rolex Datejust 31", Description = "Đồng hồ Oyster Perpetual Datejust 31 bằng thép Oystersteel và vàng Everose đi kèm mặt số màu sô-cô-la, nạm kim cương và dây đeo Jubilee.", Price = 15000, CategoryId = 1 },
            new Product { Id = 4, Name = "Rolex M126234-0051", Description = "Đồng hồ Oyster Perpetual Datejust 36 bằng Thép Oystersteel và vàng trắng đi kèm mặt số màu xanh bạc hà và dây đeo Jubilee.", Price = 13000, CategoryId = 1 },
            new Product { Id = 5, Name = "AQUA TERRA 150MCO‑AXIAL MASTER CHRONOMETER 41 MM", Description = "Đồng Hồ Omega Seamaster Aqua Terra 150M Co-Axial Master Chronometer 41mm 220.52.41.21.03.001 là một phiên bản đến từ bộ sưu tập danh tiếng Seamaster của thương hiệu đồng hồ Omega.", Price = 6000, CategoryId = 2 },
            new Product { Id = 6, Name = "Omega Seamaster 220.10.41.21.03.001 Aqua Terra 41mm", Description = "Đồng hồ Omega Seamaster Aqua Terra Master Chronometer 220.10.41.21.03.001 của thương hiệu OMEGA luôn được biết đến là một thương hiệu xa xỉ, lâu đời, nổi tiếng và uy tín bậc nhất trong những thương hiệu đồng hồ Thụy Sĩ.", Price = 4000, CategoryId = 2 },
            new Product { Id = 7, Name = "Đồng hồ Nam Omega Seamaster 210.90.42.20.01.001 Diver 300M 007 Edition", Description = "Giống hệt chiếc đồng hồ của 007 trong No Time To Die, chiếc Seamaster 42mm này được làm bằng Titanium Cấp 2 chắc chắn nhưng nhẹ, có vòng bezel và mặt số bằng nhôm nhiệt đới màu nâu.", Price = 3500, CategoryId = 2 },
            new Product { Id = 8, Name = "Đồng hồ Omega Seamaster Aqua Terra Co-Axial Day Date", Description = "Đồng hồ Omega 231.53.42.22.02.001 là một tác phẩm nghệ thuật thời gian đích thực, kết hợp hoàn hảo giữa công nghệ tiên tiến và sự tinh tế của thiết kế. Được tạo ra bởi hãng đồng hồ danh tiếng Omega, chiếc đồng hồ này thể hiện sự chính xác, đẳng cấp và đẹp mắt của một sản phẩm cao cấp.", Price = 6500, CategoryId = 2 },
            new Product { Id = 9, Name = "Hublot 582.NX.1170.RX.1704", Description = "Đồng Hồ Hublot Classic Fusion 582.NX.1170.RX.1704 gây thương nhớ cho người đối diện với mặt số đen bí ẩn và đẳng cấp cùng với những viên kim cương lấp lánh được đính trên vỏ và vành bezel. Sản phẩm được làm từ titanium, hoạt động chính xác với bộ máy lên cót tự động Cal Hub1120. Cùng Gia Bảo Luxury tìm hiểu thêm về chiếc đồng hồ này.", Price = 2000, CategoryId = 3 },
            new Product { Id = 10, Name = "Hublot 542.OX.1181.LR", Description = "Với thương hiệu Hublot, dòng sản phẩm Classic Fusion là những thiết kế dễ tiếp cận nhất, với mức giá cực kỳ hợp lý. Với những phiên bản vàng khối như chiếc Hublot Classic Fusion 542.OX.1181.LR, mức giá cũng không bị đẩy lên quá cao.", Price = 7000, CategoryId = 3 },
            new Product { Id = 11, Name = "Đồng hồ Hublot Spirit of Big Bang King Gold Rainbow 641.OX.0110.LR.0999", Description = "Spirit of Big Bang là một trong những bộ sưu tập đồng hồ đình đám, nổi tiếng nhất của Hublot. Được ra mắt vào lần đầu vào năm 2014, Spirit of Big Bang đã mang đến không ít sự bất ngờ của người chơi đồng hồ với một thiết kế có bộ vỏ tonneau hình thùng vô cùng mới lạ.", Price = 100000, CategoryId = 3 },
            new Product { Id = 12, Name = "Đồng hồ Hublot Classic Fusion Takashi Murakami Sapphire Rainbow 507.JX.0800.RT.TAK21 507JX0800RTTAK21", Description = "Đồng hồ Hublot Classic Fusion Takashi Murakami Sapphire Rainbow 507.JX.0800.RT.TAK21 507JX0800RTTAK21 là mẫu đồng hồ đến từ thương hiệu Hublot, có kích cỡ mặt số 45 mm dành cho các quý ông lịch lãm. Chiếc đồng hồ sử dụng bộ máy tự động có xuất xứ Thụy Sĩ, đồng hồ có thể vận hành trong thời gian dài, có độ bền và giá trị sưu tầm cao. Chất liệu kính làm từ Sapphire đem lại khả năng chống xước, chống lóa tuyệt vời. Đồng hồ được trang bị dây cao su bền bỉ, trẻ trung năng động. Chất liệu kính làm từ Sapphire đem lại khả năng chống xước, chống lóa tuyệt vời.", Price = 93000, CategoryId = 3 });
        }
    }
}
