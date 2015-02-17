using UnityEngine;
using System.Collections;

public class PathSetup : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Path path = GetComponent<Boid>().path;

        path.AddWaypoint(new Vector3(500, 100, 500));
        path.AddWaypoint(new Vector3(500, 100, 1500));
        path.AddWaypoint(new Vector3(-500, 100, 1500));
        path.AddWaypoint(new Vector3(-500, 100, 500));

        gameObject.renderer.material.color = Color.cyan;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
