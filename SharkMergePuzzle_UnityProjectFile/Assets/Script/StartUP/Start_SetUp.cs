using UnityEngine;

public class Start_SetUp
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    static void Init()
    {
        Debug.Log("Start_SetUp/Init_0:UnityProject実行開始");

    }
}
