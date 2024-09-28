using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vacham : MonoBehaviour
{
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("TENLUA"))
        {
            Destroy(gameObject);
        }
    }
}
