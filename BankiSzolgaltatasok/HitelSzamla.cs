using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
	public class HitelSzamla:Szamla
	{
		private int hitelkeret;

		public HitelSzamla(Tulajdonos tulajdonos, int hitelkeret) : base(tulajdonos)
		{
			this.hitelkeret = hitelkeret;
		}

		public int HitelKeret { get => hitelkeret; set => hitelkeret = value; }

		public override bool Kivesz(int osszeg)
		{
			if (AktualisEgyenleg - osszeg >= -Hitelkeret)
			{
				return true;
			}
			return false;
		}
	}
}
