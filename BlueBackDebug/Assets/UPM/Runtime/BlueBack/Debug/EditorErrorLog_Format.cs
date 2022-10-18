

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
	/** EditorErrorLog_Format
	*/
	public sealed class EditorErrorLog_Format
	{
		/** format
		*/
		public string format;

		/** callback
		*/
		public EditorErrorLog.CallBackType callback;

		/** constructor
		*/
		public EditorErrorLog_Format(string a_format,EditorErrorLog.CallBackType a_callback)
		{
			//format
			this.format = a_format;

			//callback
			this.callback = a_callback;
		}

		/** Execute
		*/
		public void Execute(string a_message)
		{
			string t_message;
			if(a_message == null){
				t_message = null;
			}else{
				t_message = string.Format(this.format,a_message);
			}
			this.callback(t_message);
		}
	}
}
#endif

