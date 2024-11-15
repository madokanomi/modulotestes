using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTestes
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTestes()
        {
            _validacoes = new ValidacoesString();
        }

[Fact]
        public void DeveContar3aCaracteresEmOlaeRetornar3()
        {
            //Arrange
            string texto = "Ola";

            //act
            int resultado = _validacoes.ContarCaracteres(texto);

            //assert
            Assert.Equal(3, resultado);
        }

        

    }
}