using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject Target;
    public static float cooldown = 4f;

    void Start()
    {
        
        StartCoroutine(spawn());
    }

    void Update()
    {
        
        cooldown -= (1 * Time.deltaTime) / 10;
        if(cooldown < 0.7f) {cooldown = 0.7f;}

        if(Input.GetKeyDown(KeyCode.Escape)){Application.Quit();}
    }

    IEnumerator spawn()
    {

        while (true)
        {
            Refresh();
            yield return new WaitForSeconds(cooldown);
        }
    }

    public void Refresh()
    {

        Vector3 SpawnPos = new Vector3(Random.Range(-4.25f, 4.25f), Random.Range(1.25f, 8.25f), 3.5f);
        Instantiate(Target, SpawnPos, Quaternion.identity);
    }
}
