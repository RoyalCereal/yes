using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    public float jumpS;
    public Rigidbody2D rb2D;
    
   
    public int jumpTimes=2;

  
    public GameObject bxC;
    bool jumpCheck;

    // Start is called before the first frame update
    void Start()
    {
        rb2D =GetComponent<Rigidbody2D>();
        
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Jump")&&jumpTimes>0)
        {
            // rb2D.AddForce(new Vector3(0f, jumpS, 0f), ForceMode2D.Impulse);
            rb2D.velocity = Vector3.up * jumpS;
            jumpTimes--;
        }

      

        
    }

    private void FixedUpdate()
    {
        Vector3 moves = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);

        transform.position += speed * moves * Time.deltaTime;

        
        
    }



}
