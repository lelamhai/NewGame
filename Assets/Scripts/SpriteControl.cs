using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MainGame.onChangeColor += FunctionChangeColor;
	}

    void FunctionChangeColor(Color color)
    {
        GetComponent<SpriteRenderer>().color = color;
    }
}
