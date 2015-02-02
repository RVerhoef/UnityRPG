using UnityEngine;
using System.Collections;

public class CameraPixelScript : MonoBehaviour {

	void Awake ()
	{
		camera.orthographicSize = Screen.height / 2;
	}
}
