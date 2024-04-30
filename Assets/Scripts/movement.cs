using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public int moveSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.D))
         {
             transform.position += Vector3.right * moveSpeed * Time.deltaTime;
             //spriteRenderer.flipX = false;
         }
         else if(Input.GetKey(KeyCode.A))
         {
             transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
             //spriteRenderer.flipX = true;
         }
    }
}
