using System;

public class TrashCounter : BaseCounter
{
    public static event EventHandler OnObjectTrashed;

    public override void Interact(Player player)
    {
        if (player.HasKitchenObject())
        {
            player.GetKitchenObject().DestroySelf();
            OnObjectTrashed?.Invoke(this, EventArgs.Empty);
        }
    }

}
