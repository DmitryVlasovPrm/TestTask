namespace TestTask
{
	public static class StringFunctions
	{
		public static string GetOnlyNumbers(string str)
		{
			var result = "";
			for (var i = 0; i < str.Length; i++)
				if (char.IsDigit(str[i])) result += str[i];

			return result;
		}

		public static string TrimSpecificSymbols(string str)
		{
			var startPos = 0;
			var length = str.Length;
			while (startPos < length)
			{
				if (!char.IsLetterOrDigit(str[startPos])) startPos++;
				else break;
			}
			str = str.Remove(0, startPos);

			length = str.Length;
			var endPos = length - 1;
			while (endPos >= 0)
			{
				if (!char.IsLetterOrDigit(str[endPos])) endPos--;
				else break;
			}
			endPos++;
			str = str.Remove(endPos, length - endPos);

			return str;
		}

		public static string GetFileName(string path)
		{
			var startId = path.LastIndexOf('/');
			if (startId == -1)
				startId = path.LastIndexOf('\\');

			if (startId == -1)
			{
				return path;
			}
			else
			{
				startId++;
				return path.Substring(startId, path.Length - startId);
			}
		}
	}
}
