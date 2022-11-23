using Microsoft.VisualStudio.TestTools.UnitTesting;

using Script;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Script.Tests
{
	[TestClass()]
	public class UtilityTests
	{
		[TestMethod()]
		public void ToUpperTest()
		{
			// Act
			var output = Utilities.Utility.ToUpper("a");

			// Assert
			Assert.AreEqual("A", output);
		}
	}
}