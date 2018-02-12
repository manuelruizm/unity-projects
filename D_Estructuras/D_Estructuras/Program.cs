using System;
using System.Collections.Generic;

namespace D_Estructuras
{

	// Las estructuras se tienen que definir dentro del namespace.
	// Las estructuras son un tipo de dato de C# que contiene varios tipos de datos básicos.

	struct Cliente{
		// Atributos de la estructura
		// Se pone public para poder cambiar los valores.
		public int id;
		public string nombre;
		public double saldo;

		// Constructor de la estructura
		public Cliente(int id, string nombre, double saldo){
			this.id = id;
			this.nombre = nombre;
			this.saldo = saldo;
		}
		// Con el this nos referimos a la propia estructura.

		// Método propio de estructura
		public void mostrarInfo(){
			Console.WriteLine("Id: " + this.id);
			Console.WriteLine("Nombre: " + this.nombre);
			Console.WriteLine("Saldo: " + this.saldo);
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			// 1. Introducción

//				Cliente mario = new Cliente ();
//				mario.id = 1;
//				mario.nombre = "Mario";
//				mario.saldo = "13.56";

			// 2. Constructores

//				Cliente mario = new Cliente (1, "Mario", 13.56);
//				mario.mostrarInfo ();

			// 3. Array de estructuras

			Cliente[] arrayClientes = { 
				new Cliente(1, "Mario", 13.56),
				new Cliente(2, "Carmen", 0),
				new Cliente(3, "Juan", -38.19)
			};

			// 4. Lista de estructuras

			List<Cliente> clientes = new List<Cliente> (arrayClientes);

			foreach (Cliente cliente in clientes) {
				cliente.mostrarInfo ();
			}
		}
	}
}
