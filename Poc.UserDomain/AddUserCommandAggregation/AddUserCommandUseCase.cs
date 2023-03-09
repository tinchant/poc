namespace Poc.UserDomain.AddUserCommandAggregation
{
    public class AddUserCommandUseCase
    {
        private readonly AddUserSpecification specification;

        public IAddUserOutputPort? OutputPort { get; private set; }

        public void SetOutputPort(IAddUserOutputPort port)
        { this.OutputPort = port; }

        public Task Exec(AddUserDto dto)
        {
            try
            {            
                var validationResult = specification.Validate(dto);
                if (validationResult.IsValid)
                {
                    var entity = new User(dto);
                    //Aqui teria a interação com o repositorio que abstrai momentaneamente
                    OutputPort?.OnSuccess();
                }
                else 
                {
                    OutputPort?.OnFailure(validationResult.ToString());
                }
            }
            catch (Exception e)
            {
                OutputPort?.OnError(e);
            }
            return Task.CompletedTask;
        }

        public AddUserCommandUseCase(AddUserSpecification specification)
        {
            this.specification = specification;
            //Aqui normalmente receberia o repositorio tbm mas estou abstraindo pro simplificar o exemplo
        }
    }
}
