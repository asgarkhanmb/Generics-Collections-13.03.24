//using Generics;
//using System.Xml.Serialization;

//IntList datas = new IntList();

//datas.Add(1);
//datas.Add(2);
//datas.Add(3);
//datas.Add(4);
//datas.Add(5);

//int[] result=datas.GetAll();

//foreach(int item in result)
//{
//    Console.WriteLine(item); 
//}

//StringList stringList = new StringList();

//stringList.Add("salam");
//stringList.Add("Sagol");

//string[] result2=stringList.GetAll();

//foreach(string item in result2)
//{
//    Console.WriteLine(item);
//}


//using Generics;

//DataList<int> datas = new DataList<int>();

//datas.Add(100);
//datas.Add(200);
//datas.Add(300);

//var result=datas.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);    
//}

//DataList<string> dataList = new DataList<string>();

//dataList.Add("salam");
//dataList.Add("salam2");

//string[] result2 = dataList.GetAll();

//foreach (string item in result2)
//{
//    Console.WriteLine(item);
//}



//DataList<bool> dataList1 = new DataList<bool>();

//dataList1.Add(true);
//dataList1.Add(false);
//dataList1.Add(true);

//var result3 = dataList1.GetAll();   

//foreach (bool item in result3)
//{
//    Console.WriteLine(item);
//}




//using Generics;

//DataList<Book> books = new DataList<Book>();

//books.Add(new Book { Id = 1, Name = "test1" });
//books.Add(new Book { Id = 2, Name = "test2" });
//books.Add(new Book { Id = 3, Name = "test3" });

//var result=books.GetAll();

//foreach(var item in result)
//{
//    Console.WriteLine(item.Name);
//}


//using Generics;

//DataList<int> datas = new DataList<int>();

//datas.Add(100);
//datas.Add(200);
//datas.Add(300);

//var result=datas.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//datas.Delete(100);

//var result1=datas.GetAll();

//foreach(var item in result1)
//{
//    Console.WriteLine(item);
//}


//using Generics;

//Repository<string>data1= new Repository<string>();

//Repository<int>data2= new Repository<int>();

//Repository<bool>data3= new Repository<bool>();

//Repository<Book,BaseEntity>data4= new Repository<Book,BaseEntity>();


using System.Collections;
using System.Collections.ObjectModel;

//ArrayList list1=new ArrayList();

//list1.Add(100);
//list1.Add("Salam");
//list1.Add(true);

//foreach(var item in list1)
//{
//    Console.WriteLine(item);
//}

//Hashtable hashtable = new Hashtable();

//hashtable.Add("role", "Admin");
//hashtable.Add("name", "Nesir");
//hashtable.Add(100, 200);
//hashtable.Add(200, 200);
//hashtable.Add(5, 200);


//foreach (DictionaryEntry item in hashtable)
//{
//    Console.WriteLine(item.Key + "--" + item.Value);
//}



//SortedList sortedList = new SortedList();


//sortedList.Add(100, 200);
//sortedList.Add(5, 100);
//sortedList.Add(55, 100);

//foreach (DictionaryEntry item in sortedList)
//{
//    Console.WriteLine(item.Key+"-"+item.Value);
//}



//SortedList<string,int>datas= new SortedList<string,int>();

//datas.Add("roleId", 100);
//datas.Add("age", 30);

//foreach (KeyValuePair<string,int> item in datas)
//{
//    Console.WriteLine(item.Key + "-" + item.Value);  
//}


//Dictionary<string, string> datas = new Dictionary<string, string>();

//datas.Add("test1", "salam1");
//datas.Add("test2", "salam2");
//datas.Add("test3", "salam3");

//foreach (KeyValuePair<string,string> item in datas)
//{
//    Console.WriteLine(item.Key+"--"+item.Value);
//}


//Console.WriteLine(datas["test1"]);


//Stack<int>nums= new Stack<int>();
//nums.Push(1);
//nums.Push(100);
//nums.Push(18);

//foreach(int item in nums)
//{
//    Console.WriteLine(item);
//}


//Queue<int> nums = new Queue<int>();
//nums.Enqueue(1);
//nums.Enqueue(2);
//nums.Enqueue(3);

//foreach (int item in nums)
//{
//    Console.WriteLine(item);
//}

//IEnumerable<int> nums = new List<int>();



//List<int> numbers = new List<int> {1,2,3,4,5,6};

//List<int> numbers2 = new List<int> { 10, 20, 30, 40, 50, 60 };



//numbers.Add(1);
//numbers.Add(2);
//numbers.Add(3);
//numbers.Add(4);

//Console.WriteLine(numbers[0]);


//for(int i = 0; i < numbers.Count; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//foreach(int item in numbers)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(numbers.FirstOrDefault(m=>m==5));


//foreach (int item in numbers)
//{
//    Console.WriteLine(item);
//}

//numbers.Remove(5);
//Console.WriteLine("--------------------");
//numbers.AddRange(numbers2);

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}