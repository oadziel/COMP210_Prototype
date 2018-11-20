using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_Box_Drop : MonoBehaviour {
    [SerializeField] private GameObject dropObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayhit;
            if (Physics.Raycast(ray, out rayhit))
            {
                Vector3 Raydrop = new Vector3(rayhit.transform.position.x, rayhit.transform.position.y + 10.0f, rayhit.transform.position.z);
                Instantiate(dropObject, Raydrop, transform.rotation);
            }
        }
    }
}
