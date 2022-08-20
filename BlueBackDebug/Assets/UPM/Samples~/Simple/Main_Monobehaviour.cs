

/** BlueBack.Debug.Samples.Simple
*/
#if(!DEF_BLUEBACK_DEBUG_SAMPLES_DISABLE)
namespace BlueBack.Debug.Samples.Simple
{
	/** Main_Monobehaviour
	*/
	public sealed class Main_Monobehaviour : UnityEngine.MonoBehaviour
	{
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
			BlueBack.Debug.Log.Execute("Log");
			#endif

			#if(DEF_BLUEBACK_DEBUG_DETAIL)
			BlueBack.Debug.Detail.Execute("Detail");
			#endif

			#if(DEF_BLUEBACK_DEBUG_ERRORLOG)
			BlueBack.Debug.ErrorLog.Execute("ErrorLog");
			#endif

			#if(DEF_BLUEBACK_DEBUG_ASSERT)
			BlueBack.Debug.Assert.Execute("Assert",null);
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

