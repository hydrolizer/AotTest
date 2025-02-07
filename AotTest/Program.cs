using System;
using System.Reflection;
using AotInspector;

namespace AotTest;

internal class Program
{
	static void Main()
	{
		try
		{
			var mi = typeof(Reflector).GetMethod("Do", BindingFlags.Static | BindingFlags.NonPublic)
							?? throw new InvalidOperationException("Reflector.Do notfound");
			mi.Invoke(null, null);
		}
		catch (Exception e)
		{
			Console.WriteLine(e);
		}
		Console.WriteLine("done");
		Console.ReadKey(true);
	}
}
