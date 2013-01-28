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
		[TestCase(2, 3)]
		[TestCase(3, 4)]
		[TestCase(4, 5)]
		[TestCase(5, 6)]
		[TestCase(6, 7)]
		[TestCase(7, 8)]
		public void AssertIsExpectedBell(int bellIndex, int bellNumber)
		{
			var actual = GetBells().ElementAt(bellIndex);

			Assert.That(actual, Is.EqualTo(bellNumber));
		}

		private IEnumerable<int> GetBells()
		{
			var currentBell = 1;
			while (true) yield return currentBell++;
		}
	}
}