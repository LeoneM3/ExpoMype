using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class WPActor : MonoBehaviour
{

    public float speed = 5.0f;

    //public Transform target;

    private void Start()
    {
      //  transform.LookAt(new Vector3(target.position.x, target.position.y, target.position.z));
    }

    private void Update()
    {
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));

    }


   // private void OnTriggerEnter(Collider other)
    //{
      //  if (other.tag == "WayPoint")
        //{
          //  target = other.gameObject.GetComponent<Wp>().nextPoint;
            //transform.LookAt(new Vector3(target.position.x, target.position.y, target.position.z));
        //}
    //}
}
