using System;

public class Cuadrado
{
	public float Lado { get; set; }
	public Cuadrado()
	{
	}

    public Cuadrado(float lado)
    {
        Lado = lado;
    }

    public float Area()
    {
        return Lado * Lado;
    }
 }
