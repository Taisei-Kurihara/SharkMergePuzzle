using UnityEngine;

public enum AspectState
{
    landscape   = 1<<0, // ‰¡’·‰æ–Ê
    portrait    = 1<<1, // c’·‰æ–Ê
}

/// <summary>
/// ‰æ–Êaspect”ä‚ð•Ï‚¦‚é‚½‚ß‚ÌcanvasŽæ“¾‚Ì‚½‚ß‚ÌView
/// </summary>
public class AspectCanvasBinder : InspectorSetOnlyBinder
{
    [SerializeField] Canvas landscapeCanvas;
    [SerializeField] Canvas portraitCanvas;

    protected override void HandOverPresenter()
    {
    }
}
