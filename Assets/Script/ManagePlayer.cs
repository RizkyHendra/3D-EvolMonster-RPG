using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    //public LayerMask grassLayer;
    //public float rangeRadius = 0.1f;
    //public Transform positionArea;

    public int presentaseMenemukanVirus;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }



    //private void CheckForEcounter()
    //{
    //    if (Physics.OverlapSphere(positionArea.position,rangeRadius, grassLayer) != null)
    //    {
    //        if (Random.Range(1, 101) <= 1)
    //        {
    //            Debug.Log("Ecounter A Virus");
    //        }

    //    }
    //}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Cube")
        {
            if (Random.Range(1, 101) <= presentaseMenemukanVirus)
            {
                Debug.Log("Ecounter A Virus");
            }
        }
    }

    //private void OnDrawGizmosSelected()
    //{
    //    if (positionArea == null)
    //        return;

    //    Gizmos.DrawWireSphere(positionArea.position, rangeRadius);
    //}
}
