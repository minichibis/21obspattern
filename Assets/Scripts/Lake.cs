/** Sam Carpenter
*   Week 3
*   Lake.cs
*   freezes instantly
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lake : MonoBehaviour, getsCold
{
	int temp = 40;
	public Text t;
    // Update is called once per frame
    void Update()
    {
        t.text = "lake temperature is " + temp + "degrees.";
    }
	
	public void UpdateTemp(int newtemp){
		temp = newtemp;
	}
}
