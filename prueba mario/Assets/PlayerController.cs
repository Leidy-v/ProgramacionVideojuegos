using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Transform hammerPoint;
    public LayerMask blockLayer;

    void Update()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit2D hit = Physics2D.Raycast(hammerPoint.position, Vector2.up, 0.5f, blockLayer);
            if (hit.collider != null)
            {
                Block block = hit.collider.GetComponent<Block>();
                if (block != null)
                {
                    block.Hit();
                }
            }
        }
    }
}
