using UnityEngine;

public class Block : MonoBehaviour
{
    public bool isThwomp = false;

    public void Hit()
    {
        if (isThwomp)
        {
            GameManager.Instance.LoseGame();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
