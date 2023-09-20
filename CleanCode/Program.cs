namespace CleanCode
{
	class Program
	{
		static void Main(string[] args)
		{
			Customer customer = new Customer()
			{
				Id = 1,
				Age = 22,
				LastName = "Atik"
			};
			CustomerDal customerDal = new CustomerDal();
			customerDal.Add(customer);
			Console.ReadLine();
		}
	}
	[ToTable("Customers")]
	[ToTable("CustomersTable")]
	class Customer
	{
		public int Id { get; set; }
		[RequiredProperty]
		public string FirstName { get; set; }
		[RequiredProperty]
		public string LastName { get; set; }
		public int Age { get; set; }
	}

	class CustomerDal
	{
		[Obsolete("Don't use Add, instead use AddNew Method")]
		public void Add(Customer c)
		{
			Console.WriteLine("{0},{1},{2},{3} added!", c.Id,c.Age,c.FirstName,c.LastName);
		}
		public void AddNew(Customer c)
		{
			Console.WriteLine("{0},{1},{2},{3} added!", c.Id, c.Age, c.FirstName, c.LastName);
		}
	}
	[AttributeUsage(AttributeTargets.Property,AllowMultiple = true)] //her yerde kullanabilirsin AttributeTargets (All,Class,Property...) pipe (altgr+kücüktür isareti) ile başka nerelerde kullanacaksak ekleyebiliyoruz.


	
	class RequiredPropertyAttribute:Attribute
	{
	}
	[AttributeUsage(AttributeTargets.Class,AllowMultiple = true)] // Allowmultiple 18ve19. satır da kullanıldığı gibi bir attribute u birden fazla kez kullanacaksak ona izin vermemiz gerekiyor.
	
	
	class ToTableAttribute : Attribute
	{
		 string _tableName;
		 public ToTableAttribute(string tableName)
		{
			_tableName=tableName;
		}

	}


}