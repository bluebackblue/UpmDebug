

/** BlueBack.Debug.Samples.Simple
*/
#if(!DEF_BLUEBACK_DEBUG_SAMPLES_DISABLE)
namespace BlueBack.Debug.Samples.Simple
{
	/** Main_Monobehaviour
	*/
	public sealed class Main_Monobehaviour : UnityEngine.MonoBehaviour
	{
		/** FORMAT
		*/
		private const string FORMAT = "<color=#FFCC99FF><b>{0}</b></color>";

		/** Awake
		*/
		private void Awake()
		{
		}

		/** Start
		*/
		private void Start()
		{
			#if(DEF_BLUEBACK_DEBUG_LOG)
			{
				BlueBack.Debug.Log.Execute("Log");
				BlueBack.Debug.Log.CallBackType t_callback = new BlueBack.Debug.Log_Format(FORMAT,BlueBack.Debug.Log.Execute).Execute;
				t_callback("Log_Format");
			}
			#endif

			#if(DEF_BLUEBACK_DEBUG_DETAIL)
			{
				BlueBack.Debug.Detail.Execute("Detail");
				BlueBack.Debug.Detail.CallBackType t_callback = new BlueBack.Debug.Detail_Format(FORMAT,BlueBack.Debug.Detail.Execute).Execute;
				t_callback("Detail_Format");
			}
			#endif

			#if(DEF_BLUEBACK_DEBUG_ERRORLOG)
			{
				BlueBack.Debug.ErrorLog.Execute("ErrorLog");
				BlueBack.Debug.ErrorLog.CallBackType t_callback = new BlueBack.Debug.ErrorLog_Format(FORMAT,BlueBack.Debug.ErrorLog.Execute).Execute;
				t_callback("ErrorLog_Format");
			}
			#endif

			#if(DEF_BLUEBACK_DEBUG_ASSERT)
			{
				BlueBack.Debug.Assert.Execute("Assert",null);
				BlueBack.Debug.Assert.CallBackType t_callback = new BlueBack.Debug.Assert_Format(FORMAT,BlueBack.Debug.Assert.Execute).Execute;
				t_callback("Assert_Format",null);
			}
			#endif
		}

		/** OnDestroy
		*/
		private void OnDestroy()
		{
		}

		/** Update
		*/
		private void Update()
		{
		}
	}
}
#endif

