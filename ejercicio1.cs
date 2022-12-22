using System;

public class Guia1
{
    //propertys
    public int Valor { get; set; }
    public string Nombre1 { get; set; }
    public int Edad1 { get; set; }
    public string Nombre2 { get; set; }
    public int Edad2 { get; set; }

    public Guia1()
	{
	}

	public Guia1(int valor, string? nombre1, int? edad1, string? nombre2, int? edad2)
    {
		Valor = valor;
        Nombre1 = nombre1;
        Edad1 = (int)edad1;
        Edad2 = (int)edad2;
        Nombre2 = nombre2;


    }

	public string EsMayorA100()
    {
		if (Valor > 100)
        {
            return "El valor es mayor que 100";
        }
        else
        {
            return "El valor no es mayor que 100";
        }
    }
    public string EsParOImpar()
    {
        if ((Valor % 2) == 0)
            return "ES PAR";
        else
            return "ES IMPAR";
    }
    public string EsDobleDeUnImpar()
    {
        var cociente = Valor / 2;
        if ((cociente % 2) == 0)
            return "No es doble de un impar";
        else
           return "Es doble de un impar";
    }
    public string NumeroRomano()
    {
        string msg;
        switch (Valor)
        {         
            case 1:
                msg = "Su correspondiente número romano es: I";
                break;
            case 2:
                msg = "Su correspondiente número romano es: II";
                break;
            case 3:
                msg = "Su correspondiente número romano es: III";
                break;
            case 4:
                msg = "Su correspondiente número romano es: IV";
                break;
            case 5:
                msg = "Su correspondiente número romano es: V";
                break;
            case 6:
                msg = "Su correspondiente número romano es: VI";
                break;
            case 7:
                msg = "Su correspondiente número romano es: VII";
                break;
            case 8:
                msg = "Su correspondiente número romano es: VIII";
                break;
            case 9:
                msg = "Su correspondiente número romano es: IX";
                break;
            case 10:
                msg = "Su correspondiente número romano es: X";
                break;
            default:
                msg = "Ingrese un valor dentro del rango 1 al 10";
                break;
        }
        return msg;
    }
    public string PersonaMenor()
    {
        string msg;
        if (Edad1 == Edad2)
        {
             msg = Nombre1 + " y " + Nombre2 + " tienen la misma edad.";
        }
        else if (Edad1 < Edad2)
        {
            msg = "La persona de menor edad es: " + Nombre1 + ". Con una diferencia de " + (Edad2 - Edad1) + " años.";
        }
        else
        {
            msg = "La persona de menor edad es: " + Nombre2 + ". Con una diferencia de " + (Edad1 - Edad2) + " años.";
        }
        return msg;
    }
    
    public string DesgloseBilletes()
    {
        var cadena = "";
        var billetes_de_1 = Valor;
        var billetes_de_mil = (billetes_de_1 - billetes_de_1 % 1000) / 1000; 
        billetes_de_1 = billetes_de_1 % 1000; //723 
        var billetes_de_quinientos = (billetes_de_1 - billetes_de_1 % 500) / 500; 
        billetes_de_1 = billetes_de_1 % 500;//223
        var billetes_de_doscientos = (billetes_de_1 - billetes_de_1 % 200) / 200; 
        billetes_de_1 = billetes_de_1 % 200;//23
        var billetes_de_cien = (billetes_de_1 - billetes_de_1 % 100) / 100;
        billetes_de_1 = billetes_de_1 % 100;//
        var billetes_de_cincuenta = (billetes_de_1 - billetes_de_1 % 50) / 50;
        billetes_de_1 = billetes_de_1 % 50;
        var billetes_de_veinte = (billetes_de_1 - billetes_de_1 % 20) / 20;
        billetes_de_1 = billetes_de_1 % 20;
        var billetes_de_diez = (billetes_de_1 - billetes_de_1 % 10) / 10;
        billetes_de_1 = billetes_de_1 % 10;
        var monedas_de_cinco = (billetes_de_1 - billetes_de_1 % 5) / 5;
        billetes_de_1 = billetes_de_1 % 5;
        var monedas_de_dos = (billetes_de_1 - billetes_de_1 % 2) / 2;
        billetes_de_1 = billetes_de_1 % 2;
        var monedas_de_uno = (billetes_de_1 - billetes_de_1 % 1) / 1;

        if (billetes_de_mil != 0)
            cadena += billetes_de_mil + " billete/s de 1000";
        if (billetes_de_quinientos != 0)
            cadena += ", " + billetes_de_quinientos + " billete/s de 500";
        if (billetes_de_doscientos != 0)
            cadena += ", " + billetes_de_doscientos + " billete/s de 200";
        if (billetes_de_cien != 0)
            cadena += ", " + billetes_de_cien + " ,billete/s de 100";
        if (billetes_de_cincuenta != 0)
            cadena += ", " + billetes_de_cincuenta + " billete/s de 50";
        if (billetes_de_veinte != 0)
            cadena += ", " + billetes_de_veinte + " billete/s de 20";
        if (billetes_de_diez != 0)
            cadena += ", " + billetes_de_diez + " billete/s de 10";
        if (monedas_de_cinco != 0)
            cadena += ", " + monedas_de_cinco + " moneda/s de 5";
        if (monedas_de_dos != 0)
            cadena += ", " + monedas_de_dos + " moneda/s de 2";
        if (monedas_de_uno != 0)
            cadena += ", " + monedas_de_uno + " moneda/s de 1.";

        return cadena;
    }

    

}
