using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF
{
	/*
	 * Singleton 模式拓展
	 * 将一个实例扩展到n个实例，例如对象池的实现。
	 * 将new构造里的调用转移到其它类中，例如多个类协同工作环境中，某个局部环境只需要拥有某个类的一个实例。
	 * 理解和拓展Singleton模式的核心是“如何控制用户使用new对一个类的实例构造器的任意调用”。
	 * 
	 *推荐参考书：
	 *《设计模式：可复用面向对象软件的基础》	--GoF
	 *《面向对象分析与设计》	--Grady Booch
	 *《敏捷软件开发：原则、模式与实践》	--Robert C. Martin
	 *《重构：改善既有代码的设计》	--Martin Fowler
	 *《Refactoring to Patterns》	--Joshua Kerievsky
	 */


	/// <summary>
	/// 单线程单例类
	/// </summary>
	/*
	public class Singleton
	{
		private static Singleton instance;

		private Singleton() { }

		public static Singleton Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new Singleton();
				}
				return instance;
			}
		}
	}
	/// <summary>
	/// 多线程单例类
	/// </summary>

	public class Singleton
	{
		private static volatile Singleton  instance = null;

		private static object lockHelper = new object();
		private Singleton() { }

		public static Singleton Instance
		{
			get
			{
				if (instance == null)
				{
					lock(lockHelper)
                    {
						if(instance == null)
                        {
							instance = new Singleton();
						}
                    }
				}
				return instance;
			}
		}
	}

	/// <summary>
	/// 另一种写法
	/// </summary>
	sealed class Singleton
    {
		// 编译器产生， runtime调用它， 不可带参数构造
		public static readonly Singleton instance = new Singleton();
		private Singleton   () { }
    }
	*/
	/// <summary>
	/// 带参数的单例类
	/// </summary>
	public class Singleton
	{
		private static Singleton instance;
		int x, y;

		/// <summary>
		/// 对外部接口
		/// </summary>
		public void init(FileStream fs) {
		
		}

		private Singleton(int x, int y) {
			this.x = x;
			this.y = y;
		}

		public static Singleton GetInstance(int x, int y)
		{
			if (instance == null)
			{
				instance = new Singleton(x,y);
			}
            else
            {
				instance.x = x;
				instance.y = y;
            }
			return instance;
		}
	}




}
