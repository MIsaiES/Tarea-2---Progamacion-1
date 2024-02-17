using System;

	int n1=0, n2=0, x1=0, x2=0;
	int c1 = 0;
	double r, d1, d2;
	float f1, f2;
do{	
		Console.WriteLine("¿Que desea hacer?");
		Console.WriteLine("1.Conversion de Tipos \n2.Operaciones\n0.Salir");
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
                    Console.WriteLine("Conversion Exitosa, el valor es :" + n1);
                    break;
				case 2:
					float f=Convert.ToSingle(n1);
                    Console.WriteLine("Conversion Exitosa, el valor es :" + f);
                    break;
				case 3:
					n1= (int)Convert.ToDecimal(n1);
                    Console.WriteLine("Conversion Exitosa, el valor es :" + n1);
                    break;
                case 4:
                    n1 = Convert.ToChar(value: n1);
                    Console.WriteLine("Conversion Exitosa, el valor es :" + n1);
                    break;
                default:
					break;
			}
			break;
		case 2:
			Console.WriteLine("Ingrese la operacion que desea realizar");
			Console.WriteLine("1.Suma de Enteros\n2.Resta de Decimales\n3.Multiplicacion de Flotantes");
			Console.WriteLine("4.Division y Modulo de Entros");
			x2 = Convert.ToUInt16(Console.ReadLine());
			switch (x2)
			{
				case 1:
					Console.WriteLine("Ingrese un numero");
					n1 = Convert.ToInt16(Console.ReadLine());
					Console.WriteLine("Ingrese un segundo numero");
					n2 = Convert.ToInt16(Console.ReadLine());
					r = n1 + n2;
					Console.WriteLine("La suma de los enteros es de: "+r);
					break;
				case 2:
                    Console.WriteLine("Ingrese un numero");
                    d1 = (double)Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Ingrese un segundo numero");
                    d2 = (double)Convert.ToDecimal(Console.ReadLine());
                    r = d1 - d2;
                    Console.WriteLine("La resta de los decimales  es de: " + r);
                    break;
				case 3:
                    Console.WriteLine("Ingrese un numero");
                    f1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese un segundo numero");
                    f2 = float.Parse(Console.ReadLine());
                    r = f1 * f2;
                    Console.WriteLine("La multiplicacion de los flotantes es de: " + r);
                    break;
                case 4:
                    Console.WriteLine("Ingrese un numero");
                    n1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Ingrese un segundo numero");
                    n2 = Convert.ToInt16(Console.ReadLine());
                    r = n1 / n2;
                    Console.WriteLine("La division de los enteros es de: " + r);
                    r = n2 % n1;
                    Console.WriteLine("El modulo de los enteros es de" + r);
                    break;
				default:
					Console.WriteLine("Opcion INVALIDA");
					break;
			}
			break;
		default:
			Console.WriteLine("Ingrese una opcion VALIDA");
			break;
	}
}while (c1==0);