using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DISTRO_GIAP : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.position = player.transform.position;
    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("TENLUA"))
        {
            Destroy(gameObject);
        }
    }

}
