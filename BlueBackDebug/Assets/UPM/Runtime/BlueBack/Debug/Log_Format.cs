

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
	/** Log_Format
	*/
	public sealed class Log_Format
	{
		/** format
		*/
		public string format;

		/** callback
		*/
		public Log.CallBackType callback;

		/** constructor
		*/
		public Log_Format(string a_format,Log.CallBackType a_callback)
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

