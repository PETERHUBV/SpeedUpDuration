using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public float jumpForce;
    public float moveSpeed;
    public float rotationSpeed;
    public Rigidbody rigidbody;
    public int score;
    public float baseMoveSpeed;
    // Start is called before the first  frame update
    void Start()
    {
        rigidbody=GetComponent<Rigidbody>();
        baseMoveSpeed=moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * moveSpeed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0,0,translation);
        transform.Rotate(0, rotation, 0);



        if (Input.GetButton("Jump"))
        {
            rigidbody.AddForce(new Vector3(0, jumpForce,0),ForceMode.Impulse);
        }
    }
}
