using UnityEngine;

public class ItemInteraction : MonoBehaviour
{
    private const string noItemMessage = "You don't have an item.";
    private const KeyCode useItemKey = KeyCode.F;

    private void Update()
    {
        if (Input.GetKeyDown(useItemKey))
        {
            Item item = GetComponentInChildren<Item>();
            Character character = GetComponent<Character>();

            if (item != null && character != null)
            {
                item.Use(character);
            }
            else
            {
                Debug.Log(noItemMessage);
            }
        }
    }
}
