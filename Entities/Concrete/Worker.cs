using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Worker: EntityBase, IEntity
    {
        [Key]
        public int RecordNumber { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public string Surname { get; set; }
        [Required]
        public DateTime StartDateOfWork { get; set; }
        public DateTime DismissalDate { get; set; }
        [Required]
        public int DepartmantCode { get; set; }
        [Required, MaxLength(50)]
        public string DepartmantName { get; set; }
        [Required, MaxLength(5)]
        public string Gender { get; set; }
        [Required]
        public string MobilePhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        [Required]
        public int TitleCode { get; set; }
        [Required, MaxLength(50)]
        public string TitleName { get; set; }
        [Required, MaxLength(200)]
        public string EmailAdress { get; set; }


    }
}
