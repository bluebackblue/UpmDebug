

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief デバッグツール。
*/


/** BlueBack.Debug
*/
namespace BlueBack.Debug
{
	/** DebugTool
	*/
	public static class DebugTool
	{
		#if(DEF_BLUEBACK_DEBUG_ASSERT)

		/** assert
		*/
		public static BlueBack.Debug.Assert.CallBackType assert = BlueBack.Debug.Assert.Execute;

		/** Assert
		*/
		public static void Assert(bool a_flag,System.Exception a_exception = null)
		{
			if(a_flag != true){
				DebugTool.assert(null,a_exception);
			}
		}

		/** Assert
		*/
		public static void Assert(bool a_flag,string a_message)
		{
			if(a_flag != true){
				DebugTool.assert(a_message,null);
			}
		}

		#endif

		#if(DEF_BLUEBACK_DEBUG_LOG)

		/** log
		*/
		public static BlueBack.Debug.Log.CallBackType log = BlueBack.Debug.Log.Execute;

		/** Log
		*/
		public static void Log(string a_message)
		{
			DebugTool.log(a_message);
		}

		#endif

		#if(DEF_BLUEBACK_DEBUG_DETAIL)

		/** detail
		*/
		public static BlueBack.Debug.Detail.CallBackType detail = BlueBack.Debug.Detail.Execute;

		/** Detail
		*/
		public static void Detail(string a_message)
		{
			DebugTool.detail(a_message);
		}

		#endif

		#if(UNITY_EDITOR)

		/** editorlog
		*/
		public static BlueBack.Debug.EditorLog.CallBackType editorlog = BlueBack.Debug.EditorLog.Execute;

		/** editorerrorlog
		*/
		public static BlueBack.Debug.EditorErrorLog.CallBackType editorerrorlog = BlueBack.Debug.EditorErrorLog.Execute;

		/** EditorLog
		*/
		public static void EditorLog(string a_message)
		{
			DebugTool.editorlog(a_message);
		}

		/** EditorErrorLog
		*/
		public static void EditorErrorLog(string a_message)
		{
			DebugTool.editorerrorlog(a_message);
		}

		#endif
	}
}

