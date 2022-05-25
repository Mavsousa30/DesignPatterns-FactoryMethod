using System;
using Factory_Method.Interfaces;

namespace Factory_Method.Implementation
{
	public class SubZero : IPersonagem
	{
		public SubZero()
		{
		}

        public void Escolhido()
        {
            Console.Write("SubZero");
        }
    }
}

