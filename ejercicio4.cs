using System;

public class PersonaEj4
{
	public string Name { get; set; }
	public string LastName { get; set; }
	public DateTime BirthDay { get; set; }
	public PersonaEj4()
	{
	}
	public PersonaEj4(string name, string lastname, DateTime birthday)
	{
		Name = name;
		LastName = lastname;
		BirthDay = birthday;
	}
	public string FullName()
	{
		return Name + " " + LastName;
	}
	public int CalculateAge()
    {
		DateTime moment = DateTime.Today;
		if (BirthDay > moment)
        {
			return -1;
        }
        else
        {
			int age = moment.Year - BirthDay.Year;

			// Comprueba que el mes de la fecha de nacimiento es mayor 
			// que el mes de la fecha actual:
			if (BirthDay.Month > moment.Month)
			{
				--age;
			}

			return age;
		}

	}
}