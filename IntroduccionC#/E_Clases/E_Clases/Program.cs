using System;

namespace E_Clases
{
	// 1. Estructuras vs Clases

//		// Estructura para guardar un animal
//		struct structAnimal{
//			public string nombre;
//
//			public structAnimal(string nombre){
//				this.nombre = nombre;
//			}
//
//			public void info(){
//				Console.WriteLine("Nombre del animal -> " + nombre);
//			}
//		}
//
//		// Clase para guardar un animal
//		class claseAnimal{
//			public string nombre;
//
//			public claseAnimal(string nombre){
//				this.nombre = nombre;
//			}
//
//			public void info(){
//				Console.WriteLine("Nombre del animal -> " + nombre);
//			}
//		}

	// 2. Getter y setter

	// public: se puede acceder sin limitaciones desde cualquier lugar
	// private: solo se tiene acceso desde la misma clase
	// protected: se puede acceder desde la propia clase o subclase

	class Animal{
		
		public string nombre;

		private double peso;
		public double Peso{
			get{ return peso; }
			set { peso = value; }
		}

		protected string sonido;
		public string Sonido{
			get { return sonido; }
			set { sonido = value; }
		}

		// Constructor por defecto
		public Animal(){
			this.nombre = "";
			this.peso = 0;
			this.sonido = "";
		}

		// Constructor con parámetros
		public Animal(string nombre, double peso, string sonido){
			this.nombre = nombre;
			this.Peso = peso;
			this.Sonido = sonido;
		}

		// Método de clase
		public void info(){
			//Console.WriteLine ("Nombre -> " + this.nombre);
			//Console.WriteLine ("Peso -> " + this.Peso);
			//Console.WriteLine ("Sonido -> " + this.Sonido);
			Console.WriteLine("Nombre -> {0}\nPeso -> {1}\nSonido -> {2}", this.nombre, this.Peso, this.Sonido);
		}

		// 3. Método especial de clase
		public override string ToString ()
		{
			return String.Format ("Nombre -> {0}\nPeso -> {1}\nSonido -> {2}", this.nombre, this.Peso, this.Sonido);
		}
	}

	class Pajaro : Animal{

		public bool vuela;


		// Constructor usando la superclase
		public Pajaro() : base(){
			this.vuela = true;
		}

		public Pajaro(string nombre, double peso, string sonido, bool vuela) : base(nombre, peso, sonido){
			this.vuela = vuela;
		}

		new public void info(){
			Console.WriteLine("Nombre -> {0}\nPeso -> {1}\nSonido -> {2}\nVuela -> {3}", this.nombre, this.Peso, this.Sonido, this.vuela);
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			// 1. Estructuras vs Clases

//				structAnimal sPerro = new structAnimal ("Perro");
//				structAnimal sPerroCopia = sPerro;
//
//				sPerro.nombre = "Gato";
//
//				sPerro.info (); // -> gato
//				sPerroCopia.info (); // -> perro
//				// Son dos estructuras distintas, cada una almacena su valor.
//
//				claseAnimal cPerro = new claseAnimal ("Perro");
//				claseAnimal cPerroCopia = cPerro;
//
//				cPerro.nombre = "Gato";
//
//				cPerro.info (); // -> gato
//				cPerroCopia.info (); // -> gato
//				// Una copia de una instancia de clase es en realidad una referencia a donde está almacenado el objeto
//				// de la clase.

			// 2. Getter y setter

//				Animal perro = new Animal ();
//				perro.nombre = "Tobby";
//				perro.Peso = 15;
//				perro.Sonido = "Guau Guau";
//
//				Animal gato = new Animal ("Misifú", 5, "Miau Miau");
//
//				//perro.info ();
//				//gato.info ();

			// 3. ToString

//				Console.WriteLine(perro);
//				Console.WriteLine(gato.ToString());

			// 4. Herencia de clases

			Pajaro loro = new Pajaro ("Pepe", 0.1, "Ack Ack Ack", true);
			loro.info ();
		}
	}


}
