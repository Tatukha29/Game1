using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerContr : MonoBehaviour
{
	Rigidbody rb;
	float x;
    float y;
    float z;
    /*public GameObject block;
    Rigidbody bulletrb;
    Rigidbody blockrb;
    GameObject bulletclone;*/
    public GameObject bull;
    GameObject cloneBull;
    Rigidbody rbClone;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         float moveVertical = Input.GetAxis("Vertical");
        rb.AddForce(transform.forward * moveVertical *40f);

        float moveHorizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0,moveHorizontal *10f,0);
       /*if (Input.GetKeyDown("space")){
            bulletclone = Instantiate(block, new Vector3(transform.position.x + 1,transform.position.y,transform.position.z + 1), Quaternion.identity);
            bulletrb = bulletclone.GetComponent<Rigidbody>();
            bulletrb.AddForce(transform.forward * 150f);
        }*/
        if(Input.GetKeyDown("space")){   
        cloneBull = Instantiate(bull, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        rbClone = cloneBull.GetComponent<Rigidbody>();
        rbClone.AddForce(transform.forward * 500f);

        }
    }
    
    void OnCollisionEnter()
     {  
      }
    
}
