using System;

namespace L2C.Exemplos.DotNet.ModificadoresAcesso.Exp.Protected
{
    public class ExemploClasseProtected
    {
        protected Guid id { get; set; }
        protected string nome { get; set; }

        protected ExemploClasseProtected()
        {
            id = Guid.NewGuid();
        }

        public string ObterNome()
        {
            return nome;
        }
    }
}