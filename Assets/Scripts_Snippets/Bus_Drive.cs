using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus_Drive : MonoBehaviour
{
    public GameObject Player;

    public float BusSped = 0.5f;
    public bool BusPaused = true;


    private void Start()
    {
        Player.SetActive(false);
    }

    void FixedUpdate()
    {
        StartCoroutine(StopBus());
    }


    IEnumerator StopBus() 
    {

            
            transform.Translate(Vector2.left * BusSped * Time.deltaTime);

            yield return new WaitForSeconds(12);


            BusSped = 0f;
            Player.SetActive(true);
            yield return new WaitForSeconds(3);

            BusSped = 2;

            transform.Translate(Vector2.left * BusSped * Time.deltaTime);

            if (transform.position.x <= -14)
                {
                    Destroy(gameObject);
                }
            }
            

      


}
