using Poc.UserDomain.AddUserCommandAggregation;

namespace Poc.UserDomain
{
    public class User
    {
        internal User()
        {
            
        }

        public User(AddUserDto dto)
        {
            Id = Guid.NewGuid();
            Name = dto.Name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }    
    }
}
