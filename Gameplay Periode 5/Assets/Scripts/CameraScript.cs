using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    [SerializeField]
    private GameObject _Player;

    private Vector3 _Offset;

	void Start () {
        _Offset = transform.position - _Player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = _Player.transform.position + _Offset;
	}
}
