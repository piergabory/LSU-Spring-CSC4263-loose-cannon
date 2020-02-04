using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBehaviour : MonoBehaviour
{

    public KeyCode fireKey;

    public GameObject projectile;
    public GameObject projectileSpawnPoint;
    public float force = 30f;

    public ParticleSystem particles;

    public uint cooldownDelay = 100;

    private uint cooldown = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown > 0) {
            cooldown --;
        } else {
            if (Input.GetKey(fireKey)) {

                Vector3 projectileForce = projectileSpawnPoint.transform.up * force;
                GameObject newProjectile = Instantiate(projectile, projectileSpawnPoint.transform.position, projectileSpawnPoint.transform.rotation);
                newProjectile.GetComponent<Rigidbody>().AddForce(projectileForce, ForceMode.Impulse);
                GetComponent<Rigidbody>().AddForce(-projectileForce, ForceMode.Impulse);
                particles.Play();

                cooldown = cooldownDelay;
            }
        }
        GetComponent<MeshRenderer>().sharedMaterial.color = Color.red * (cooldown / (float)cooldownDelay);
    }
}
