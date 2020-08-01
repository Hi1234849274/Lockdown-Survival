using UnityEngine;
using UnityEngine.UI;

public class ShopCard : MonoBehaviour {
    
    GameManager gM;
    Button buttonComponent;
    public Item item;
    
    void Start() {
        gM = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    public void ShopForItem() {
        Instantiate(item.prefab, gM.DeliverySpot.position, Quaternion.identity);
        Debug.Log("I just shopped for a " + item.name.ToString());
        Destroy(gameObject);
    }

}