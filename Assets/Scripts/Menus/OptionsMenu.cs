using UnityEngine;

public class OptionsMenu : MonoBehaviour
{

    public void SetFullscreen(bool value) {
        Screen.fullScreen = value;
    }
    public void SetQuality(int index) {
        QualitySettings.SetQualityLevel(index);
    }

}
