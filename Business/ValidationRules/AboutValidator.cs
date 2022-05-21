using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("En az 50 karakter gereklidir.");
            RuleFor(x => x.ImageOne).NotEmpty().WithMessage("Resim1 alanı boş geçilemez");
        }
    }
}
