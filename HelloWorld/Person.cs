using System;
namespace HelloWorld
{
	public class Person
	{
		private String? name;
		private int? age;
		private String? email;
		private String? addressLine01;
		private String? addressLine02;
		private String? postCode;

		//use prop => public object MyProperty {get; set;}
		public String Name { get { return name ?? ""; } set { name = value; } }
		public int Age { get { return age ?? 0; } set { age = value; } }
		public String Email { get { return email ?? ""; } set { email = value; } }
		public String AddressLine01 { get { return addressLine01 ?? ""; } set { addressLine01 = value; } }
		public String AddressLine02 { get { return addressLine02 ?? ""; } set { addressLine02 = value; } }
		public String PostCode { get { return postCode ?? "";  } set { postCode = value; } }

		public static void sayHi(String _name)
		{
			Console.Out.WriteLine("HI ! " + _name);
		}

		public void printDetail()
		{
			Console.Out.WriteLine(name!.ToUpperInvariant());
            Console.Out.WriteLine(age);
            Console.Out.WriteLine(email);
            Console.Out.WriteLine(addressLine01);
            Console.Out.WriteLine(addressLine02);
            Console.Out.WriteLine(postCode);
        }
	}
}

