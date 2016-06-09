using L2C.Exemplos.DotNet.ModificadoresAcesso.Exp.Internal;
using System;

namespace Novo.Namespace
{
    public class UtilizandoClasseProtectedInternal : ExemploClasseInternal
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