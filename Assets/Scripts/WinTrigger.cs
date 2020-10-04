using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class WinTrigger : MonoBehaviour
{
    public Text winTextObject;



    // Start is called before the first frame update
    void Start()
    {
        winTextObject.GetComponent<Text>().text = "";
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Treasure"))
        {
            other.gameObject.SetActive(false);
            winTextObject.GetComponent<Text>().text = "You Won";

        }

    }
}
