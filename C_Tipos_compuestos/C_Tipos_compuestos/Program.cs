using System;
using System.Collections.Generic;

namespace C_Tipos_compuestos
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// 1. Cadenas

//				// Es una estructura compuesta de carácteres y se definen siempre
//				// entre comillas dobles.
//				// Dentro de ellas hay secuencias de escape que nos permiten definir
//				// funcionalidades dentro de la cadena. Se usan con la \ (barra invertida).
//
//				// \n -> salto de línea
//				// \t -> tabulación
//				// \\ -> \
//				// \" -> "
//
//				string cadena = "Hola mundo!";
//				Console.WriteLine (cadena);

//				// Las funciones de las cadenas que aparecen a continuación no modifican
//				// el valor de la propia cadena sino que dan información complementaria.
//				// El valor obtenido se puede capturar para utilizarlo en otra cosa.
//
//				string cadena = "Hola mundo";
//
//				Console.WriteLine ("Longitud de la cadena: " + cadena.Length);
//				Console.WriteLine ("Índice de subcadena: " + cadena.IndexOf("mundo"));
//				Console.WriteLine ("Devolver subcadena: " + cadena.Substring(0,4));
//				Console.WriteLine ("Comparar dos cadenas: " + cadena.Equals("Hola mundo"));
//				Console.WriteLine ("Empieza con una subcadena: " + cadena.StartsWith("Hola"));
//				Console.WriteLine ("Acaba con una subcadena: " + cadena.EndsWith("mundo"));
//				Console.WriteLine ("Reemplazar una palabra: " + cadena.Replace("Hola", "Adiós"));
//				Console.WriteLine ("Reemplazar un carácter: " + cadena.Replace("o","a"));
//
//				string cadena2 = "          Muchos espacios      ";
//				Console.WriteLine ("Borrar espacios: " + cadena2.Trim());
//
//				string cadena3 = "";
//				Console.WriteLine ("Cadena nula o vacía: " + string.IsNullOrEmpty(cadena3));
//
//				string cadena4 = "     ";
//				Console.WriteLine ("Cadena nula o espacios en blanco: " + string.IsNullOrWhiteSpace(cadena4));

			// 2. Array

//				// Colección de datos homogénea (mismo tipo) y de tamaño definido no modificable.
//				// El contenido de los elementos del array sí es modificable.
//
//				int[] numeros = { 4, 1, -6, 12 };
//
//				Console.WriteLine ("numeros[0] -> " + numeros [0]);
//				Console.WriteLine ("numeros[1] -> " + numeros [1]);
//				Console.WriteLine ("numeros[2] -> " + numeros [2]);
//				Console.WriteLine ("numeros[3] -> " + numeros [3]);
//
//				Console.WriteLine ("Longitud: " + numeros.Length);
//				Console.WriteLine ("Buscar un elemento: " + Array.IndexOf (numeros, -6));
//				Console.WriteLine ("Buscar un elemento: " + Array.IndexOf (numeros, 100));
//
//				string[] palabras = { "unas", "cuantas", "palabras" };
//				string cadena = string.Join (" ", palabras);
//				Console.WriteLine (cadena);
//
//				string[] palabrass = "Unas cuantas palabras".Split (' ');
//				foreach (string palabra in palabrass) {
//					Console.WriteLine (palabra);
//				}

//				// Creación de arrays no inicializados.
//
//				int[] numeros = new int[10];
//
//				Random Generador = new Random ();
//
//				for (var i = 0; i < numeros.Length; i++) {
//					numeros [i] = Generador.Next (0, 101);
//				}
//
//				foreach (int numero in numeros) {
//					Console.WriteLine (numero);
//				}

			// 3. Listas

//				// Colección de datos de un tipo concreto pero de tamaño indefinido.
//				// Hay que importarlas: using System.Collections.Generic;
//
//				List<int> numeros = new List<int> ();
//				Console.WriteLine ("Contador de elementos: " + numeros.Count);
//
//				numeros.Add (1);
//				numeros.Add (2);
//				numeros.Add (3);
//
//				foreach (int numero in numeros) {
//					Console.WriteLine (numero);
//				}
//
//				Console.WriteLine ("Contador de elementos: " + numeros.Count);
//
//				// Se puede añadir un array a una lista (del mismo tipo).
//
//				int[] arrayNumeros = { 4, 5 };
//				numeros.AddRange (arrayNumeros);
//
//				foreach (int numero in numeros) {
//					Console.WriteLine (numero);
//				}
//
//				// Vaciar una lista
//
//				numeros.Clear ();
//				Console.WriteLine ("Contador de elementos: " + numeros.Count);

//				// Inicializar con un constructor
//
//				int[] arrayNumeros = { 1, 2, 3, 4, 5 };
//				List<int> numeros = new List<int> (arrayNumeros);
//
//				foreach (int numero in numeros) {
//					Console.WriteLine (numero);
//				}
//
//				// Insertar/eliminar un valor en una posición concreta
//
//				numeros.Insert (0, 99);
//
//				foreach (int numero in numeros) {
//					Console.WriteLine (numero);
//				}
//
//				numeros.Remove (99);
//				numeros.RemoveAt (0);
//
//				foreach (int numero in numeros) {
//					Console.WriteLine (numero);
//				}

//				// Buscar elementos en una lista
//
//				List<int> numeros = new List<int> (new int[] { 1, 2, 3, 4, 5 });
//
//				Console.WriteLine ("Buscar un número o -1: " + numeros.IndexOf(5));
//				Console.WriteLine ("Buscar un número o -1: " + numeros.IndexOf(999));
//				Console.WriteLine ("Contiene un número: " + numeros.Contains(999));

//				// Ordenar una lista
//
//				List<int> numerosDesordenados = new List<int>(new int[]{76,-98,21,14,-57,0});
//
//				numerosDesordenados.Sort ();
//
//				numerosDesordenados.Reverse ();
//
//				foreach (int numero in numerosDesordenados) {
//					Console.WriteLine (numero);
//				}
//
//				// Sort y reverse actúan directamente sobre la lista.





		}
	}
}
