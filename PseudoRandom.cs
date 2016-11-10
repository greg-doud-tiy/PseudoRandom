// PseudoRandom numbers
using System;
namespace GregoryDoud {
	/// <summary>
	/// Generates pseudo-random numbers in various ways
	/// a single random number
	/// </summary>
	public class PseudoRandom {
		static Random rnd = null;
		/// <summary>
		/// Gets a pseudo-random integer between 1 & max inclusive
		/// </summary>
		public static int GetInt(int max = int.MaxValue) {
			return rnd.Next(max) + 1;
		}
		static PseudoRandom() {
			rnd = new Random(DateTime.Now.Millisecond);
		}
	}
}