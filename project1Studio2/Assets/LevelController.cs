using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public ColorChange[] colors;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var counter = 0;
        for (int i = 0; i < colors.Length; i++)
        {
            if (colors[i].isChanged)
            {
                counter++;
            }
        }
        Debug.LogError(counter);
    }
}
