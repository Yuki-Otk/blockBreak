using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject block;
	// Use this for initialization
	void Start () {
        int x = -3, y = 19;
        for(int i=0; i< 4; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Instantiate(block,new Vector3(x+j*x*-1,y-2*i,0),Quaternion.identity);
            }
        }
        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
