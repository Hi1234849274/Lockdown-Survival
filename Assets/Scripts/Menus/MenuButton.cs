using UnityEngine;

public class MenuButton : MonoBehaviour {
    public AudioManager aM;

    void Start() {
        aM = FindObjectOfType<AudioManager>();
    }
    void OnMouseOver() {
        aM.Play("Button Hover");
    }
}