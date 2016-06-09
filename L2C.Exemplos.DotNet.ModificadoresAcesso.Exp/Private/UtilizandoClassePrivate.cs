using System;

namespace L2C.Exemplos.DotNet.ModificadoresAcesso.Exp.Private
{
    public class UtilizandoClassePrivate : ExemploClassePrivate //Não é possível Herdar a classe
    {
        public Guid idNome { get; set; }

        public void ObterNome()
        {
            ExemploClassePrivate _classePrivate = new ExemploClassePrivate(); //Não é possível Instanciar a classe

            string nome = _classePrivate.ObterNome();//Os métodos da classe não estão acessiveis
        }

        public void PreencherNome()
        {
            base.nome = "Lucas Leme";//As propriedades da classe não estão acessíveis
            idNome = base.id;//As propriedades da classe não estão acessíveis
        }
    }
}