using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef {
    [Table("product")]
    public class Product {
        [Key]
        public int ProductID {get;set;}
        [Required]
        [StringLength(50)]
        public string ProductName {get; set;}
        [StringLength(50)]
        public string Provider {get; set;}
    }
}