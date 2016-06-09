using System;

namespace L2C.Exemplos.DotNet.ModificadoresAcesso.Exp.Public
{
    public class ExemploClassePublica
    {
        public Guid id { get; set; }
        public string nome { get; set; }

        public ExemploClassePublica()
        {
            id = Guid.NewGuid();
        }

        public bool NomePossuiValor()
        {
            return string.IsNullOrEmpty(this.nome);
        }
    }
}