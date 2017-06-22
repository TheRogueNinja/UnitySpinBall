using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinBall : MonoBehaviour {
	public Rigidbody projectile;
    public Transform shotPos;
    public float shotForce = 5f;
    public float moveSpeed = 10f;
    
    void Update ()
    {

        float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        
        transform.Translate(new Vector3(h, v, 0f));
        
        if(Input.GetButtonUp("Fire1"))
        {   
            
            Rigidbody shot = Instantiate(projectile, shotPos.position, shotPos.rotation);
            //shot.AddForce(shotPos.forward* shotForce);
            shot.transform.position = transform.position+Camera.main.transform.forward * 2;
            shot.velocity = Camera.main.transform.forward * 50;

            //shot.transform.rotation = Quaternion.AngleAxis(30, Vector3.up);
        }
        
    }
}
