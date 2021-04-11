using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float moveHorizontal, moveVertical;
    Vector3 movment;
    public float speed;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
        movment = new Vector3(moveHorizontal, moveVertical, 0);
        movment = movment.normalized;
        rb.MovePosition(transform.position + (movment * speed * Time.deltaTime));
        //transform.position = transform.position + (movment * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {

    }

    private void OnTriggerEnter(Collider other)
    {

    }
}
