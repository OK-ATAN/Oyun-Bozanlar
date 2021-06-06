using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    public GameObject Pause;
    public Transform body;
    float xRot = 0f;
    public bool oyunDevam = true;
    public float sens;

    void Start()
    {
        MouseGizleme();

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            oyunDevam = !oyunDevam;
            MouseGizleme();

        }
        if (oyunDevam) {


            float mouseX = Input.GetAxisRaw("Mouse X") * PlayerPrefs.GetFloat("mouseHassasiyet") * Time.deltaTime;   
            float mouseY = Input.GetAxisRaw("Mouse Y") * PlayerPrefs.GetFloat("mouseHassasiyet") * Time.deltaTime;

            xRot -= mouseY;
            xRot = Mathf.Clamp(xRot, -80f, 80f);
            transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
            body.Rotate(Vector3.up * mouseX);

        }
    }
    void MouseGizleme()
    {
        if (oyunDevam)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Pause.SetActive(false);
        }
        else
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Pause.SetActive(true);
        }

    }
//----------menü-------------------------
    public void devamEt()
    {
        oyunDevam = !oyunDevam;
        MouseGizleme();
    }

    public void cik()
    {
        Application.Quit();
    }



//--------------------------------
}
