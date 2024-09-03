using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptReferencePractice : MonoBehaviour
{
    public ComponentFun ourOtherScript;
    public Light coolLightObject;
    public Light referenceLight;

    public Color lightColor;

    // Start is called before the first frame update
    void Start()
    {
        SetComponentFunVariables();

        SetupLightStuff();
    }

    private void Update()
    {
        
    }

    void SetComponentFunVariables()
    {
        ourOtherScript.counter++; //This is the same as saying ourOtherScript.counter = ourOtherScript.counter + 1;
        ourOtherScript.myName = "Anthony Ramirez"; // This modifies the myName stringvarible in the referenced ComponentFun script.
    }

    public void SetupLightStuff()
    {
        coolLightObject.intensity = 2f;
        coolLightObject.range = 25f;
        //coolLightObject.color = Color.blue;

        coolLightObject.color = referenceLight.color;
    }

    private void OnEnable()
    {
        
    }
}
