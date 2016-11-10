// PseudoRandom numbers
using System;
namespace GregoryDoud {
	public class PseudoRandom {
		static Random rnd = null;
		/// <summary>
		/// Gets a pseudo-random integer between 0 & 2^32 inclusive
		/// </summary>
		public static int GetInt() {
			return rnd.Next();
		}
		static PseudoRandom() {
			rnd = new Random(DateTime.Now.Millisecond);
		}
	}
}