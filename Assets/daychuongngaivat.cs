using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daychuongngaivat : MonoBehaviour
{
    public float luc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rigidbody = hit.collider.attachedRigidbody;

        if (rigidbody != null)
        {
            Vector3 dichuyen = hit.gameObject.transform.position - transform.position;
            dichuyen.y = 0;
            dichuyen.Normalize();

            rigidbody.AddForceAtPosition(dichuyen * luc, transform.position, ForceMode.Impulse);

        }
    }
}
