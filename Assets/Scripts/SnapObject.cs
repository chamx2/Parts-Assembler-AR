using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class SnapObject : MonoBehaviour
{


    public void OnTriggerEnter(Collider other)
    {

        Debug.Log(other.gameObject.name + " " + other.gameObject.tag + " " + tag);
        if (gameObject.tag == other.tag)
        {
           
            other.transform.position = transform.position;
            other.transform.rotation = transform.rotation;

            //other.gameObject.GetComponent<Collider>().enabled = false;  // disables the collider so it won't be interactable again.
            //other.attachedRigidbody.MovePosition(transform.position);
        }
    }


    private IEnumerator OnTriggerStay(Collider other)
    {
        yield return new WaitForSeconds(1);

        if (gameObject.tag == other.tag)
        {

            other.transform.position = transform.position;
            other.transform.rotation = transform.rotation;

            
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
