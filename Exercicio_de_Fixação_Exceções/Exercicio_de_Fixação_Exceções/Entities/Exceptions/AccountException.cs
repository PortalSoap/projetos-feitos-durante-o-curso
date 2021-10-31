using System;

namespace Exercicio_de_Fixação_Exceções.Entities.Exceptions
{
    class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message)
        {
        }
    }
}
