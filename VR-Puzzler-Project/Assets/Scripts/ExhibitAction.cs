using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExhibitAction : MonoBehaviour {

    public GameObject photo;
    private GvrAudioSource _audio_source;

    // Use this for initialization
    void Start () {
        _audio_source = gameObject.GetComponent<GvrAudioSource>();
        _audio_source.playOnAwake = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void popupPhoto() {
        photo.SetActive(true);
        _audio_source.Play();
    }

    public void closePopup()
    {
        photo.SetActive(false);
        _audio_source.Play();
    }
}
