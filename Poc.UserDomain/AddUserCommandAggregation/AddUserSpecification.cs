using FluentValidation;

namespace Poc.UserDomain.AddUserCommandAggregation
{
    public class AddUserSpecification : AbstractValidator<AddUserDto>
    {
        public AddUserSpecification()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please specify a name");
        }
    }
}
