using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 90 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Hero")
        {
            //sound effect
            SoundManagerScript.PlaySound("coinPickup");

            ScoreManager.instance.AddPoint();
            Destroy(gameObject);
        }
    }
}
