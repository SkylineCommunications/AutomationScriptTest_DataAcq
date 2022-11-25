namespace Script.Tests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

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