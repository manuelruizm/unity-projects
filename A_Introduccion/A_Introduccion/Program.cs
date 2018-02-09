using System;

namespace A_Introduccion
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Console.WriteLine ("Hello World!");

			// Comentario en una línea
			/*
			 * Comentario en varias líneas
			 * */

			// 1. Entradas de usuario

//				// Sirve para mostrar información
//				// Se utilizan valores literales: tienen el valor literalmente escrito
//				Console.WriteLine ("Hola!!!!");
//				Console.WriteLine ("Cómo te llamas?");
//
//				// También sirven para recibir información
//				string nombre = Console.ReadLine();
//				Console.WriteLine ("Hola " + nombre);
//
//				// Variable: es un espacio en la memoria que reservamos para guardar datos

			// 2. Tipos de datos

//				// Booleanos o lógicos ... true - false
//				bool logico = true;
//
//				// Caracteres ... símbolos unicode de 16 bits
//				char caracter = 'A';
//
//				// Enteros ... desde -2.147.483.647 a 2.147.483.647
//				int entero = 10;
//
//				// Largos ... para guardar muchísimos más enteros
//				long largo = 999999999999;
//
//				// Un flotante puede guardar números con parte decimal (hasta 7 decimales de precisión)
//				float flotante = 120.5f;
//
//				// Un doble puede guardar números decimales muchísimo más grandes (hasta 15 decimales de precisión)
//				double doble = 10.12345678901234567890;
//
//				// Tipo dinámico
//				dynamic numero = 10;
//				numero = -10.45;
//				numero = "asdf";
//
//				// No se pueden mostrar por pantalla porque el sistema no sabe qué es ese dato.

//				// Definición con var
//				var numeroo = 10;
//
//				// Se le asigna el tipo en cuanto se le da un valor. Sí se pueden mostrar por pantalla.
//
//				// Para conocer el tipo de dato de una variable existe una función.
//				Console.WriteLine(numeroo.GetTypeCode());

			// 3. Operadores matemáticos

//				var a = 4;
//				var b = 3;
//
//				var resultado = a + b;
//				Console.WriteLine (resultado);
//
//				// Hay sumas (+), restas (-), multiplicaciones (*) y divisiones (/).
//				// Las divisiones hay que tener en cuenta el tipo de dato que se está manejando.
//				// Si ambos datos son enteros, el resultado de la división será entero.
//
//				// También está el módulo (%)(resto de la divisón entera).
//				Console.WriteLine(a%b);

//				// Operadores unitarios
//				var i = 0;
//
//				Console.WriteLine (i);
//				i++;
//				Console.WriteLine (i);
//				i--;
//				i--;
//				Console.WriteLine (i);
//				Console.WriteLine(++i);
//				Console.WriteLine (--i);
//
//				/*
//				 * Hay que tener en cuenta que si se utiliza el operador unitario dentro de alguna función,
//				 * entonces se ejecuta primero la función y después el operador. Para que se ejecute primero
//				 * el operador es necesario ponerlo delante de la variable.
//				 * */
//
//				// Operadores de asignación
//
//				// +=, -=, *=, /=, %=

			// 4. Funciones matemáticas
			  
//			var a = 4;
//			var b = -7.5;
//
//			Console.WriteLine ("Valor absoluto: " + Math.Abs(a));
//			Console.WriteLine ("Redondeo clásico: " + Math.Round(b));
//			Console.WriteLine ("Redondeo al alza: " + Math.Ceiling(b));
//			Console.WriteLine ("Redondeo a la baja: " + Math.Floor(b));
//			Console.WriteLine ("Número más grande: " + Math.Max(a,b));
//			Console.WriteLine ("Número más pequeño: " + Math.Min(a,b));
//			Console.WriteLine ("Potencia de un número: " + Math.Pow(a,2));
//			Console.WriteLine ("Raíz cuadrada: " + Math.Sqrt(a));

			// 5. Números aleatorios

//				Random Generador = new Random ();
//
//				var aleatorio = Generador.Next (1,11);
//
//				// Queremos que vaya entre 1 y 10. Hay que tener en cuenta que el último no se incluye.
//
//				// Para valores aleatorios entre 0 y 1 tenemos:
//
//				Generador.NextDouble ();
//
//				Console.WriteLine (aleatorio);
		}
	}
}
