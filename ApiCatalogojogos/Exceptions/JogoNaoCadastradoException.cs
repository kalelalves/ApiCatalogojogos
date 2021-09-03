using System;

namespace ApiCatalogojogos.Exceptions
{
    public class JogoNaoCadastradoException: Exception
    {
        public JogoNaoCadastradoException()
            :base("Este jogo não está cadastrado")
        {}
    }
}
