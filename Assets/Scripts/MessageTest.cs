using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageTest : MonoBehaviour
{
    public bool doUpdateChecks;

    // OnEnable is called when the script or GameObject becomes enabled
    private void OnEnable()
    {
        Debug.Log("Enabled");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started");
    }

    // Update is called once per frame
    void Update()
    {
        if (!doUpdateChecks) return;
        Debug.Log("Update");
        Debug.Log($"Update delta time:{Time.deltaTime}");
    }

    private void FixedUpdate()
    {
        if (!doUpdateChecks) return;
        Debug.Log("Fixed Update");
        Debug.Log($"Fixed Update delta time:{Time.fixedDeltaTime}");
    }

    private void LateUpdate()
    {
        if (!doUpdateChecks) return;
        Debug.Log("Late Update");
        Debug.Log($"Late Update delta time:{Time.deltaTime}");
    }
}
