using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class SnapObject : MonoBehaviour
{


    public void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Plasma"))
        {
            Debug.Log(other.gameObject.name + " " + other.gameObject.tag + " " + tag);
            other.transform.position = transform.position;
            other.transform.rotation = transform.rotation;

            //other.gameObject.GetComponent<Collider>().enabled = false;  // disables the collider so it won't be interactable again.
            //other.attachedRigidbody.MovePosition(transform.position);
        }
    }


    //private void OnCollisionEnter(Collision collision)
    //{
    //    //Debug.Log(collision.gameObject.name);
    //    //if (collision.gameObject.CompareTag(this.gameObject.tag))
    //    //{
    //    //    //collision.transform.position = this.transform.position;
    //    //    //collision.transform.rotation = this.transform.rotation;
    //    //}
    //}
}
