using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace BellringingKata
{
	[TestFixture]
	public class BellringingKataTests
	{

		[TestCase(0, 1)]
		[TestCase(1, 2)]
		public void AssertIsExpectedBell(int bellIndex, int bellNumber)
		{
			var actual = GetBells().ElementAt(bellIndex);

			Assert.That(actual, Is.EqualTo(bellNumber));
		}

		private IEnumerable<int> GetBells()
		{
			yield return 1;
			yield return 2;
		}
	}
}