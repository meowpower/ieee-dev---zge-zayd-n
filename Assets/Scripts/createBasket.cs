using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBasket : MonoBehaviour
{
    public GameObject basketPrefab;
    void start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
        {
            Vector3 randomBasketPosition = new Vector3(Random.Range(-7,8),0,Random.Range(-7,8));
            Instantiate(basketPrefab , randomBasketPosition, Quaternion.identity);
        }
}
