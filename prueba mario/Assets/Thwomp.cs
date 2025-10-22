using UnityEngine;

public class Thwomp : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float range = 1f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float offset = Mathf.Sin(Time.time * moveSpeed) * range;
        transform.position = startPos + Vector3.up * offset;
    }
}
