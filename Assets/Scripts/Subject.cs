/** Sam Carpenter
*   Week 3
*   Subject.cs
*   basis for observation
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;   

public abstract class Subject : MonoBehaviour
{
	public List<getsCold>observers = new List<getsCold>();
    void Awake(){
        foreach(getsCold g in FindObjectsOfType<MonoBehaviour>().OfType<getsCold>()){
			observers.Add(g);
		}
    }

    // Update is called once per frame
    public abstract void Update();
	
	void Register(GameObject g){
		observers.Add(g.GetComponent<getsCold>());
	}
	
	protected void Remove(getsCold g){
		observers.Remove(g);
	}
	
	public abstract void Notify();
}
