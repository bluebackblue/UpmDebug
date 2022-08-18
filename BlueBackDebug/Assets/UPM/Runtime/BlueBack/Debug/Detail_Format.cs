

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
	/** Detail_Format
	*/
	public sealed class Detail_Format
	{
		/** format
		*/
		public string format;

		/** callback
		*/
		public Detail.CallBackType callback;

		/** constructor
		*/
		public Detail_Format(string a_format,Detail.CallBackType a_callback)
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

