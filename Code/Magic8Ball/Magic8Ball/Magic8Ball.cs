using System;

namespace Magic8Ball
{
	public class Magic8Ball
	{
		private static string[] phrases = new string[] {
			"Hello world"
		};

		private Random r = new Random();

		public Magic8Ball ()
		{
		
		}

		public string Shake() 
		{
			int i = r.Next (0, phrases.Length - 1);
			return phrases [i];
		}
	}
}

