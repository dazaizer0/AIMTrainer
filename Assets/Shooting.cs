using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shooting : MonoBehaviour
{

    // shooting
    public float rayLen = 100f;
    public Transform firePos;

    // score
    public static int score;
    public TextMeshProUGUI Score;
    

    void Update()
    {
        
        if(Input.GetButtonDown("Fire1"))
            Shoot();

        Score.text = score.ToString();
    }

    void Shoot()
    {

        RaycastHit hit;

        if (Physics.Raycast(firePos.position, firePos.forward, out hit, rayLen))
        {

            Destroy(hit.collider.gameObject);

            Debug.DrawRay(firePos.position, hit.transform.position, Color.red, 0.1f);
            Debug.Log("Shooted");
            score += 1;
        }
        
    }
}
