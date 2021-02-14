/** Sam Carpenter
*   Week 3
*   temperature.cs
*   runs most things
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class temperature : Subject
{
	private int temp = 40;
	public Text t;
	
    // Update is called once per frame
    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
			Notify();
		} else if (Input.GetKeyDown(KeyCode.UpArrow)){
			TempUp();
			Notify();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)){
			TempDown();
			Notify();
		} else if (Input.GetKeyDown(KeyCode.Q)){
			List<getsCold>m = new List<getsCold>();
			foreach(getsCold g in observers){
				if (g is Lake){
					g.UpdateTemp(temp + 30);
					m.Add(g);
				}
			}
			foreach(getsCold v in m){
				observers.Remove(v);
			}
			m.Clear();
		}
		t.text = "ambient temperature is " + temp + "degrees";
    }
	
	public override void Notify(){
		foreach(getsCold g in observers){
			g.UpdateTemp(temp);
		}
	}
	
	private void TempUp(){
		temp = Mathf.Min(temp + 10, 90);
	}
	
	private void TempDown(){
		temp = Mathf.Max(temp - 10, 0);
	}
}
