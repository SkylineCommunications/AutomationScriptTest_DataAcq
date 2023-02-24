using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilitiesBis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesBis.Tests
{
	[TestClass()]
	public class UtilityBisTests
	{
		[TestMethod()]
		public void ToLowerTest()
		{
			Console.WriteLine(Skyline.DataMiner.Automation.CalendarMode.Decade);

			var result = UtilitiesBis.UtilityBis.ToLower("B");

			
			Assert.AreEqual("b", result);
		}
	}
}