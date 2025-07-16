using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 dir;
    public float speed = 5;

    public GameObject explostionFactory;

    private void Start()
    {
        int ranValue = UnityEngine.Random.Range(0, 10);

        if(ranValue < 3) // 30%
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        else
        {
            dir = Vector3.down;
        }
    }

    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject smObject = GameObject.Find("ScoreManager");
        ScoreManager sm = smObject.GetComponent<ScoreManager>();

        sm.setScore(sm.GetScore() + 1);

        GameObject explosion = Instantiate(explostionFactory);
        explosion.transform.position = transform.position;

        Destroy(collision.gameObject);

        Destroy(gameObject);
    }

   
}
