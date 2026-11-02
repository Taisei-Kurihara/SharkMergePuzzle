using UnityEngine;

/// <summary>
/// Binder クラスの破棄方法を示す列挙型.
/// </summary>
public enum BinderDestructionType
{
    ComponentOnly,      // プレハブなどにある、このバインダー（コンポーネント）のみを削除.
    GameObjectIfEmpty,  // 他のGameObjectに他のコンポーネントが残っていなければ GameObjectごと削除.
    GameObjectForce     // 他のコンポーネントの有無に関わらず、GameObjectごと強制削除.
}

/// <summary>
/// scene上にあるものを Presenter に引き渡す機能のみを持つクラスとして実装することを宣言するためのクラス.
/// 終了時には指定された方法で自壊する.
/// </summary>
public abstract class InspectorSetOnlyBinder : MonoBehaviour
{
    // 子クラスでオーバーライドするとコンポーネントアタッチ時の type 初期値が変わる.
    protected virtual BinderDestructionType DefaultType => BinderDestructionType.ComponentOnly;
    [SerializeField] private BinderDestructionType type;

    // コンポーネントをアタッチした瞬間に Unity が呼ぶ（Editorのみ）.
    private void Reset() => type = DefaultType;

    private void Awake()
    {
        HandOverPresenter();
    }

    protected abstract void HandOverPresenter();
}
