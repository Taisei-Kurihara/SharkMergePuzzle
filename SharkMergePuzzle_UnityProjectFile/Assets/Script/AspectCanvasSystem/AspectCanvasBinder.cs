using UnityEngine;

/// <summary>
/// 画面aspect比を変えるためのcanvas取得のためのView
/// 表示非表示を切り替えるためだけの物なので ボタンなど中身の要素については扱わない
/// </summary>
public class AspectCanvasBinder : InspectorSetOnlyBinder
{
    [SerializeField] private Canvas landscapeCanvas;
    [SerializeField] private Canvas portraitCanvas;

    protected override void HandOverPresenter()
    {
    }
}
