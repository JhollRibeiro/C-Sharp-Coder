using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
	class Aviao : Veiculo
	{
		private string prefixo;

		public string Prefixo 
		{
			get { return prefixo; }
			set { prefixo = value; }
		}

		public Aviao(string fab, 
					 string mod,
					 string cor,
					 string prefixo) : base(fab, mod, cor)
		{
			this.prefixo = prefixo;
		}
		
	}
}
