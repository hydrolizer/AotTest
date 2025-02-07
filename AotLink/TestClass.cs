using System;

namespace AotLink;

internal class TestClass
{
	public string? Foo { get; set; }

	protected int Bar => 123;

	private static void Zot(string what) => Console.WriteLine("TestClass.Zot: {0}", what);
}
