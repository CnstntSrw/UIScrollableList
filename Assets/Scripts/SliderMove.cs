using UnityEngine;
using UnityEngine.UI;

public class SliderMove : MonoBehaviour
{
    public ScrollRect Rect;
    public Slider ScrollSlider;

    private void Update()
    {
        Rect.verticalNormalizedPosition = 1 - ScrollSlider.value;
    }
}