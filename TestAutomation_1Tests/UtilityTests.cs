namespace Script.Tests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Skyline.DataMiner.DataMinerSolutions.ProcessAutomation.Model;

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

	// DOES NOT WORK: ProcessAutomation.dll cannot run. This first needs to turn into a public NuGet with all dependencies grabbed from DevPack.
	//[TestClass()]
	//public class TestUsingProcessAutomationAssembly
	//{
	//	[TestMethod()]
	//	public void TestCode()
 //       {
	//		ConsumerInfo info = new ConsumerInfo();
	//		info.ConsumerReference = "Test";
	//		Assert.IsNotNull(info.ConsumerReference);
	//	}
	//}
}