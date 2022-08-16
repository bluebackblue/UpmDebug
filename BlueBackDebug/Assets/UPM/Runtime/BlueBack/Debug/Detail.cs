

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

