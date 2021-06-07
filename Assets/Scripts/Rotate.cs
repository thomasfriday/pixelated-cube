using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        Vector3 angle = new Vector3(0, 45, 0);
        transform.Rotate(angle * Time.deltaTime * speed);
    }
}
