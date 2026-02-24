using UnityEngine;

public class gol : MonoBehaviour
{   
    void OnTriggerEnter2D (Collider2D hitInfo) {
        if (hitInfo.tag == "disco")
        {
            string wallName = transform.name;
        }
    }

}
