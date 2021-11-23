using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityMove : MonoBehaviour
{
    Main main;
    Grid grid;
    void Start()
    {
        grid = GetComponent<Grid>();
    }

    // Update is called once per frame
    void Update()
    {
        SetStartPos();
    }

    public void SetStartPos()
    {
        Node Snode = CurrentPos();
        Snode = main.start;
        Snode.ChangeStart = true;

    }

    public Node CurrentPos()
    {
        RaycastHit hit;
        if (Physics.Raycast(this.transform.position, -this.transform.up, out hit))
        {
            if (hit.collider)
            {
                GameObject obj = hit.collider.gameObject;
                //Debug.Log(obj.name);
                //Debug.Log(obj.transform.position);
                return grid.NodePoint(obj.transform.position);
            }
        }
        return null;
    }
}
