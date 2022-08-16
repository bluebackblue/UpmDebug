

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief エラーログ。
*/


/** BlueBack.Debug
*/
#if(DEF_BLUEBACK_DEBUG_LOG)
namespace BlueBack.Debug
{
	/** ErrorLog
	*/
	public static class ErrorLog
	{
		/** Default
		*/
		public static void Default(string a_message)
		{
			if(a_message != null){
				UnityEngine.Debug.LogError(a_message);
			}
		}

		/** ProcType
		*/
		public delegate void ProcType(string a_message);
	}
}
#endif

