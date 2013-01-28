using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace BellringingKata
{
	[TestFixture]
	public class BellringingKataTests
	{
		[Test]
		public void Should_return_1_as_the_first_bell()
		{
			var actual = GetBells().First();

			Assert.That(actual, Is.EqualTo(1));
		}

		private IEnumerable<int> GetBells()
		{
			yield return 1;
		}
	}
}