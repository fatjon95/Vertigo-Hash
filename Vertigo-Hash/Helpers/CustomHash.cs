using System;
namespace Vertigo_Hash.Helpers
{
	public static class CustomHash
	{
		public static long Hash(string input)
		{
			long hash = 0;

			for(int i=0; i< input.Length; i++)
			{
				hash = (hash * 31) + (long)input[i];
			}

			return hash;
		}
	}
}

