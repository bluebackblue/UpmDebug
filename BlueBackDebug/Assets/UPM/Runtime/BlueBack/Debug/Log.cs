

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
		/** Default
		*/
		public static void Default(string a_message)
		{
			if(a_message != null){
				UnityEngine.Debug.Log(a_message);
			}
		}

		/** ProcType
		*/
		public delegate void ProcType(string a_message);
	}
}
#endif

