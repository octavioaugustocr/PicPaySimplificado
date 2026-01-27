using FluentValidation;
using FluentValidation.Validators;
using PicPaySimplificado.Exceptions;

namespace PicPaySimplificado.Application.SharedValidators
{
    public class PasswordValidator<T> : PropertyValidator<T, string>
    {
        public override string Name => "PasswordValidator";

        public override bool IsValid(ValidationContext<T> context, string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                context.MessageFormatter.AppendArgument("ErrorMessage", ResourceMessagesException.PASSWORD_EMPTY);

                return false;
            }

            if (password.Length < 8)
            {
                context.MessageFormatter.AppendArgument("ErrorMessage", ResourceMessagesException.INVALID_PASSWORD);

                return false;
            }

            return true;
        }

        protected override string GetDefaultMessageTemplate(string errorCode) => "{ErrorMessage}";
    }
}
