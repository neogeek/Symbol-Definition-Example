using UnityEngine;

public class ExampleUsage : MonoBehaviour
{

    private void Start()
    {

#if ENABLE_INPUT_SYSTEM
        Debug.Log("New Input System is enabled.");
#else
        Debug.Log("The legacy Input System is enabled.");
#endif

    }

}
