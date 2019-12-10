using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOCADORA_RA32163
{
	class Program
	{
		static void Main(string[] args)
		{

			Fabricante fabricante1 = new Fabricante(035, "Fiat", "11.111.111/1111-11"); 
			Fabricante fabricante2 = new Fabricante(040, "Ford", "22.222.222/2222-22");

			Motor motor1 = new Motor(935871, 1.0f, "flex");
			Motor motor2 = new Motor(024851, 2.0f, "flex");

			Carro carro1Fab1 = new Carro("DAL-7453", fabricante1, motor1, "Palio", 49f);
			Carro carro2Fab1 = new Carro("CSW-8753", fabricante1, motor1, "Uno", 39f);

			Carro carro1Fab2 = new Carro("DBM-8547", fabricante2, motor2, "Focus", 67f);
			Carro carro2Fab2 = new Carro("DBN-2145", fabricante2, motor2, "Fusion", 109f);

			carro1Fab1.Acelerar(80);

			carro1Fab2.Acelerar(100);

			carro1Fab1.Exibe();
			carro2Fab1.Exibe();

			carro1Fab2.Exibe();
			carro2Fab2.Exibe();

			Cliente euAluno = new Cliente(000000, "Vinicius Garcia", "380.668.412-21","49.352.215-5", 150000f);
			Cliente eleProfessor = new Cliente(1, "Henrique Poyatos", "008.000.015-00", "00.000.000-1", 500f);

			Locacao locUm = new Locacao(00389, euAluno, carro1Fab1);
			Locacao locDois = new Locacao(00390, euAluno, carro2Fab1);

			Locacao locTres = new Locacao(00391, eleProfessor, carro1Fab2);
			Locacao locQuatro = new Locacao(00392, eleProfessor, carro2Fab2);

			locUm.Exibe();
			locDois.Exibe();

			locTres.Exibe();
			locQuatro.Exibe();

			// Validação dos método Verificamotor da classe Carro. // EXTRA, não era necessário
			Console.WriteLine("------------------");
			Console.WriteLine("validações metodos");
			Console.WriteLine("------------------");
			Console.WriteLine("O carro1Fab1 tem o motor2? Resposta: {0}",carro1Fab1.VerificaMotor(motor2));
			Console.WriteLine("O carro1Fab1 tem o motor1? Resposta: {0}", carro1Fab1.VerificaMotor(motor1));
			
			Console.ReadKey();


		}
	}
}
