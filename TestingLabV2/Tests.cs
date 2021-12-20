using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLab3V2
{
	[TestFixture]
	public class Tests
	{

		[Test]
		public void MoreTest()
		{

			Assert.Throws<ArgumentException>(() =>
			{
				Versions version = new Versions("10.5.1-aplha.beta");
			});

			Assert.IsTrue(new Versions("1.0.0") > new Versions("1.0.0-alpha"));
			Assert.IsTrue(new Versions("1.0.1") > new Versions("1.0.0"));
			Assert.IsTrue(new Versions("1.1.0") > new Versions("1.0.0"));
			Assert.IsTrue(new Versions("1.1.1") > new Versions("1.1.0"));
			Assert.IsFalse(new Versions("4.1.9-1") > new Versions("5.9.0-5"));
			Assert.IsFalse(new Versions("7.1.4-1") > new Versions("7.1.5-1"));
			Assert.IsFalse(new Versions("0.1.9-1") > new Versions("0.2.0-5"));
		}

		[Test]
		public void LessTest()
		{
			Assert.IsTrue(new Versions("1.0.0-beta.alpha") < new Versions("1.0.0-beta.1"));
			Assert.IsTrue(new Versions("5.5.4-beta.1") < new Versions("5.5.5-beta.alpha"));
			Assert.IsTrue(new Versions("0.1.1-beta.1") < new Versions("0.1.2-beta.alpha"));

		}

		[Test]
		public void MoreOrEqualTest()
		{
			Assert.IsTrue(new Versions("1.1.0") >= new Versions("1.0.0"));
			Assert.IsTrue(new Versions("4.6.7") >= new Versions("4.6.0"));
			Assert.IsTrue(new Versions("5.5.5") >= new Versions("5.5.5-alpha"));

		}

		[Test]
		public void LessOrEqualTest()
		{
			Assert.IsTrue(new Versions("1.0.0") <= new Versions("1.1.0"));
			Assert.IsFalse(new Versions("5.8.1-alpha") <= new Versions("4.8.7-alpha"));
			Assert.IsFalse(new Versions("4.1.7-alpha.5") <= new Versions("4.1.7-alpha.1"));
	
																								
		}

		[Test]
		public void EqualTest()
		{
			Assert.IsTrue(new Versions("0.0.0") == new Versions("0.0.0"));
			Assert.IsTrue(new Versions("5.1.1") == new Versions("5.1.1"));
			Assert.IsTrue(new Versions("1.1.1-beta") == new Versions("1.1.1-beta"));
			Assert.IsFalse(new Versions("80.10.7-alpha") == new Versions("80.10.7"));
		}

		[Test]
		public void NoEqualTest()
		{
			Assert.IsTrue(new Versions("1.0.0") != new Versions("1.0.1"));
			Assert.IsTrue(new Versions("5.1.5-alpha") != new Versions("5.1.5"));
			Assert.IsFalse(new Versions("1.0.0") != new Versions("1.0.0"));
			Assert.IsFalse(new Versions("8.7.4-1") != new Versions("8.7.4-1"));
		}
	}
}
