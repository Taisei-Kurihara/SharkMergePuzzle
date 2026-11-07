using UnityEngine;

public enum AspectState
{
    landscape = 1 << 0, // �������
    portrait = 1 << 1, // �c�����
}



public class AspectCanvasPresenter
{
    private AspectState _aspectState;
    public AspectState AspectState => _aspectState;

    private void AspectStateChanger(AspectState aspectState) => _aspectState = aspectState;

    
    private Canvas _landscapeCanvas;
    private Canvas _portraitCanvas;


    public AspectCanvasPresenter(Canvas landscapeCanvas,Canvas portraitCanvas)
    {
        _landscapeCanvas = landscapeCanvas;
        _portraitCanvas = portraitCanvas;

        // AspectStateChangerをModelに渡し、Modelが任意タイミングで呼べるようにする.
        var model = new AspectCanvasModel(AspectStateChanger);
    }


}
