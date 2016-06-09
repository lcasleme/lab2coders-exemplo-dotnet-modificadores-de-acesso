using System;

namespace L2C.Exemplos.DotNet.ModificadoresAcesso.Exp.Public
{
    public class UtilizandoClassePublica : ExemploClassePublica
    {
        public Guid idNome { get; set; }

        public void NomeNaoNulo()
        {
            ExemploClassePublica _classePublica = new ExemploClassePublica();

            bool possuiValor = _classePublica.NomePossuiValor();
        }

        public void PreencherNome()
        {
            base.nome = "Lucas Leme";
            idNome = base.id;
        }
    }
}