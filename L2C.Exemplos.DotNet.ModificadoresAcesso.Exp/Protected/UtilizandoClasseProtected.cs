using System;

namespace L2C.Exemplos.DotNet.ModificadoresAcesso.Exp.Protected
{
    public class UtilizandoClasseProtected : ExemploClasseProtected
    {
        public Guid idNome { get; set; }

        public void ObtemNome()
        {
            string nome = base.ObterNome();
        }

        public void PreencherNome()
        {
            base.nome = "Lucas Leme";
            idNome = base.id;
        }
    }
}