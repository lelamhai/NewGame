using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour {
    public delegate void ChangeColor(Color color);
    public static event ChangeColor onChangeColor;

	// Use this for initialization
	void Start () {
		if(onChangeColor != null)
        {
            onChangeColor(Color.red);
        }
	}
	
	
}
