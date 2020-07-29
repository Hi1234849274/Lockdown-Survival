using UnityEngine;

[CreateAssetMenu(menuName = "Shopping/Item", fileName = "New Item")]
public class Item : ScriptableObject {
public new string name;
[TextArea(0, 10)]
public string description;
public Sprite artWork;
public int price;
public GameObject prefab;
}