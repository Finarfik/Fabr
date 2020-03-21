namespace Фбрк
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Фурнитура
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Артикул { get; set; }

        [Required]
        [StringLength(100)]
        public string Наименование { get; set; }

        [StringLength(50)]
        public string Ширина { get; set; }

        [StringLength(50)]
        public string Длина { get; set; }

        [Required]
        [StringLength(50)]
        public string Тип { get; set; }

        [Required]
        [StringLength(50)]
        public string Цена { get; set; }

        [Required]
        [StringLength(50)]
        public string Вес { get; set; }
    }
}
