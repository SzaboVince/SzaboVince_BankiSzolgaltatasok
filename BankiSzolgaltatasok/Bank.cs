using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
	public class Bank
	{
		private List<Szamla> szamlaLista;

		public long OsszHitelkeret { get => OsszHitelkeret; }

		public Bank()
		{
			this.szamlaLista = new List<Szamla>();
		}

		public Szamla SzamlaNyitas(Tulajdonos tulajdonos, int hitelkeret)
		{
			if (hitelkeret >= 0)
			{
				HitelSzamla ujszamla = new HitelSzamla(tulajdonos, hitelkeret);
				szamlaLista.Add(ujszamla);
				return ujszamla;
			}
			else
			{

			MegtakaritasiSzamla ujszamla = new MegtakaritasiSzamla(tulajdonos);
			szamlaLista.Add(ujszamla);
			return ujszamla;
			}
		}

		public long GetOsszEgyenleg(Tulajdonos tulajdonos)
		{
			return szamlaLista.Where(s => s.Tulajdonos == tulajdonos).Sum(s => s.AktualisEgyenleg);
		}

		public Szamla GetLegnagyobbEgyenleguSzamla(Tulajdonos tulajdonos)
		{
			return szamlaLista.Where(s => s.Tulajdonos == tulajdonos).OrderByDescending(s => s.AktualisEgyenleg).FirstOrDefault();
		}


	}
}
