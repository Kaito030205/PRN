using Microsoft.Extensions.Configuration;

namespace Demo03_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ĐỌC FILE .JSON
            // 1. TẠO FILE .JSOM
            // 2. CÀI THƯ VIỆN/PACKAGE
            // Microsoft.Extensions.Configuration.Json
            // 3. CẤU HÌNH
            IConfiguration config =
                new ConfigurationBuilder()
                // CHỈ RÕ THƯ MỤC ĐANG LÀM VIỆC
                .SetBasePath(AppContext.BaseDirectory)
                // THÊM FILE JSON VÀO CẤU HÌNH
                .AddJsonFile("data.json", false, true)
                // BUILD CẤU HÌNH
                .Build();
            Console.WriteLine(config["key3:key4"]);


        }
    }

}

//namespace Demo03_2
//    {
//        internal class Program
//        {
//            static void Main(string[] args)
//            {
//                // GENERIC COLLECTIONS
//                List<int> numbers = new() { 1, 2, 3, 4, 5, -7, 9 };

//                //var evennumbers = new List<int>();

//                //foreach(var number in numbers)
//                //{
//                //    if(number % 2==0)
//                //    {
//                //        evennumbers.Add(number);
//                //    }
//                //}


//                // LINQ: LANGUAGE INTEGRATED QUERY
//                // HỖ TRỢ TRUY VẤN DỮ LIỆU TRỰC TIẾP TRONG C#
//                // DBI: .sql: SELECT * FROM numbers WHERE number % 2 == 0
//                // -LINQ  TO OBJECTS: TRUY VẤN TRỰC TIẾP TRÊN CÁC COLLECTIONS
//                // -LINQ TO SQL: TRUY VẤN TRỰC TIẾP TRÊN CÁC DATABASE
//                // -LINQ TO XML: TRUY VẤN TRỰC TIẾP TRÊN CÁC FILE XML
//                // -LINQ TO JSON
//                // CÁCH SỬ DỤNG : QUERY SYNTAX
//                // from <BIẾN ĐẠI DIỆN> IN <COLLECTION>
//                // where <ĐIỀU KIỆN> select <GIÁ TRỊ TRẢ VỀ>...;
//                // LẤY RA CÁC SỐ CHẴN


//                var evennumbers = from num in numbers
//                                  where num % 2 == 0
//                                  select num;
//                Console.WriteLine(string.Join(", ", evennumbers));

//                // CÁCH 2: METHOD SYNTAX ( EXTENSION METHOD)
//                // VD: WHERE(), FIRST(DK), MAX(), MIN(), AVERAGE(), SUM()
//                // COUNT, SUM, ...
//                // LẤY RA CÁC SỐ LẺ
//                // PASS DELEGEATE AS PARAMETER
//                // ANONYMOUS METHOD

//                var oddnumbers = numbers.Where(x => x % 2 != 0 && x > 0);
//                // LẤY CÁC SỐ X % 2 != 0 (SỐ LẺ ) VÀ LỚN HƠN 0
//                Console.WriteLine(string.Join(", ", oddnumbers));
//                //LẤY RA 2 SỐ ĐẦU TIÊN
//                var first2 = numbers.First(x => x == 2);
//                Console.WriteLine(string.Join(", ", first2));
//                // FIRST, FIRSTOFDEFAULT GIỐNG NHAU
//                // NẾU TÌM THẤY
//                // NGƯỢC LẠI
//                // FIRST: BÁO LỖI
//                // FIRST OF DEFAULT: TRẢ VỀ GIÁ TRỊ MẶC ĐỊNH (0, NULL, FALSE, ...)
//                // int, double, float: 0
//                //string, [], Employee ...: NULL
//                // ORDERBY: SẮP XẾP
//                // DISTINCT: LOẠI BỎ PHẦN TỬ TRÙNG
//                var distinctNumbers = numbers
//                                    .OrderBy(x => x)
//                                    .Distinct();
//                Console.WriteLine(string.Join(", ", distinctNumbers));
//            }

//        }
//    }
