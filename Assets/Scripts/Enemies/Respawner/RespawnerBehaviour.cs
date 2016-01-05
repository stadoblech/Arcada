using UnityEngine;
using System.Collections;

public class RespawnerBehaviour : MonoBehaviour {

    public GameObject enemy;
    public bool respawnOffScreen;
    public float respawnCooldown;

    private float respawnTimer;

	void Start () {
        respawnTimer = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if(!GetComponent<EnemyLife>().living)
        {
            Destroy(transform.parent.gameObject);
        }

        if (respawnOffScreen)
        {
            respawnTimer -= Time.deltaTime;

            if (respawnTimer <= 0)
            {
                SoundEffectsManager.Instance.respawnerAction();
                Instantiate(enemy, getRespawnPosition(), Quaternion.identity);
                respawnTimer = respawnCooldown;
            }
        }else if(!respawnOffScreen && GetComponent<SpriteRenderer>().isVisible)
        {
            respawnTimer -= Time.deltaTime;

            if (respawnTimer <= 0)
            {
                SoundEffectsManager.Instance.respawnerAction();
                Instantiate(enemy, getRespawnPosition(), Quaternion.identity);
                respawnTimer = respawnCooldown;
            }
        }
	}

    Vector3 getRespawnPosition()
    {
        Camera c = Camera.main;
        float cameraHeight = c.orthographicSize;
        float cameraWidth = cameraHeight / c.aspect;

        return new Vector3(
            c.transform.position.x + Random.Range(-cameraWidth,+cameraWidth),
            c.transform.position.y + Random.Range(-cameraHeight,cameraHeight));
    }
}
