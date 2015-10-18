using UnityEngine;
using System.Collections;

public class CBala : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //yield return new WaitForSeconds(5);
        Destroy(gameObject, 3f);
    }
}
