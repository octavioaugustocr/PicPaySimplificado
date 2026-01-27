using FluentValidation;

namespace PicPaySimplificado.Application.SharedValidators
{
    public static class ValidatorsExtensions
    {
        public static IRuleBuilderOptions<T, string> PasswordIsValid<T>(this IRuleBuilder<T, string> ruleBuilder) => ruleBuilder.SetValidator(new PasswordValidator<T>());
    }
}
