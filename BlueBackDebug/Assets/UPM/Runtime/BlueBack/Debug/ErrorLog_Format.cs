

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
	/** ErrorLog_Format
	*/
	public sealed class ErrorLog_Format
	{
		/** format
		*/
		public string format;

		/** callback
		*/
		public ErrorLog.CallBackType callback;

		/** constructor
		*/
		public ErrorLog_Format(string a_format,ErrorLog.CallBackType a_callback)
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
			this.callback(string.Format(this.format,a_message));
		}
	}
}
#endif

