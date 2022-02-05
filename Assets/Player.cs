using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField]

    private float jumpPower = 800;

    [SerializeField]

    private float moveSpeed = 10;

    private bool grounded;







    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();






    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))

        {
            transform.position += transform.TransformDirection(Vector3.forward * moveSpeed * Time.deltaTime);




        }

        if (Input.GetKey(KeyCode.S))

        {
            transform.position += transform.TransformDirection(Vector3.back * moveSpeed * Time.deltaTime);



        }

        if (Input.GetKey(KeyCode.A))

        {
            transform.Rotate(new Vector3(0, -5, 0));



        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 5, 0));




        }
        if (Input.GetKeyDown(KeyCode.Space))

        {
            if (grounded == true)

            {
                rb.AddForce(Vector3.up * jumpPower);



            }








        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")

        {

            grounded = true;

        }



    }

    private void OnCollisionExit(Collision collision)
    {

        if (collision.gameObject.tag == "Ground")


        {
            grounded = false;


        }





    }











}
