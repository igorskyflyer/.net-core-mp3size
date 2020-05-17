namespace Mp3Size_CLI
{
	class Mp3Size
	{
		/// <summary>
		/// Gets the size of 1 second of Mp3 file for the provided bitrate.
		/// </summary>
		/// <param name="rate">the bitrate, defaults to 160Kbps</param>
		/// <returns>the size of 1 second of Mp3 file in bits</returns>
		private static int GetBitrate(int rate = 160)
		{
			if (rate >= 8)
			{
				return rate / 8;
			}
			else
			{
				return 160 / 8;
			}
		}

		/// <summary>
		/// Parses and returns the time of the Mp3 file.
		/// </summary>
		/// <param name="time">expects HH:MM:ss or MM:ss formatted string</param>
		/// <returns>the number of seconds or -1 if the provided input is not valid</returns>
		private static int GetAudioLength(string time)
		{
			try
			{
				string[] digits = time.Split(":");
				int count = digits.Length;

				// assuming MM:ss format
				if (count == 2)
				{
					int minutes = int.Parse(digits[0]);
					int seconds = int.Parse(digits[1]);

					return minutes * 60 + seconds;
				}
				// assuming HH:MM:ss format
				else if (count == 3)
				{
					int hours = int.Parse(digits[0]);
					int minutes = int.Parse(digits[1]);
					int seconds = int.Parse(digits[2]);

					return hours * 3600 + minutes * 60 + seconds;
				}
				else
				{
					return -1;
				}
			}
			catch
			{
				return -1;
			}
		}

		/// <summary>
		///  Gets the estimated size of the Mp3 file based on the audio time and bitrate.
		/// </summary>
		/// <param name="time">the length of the Mp3 file</param>
		/// <param name="rate">the bitrate of the file, defaults to 160</param>
		/// <returns>the estimated Mp3 file size (in KB) or -1 in case of an error</returns>
		public static int GetFileSize(string time, int rate = 160)
		{
			int audioLength = GetAudioLength(time);

			if (audioLength > -1)
			{
				return audioLength * GetBitrate(rate);
			}
			else
			{
				return -1;
			}
		}
	}
}
