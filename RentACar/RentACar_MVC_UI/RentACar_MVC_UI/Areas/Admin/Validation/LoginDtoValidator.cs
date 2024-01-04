using FluentValidation;
using RentACar_MVC_UI.Models.Dtos;

namespace RentACar_MVC_UI.Areas.Admin.Validation
{
    public class LoginDtoValidator:AbstractValidator<LoginDto>
    {
        public LoginDtoValidator()
        {
            RuleFor(dto => dto.UserName).NotEmpty().WithMessage("Kullanıcı Adı Boş Bırakılamaz...").Length(5, 10).WithMessage("Kullanıcı Adı 5 ila 10 Karakter Arasında Olmalıdır...");
            RuleFor(dto => dto.Password).NotEmpty().WithMessage("Şifre Alanı Boş Bırakılamaz...").Length(5, 25).WithMessage("Şifre 5 ila 25 Karakter Arasında Olmalıdır...");
        }
    }
}
