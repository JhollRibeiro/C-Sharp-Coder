using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.C_ClassesEMetodos
{
    class MetodosEstaticos
    {
        public class CalculadoraEstatica
        {
            // Método de Classe ou Método estático!!!
            public static int Multiplicar(int a, int b)
            {
                return a * b;
            }

            // Método de instância!!!
            public int Somar(int a, int b)
            {
                return a + b;
            }
        }
        public static void Executar()
        {
            /*
             * MÉTODOS ESTÁTICOS *
             * A diferença entre um método Estático e um método não Estático
             * é que o Estático só pode ser acessado somente a partir Classe, dessa forma: 
             * 'NomeDaClasse.NomeDoMetotdo()',
             * ou seja, esse método pertence à Classe não ao Objeto.
             * 
             * Já no método não estático, é preciso instanciar um Objeto dessa forma:
             * 'var nomoDoObjeto = new NomeDaClasse()'
             * para poder acessar os MEMBROS da Classe, dessa forma:
             * 'nomoDoObjeto.NomeDoMetotdo()', neste caso o Método pertence ao Objeto e não à Classe.
             * 
             * Finalizando, 
             * um método que pertece à Classe não é acessivel a partir de um Objeto e 
             * um método que pertece ao Objeto não é acessivel a partir da Classe.
             */

            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));
        }
    }
}
