using System.ComponentModel.DataAnnotations;
using System;

namespace MVCBook.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "标题")]
        public string Title { get; set; }

        [DataType(DataType.Date)]//仅显示日期，而非时间信息
        [Display(Name = "出版日期")]
        public DateTime PublicationDate { get; set; }
        [Display(Name = "作者")]
        public string Author { get; set; }
        [Display(Name = "价格")]
        public decimal Price { get; set; }
        [Display(Name = "类型")]
        public string Type { get; set; }
    }
}
