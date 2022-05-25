using System;
using Factory_Method.Interfaces;

namespace Factory_Method.Implementation
{
	public class LiuKang : IPersonagem
	{
		public LiuKang()
		{
		}

        public void Escolhido()
        {
            Console.Write("Liu Kang");
        }
    }
}

