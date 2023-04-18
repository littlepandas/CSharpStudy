using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpStudy2
{
	class Program
	{
		static void Main(string[] args)
		{
			//默认情况下 参数默认按值类型传递
			#region string类型作为参数的时候按值类型传递 方法中修改是无效的输出是123 因为string的大小是不可变的 当在方法中改变string的时候会创建新的内存分配
			string s ="123";
			Foo(s);
			Console.WriteLine(s);
			Console.ReadKey();
			#endregion

			#region stringbuilder类型作为参数传递的时候 按值类型传递会修改调用者的变量的值 但是置空却无效 因为参数传递是复制的引用而非对象本身 修改能够实现修改对象的变量 但是置空等于把引用指向空地址  输出是 true  test
			StringBuilder sb = new StringBuilder();
			Foo(sb);
			Console.WriteLine(sb.ToString());
			Console.ReadKey();
			#endregion

			#region 自己声明的类 同stringbuilder的效果 输出是 true hao
			Person p1 = new Person();
			p1.name = "li";
			FooPerson(p1);
			Console.WriteLine(p1.name);
			Console.ReadKey();
			#endregion

		}
		#region 值类型的引用类型参数传递测试 默认情况下参数按值传递 但是如果参数用ref和out修饰则会按引用传递
		public static void Foo(string s)
		{
			s = "456";
			s = null;
		}
		public static void Foo(StringBuilder foosb)
		{
			foosb.Append("test");
			foosb = null;
			Console.WriteLine(foosb==null);
		}
		public static void FooPerson(Person fooP)
		{
			fooP.name = "hao";
			fooP = null;
			Console.WriteLine(fooP == null);
		}
		public	class Person
		{
			public string name;
		}
		#endregion

	}

}
