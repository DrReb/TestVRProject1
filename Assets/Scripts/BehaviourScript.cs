using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourScript : MonoBehaviour
{


    public Material Gazed;
    public Material NotGazed;
    Renderer Target;

    void Start()
    {
        Target = GetComponent<Renderer>();
        Target.material = NotGazed;
        LocalTeleportation();
    }

    public void GazeEvent()
    {
        Target.material = Gazed;
    }

    public void NotGazeEvent()
    {
        Target.material = NotGazed;
    }

    public void LocalTeleportation()
    {
        gameObject.transform.position = new Vector3(RandomPosition(), Random.Range(0.5f, 2), RandomPosition());
    }

    public float RandomPosition()
    {
        var coordinate = Random.Range(-9, 9);
        while (coordinate > -2 && coordinate < 2)
            coordinate = Random.Range(-9, 9);
        return coordinate;
    }
}
