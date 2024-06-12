using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    float DogTimer;

    [SerializeField] private float dogCooldown = 1f;

    // Update is called once per frame
    void Update()
    {
        DogTimer += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && DogTimer > dogCooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            DogTimer = 0f;
        }
    }
}
