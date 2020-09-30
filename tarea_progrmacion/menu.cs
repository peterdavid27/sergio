using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
/*
 En la misma es necesario utilizar herencias y polimorfismo (Interfaces) para poder obtener la totalidad de los puntos, ya que por el uso de herencia tienen 1 punto , por el uso de interfaces otro punto y el punto restante por completar la funcionalidad solicitada, La tarea debe ser subida a Github y colocar el link del repositorio en la entrega. 

Se debe construir un sistema para registrar transacciones de esta transacciones se registran los siguientes datos 
(Numero de transacción(Debe ser único en cada transacción)
nombre del cliente
monto de la transacción (dos tipos: transacción aprobada o transacción rechazada)(durante el registro debe preguntarle al usuario si es una transacción aprobada o rechazad)

add
editar
buscar numero de transacción sino existe indicarle al user que es invalido y preguntarle si desea realizar otra búsqueda si la respuesta es Si le permitirá ingresar otro numero de transacción en caso de ser No lo enviá al menú principal una vez colocado un numero de transacción existente solo se permite editar el nombre del cliente y el monto de la transacción.

Los dos tipos de transacción se deben poder eliminar pero cuando se elimina una transacción de tipo aprobada, estas transacciones aparte de ser eliminada del listado de su tipo se debe agregar en otro listado para control de auditoria ese otro listado para transacciones aprobada borrada se llama transacciones canceladas , pero al borrar las transacciones rechazadas se deben eliminar de el listado de su tipo y se debe agregar en otro listado llamado transacciones eliminadas. 

Finalmente se pueden listar todas las transaccionesy se debe indicar cuales están aprobada,  rechazada , cancelada o eliminada.
 */



namespace tarea_progrmacion
{
	public class Persona
	{
		public int id { get; set; }
		public string nombre { get; set; }
		public int saldo { get; set; }


	}
	public class Cliente : Persona
	{
		public static void Main()
		{
			Cliente persona1 = new Cliente();
			Console.WriteLine("Cajero automático");
			Console.WriteLine("");
			Console.WriteLine("Favor de ingresar su nombre completo");
			persona1.nombre = Console.ReadLine();
			Console.WriteLine("");
			int res;
			int r;
			do
			{
				Console.WriteLine(persona1.nombre + " ¿Qué tipo de transacció deseas realizar?");
				Console.WriteLine("");
				Console.WriteLine("1 = Retiro");
				Console.WriteLine("2 = Deposito");
				Console.WriteLine("3 = Salir");
				Console.WriteLine("");
				res = int.Parse(Console.ReadLine());
				switch (res)
				{
					case 1:
						Console.WriteLine("¿Qué cantidad desea retirar?");
						int cantidad = int.Parse(Console.ReadLine());
						persona1.retiro(cantidad);
						r = 0;

						break;

					case 2:
						Console.WriteLine("¿Qué cantidad desea depositar?");
						cantidad = int.Parse(Console.ReadLine());
						persona1.deposito(cantidad);
						r = 0;
						break;

					case 3:
						Console.WriteLine("Cerrando sesión " + persona1.nombre);
						Console.WriteLine("Puede retirar su tarjeta");
						Console.WriteLine("....");
						Console.WriteLine("Que tenga un buen día");
						r = 2;
						break;

					default:
						Console.WriteLine("Esta opción no existe");
						r = 0;
						break;
				}

			} while (r < 2);
		}
		public int retiro(int cantidad)
		{
			if (saldo <= cantidad)
			{
				Console.WriteLine("Transacción invalida. Fondos insuficientes");
				Console.WriteLine("");
				return saldo;
			}
			else
			{
				Console.WriteLine("Se ha retirado la cantidad de: " + cantidad);
				saldo = saldo - cantidad;
				Console.WriteLine("Su saldo actual es de " + saldo + "$");
				Console.WriteLine("");
				return saldo;
			}
		}
		public int deposito(int cantidad)
		{
			Console.WriteLine("Se ha depositado la cantidad de: " + cantidad + "$");
			saldo = saldo + cantidad;
			Console.WriteLine("Su saldo actual es de " + saldo + "$");
			Console.WriteLine("");
			return saldo;
		}
	}
}
