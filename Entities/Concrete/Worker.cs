using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Worker: IEntity
    {
        [Required]
        public int RecordNumber { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public string Surname { get; set; }
        [Required]
        public DateTime StartDateOfWork { get; set; }
        public DateTime DismissalDate { get; set; }
        [Required]
        public Int16 DepartmantCode { get; set; }
        [Required, MaxLength(50)]
        public string DepartmantName { get; set; }
        [Required]
        public Int16 MobilePhoneNumber { get; set; }
        public Int16 HomePhoneNumber { get; set; }
        [Required]
        public int TitleCode { get; set; }
        [Required, MaxLength(50)]
        public string TitleName { get; set; }
        [Required, MaxLength(200)]
        public string EmailAdress { get; set; }


    }
}
