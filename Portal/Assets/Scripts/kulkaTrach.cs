using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kulkaTrach : MonoBehaviour

{
	[SerializeField] PortalColor pc;
	private lubudubu lubudubu;
	RaycastHit target;
	private void OnCollisionEnter(Collision collision)
	{
		Vector3 kierunek = collision.contacts[0].point - transform.position;
		if (Physics.Raycast(transform.position,kierunek,out target))
		{
			lubudubu.WystrzalPortalu(pc, target);
		}


	}
	private void OnEnable()
	{
		lubudubu = GameObject.FindObjectOfType<lubudubu>();
	}
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
