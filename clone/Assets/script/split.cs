using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class split : MonoBehaviour
{
    [SerializeField]
    private GameObject character;

    [SerializeField]
    private GameObject player;

    [SerializeField, Range(0.0f, 1.0f)]
    private float miniSize = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        character.transform.localScale = new Vector3(miniSize, miniSize, 1.0f);
    
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //character.transform.localScale *= new Vector2(0.8f, 0.8f);
            Instantiate(character, new Vector3(player.transform.position.x, player.transform.position.y + 3, player.transform.position.z), Quaternion.identity);
        }

    }
}
