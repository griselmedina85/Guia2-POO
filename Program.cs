using Guia2_POO;

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
    Console.WriteLine("La persona tiene "+ age+ " años");
};

/*ejercicio 5*/
Auto miauto = new Auto("Chevrolet", "prisma", "blanco");
Console.WriteLine(miauto.EncenderApagar(true));

/*ejercicio 6*/
Pet mimascota = new Pet();
mimascota.Name = "Json";
mimascota.Type = TypePetEnum.Cat;
Console.WriteLine(mimascota.FeedPet());

/*ejercicio 7*/
PetEj7 miotramascota = new PetEj7();
miotramascota.Name = "Sheena";
miotramascota.Type = TypePetEnum.Dog;
miotramascota.Energy = 20;
Console.WriteLine(miotramascota.RunPet());
Console.WriteLine(miotramascota.FeedPet());

/*ejercicio 8*/
Smartphone mismartphone = new Smartphone("motorola", "g20", 50, 50);
var estado = mismartphone.OnOff(false);//envia estado actual, apagado-> enciende
if(estado)
{
    Console.WriteLine("Smartphone Encendido");
}
else
{
    Console.WriteLine("Smartphone apagado");
}
var brillo = mismartphone.BrightnessLevel("sube");
Console.WriteLine("Brillo de pantalla: "+brillo);

/*ejercicio 10*/
Smartphone mi_smartphone = new Smartphone() { Make = "motorola", Model = "g20", Volume = 50, Brightness = 50 };
string edad2 = "29/03/1985";
PersonaEj10 yo = new PersonaEj10("Griselda", "Medina", DateTime.ParseExact(edad2, "dd/MM/yyyy", null));
yo.Smartphone = mi_smartphone;




