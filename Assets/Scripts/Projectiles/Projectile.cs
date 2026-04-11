using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float projectileSpeed;
 
    void Update()
    {
        this.transform.Translate(-projectileSpeed * Time.deltaTime, 0, 0);
        //Making sure that the projectile is destroyed at some point.
        if(this.transform.position.x <= -100)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
