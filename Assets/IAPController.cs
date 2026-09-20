using UnityEngine;
using UnityEngine.Purchasing;

public class IAPController : MonoBehaviour
{
    public void OnPurchaseComplete(Product product)
    {
        if (product.definition.id == "100Gold")
        {
            int currentGold = PlayerPrefs.GetInt("Gold", 0);
            currentGold += 100;
            PlayerPrefs.SetInt("Gold", currentGold);
            PlayerPrefs.Save();

            Debug.Log($"Покупка успешна! Выдано 100 золота. Всего: {currentGold}");
        }
    }
}