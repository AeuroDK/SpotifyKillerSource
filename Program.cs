using System;
using System.IO;

namespace AddKiller_Spotify
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			try
			{
				using (StreamWriter streamWriter = File.AppendText("C:\\Windows\\System32\\drivers\\etc\\hosts"))
				{
					streamWriter.WriteLine("\r\n0.0.0.0  ads-fa.spotify.com");
					streamWriter.WriteLine("\r\n0.0.0.0  adclick.g.doublecklick.net");
					streamWriter.WriteLine("\r\n0.0.0.0  bounceexchange.com");
					streamWriter.WriteLine("\r\n0.0.0.0  core.insightexpressai.com");
					Console.WriteLine("Succesfully Blocked Spotify ads ;)");
					Console.ReadLine();
				}
			}
			catch
			{
				Console.WriteLine("Something Did wrong Make Sure to Run me as An Administrator ;).");
				Console.Read();
			}
		}
	}
}