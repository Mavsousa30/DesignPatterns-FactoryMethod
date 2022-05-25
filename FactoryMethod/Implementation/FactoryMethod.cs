using System;
using Factory_Method.Interfaces;

namespace Factory_Method.Implementation
{
	public class FactoryMethod
	{
        public IPersonagem Escolher_Personagem(string personagem)
        {
			switch (personagem)
            {
				case "Liu Kang": return new LiuKang();
				case "Scorpion": return new Scorpion();
				case "SubZero": return new SubZero();
				default: return null;
            }
        }
	}
}

