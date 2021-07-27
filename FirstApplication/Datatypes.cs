using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApplication
{
    class Datatypes
    {
		void Types()
		{
			String name;
			int age;
			float salary = 37829.87f;
			Console.WriteLine("Enter the name");
			name = Console.ReadLine();
			Console.WriteLine("Enter the age");
			age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Name: {0} && Age:{1} && salary:{2})", name, age, salary);
		}
		void TypeConversion()
		{
			//Implicit type conversion and Explicit
			//Implicit type conversion 
			//int<float<double

			int num = 100;
			float petrol = num;
			double disel = petrol;
			Console.WriteLine("Implicit type conversion:{0}", disel);

			//Explicit type conversion
		}

		void Boxingandunboxing()
		{
			//converting value type to reference type is boxing
			//conversting reference type to value type is unboxing
			int salary = 20000;
			object obj = salary;
			int number = (int)obj;
			Console.WriteLine("Boxingandunboxing:{0}", number);
		}

		void NullableTypes()
		{
			//value Nullable Types
			//int age1=null;
			int? age = null;
			Console.WriteLine();
			//Reference nullable type
			string? City = null;
			Console.WriteLine();
		}

		static void Main()
		{
			Datatypes datatypes = new Datatypes();
			datatypes.Types();
			Console.WriteLine("-----------");
			datatypes.TypeConversion();
			Console.WriteLine("------------");
			datatypes.Boxingandunboxing();
			Console.WriteLine("Hello World!");
		}
	}
}
