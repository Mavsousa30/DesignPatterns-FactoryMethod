using System;
using Factory_Method.Interfaces;

namespace Factory_Method.Implementation
{
	public class Scorpion : IPersonagem
	{
		public Scorpion()
		{
		}

        public void Escolhido()
        {
            Console.Write("Scorpion");
        }
    }
}

