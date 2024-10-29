using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineFun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitAndPostDebug());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator WaitAndPostDebug()
    {
        Debug.Log("Start of this coroutine!");

        yield return null; //Waits until next frame to continue with the rest of the code.

        yield return new WaitForSeconds(3f);

        Debug.Log("End of this coroutine!");
    }

    public float ReturnNumber()
    {
        return 5f;
    }
}
