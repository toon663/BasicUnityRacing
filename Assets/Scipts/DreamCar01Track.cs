using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCar01Track : MonoBehaviour
{
    public GameObject TheMarker;
    public GameObject NoviceMark01;
    public GameObject NoviceMark02;
    public GameObject NoviceMark03;
    public GameObject NoviceMark04;
    public GameObject NoviceMark05;
    public GameObject NoviceMark06;
    public GameObject NoviceMark07;
    public GameObject NoviceMark08;
    public GameObject NoviceMark09;
    public GameObject NoviceMark10;
    public GameObject NoviceMark11;
    public GameObject NoviceMark12;
    public GameObject NoviceMark13;
    public GameObject NoviceMark14;
    public GameObject NoviceMark15;
    public GameObject NoviceMark16;
    public GameObject NoviceMark17;
    public GameObject NoviceMark18;
    public GameObject NoviceMark19;
    public GameObject NoviceMark20;
    public GameObject NoviceMark21;
    public GameObject NoviceMark22;
    public GameObject NoviceMark23;
    public GameObject NoviceMark24;
    public GameObject NoviceMark25;
    public GameObject NoviceMark26;
    public GameObject NoviceMark27;
    
    public int MarkTracker;

    void Update()
    {
        if(MarkTracker == 0)
        {
            TheMarker.transform.position = NoviceMark01.transform.position;
        }
        if(MarkTracker == 1)
        {
            TheMarker.transform.position = NoviceMark02.transform.position;
        }
        if(MarkTracker == 2)
        {
            TheMarker.transform.position = NoviceMark03.transform.position;
        }
        if(MarkTracker == 3)
        {
            TheMarker.transform.position = NoviceMark04.transform.position;
        }
        if(MarkTracker == 4)
        {
            TheMarker.transform.position = NoviceMark05.transform.position;
        }
        if(MarkTracker == 5)
        {
            TheMarker.transform.position = NoviceMark06.transform.position;
        }
        if(MarkTracker == 6)
        {
            TheMarker.transform.position = NoviceMark07.transform.position;
        }
        if(MarkTracker == 7)
        {
            TheMarker.transform.position = NoviceMark08.transform.position;
        }
        if(MarkTracker == 8)
        {
            TheMarker.transform.position = NoviceMark09.transform.position;
        }
        if(MarkTracker == 9)
        {
            TheMarker.transform.position = NoviceMark10.transform.position;
        }
        if(MarkTracker == 10)
        {
            TheMarker.transform.position = NoviceMark11.transform.position;
        }
        if(MarkTracker == 11)
        {
            TheMarker.transform.position = NoviceMark12.transform.position;
        }
        if(MarkTracker == 12)
        {
            TheMarker.transform.position = NoviceMark13.transform.position;
        }
        if(MarkTracker == 13)
        {
            TheMarker.transform.position = NoviceMark14.transform.position;
        }
        if(MarkTracker == 14)
        {
            TheMarker.transform.position = NoviceMark15.transform.position;
        }
        if(MarkTracker == 15)
        {
            TheMarker.transform.position = NoviceMark16.transform.position;
        }
        if(MarkTracker == 16)
        {
            TheMarker.transform.position = NoviceMark17.transform.position;
        }
        if(MarkTracker == 17)
        {
            TheMarker.transform.position = NoviceMark18.transform.position;
        }
        if(MarkTracker == 18)
        {
            TheMarker.transform.position = NoviceMark19.transform.position;
        }
        if(MarkTracker == 19)
        {
            TheMarker.transform.position = NoviceMark20.transform.position;
        }
        if(MarkTracker == 20)
        {
            TheMarker.transform.position = NoviceMark21.transform.position;
        }
        if(MarkTracker == 21)
        {
            TheMarker.transform.position = NoviceMark22.transform.position;
        }
        if(MarkTracker == 22)
        {
            TheMarker.transform.position = NoviceMark23.transform.position;
        }
        if(MarkTracker == 23)
        {
            TheMarker.transform.position = NoviceMark24.transform.position;
        }
        if(MarkTracker == 24)
        {
            TheMarker.transform.position = NoviceMark25.transform.position;
        }
        if(MarkTracker == 25)
        {
            TheMarker.transform.position = NoviceMark26.transform.position;
        }
        if(MarkTracker == 26)
        {
            TheMarker.transform.position = NoviceMark27.transform.position;
        }
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "DreamCar01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
            if(MarkTracker == 27)
            {
                MarkTracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
