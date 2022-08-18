

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief ログ。
*/


/** BlueBack.Debug
*/
#if(DEF_BLUEBACK_DEBUG_LOG)
namespace BlueBack.Debug
{
	/** Log
	*/
	public static class Log
	{
		/** CallBackType
		*/
		public delegate void CallBackType(string a_message);

		/** Execute
		*/
		public static void Execute(string a_message)
		{
			UnityEngine.Debug.Log(a_message);
		}
	}
}
#endif

