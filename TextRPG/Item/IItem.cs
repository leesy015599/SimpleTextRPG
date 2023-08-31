using System;
namespace TextRPG
{
	public interface IItem
	{
		public string Name { get; set; }

		public void Use(Warrior warrior);
	}
}

