using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class WorkerValidator:AbstractValidator<Worker>
    {

        public WorkerValidator()
        {
            RuleFor(w => w.DepartmantName).NotEmpty();
            RuleFor(w => w.DepartmantCode).NotEmpty();
            RuleFor(w => w.EmailAdress).NotEmpty();
            RuleFor(w => w.Gender).NotEmpty();
            RuleFor(w => w.Name).NotEmpty();
            RuleFor(w => w.Surname).NotEmpty();
            RuleFor(w => w.TitleCode).NotEmpty();
            RuleFor(w => w.TitleName).NotEmpty();
            RuleFor(w => w.StartDateOfWork).NotEmpty();

            RuleFor(w => w.EmailAdress).EmailAddress();

            RuleFor(w => w.StartDateOfWork).LessThanOrEqualTo(DateTime.Now).WithMessage("Seçilen tarih, gün tarihinden ileri olamaz");
            RuleFor(w => w.EmailAdress.Length).LessThan(200);
            RuleFor(w => w.TitleName.Length).LessThan(50);
            RuleFor(w => w.DepartmantName.Length).LessThan(50);
            RuleFor(w => w.Name.Length).LessThan(50);
            RuleFor(w => w.Surname.Length).LessThan(50);
        }
    }
}
