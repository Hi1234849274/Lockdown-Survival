using UnityEngine;

public class Water : MonoBehaviour
{
public float maxWater = 100f;
protected float currentWater;


    void Start() {
        currentWater = maxWater;
    }
    void Update() {
        currentWater -= (Time.deltaTime * 0.002f);
    }
    public void DrinkWater(float waterAmount) {
        currentWater += waterAmount;
    }
}