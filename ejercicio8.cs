using System;

public class Smartphone
{
	public string Make { get; set; }
	public string Model { get; set; }  
    public int Volume { get; set; }
    public int Brightness { get; set; }

	public Smartphone()
	{
	}

	public Smartphone(string marca, string modelo, int volumeninicial=50, int brilloinicial=50)
    {
		Make = marca;
		Model = modelo;
        Volume = volumeninicial;
        Brightness = brilloinicial;
    }
	public bool OnOff(bool state)
    {
        if (state)
        {
			return false; //se apaga
        }
        else
        {
            return true; //se enciende
        }
    }
    public int UpDownVolume(string vol)
    {
        if(vol == "sube")
        {
            if (Volume < 100)
            {
                Volume += 10;
            }
        }else if(Volume != 0)
        {
            Volume -= 10;
        }
        return Volume; 
    }
    public bool Silence()
    {
        Volume = 0;
        return true;
    }
    public int BrightnessLevel(string brillo)
    {
        if (brillo == "sube")
        {
            if (Brightness < 100)
            {
                Brightness += 1;
            }
        }
        else if (Brightness != 0)
        {
            Brightness -= 1;
        }
        return Brightness;
    }
}
