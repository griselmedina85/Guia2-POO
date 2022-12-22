using Guia2_POO;
using System;

public class Pet
{
	public string Name { get; set; }
	public TypePetEnum Type { get; set; }
	public int Energy { get; set; }
	public Pet()
	{
	}
	public string FeedPet()
    {
		Energy += 30;
		return Name+" ha incrementado su energía 30%";
    }

}
