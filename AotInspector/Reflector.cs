using System.Reflection;
using AotLink;

namespace AotInspector;

public class Reflector
{
	internal static void Do()
	{
		var type = typeof(Anchor).Assembly.GetType("AotLink.TestClass")
			?? throw new InvalidOperationException("AotLink.TestClass notfound");
		foreach(var pi in type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
			Console.WriteLine("{0}: {1}", pi.Name, pi.PropertyType);
		var mi = type.GetMethod("Zot", BindingFlags.Static | BindingFlags.NonPublic);
		if (mi == null)
			Console.WriteLine("Method Zot notfound");
		else
			mi.Invoke(null, ["huh?"]);
	}
}
