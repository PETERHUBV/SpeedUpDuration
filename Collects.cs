using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collects : MonoBehaviour
{

    public float Speeding =3;
    public float SpeedDuration  =10;




    public bool isCoins, isSpeedUp, isSpeedBoost;
    // Start is called before the first frame update


    private void OnTriggerEnter(Collider other)
    {

        Test Player = other.GetComponent<Test>();
        if (other.CompareTag("Player"))
        {
            if (isCoins)
            {

                Player.score++;
                Destroy(gameObject);
            }
            if (isSpeedUp)
            {

                Player.moveSpeed += 1.2f;
                Destroy(gameObject);
            }
            if (isSpeedBoost)
            {

                Destroy(gameObject);

            }


        }

    }
}




            
     

           

    


// Update is called once per frame


