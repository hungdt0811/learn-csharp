using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef {
    [Table("product")]
    public class Product {
        [Key]
        public int ProductID {get; set;}
        
        [Required]
        [StringLength(50)]
        [Column("Tên sản phẩm", TypeName = "ntext")]
        public string Name {get; set;}

        [Column("Giá", TypeName = "money")]
        public double Price {get; set;}

        public int CatID {get; set;}

        // Foreign Key
        [ForeignKey("CatID")]
        public Category Category {get; set;} // FK -> PK

        public void ShowInfo() {
            Console.WriteLine($"{ProductID} -- {Name} -- {Price}");
        } 
    }
}