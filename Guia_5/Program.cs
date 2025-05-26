// See https://aka.ms/new-console-template for more information

using Guia_5;using System.Globalization;

//Ejercicios.Persona persona1 = new Ejercicios.Persona();
//Console.WriteLine(persona1.ToString());

Ejercicios.Persona persona2 = new Ejercicios.Persona(44966426, "Santiago", "Suppes","08/07/2003", 15, "Masculino");
Console.WriteLine(persona2.ToString());

persona2.Saludar();
persona2.CumplirAnios();
persona2.Saludar();

persona2.MostrarDatos();
persona2.EsMayorDeEdad();