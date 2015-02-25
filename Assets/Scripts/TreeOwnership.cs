using UnityEngine;
using System.Collections;

public class TreeOwnership : MonoBehaviour {
	
	private int player = 0; // 0,1,2,3 or 4 (0 being "not owned" or neutral)
	public int unitBuildRate;
	private int ant = 0;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(player!=0){
		ant++;
		}
		
	}
	
	void SendAnts(int percent){
	ant = ant * percent;
	}
	
}
