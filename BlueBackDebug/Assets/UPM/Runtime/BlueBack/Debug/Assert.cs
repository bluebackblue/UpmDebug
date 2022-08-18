

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
		/** CallBackType
		*/
		public delegate void CallBackType(string a_message,System.Exception a_exception);

		/** Execute
		*/
		public static void Execute(string a_message,System.Exception a_exception)
		{
			if(a_message != null){
				UnityEngine.Debug.LogError(a_message);
			}

			if(a_exception != null){
				UnityEngine.Debug.LogError(string.Format("{0}\n{1}\n{2}",a_exception.Message,a_exception.StackTrace,a_exception.ToString()));
			}

			UnityEngine.Debug.Assert(false);
		}
	}
}
#endif

