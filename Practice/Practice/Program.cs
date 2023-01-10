


#region Homework
//3) Person tipinden listimiz var. Maashi 1000-den cox olan personlarin ad,
//    soyad ve addresini gosteren ve parametr olaraq predicate qebul  eden method yazin.


using Practice;
using Practice.Controllers;
using ServiceLayer.Services;
using System.Reflection;

//PersonController controller = new PersonController();
//controller.GetPersonBySalary();

#endregion



//Book book1 = new Book() { Id = 1, Name = "Xosrov"};
//Book book2 = new Book() { Id = 2, Name = "7 gozel" };

//Library library = new();

//library[0] = book1;
//library[1] = book2; 


//Console.WriteLine(library[0].Name);
//Console.WriteLine(library[1].Name);


Assembly assembly = Assembly.GetExecutingAssembly();

foreach (var item in assembly.GetTypes())
{
	//Console.WriteLine(item);

	foreach (var item2 in item.GetMembers())
	{
		Console.WriteLine(item2);
	}
}




