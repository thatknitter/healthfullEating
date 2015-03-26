using System;
using System.Data.Entity;

namespace healthfullEating
{
	public class Direction
	{
		public int ID { get; set; }
		public int RecipeID { get; set; }
		public string Info { get; set; }

        public virtual Recipe Recipe { get; set; }

		public Direction (string Dir)
		{
            this.Info = Dir;
		}
	}
}

