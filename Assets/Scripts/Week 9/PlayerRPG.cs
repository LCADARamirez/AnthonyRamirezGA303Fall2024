using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerRPG : MonoBehaviour
{
    public float health = 100f;
    public float maxHealth = 100f;

    public TextMeshProUGUI healthText;
    public TextMeshProUGUI ammoText;


    public float attackDamage = 5f;
    public float attackInterval = 1f;
    private bool isAttackReady = true;
    public Image attackReadyImage;

    public float attackDamageBoostAmount = 3f;
    public bool isAttackDamageBoosted = false;
    public float attackDamageBoostDuration = 10f;

    private float timer;

    public float rangedAttackDamage = 3f;
    public int rangedAmmo = 5;
    public float rangedProjectileForce = 500f;
    public GameObject rangedProjectilePrefab;
    public Transform projectileSpawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isAttackReady == false)
        {
            timer += Time.deltaTime;

            if (timer >= attackInterval)
            {
                isAttackReady = true;
                attackReadyImage.gameObject.SetActive(isAttackReady);
                timer = 0f;
            }
        }
        

        if(Input.GetMouseButtonDown(0))
        {
            if(isAttackReady == true)
            {
                RaycastHit hit;

                if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 3f))
                {
                    BaseEnemy enemy = hit.collider.GetComponent<BaseEnemy>();

                    if (enemy != null)
                    {
                        Attack(enemy);
                    }
                }
            }
        }

        if(Input.GetMouseButtonDown(1))
        {
            RangedAttack();
        }
    }

    public void Attack(BaseEnemy enemy)
    {
        float totalDamage = attackDamage;

        if(isAttackDamageBoosted == true)
        {
            totalDamage += attackDamageBoostAmount;
        }

        enemy.TakeDamage(totalDamage);
        isAttackReady = false;
        attackReadyImage.gameObject.SetActive(isAttackReady);
    }

    public void RangedAttack()
    {
        if(rangedAmmo > 0)
        {
            GameObject go = Instantiate(rangedProjectilePrefab, projectileSpawnPosition.position, projectileSpawnPosition.rotation);

            go.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * rangedProjectileForce);

            rangedAmmo--;

            ammoText.text = rangedAmmo.ToString();

            Destroy(go, .75f);
        }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;

        healthText.text = health.ToString();

        if (health <= 0)
        {
            Debug.Log("YOU DIED");
        }
    }

    public void AddHealth(float healthAmount)
    {
        health += healthAmount;

        if(health > maxHealth)
        {
            health = maxHealth;
        }

        healthText.text = health.ToString();
    }

    public void AttackDamagePowerUp()
    {
        isAttackDamageBoosted = true;
    }

    private IEnumerator WaitAndRemoveAttackDamageBuff()
    {
        yield return new WaitForSeconds(attackDamageBoostDuration / 2);

        Debug.Log("Time is almost up!");

        yield return new WaitForSeconds(attackDamageBoostDuration / 2);

        isAttackDamageBoosted = false;
    }
}
