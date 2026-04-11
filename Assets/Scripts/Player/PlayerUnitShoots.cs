using UnityEngine;

public class PlayerUnitShoots : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;

    private void Start()
    {
        InvokeRepeating("ShootProjectile", 1.5f, 1.5f);
    }
    private void ShootProjectile()
    {
        Instantiate(projectilePrefab, this.transform.position, this.transform.rotation);
    }
}
