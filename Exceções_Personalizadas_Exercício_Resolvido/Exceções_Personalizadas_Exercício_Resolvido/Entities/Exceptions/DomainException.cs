using System;

namespace Exceções_Personalizadas_Exercício_Resolvido.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }

    }
}
