using System;

public class AutoEj11
{
	public string Marca { get; set; }
	public string Modelo { get; set; }
	public string Color { get; set; }
	public bool Encendido { get; set; }
	public PersonaEj10 Persona { get; set; }

	private int _velocidad;

	public int GetVelocidad()
	{
		return _velocidad;
	}

	public void SetVelocidad(int value)
	{
		_velocidad = value;
	}

	public AutoEj11()
	{
	}
	public AutoEj11(string marca, string modelo, string color, bool enciende)
	{
		Marca = marca;
		Modelo = modelo;
		Color = color;
		Encendido = enciende;
	}

	public string EncenderApagar(bool enciende = false)
	{
		string msg;
		if (enciende)
		{
			if (Persona.Name != null && Persona.CalculateAge() > 18)
			{
				Encendido = true;
				msg = "Motor encendido";
			}
			else
			{
				msg = "No cumple las condiciones para encender el auto";
			}
		} else
			{
				Encendido = false;
				msg = "Motor apagado";
			}
		
		return msg;
	}

	public void Acelerar()
	{
		if (Encendido)
		{
			_velocidad += 10;
		}
	}
	public void Frenar()
	{
		if (Encendido)
		{
			_velocidad -= 20;
		}
	}

}
