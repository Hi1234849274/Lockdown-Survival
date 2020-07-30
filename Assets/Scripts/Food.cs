using UnityEngine;

public class Food : MonoBehaviour
{
public float maxFood = 100f;
protected float currentFood;


    void Start() {
        currentFood = maxFood;
    }
    void Update() {
        currentFood -= (Time.deltaTime * 0.002f);
    }
    public void EatFood(float foodAmount) {
        currentFood += foodAmount;
    }
}