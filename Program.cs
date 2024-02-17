using System;

	int n1=0, n2=0, x1=0, x2=0;
	int c1 = 0;
	string txt;
do{	
		Console.WriteLine("¿Que desea hacer?");
		Console.WriteLine("1.Conversion de Tipos \n2.Operaciones\n3.Manejo de Texto\n4.Calculos y Conversiones\n0.Salir");
		x1=Convert.ToUInt16(Console.ReadLine());

	switch (x1)
	{
		case 0:
			c1++;
			break;
		case 1:
			Console.WriteLine("¿Que tipo de numero desea ingresar?");
			Console.WriteLine("1.Entero\n2.Flotante\n3.Decimal");
			x2 = Convert.ToUInt16(Console.ReadLine());
			Console.WriteLine("Ingrese el numero");
			switch (x2)
			{
				case 1:
					n1 = Convert.ToInt16(Console.ReadLine());
					break;
				case 2:
					n1 = (int)float.Parse(Console.ReadLine());
					break;
				case 3:
					n1 = (int)Convert.ToDecimal(Console.ReadLine());
					break;
				
				default:
					Console.WriteLine("Opcion INVALIDA");
					break;
			}
			Console.WriteLine("¿A que tipo de dato desea convertir el valor ingreasado?");
			Console.WriteLine("1.Entero\n2.Flotante\n3.Decimal\n4.Cadena de Texto");	
			x2 = Convert.ToUInt16(Console.ReadLine());
			switch (x2)
			{
				case 1:
					n1= (int)n1;
					break;
				case 2:
					float f1=Convert.ToSingle(n1);
					break;
				case 3:
					n1= (int)Convert.ToDecimal(n1);
					break;
                case 4:
                    n1 = Convert.ToChar(value: n1);
                    break;
                default:
					break;
			}
			Console.WriteLine("Conversion Exitosa, el valor es :"+n1);
			break;
		case 2:
			Console.WriteLine("Ingrese la operacion que desea realizar");
			Console.WriteLine("1.Suma de Enteros\n2.Resta de Decimales\n3.Multiplicacion de Flotantes");
			Console.WriteLine("4.Division de Entros\n5.Modulo de Enteros");
			x2 = Convert.ToUInt16(Console.ReadLine());
			switch (x2)
			{
				case 1:
					/////////////////////////////////////////////////////
					break;
				default:
					Console.WriteLine("Opcion INVALIDA");
					break;
			}
			break;
		case 3:
			Console.WriteLine("Ingrese su cadena de texto");
			txt = Console.ReadLine();
			Console.WriteLine("");
			break;
		case 4:

			break;
		default:
			Console.WriteLine("Ingrese una opcion VALIDA");
			break;
	}
}while (c1==0);