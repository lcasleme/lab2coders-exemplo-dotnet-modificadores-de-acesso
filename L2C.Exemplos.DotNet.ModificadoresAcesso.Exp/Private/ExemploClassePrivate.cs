using System;

namespace L2C.Exemplos.DotNet.ModificadoresAcesso.Exp.Private
{
    public class ExemploClassePrivate
    {
        private Guid id { get; set; }
        private string nome { get; set; }

        private ExemploClassePrivate()
        {
            id = Guid.NewGuid();
        }

        private string ObterNome()
        {
            return nome;
        }
    }
}