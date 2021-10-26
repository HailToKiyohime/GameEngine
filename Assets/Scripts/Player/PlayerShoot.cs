using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public float fireRate = 0.2f;
    public Transform firingPoint;
    public Transform shieldPos;
    public GameObject bulletPrefab;
    public GameObject shieldPrefab;

    float timeUntilFire;
    PlayerMovement pm;
    private GameObject clone;

    private void Start()
    {
        pm = gameObject.GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && timeUntilFire < Time.time)
        {
            Shoot();
            timeUntilFire = Time.time + fireRate;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Shield();
            
        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            Destroy(clone);
        }

    }

    public void Shoot()
    {
        float angle = pm.isFacingRight ? 0f : 180f;
        Instantiate(bulletPrefab, firingPoint.position, Quaternion.Euler(new Vector3(0, 0, angle)));
    }

    public void Shield()
    {
        clone = (GameObject)Instantiate(shieldPrefab, shieldPos.position, Quaternion.identity);
    }
}
