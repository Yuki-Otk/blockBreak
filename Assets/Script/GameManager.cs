using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject block,text,boll;
    int w = 3, h = 4;
    int blockNum;
	// Use this for initialization
	void Start () {
        blockNum = w * h;
        text.SetActive(false);
        int x = -3, y = 19;
        for(int i=0; i< h; i++)
        {
            for(int j = 0; j < w; j++)
            {
                GameObject gameObject= Instantiate(block,new Vector3(x+j*x*-1,y-2*i,0),Quaternion.identity);
                //block.GetComponent<Renderer>().material.color = Color.blue;
                if ((i + j + 2) % 2 == 0)
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.green;
                }
            }
        }		
	}
	
	// Update is called once per frame
	void Update () {
        if (blockNum == 0)
        {
            boll.SetActive(false);
            text.SetActive(true);
        }
	}

    public void DoBlockDec()
    {
        blockNum--;
    }
}
