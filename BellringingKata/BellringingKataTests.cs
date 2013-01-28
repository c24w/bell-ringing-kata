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
		public void First_eight_bells_shoud_return_the_expected_number(int bellIndex, int bellNumber)
		{
			var actual = GetBells().ElementAt(bellIndex);

			Assert.That(actual, Is.EqualTo(bellNumber));
		}

		[Test]
		public void Sequence_9_to_16_should_return_the_expected_sequence()
		{
			var actual = GetBells().Skip(8).Take(8).ToArray();

			Assert.That(actual, Is.EqualTo(new[] { 2, 1, 4, 3, 6, 5, 8, 7 }));
		}

		private static IEnumerable<int> GetBells()
		{
			var bells = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
			foreach (var bellNumber in bells)
			{
				yield return bellNumber;
			}

			for (var i = 0; i < bells.Length; i+=2)
			{
				yield return bells[i + 1];
				yield return bells[i];
			}
		}
	}
}