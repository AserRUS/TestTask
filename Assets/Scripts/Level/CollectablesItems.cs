using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablesItems : MonoBehaviour
{
    private enum CollectibleItemType
    {
        Money,
        Alcohol
    }

    [SerializeField] private CollectibleItemType m_CollectibleItemType;
    [SerializeField] private GameObject m_SelectionEffect;

    private void OnTriggerEnter(Collider collision)
    {
        Player player = collision.transform.parent.GetComponent<Player>();
        if (player != null)
        {
            if (m_CollectibleItemType == CollectibleItemType.Money)
            {

            }
                
            else if (m_CollectibleItemType == CollectibleItemType.Alcohol)
            {

            }
                

            //Instantiate(m_SelectionEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }
}
