using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrevNext : MonoBehaviour
{
    int count;
    int nooftool;
    public Button next;
    bool nexttrue;
    public Button prev;

    bool prevtrue;   
    public List<GameObject> tooldes = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        nooftool = tooldes.Count;
        nexttrue = true;
        prevtrue = true;
        prev.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (count < nooftool - 1 && nexttrue == false)
        {
            next.interactable=true;
            nexttrue = true;
        }
        if (count > 0 && prevtrue == false)
        {
            prev.interactable = true;
            prevtrue = true;
        }        
    }

    public void OnClickNext()
    {
        count++;        
        if (count<=nooftool-1)
        {            
            tooldes[count - 1].SetActive(false);
            tooldes[count].SetActive(true);
        }    
        if(count>=nooftool-1)
        {
            next.interactable=false;
            nexttrue = false;
        }
        if(count == 1)
        {
            prev.interactable = true;
        }
    }
    public void OnClickPrevious()
    {
        count--;        
        if (count>=0)
        {            
            tooldes[count+1].SetActive(false);
            tooldes[count].SetActive(true);
        }
        if (count <= 0)
        {
            prev.interactable = false;
            prevtrue = false;
        }
    }    
}
