using System;
using System.Collections.Generic;
using System.Text;

namespace Agencia
{
    class Cabanias
    {
		public double precioXDia { get; set; }
		public int habitaciones { get; set; }
		public int banos { get; set; }

		public Cabanias(double precXD, int hab, int ban)
		{
			precioXDia = precXD;
			habitaciones = hab;
			banos = ban;
		}

		public override string ToString()
		{
			return base.ToString() + ": " + precioXDia.ToString();
		}




	}
}
