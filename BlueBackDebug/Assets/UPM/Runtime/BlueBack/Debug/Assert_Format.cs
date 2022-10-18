

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
	/** Assert_Format
	*/
	public sealed class Assert_Format
	{
		/** format
		*/
		public string format;

		/** callback
		*/
		public Assert.CallBackType callback;

		/** constructor
		*/
		public Assert_Format(string a_format,Assert.CallBackType a_callback)
		{
			//format
			this.format = a_format;

			//callback
			this.callback = a_callback;
		}

		/** Execute
		*/
		public void Execute(string a_message,System.Exception a_exception)
		{
			string t_message;
			if(a_message == null){
				t_message = null;
			}else{
				t_message = string.Format(this.format,a_message);
			}
			this.callback(t_message,a_exception);
		}
	}
}
#endif

