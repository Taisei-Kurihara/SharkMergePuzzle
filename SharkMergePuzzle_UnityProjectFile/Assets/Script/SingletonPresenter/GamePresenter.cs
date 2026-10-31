using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class GamePresenter : Singleton<GamePresenter>
{
    #region ローカル変数

    private PoolManager _poolManager;
    private ILoadsystem _loadSystem;
    private InGameManager _inGameManager;

    #endregion

    protected override void Awake()
    {
        base.Awake();
    }

    /// <summary> InGameManagerの初期化とゲーム開始. </summary>
    public void StartInGame()
    {
        InitGame(this.GetCancellationTokenOnDestroy()).Forget();
    }

    private async UniTask InitGame(CancellationToken cancellationToken)
    {
        _poolManager = new PoolManager();
        _loadSystem = new Loadsystem_AddressablesManager();

        _inGameManager = new InGameManager();
        _inGameManager.StartUP(_poolManager);
    }
}
