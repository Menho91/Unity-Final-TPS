using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public ParticleSystem Explosion;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision Other)
    {
        ParticleSystem fire = Instantiate(Explosion, transform.position, Quaternion.identity);
        fire.Play();

        if (Other.collider.tag == "Enemy")
        {
            GameObject manager = GameObject.Find("ScoreManager");
            manager.GetComponent<ScoreManager>().IncScore();
            Destroy(gameObject, 0.2f);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
