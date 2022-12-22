using System;

public class Persona
{
	public	string Name { get; set; }
	public string LastName { get; set; }
	public Persona()
	{
	}
	public Persona(string name, string lastname)
    {
		Name = name;
		LastName = lastname;
    }
	public string FullName()
    {
		return Name + " " + LastName ;
    }
}
