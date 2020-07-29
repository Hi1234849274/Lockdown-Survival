using UnityEngine;

public class Interactable : MonoBehaviour {
    
    private GameObject effect;
    private bool canInteract = false;

    public GameObject Player;
    public GameObject InteractableEffect;

    public float maxDistanceToInteract = 5f;

    
    void Update() {
        if (Vector2.Distance(Player.transform.position, transform.position) < maxDistanceToInteract) {
            if (effect != null) {
                effect = Instantiate(InteractableEffect, transform.position, Quaternion.identity);
            }
            canInteract = true;
        } else {
            canInteract = false;
            if (effect != null) {
                Destroy(gameObject);
            }
        }
        if (Input.GetKeyDown(KeyCode.E)) {
            if (canInteract) {
                Debug.Log("Interacting with " + gameObject);
                gameObject.SendMessage("Interact", SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}