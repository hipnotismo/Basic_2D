using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D body;
    
    Vector2 movement;

    public float runSpeed = 10.0f;
    private float timer = 0.0f;
    private bool contact = false;

    public delegate void OnPressAction(int sprit);
    public static event OnPressAction buttonAction;

    void Start()
    {
        buttonAction?.Invoke(0);
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (Input.GetKey(KeyCode.S))
        {
            buttonAction?.Invoke(0);

        }
        if (Input.GetKey(KeyCode.W))
        {
            buttonAction?.Invoke(1);

        }
        if (Input.GetKey(KeyCode.A))
        {
            buttonAction?.Invoke(2);

        }
        if (Input.GetKey(KeyCode.D))
        {
            buttonAction?.Invoke(3);

        }

        if (contact)
        {
            timer += Time.deltaTime;
            Debug.Log(timer);
            if (timer >= 5)
            {
                contact = false;
            }
            body.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
            body.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
        }
    }

   
    private void FixedUpdate()
    {
        body.MovePosition(body.position + movement * runSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OnCollisionEnter2D");
        body.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        contact = true;
    }
    //void OnTri(Collision2D col)
    //{
    //    Debug.Log("OnCollisionEnter2D");
    //}
}