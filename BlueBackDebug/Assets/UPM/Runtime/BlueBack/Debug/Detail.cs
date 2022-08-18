

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief 詳細。
*/


/** BlueBack.Debug
*/
#if(DEF_BLUEBACK_DEBUG_DETAIL)
namespace BlueBack.Debug
{
	/** Detail
	*/
	public static class Detail
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

