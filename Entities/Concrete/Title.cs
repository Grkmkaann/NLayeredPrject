using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Title: IEntity
    {
        [Required]
        public int Code { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }

    }
}
