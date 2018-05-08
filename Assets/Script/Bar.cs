using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour {
    // マウスカーソル座標
    private Vector3 mousePos;
    // スクリーン座標をワールド座標に変換した位置座標
    private Vector3 screenToWorldPointPosition;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // マウス座標を変数に格納
        //mousePos = Input.mousePosition;
        
        //マウスカーソル座標にカメラのZ座標を代入（カメラのZ座標が-の場合は=-にする）
        mousePos.z = -Camera.main.transform.position.z;
        //mousePos.z = 0;
        // マウスカーソル座標をスクリーン座標からワールド座標に変換する
        screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(mousePos);
        //オブジェクトの座標に変数の値を代入
        transform.position = screenToWorldPointPosition;
        Vector3 vector = transform.position;
        vector.z = 0;
        transform.position = vector;
        //this.GetComponent<Rigidbody>().AddForce(transform.right * Input.GetAxisRaw("Horizontal") * accel, ForceMode.Impulse);
    }
}
