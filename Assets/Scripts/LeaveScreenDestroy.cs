using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveScreenDestroy : MonoBehaviour {

    private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Awake () {

        spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

        if (spriteRenderer.isVisible == false) {

            Destroy(this.gameObject);
        }
	}
}
