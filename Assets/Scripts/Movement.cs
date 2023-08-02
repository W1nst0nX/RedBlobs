using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MovementSpeed;
    public Ally script;
    private float timer;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        timer = 10f;
    }

    private void Update()
    {
        var pos = transform.position;
        var enemyPos = FindClosestEnemy().transform.position;
        if (Vector2.Distance(transform.position, enemyPos) <= script.range && pos.x < enemyPos.x)
        {
            //attack
            MovementSpeed = 0;
            if(timer <= script.atkspd)
            {
                timer += Time.deltaTime;
            }
            else
            {
                timer = 0;
                var attacking = FindClosestEnemy().GetComponent<Enemy>();
                var baseAtk = FindClosestEnemy().GetComponent<eBaseHP>();
                if (attacking != null)
                {
                    attacking.takeDamage(script.damage);
                }
                else if (baseAtk != null)
                {
                    baseAtk.takeDamage(script.damage);
                }
            }
        }
        else
        {
            MovementSpeed = script.speed;
            transform.position += MovementSpeed * Time.deltaTime * new Vector3(1, 0, 0);
        }

    }

    public GameObject FindClosestEnemy()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }
}
