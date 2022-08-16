

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief アサート。
*/


/** BlueBack.Debug
*/
#if(DEF_BLUEBACK_DEBUG_ASSERT)
namespace BlueBack.Debug
{
	/** Assert
	*/
	public static class Assert
	{
		/** Default
		*/
		public static void Default(string a_message,System.Exception a_exception)
		{
			if(a_message != null){
				UnityEngine.Debug.LogError(a_message);
			}

			if(a_exception != null){
				UnityEngine.Debug.LogError(a_exception.ToString());
			}

			UnityEngine.Debug.Assert(false);
		}

		/** ProcType
		*/
		public delegate void ProcType(string a_message,System.Exception a_exception);
	}
}
#endif

