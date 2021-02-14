/** Sam Carpenter
*   Week 3
*   Brook.cs
*   Freezes on a whim
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brook : MonoBehaviour, getsCold
{
	int temp = 40;
	public Text t;
    // Update is called once per frame
    void Update()
    {
        t.text = "brook temperature is " + temp + "degrees.";
    }
	
	public void UpdateTemp(int newtemp){
		int tempdiff = Mathf.Abs(temp-newtemp);
		if (Random.Range(0, tempdiff) < 9) {
			temp = newtemp;
		}
	}
}
