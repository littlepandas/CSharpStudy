using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy2
{
	/// <summary>
	/// 访问修饰符：
	///		public:同一程序集的其他任何代码或引用改程序集的其他程序集都可访问
	///		internal:同一程序集的人员和代码都有可以访问，但是其他程序集不可以访问
	///		protected internal:同一程序集的任何代码或其他程序集中的任何派生类都可以访问改类型成员
	///     protected:本类和派生类中可访问
	///		private:只能在本类中访问
	///		
	///		命名空间下的成员（Class、 StaticClass、 abstract Class、 Interface、 Enmu、 Struct ）默认为访问修饰符为internal 可以用public修饰不能用其他访问修饰符去修饰	
	/// </summary>
	namespace ChapterOne
	{
		/// <summary>
		/// 非静态类不能继承静态类，可以继承类 抽象类和接口 但是类和抽象类只能单继承不能多继承 接口可以多继承
		/// 非静态类可以包含静态成员和非静态成员 
		/// 成员默认为private 可以用其他访问修饰符修饰
		/// </summary>
		class TestNonStaticClassDefaultAccess 
		{
			public int number;
			int nubmers;
			int GetNumbers()
			{
				return nubmers;
			}
			public int GetNumber()
			{
				return 1;
			}
		}
		class TestNonStaticClassDefaultAccessSon : TestNonStaticClassDefaultAccess
		{
			public void TestMebersAccess()
			{
				//numbers  GetNumbers()无法访问 说明访问权限为private
				//nubmers
				//GetNumbers();
			}
			//可以用new关键字重写父类的方法
			public new int GetNumber()
			{
				return 1;
			}
		}
		/// <summary>
		/// 静态类不支持继承 
		/// 静态类只能包含静态成员
		/// 静态成员的默认访问权限为private
		/// 由于静态类不能被继承也不能继承其他类或者接口 所以静态类中的成员不能用protected和protected internal修饰符修饰
		/// </summary>
		public static class TestStaticClassDefaultAccess
		{
			//protected static int a;//Illegal
			//protected internal static int a;//Illegal
			static int numbers;
			static int GetNubmers()
			{
				TestNonStaticClassDefaultAccess testNonStaticClassDefaultAccess = new TestNonStaticClassDefaultAccess();
				testNonStaticClassDefaultAccess.number = 2;
				return numbers;
			}
		}

		class TestStaticClassMebersDefaultAccess
		{
			//int i =	TestStaticClassDefaultAccess.numbers;//无法访问 说明访问权限为private
		}

		/// <summary>
		/// 接口可以支持多继承
		/// 接口不能包含实例化字段，也就是只能包含方法（引文接口是完全抽象的所以也不能包含方法的实现）
		/// 成员默认访问修饰符为public且不能有显式public
		/// </summary>
		interface TestInterfaceDefaultAccess
		{
			//int numbers;
			//int GetNubers() { }
			 int Getnumbers();
		}
		/// <summary>
		/// 接口继承接口 不用实现所继承接口的方法
		/// </summary>
		interface TestInterfaceDefaultAccess2: TestInterfaceDefaultAccess
		{

		}

		class TestInterfaceDefaultAccessSon : TestInterfaceDefaultAccess
		{
			//int i =	TestStaticClassDefaultAccess.numbers;//无法访问 说明访问权限为private
			public int Getnumbers()
			{
				return 0;
			}
		}
		/// <summary>
		/// 抽象类支持单继承 抽象类可以继承抽象类
		/// 抽象类中可以有非抽象成员包括字段和方法
		/// 抽象类中的抽象方法用abstract修饰必须包含访问修饰符，不能包含方法体，子类用override重写
		/// </summary>
		abstract class TestAbstractClassDefaultAccess
		{
			int a;
			static int b;
			public void TestMethod()
			{

			}
			protected abstract int GetNumbers(); 
		}
		abstract class TestAbstractClassDefaultAccess2: TestAbstractClassDefaultAccess
		{

		}
		class TestAbstractClassDefaultAccessSon : TestAbstractClassDefaultAccess
		{
			protected override int GetNumbers()
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// 枚举类型 不支持继承
		/// </summary>
		enum TestEnumDefaultAccess
		{
			A,
			B,
			C
		}
		/// <summary>
		/// 结构体类型不能被继承可以继承,只可以继承接口
		/// 结构体的成员默认访问修饰符 因为不能被继承 所以成员不能修饰为protected
		/// </summary>
		struct TestStructDefaultAccess : TestInterfaceDefaultAccess
		{
			string A;
			void GetString()
			{

			}
			public int Getnumbers()
			{
				throw new NotImplementedException();
			}
		}

		public class TestStructAccess
		{
			public void Test()
			{
				TestStructDefaultAccess testStructDefaultAccess = new TestStructDefaultAccess();
				//testStructDefaultAccess.A
			}
		}
	}
}
