using System;
using System.Data.Entity;

namespace healthfullEating
{
	public class PanFresh
	{
		public int ID { get; set; }
		public int RecipeID { get; set; }
		public string PanFreshName { get; set; }
		public string PanFreshAmt { get; set; }
		public string PanFreshPrep { get; set; }
		public string PanFreshSpecial { get; set; }

        public virtual Recipe Recipe { get; set; }

		public PanFresh (string Name, string Amount, string Prep, string Special)
		{
            this.PanFreshName = Name;
            this.PanFreshAmt = Amount;
            this.PanFreshPrep = Prep;
            this.PanFreshSpecial = Special;

		}
	}

}

