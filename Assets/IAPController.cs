using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAPController : MonoBehaviour
{
    public void OnPurchaseCompleted(string productId)
    {
        Debug.Log("Purchase");
    }
}
