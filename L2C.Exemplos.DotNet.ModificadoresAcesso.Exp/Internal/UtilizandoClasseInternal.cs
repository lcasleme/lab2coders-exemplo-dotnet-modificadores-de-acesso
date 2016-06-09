using System;

namespace L2C.Exemplos.DotNet.ModificadoresAcesso.Exp.Internal
{
    internal class UtilizandoClasseInternal : ExemploClasseInternal
    {
        public Guid idNome { get; set; }

        public void ObtemNome()
        {
            string nome = base.ObterNome();
            string nomeId = base.ObterNomeEId();
        }

        public void PreencherNome()
        {
            base.nome = "Lucas Leme";
            idNome = base.id;
        }
    }
}