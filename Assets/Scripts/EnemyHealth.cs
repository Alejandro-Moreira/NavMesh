using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject explosionFX;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 fxPos = transform.position + Vector3.up * 0.5f;

            GameObject fx = Instantiate(
                explosionFX,
                fxPos,
                Quaternion.identity
            );

            Destroy(fx, 2f);
            Destroy(gameObject);
        }
    }
}
