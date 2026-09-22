using UnityEngine;
using UnityEngine.Purchasing;

public class IAPController : MonoBehaviour
{
    public void OnOrderPending(PendingOrder pendingOrder)
    {
        foreach (var item in pendingOrder.CartOrdered.Items())
        {
            if (item.Product.definition.id == "100Gold")
            {
                int currentGold = PlayerPrefs.GetInt("Gold", 0);
                currentGold += 100;
                PlayerPrefs.SetInt("Gold", currentGold);
                PlayerPrefs.Save();

                Debug.Log($"Заказ в процессе! Выдано 100 золота. Всего: {currentGold}");
            }
        }
    }
}