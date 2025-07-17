using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 dir;
    public float speed = 5;

    public GameObject explostionFactory;

    private void OnEnable()
    {
        int ranValue = UnityEngine.Random.Range(0, 10);

        if(ranValue < 7)
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

    private void OnCollisionEnter(Collision other)
    {
        //GameObject smObject = GameObject.Find("ScoreManager");
        //ScoreManager sm = smObject.GetComponent<ScoreManager>();

        //sm.setScore(sm.GetScore() + 1);

        //ScoreManager를 싱글톤을 사용해서 불러오기
        //ScoreManager.Instance.setScore(ScoreManager.Instance.GetScore() + 1);
        ScoreManager.Instance.Score++;

        GameObject explosion = Instantiate(explostionFactory);
        explosion.transform.position = transform.position;

        if(other.gameObject.name.Contains("Bullet"))
        {
            //other.gameObject.SetActive(false);
            //PlayerFire player = GameObject.Find("Player").GetComponent<PlayerFire>();
            //player.bulletObjectPool.Add(other.gameObject);

            //리스트
            //PlayerFire.Instance.bulletObjectPool.Add(other.gameObject);

            PlayerFire.Instance.bulletObjectPool.Enqueue(other.gameObject);
            other.gameObject.SetActive(false);
        }
        else
        {
            Destroy(other.gameObject);
        }

        EnemyManager.Instance.enemyObjectPool.Enqueue(gameObject);
        gameObject.SetActive(false);
    }

   
}
