/* ejercicio 1*/
Guia1 miguia = new Guia1();
miguia.Valor = 1500;
Console.WriteLine(miguia.DesgloseBilletes());
Console.WriteLine(miguia.NumeroRomano());
Console.WriteLine(miguia.EsParOImpar());

/* ejercicio 2 */
Console.WriteLine("Ingrese lado: ");
float a;
var lado = Console.ReadLine();
float.TryParse(lado, out a);
Cuadrado cuadrado = new Cuadrado();
cuadrado.Lado = a;
Console.WriteLine("El área del cuadrado es: "+ cuadrado.Area());//no imprime correctamente decimal

/* ejercicio 3*/
var nuevaPersona = new Persona("Griselda", "Medina");
Console.WriteLine(nuevaPersona.FullName());

/*ejercicio 4 */
string edad = "22/09/1986";
var otraPersona = new PersonaEj4("Romina", "Medina", DateTime.ParseExact(edad, "dd/MM/yyyy", null));
var age = otraPersona.CalculateAge();
if ( age == -1)
{
    Console.WriteLine("Error en los datos");
}else 
{ 
    Console.WriteLine("La persona tiene "+ age+ "años");
};

