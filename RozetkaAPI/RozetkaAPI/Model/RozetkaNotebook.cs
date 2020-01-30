using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RozetkaAPI.Model
{
    public class RozetkaNotebook
    {
        [Key]
        public int NotebookID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string NotebookManufacture { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string NotebookName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string NotebookSeries { get; set; }
        [Required]
        public int NotebookPrice { get; set; }
        [Required]
        [Column(TypeName = "float")]
        public double NotebookScreenDiagonal { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string NotebookScreenResolution { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string NotebookProcessor { get; set; }
        [Required]
        public int NotebookRAM { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string NotebookStorage { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string NotebookVideoCard { get; set; }
        [Required]
        [Column(TypeName = "float")]
        public double NotebookWeight { get; set; }
    }
}
