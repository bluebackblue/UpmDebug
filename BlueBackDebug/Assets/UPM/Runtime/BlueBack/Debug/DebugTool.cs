

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief デバッグツール。
*/


/** define
*/
#define ASMDEF_TRUE


/** BlueBack.Debug
*/
namespace BlueBack.Debug
{
	/** DebugTool
	*/
	public static class DebugTool
	{
		#if(DEF_BLUEBACK_DEBUG_ASSERT)

		/** assertproc
		*/
		#if(ASMDEF_TRUE)
		public static BlueBack.Debug.Assert.CallBackType assertproc = BlueBack.Debug.Assert.Execute;
		#endif

		/** Assert
		*/
		public static void Assert(bool a_flag,System.Exception a_exception = null)
		{
			if(a_flag != true){
				#if(ASMDEF_TRUE)
				DebugTool.assertproc(null,a_exception);
				#endif
			}
		}

		/** Assert
		*/
		public static void Assert(bool a_flag,string a_message)
		{
			if(a_flag != true){
				#if(ASMDEF_TRUE)
				DebugTool.assertproc(a_message,null);
				#endif
			}
		}

		#endif

		#if(DEF_BLUEBACK_DEBUG_LOG)

		/** logproc
		*/
		#if(ASMDEF_TRUE)
		public static BlueBack.Debug.Log.CallBackType logproc = BlueBack.Debug.Log.Execute;
		#endif

		/** Log
		*/
		public static void Log(string a_message)
		{
			#if(ASMDEF_TRUE)
			DebugTool.logproc(a_message);
			#endif
		}

		#endif

		#if(DEF_BLUEBACK_DEBUG_DETAIL)

		/** detailproc
		*/
		#if(ASMDEF_TRUE)
		public static BlueBack.Debug.Detail.CallBackType detailproc = BlueBack.Debug.Detail.Execute;
		#endif

		/** Detail
		*/
		public static void Detail(string a_message)
		{
			#if(ASMDEF_TRUE)
			DebugTool.detailproc(a_message);
			#endif
		}

		#endif

		#if(UNITY_EDITOR)

		/** editorlogproc
		*/
		#if(ASMDEF_TRUE)
		public static BlueBack.Debug.Log.CallBackType editorlogproc = BlueBack.Debug.Log.Execute;
		#endif

		/** editorerrorlogproc
		*/
		#if(ASMDEF_TRUE)
		public static BlueBack.Debug.ErrorLog.CallBackType editorerrorlogproc = BlueBack.Debug.ErrorLog.Execute;
		#endif

		/** EditorLog
		*/
		public static void EditorLog(string a_message)
		{
			#if(ASMDEF_TRUE)
			DebugTool.editorlogproc(a_message);
			#endif
		}

		/** EditorErrorLog
		*/
		public static void EditorErrorLog(string a_message)
		{
			#if(ASMDEF_TRUE)
			DebugTool.editorerrorlogproc(a_message);
			#endif
		}

		#endif
	}
}

