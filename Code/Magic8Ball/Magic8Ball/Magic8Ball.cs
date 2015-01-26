using System;

namespace Magic8BallShared
{
	public class Magic8Ball
	{
		private static string[] phrases = new string[] {
			"It is certain",
			"It is decidedly so",
			"Without a doubt",
			"Yes definitely",
			"You may rely on it",
			"As I see it, yes",
			"Most likely",
			"Outlook good",
			"Yes",
			"Signs point to yes",
			"Reply hazy try again",
			"Ask again later",
			"Better not tell you now",
			"Cannot predict now",
			"Concentrate and ask again",
			"Don't count on it",
			"My reply is no",
			"My sources say no",
			"Outlook not so good",
			"Very doubtful"
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

