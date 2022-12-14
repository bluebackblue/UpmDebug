

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

