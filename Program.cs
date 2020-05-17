using System;

namespace Mp3Size_CLI
{
	/**
	 * *mp3size*
	 *
	 * Calculates an estimated file size of Mp3 files.
	 *
	 * Author: Igor Dimitrijević <igor.dvlpr@gmail.com>, 2020.
	 * Version: 1.0.1
	 * License: MIT, see LICENSE.txt.
	 *
	 * Note: does NOT validate any input, that's up to you. :)
	 */

	class Program
	{
		static void Run(string[] args)
		{
			string time;
			int bitrate = 160;

			if (args.Length > 0)
			{
				time = args[0];

				if (args.Length > 1)
				{
					int.TryParse(args[1], out bitrate);
				}
			}
			else
			{
				Console.Write("Mp3 file time (MM:ss or HH:MM:ss): ");
				time = Console.ReadLine();

				Console.Write("Bitrate in Kbps: ");
				int.TryParse(Console.ReadLine(), out bitrate);
			}

			Console.WriteLine();

			int fileSize = Mp3Size.GetFileSize(time, bitrate);

			if (fileSize == -1)
			{
				Console.WriteLine("Not a valid time format.");
			}
			else
			{
				Console.WriteLine($"File size: {fileSize}KB");
			}

			Console.WriteLine();
			Console.WriteLine("Press 'A' to calculate the size of a new file or any other key to exit...");

			ConsoleKeyInfo key = Console.ReadKey();

			if (key.KeyChar == 'A' || key.KeyChar == 'a')
			{
				Console.Clear();

				// discard the initial arguments
				Run(Array.Empty<string>());
			}
			else
			{
				Environment.Exit(0);
			}
		}

		static void Main(string[] args)
		{
			Run(args);
		}
	}
}
