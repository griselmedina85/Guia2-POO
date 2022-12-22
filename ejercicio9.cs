using System;

public class AutoEj9
{
	public string Marca { get; set; }
	public string Modelo { get; set; }
	public string Color { get; set; }
	public bool Encendido { get; set; }
	
	private int _velocidad;
	
	public int GetVelocidad()
	{
		return _velocidad;
	}

	public void SetEdad(int value)
	{
		_velocidad = value;
	}

	public AutoEj9()
	{
	}
	public AutoEj9(string marca, string modelo, string color, bool enciende)
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
			Encendido = true;
			msg = "Motor encendido";
		}
		else
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
