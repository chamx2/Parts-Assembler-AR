using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform targetEditor;
    public Transform targetAR;


    private Transform target;

    private void Start()
    {
        if(!targetEditor.gameObject.activeSelf || targetEditor == null )
        {
            target = targetAR;
        }

        target = targetEditor;
    }

    private void FixedUpdate()
    {
        //transform.LookAt(target);

        transform.LookAt(2 * transform.position - target.position);
    }


}
