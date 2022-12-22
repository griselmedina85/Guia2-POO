using Guia2_POO;
using System;

public class PetEj7
{
	public string Name { get; set; }
	public TypePetEnum Type { get; set; }
	public int Energy { get; set; }
	public PetEj7()
	{
	}
	public string FeedPet()
	{
		Energy += 30;
		return Name + " ha incrementado su energía 30%, ahora posee "+Energy+"%";
	}

	public string RunPet()
    {
		string msg;
		Energy -= 10;
		if (Energy < 20)
        {
			msg = "Tu mascota "+Name+" ya no posee energía para ejercitarse, alimentalo";
        }
        else
        {
			msg = "Tu mascota " + Name + " le queda " + Energy + " % de energía.";

		}
		return msg;
    }
}
