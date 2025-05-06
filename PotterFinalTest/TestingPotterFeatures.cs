using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace PotterFinalTest;

using Xunit;
public class TestingPotterFeatures
{
	private TestingPotterFeatures tester = new TestingPotterFeatures();
	
	[Theory] 
	[InlineData("Ravenclaw")] 
	[InlineData("Slytherin")] 
	[InlineData("Hufflepuff")] 
	[InlineData("Gryffindor")]
	
	public void UserGetHouseCorrectResult(string userInputHouseName)
	{ 
		// Create a test where a User does get house and returns the house they selected
		string result = tester.Evaluate(userInputHouseName);
		Assert.Equal(userInputHouseName, result);
	}
}
