using Journey.Communication.Requests;
using Journey.Exception.ExceptionsBase;

namespace Journey.Application.UseCases.Trip.Register
{
    public class RegisterTripUseCase
    {
        public void Execution(RequestRegisterTripJson request)
        {
            Validate(request);
        }

        private void Validate(RequestRegisterTripJson request)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
                throw new JourneyException("Nome incorreto");
            if(request.StartDate.Date < DateTime.UtcNow.Date)
                throw new JourneyException("Data da viagem deve ser maior que a data de Hoje!");
            if(request.EndDate.Date < request.StartDate.Date)
                throw new JourneyException("A viagem deve terminar apos a data de inicio!");
        }
    }
}
