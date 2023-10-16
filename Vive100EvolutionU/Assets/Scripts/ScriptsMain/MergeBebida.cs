using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class MergeBebida : MonoBehaviour
{
    int ID;
    public GameObject MergedObject;
    public float Distance;
    public float MergeSpeed;

    void Start()
    {
        ID = GetInstanceID();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bebidas") && collision.gameObject.GetComponent<SpriteRenderer>().material == GetComponent<SpriteRenderer>().material)
        {
            if (ID < collision.gameObject.GetComponent<MergeBebida>().ID) { return; }
            Destroy(collision.gameObject);
            Destroy(gameObject);

            Vector3 mergedPosition = (transform.position + collision.gameObject.transform.position) / 2;
            GameObject merged = Instantiate(MergedObject, mergedPosition, Quaternion.identity);

            merged.GetComponent<Rigidbody2D>().velocity = MergeSpeed * (mergedPosition - transform.position);
        }
    }
}

