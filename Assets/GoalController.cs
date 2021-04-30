using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalController : MonoBehaviour
{
    GameObject GoalText;
    // Start is called before the first frame update
    void Start()
    {
        this.GoalText = GameObject.Find("Goal");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
