using UnityEngine;

public class ClearCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player)
    {
        // if counter is clear
        if (!HasKitchenObject())
        {
            // Player is carrying something, put it on the clear top point
            if (player.HasKitchenObject())
                player.GetKitchenObject().SetKitchenObjectParent(this);
        }
        else
        {
            if (!player.HasKitchenObject())
                GetKitchenObject().SetKitchenObjectParent(player);
        }
    }

}