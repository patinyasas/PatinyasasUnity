using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUi : MonoBehaviour
{
    [SerializeField]
    private GameObject selectionMarker;
    public GameObject SelectionMarker { get { return selectionMarker; } }

    public static MainUi instance;

    private void Awake()
    {
        instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
