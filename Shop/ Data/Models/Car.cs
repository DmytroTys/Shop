using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shop.Data.Models
{
    public class Car
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int id { get; set; }

        [DataType(DataType.Text)] [Required]

        public string name { get; set; }

        public string shortDisc { get; set; }

        public string longDisc { get; set; }

        public string img { get; set; }

        [Required]
        public ushort price { get; set; }

        public bool isFavorite { get; set; }

        public bool available { get; set; }

        public int categoryId { get; set; }

        public virtual Category Category { get; set; }

        public Car()
        {
        }
    }
}
