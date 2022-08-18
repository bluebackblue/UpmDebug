

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief ログ。
*/


/** BlueBack.Debug
*/
#if(UNITY_EDITOR)
namespace BlueBack.Debug
{
	/** EditorLog
	*/
	public static class EditorLog
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

