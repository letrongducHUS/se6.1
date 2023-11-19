using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnemy : MonoBehaviour
{
    private Vector3 mypos;
    public GameObject Bullets;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Flesh")
        {
            Debug.Log("EnemyDetected");
            other.gameObject.GetComponentInParent <CharacterDamage>().ApplyDamage(1000, mypos, Camera.main.transform.position, transform, true, false);
            Destroy(Bullets, 0.2f);
        }

        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("EnemyDetected");
            other.transform.gameObject.GetComponent<DarkTreeFPS.NPC>().GetHit(1000);
            Destroy(Bullets, 0.2f);
        }
    }
}
