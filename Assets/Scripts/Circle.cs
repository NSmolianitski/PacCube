using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] private Score score;

    private void OnTriggerEnter2D(Collider2D col)
    {
        score.IncreaseScore();
        Destroy(gameObject);
    }
}
