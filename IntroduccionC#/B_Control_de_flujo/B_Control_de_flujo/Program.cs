using System;

namespace B_Control_de_flujo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Operadores relacionales: > < >= <= == !=
			// Sirven para comparar dos valores literales o variables.

			// Operadores lógicos: && (and), || (or), ^ (xor), ! (not)

			// 1. Condicional if

//				var edad = 7;
//
//				if (edad >= 18) {
//					Console.WriteLine ("Es un adulto");
//				}
//
//				else if (edad < 18 && edad > 11) {
//					Console.WriteLine ("Es un adolescente");
//				}
//
//				else {
//					Console.WriteLine ("Es un niño");
//				}

//				// Operador ternario
//
//				var edad = 27;
//
//				bool descuento = (edad < 12 || edad >= 65) ? true : false;
//
//				Console.WriteLine (descuento);

			// 2. Switch (condicional)

//				var opcion = "saludar";
//
//				switch (opcion) {
//					case "saludar":
//						Console.WriteLine ("Buenos días!");
//						break;
//					default:
//						Console.WriteLine ("No se reconoce la opción");
//						break;
//				}

			// 3. While (control de flujo iterativo)

//				var i = 0;
//
//				while(i<10){
//
//					if (i == 5) {
//						i++;
//						continue;
//					}
//
//					if (i == 7) {
//						break;
//					}
//
//					Console.WriteLine (i);
//					i++;
//				}

			// 4. Do while

//				var condicion = false;
//
//				do {
//					Console.WriteLine("Hola");
//				} while(condicion);

			// 5. For

//				for (int i = 0; i < 10; i++) {
//					Console.WriteLine (i);
//				}

			// 6. Foreach

//				string cadena = "Hola buenos días";
//
//				foreach (char caracter in cadena) {
//					Console.WriteLine (caracter);
//				}
		}
	}
}
