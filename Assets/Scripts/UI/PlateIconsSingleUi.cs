using UnityEngine;
using UnityEngine.UI;

public class PlateIconsSingleUi : MonoBehaviour
{
    [SerializeField] private Image image;

    public void SetKitchenObjectSO(KitchenObjectSO kitchenObjectSO)
    {
        image.sprite = kitchenObjectSO.sprite;
    }
}
