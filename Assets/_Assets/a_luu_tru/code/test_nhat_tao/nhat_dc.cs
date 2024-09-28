using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nhat_dc : MonoBehaviour
{

    public GameObject player;
    public GameObject giap;
    public GameObject new_giap;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {


            Vector2 vitrino = new Vector2(player.transform.position.x,player. transform.position.y);
            //Destroy(gameObject);
            new_giap = Instantiate(giap, vitrino, Quaternion.identity);
            Destroy(gameObject);
            Debug.Log("co cham ko");
        }
    } 

}
