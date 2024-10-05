using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Merhaba Dünya");
    }
    public float donmeHizi = 1000f;
    public float hareketHizi = 5f;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float yataydaFareHareketi = Input.GetAxis("Mouse X");
            float donmeMiktari = yataydaFareHareketi * donmeHizi * Time.deltaTime;
            transform.Rotate(Vector3.up, donmeMiktari);
        }
        
        float sagaSolaDegeri = Input.GetAxis("Horizontal");
        float ileriGeriDegeri = Input.GetAxis("Vertical");
        float xHareket = sagaSolaDegeri * hareketHizi * Time.deltaTime;
        float yHareket = ileriGeriDegeri * hareketHizi * Time.deltaTime;
        transform.Translate(new Vector3(xHareket, 0, yHareket));
    }
}