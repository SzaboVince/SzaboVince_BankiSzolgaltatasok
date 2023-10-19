using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
	public class MegtakaritasiSzamla:Szamla
	{
		private static double alapKamat=1.1;
		private double kamat;

		public double Kamat { get => kamat; set => kamat = value; }

		public MegtakaritasiSzamla(Tulajdonos tulajdonos):base(tulajdonos)
		{
			kamat= alapKamat;
		}

		public override bool Kivesz(int osszeg)
		{
			if (AktualisEgyenleg - osszeg >= 0)
			{
				return true;
			}
			return false;
		}
		public void KamatJovairas()
		{
			AktualisEgyenleg += Convert.ToInt32(Convert.ToDouble(AktualisEgyenleg) * Kamat);
		}
	}
}
