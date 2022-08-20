

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief エラーログ。
*/


/** BlueBack.Debug
*/
#if(DEF_BLUEBACK_DEBUG_ERRORLOG)
namespace BlueBack.Debug
{
	/** ErrorLog
	*/
	public static class ErrorLog
	{
		/** CallBackType
		*/
		public delegate void CallBackType(string a_message);

		/** Execute
		*/
		public static void Execute(string a_message)
		{
			UnityEngine.Debug.LogError(a_message);
		}
	}
}
#endif

