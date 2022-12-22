using System;

public class Auto
{
	public string Marca { get; set; }
	public string Modelo { get; set; }
	public string Color { get; set; }

	public Auto()
	{
	}
	public Auto(string marca, string modelo, string color)
    {
		Marca = marca;
		Modelo = modelo;
		Color = color;
    }

	public string EncenderApagar(bool enciende = false)
    {
		string msg;
		if (enciende == true)
        {
			msg = "Motor encendido";
        }
        else
        {
			msg = "Motor apagado";
		}
		return msg;
    }
}
