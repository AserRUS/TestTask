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
    [SerializeField] private float value;
    private void OnTriggerEnter(Collider collision)
    {
        Player player = collision.transform.parent.GetComponent<Player>();
        if (player != null)
        {
            if (m_CollectibleItemType == CollectibleItemType.Money)
            {
                player.PickUpMoney(value);
            }
                
            else if (m_CollectibleItemType == CollectibleItemType.Alcohol)
            {
                player.PickUpAlcohol(value);
            }
                

            Destroy(gameObject);

        }
    }
}
