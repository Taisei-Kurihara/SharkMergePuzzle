using UnityEngine;

/// <summary>
/// scene“à‚É‚ ‚é‚à‚Ì‚ð Presenter ‚Éˆø‚«“n‚·
/// </summary>
public abstract class InspectorSetOnlyView : MonoBehaviour
{
    private void Awake()
    {
        HandOverPresenter();
    }

    protected abstract void HandOverPresenter();
}
