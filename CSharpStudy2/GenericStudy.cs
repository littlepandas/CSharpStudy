using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy2
{
	/// <summary>
	/// 泛型学习
	/// </summary>
	class GenericStudy
	{
		/// <summary>
		/// 定义一个泛型集合
		/// </summary>
		public void InitGenericList()
		{
			List<string> stringList = new List<string>() { "asdf", "asdf" };
			foreach (string item in stringList)
			{
				Console.WriteLine(item);
			}
		}
		/// <summary>
		/// 定义一个泛型字典
		/// </summary>
		public void InitGenericDictionary()
		{
			Dictionary<int, string> initDictionary = new Dictionary<int, string>();
			//键值不能重复
			initDictionary.Add(1, "asdfa");
			Console.WriteLine(initDictionary[1]);
			foreach (int item in initDictionary.Keys)
			{
				Console.WriteLine(initDictionary[item]);
			}
		}

		
		public class MyGeneric<T>
		{
			private T t;
			public MyGeneric(T t)
			{
				this.t = t;
			}
		}
	}
	
	public class Test
	{
		public void Init()
		{
			GenericStudy genericStudy = new GenericStudy();
			GenericStudy.MyGeneric<int> myGeneric = new GenericStudy.MyGeneric<int>(4);
			Test t = new Test();
			t.ToString();
		}

	}
}
