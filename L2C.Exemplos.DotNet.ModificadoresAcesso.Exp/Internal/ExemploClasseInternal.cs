using System;

namespace L2C.Exemplos.DotNet.ModificadoresAcesso.Exp.Internal
{
    internal class ExemploClasseInternal
    {
        internal Guid id { get; set; }
        internal string nome { get; set; }

        internal ExemploClasseInternal()
        {
            id = Guid.NewGuid();
        }

        internal string ObterNome()
        {
            return nome;
        }

        protected internal string ObterNomeEId()
        {
            return string.Format("{0} - {1}", id.ToString(), nome);
        }
    }
}