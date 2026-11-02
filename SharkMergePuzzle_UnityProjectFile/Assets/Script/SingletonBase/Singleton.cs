/// <summary>
/// 非MonoBehaviourシングルトン基底クラス.
/// シーン探索・重複排除は行わない.
/// </summary>
public class Singleton<T> where T : Singleton<T>, new()
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new T();
                instance.OnInitialize();
            }
            return instance;
        }
    }

    /// <summary> 初期化時に呼ばれる. オーバーライドして使用. </summary>
    protected virtual void OnInitialize() { }
}