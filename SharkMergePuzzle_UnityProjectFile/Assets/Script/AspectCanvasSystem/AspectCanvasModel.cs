using System;

public class AspectCanvasModel
{
    // Presenterから渡されたAspectState変更用コールバック.
    private readonly Action<AspectState> _onAspectStateChanged;

    public AspectCanvasModel(Action<AspectState> onAspectStateChanged)
    {
        _onAspectStateChanged = onAspectStateChanged;
    }
}
