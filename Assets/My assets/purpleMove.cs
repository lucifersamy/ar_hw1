using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class purpleMove : MonoBehaviour
{
    [SerializeField] Transform[] Positions;
    Transform nextPosition;
    [SerializeField] float objectSpeet;

    int nextPositionIndex;
    // Start is called before the first frame update
    void Start()
    {
        nextPosition = Positions[0];
    }

    // Update is called once per frame
    void Update()
    {
        moveGameObject();
    }

    void moveGameObject()
    {
        if (transform.position == nextPosition.position)
        {
            nextPositionIndex++;
            if (nextPositionIndex >= Positions.Length)
            {
                nextPositionIndex = 0;
            }
            nextPosition = Positions[nextPositionIndex];
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, nextPosition.position, objectSpeet * Time.deltaTime);
        }
    }
}
