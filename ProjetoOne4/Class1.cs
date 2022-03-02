using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;

namespace ProjetoOne4
{
    public class Class1 : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        [Description("Insira o Primeiro Número")]
        public InArgument<Double> PrimeiroNumero { get; set; }

        [Category("Input")]
        [RequiredArgument]
        [Description("Insira o Segundo Número")]
        public InArgument<Double> SegundoNumero { get; set; }

        [Category("Output")]
        public OutArgument<Double> Resultado { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var primeiroNumero = PrimeiroNumero.Get(context);
            var segundoNumero = SegundoNumero.Get(context);
            var resultado = primeiroNumero + segundoNumero;

            Resultado.Set(context, resultado);
        }
    }
}
