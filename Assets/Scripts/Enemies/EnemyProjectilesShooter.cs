using UnityEngine;
using System.Collections;

public class EnemyProjectilesShooter : MonoBehaviour {

    public GameObject projectile;
    public float fireCooldown;
    public bool shootingOffScreen = false;
    public bool shootOnRespawn;
    public float firstShotTime;

    float fireTimer;

	void Start () {
        //shootingOffScreen = false;
        if(shootOnRespawn)
        {
            fireTimer = 0;
        }else
            fireTimer = firstShotTime;
	}
	
	// Update is called once per frame
	void Update () {

        if(GetComponent<SpriteRenderer>() == null)
        {
            shootProjectile();
            return;
        }

        if (!shootingOffScreen && GetComponent<SpriteRenderer>().isVisible)
        {
            shootProjectile();
        }else if(shootingOffScreen)
        {
            shootProjectile();
        }
	}

    void shootProjectile()
    {
        fireTimer -= Time.deltaTime;
        if (fireTimer <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            fireTimer = fireCooldown;
        }
    }
}
