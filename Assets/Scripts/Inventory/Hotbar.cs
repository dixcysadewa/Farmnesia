using UnityEngine;

public class Hotbar : MonoBehaviour
{
    [SerializeField] private GameObject[] highlights;

    [Header("Item di tiap Slot")]
    public ItemType[] slotItems = new ItemType[9];

    private int currentSlot = 0;

    private void Start()
    {
        // Slot 1
        slotItems[0] = ItemType.Hoe;

        // Slot 2
        slotItems[1] = ItemType.Axe;

        // Slot 3
        slotItems[2] = ItemType.WateringCan;

        // Slot 4
        slotItems[3] = ItemType.ChiliSeed;

        // Slot 5
        slotItems[4] = ItemType.CarrotSeed;

        // Slot 6
        slotItems[5] = ItemType.TomatoSeed;

        // Slot 7
        slotItems[6] = ItemType.CornSeed;

        // Slot 8
        slotItems[7] = ItemType.PotatoSeed;

        // Slot 9
        slotItems[8] = ItemType.CabbageSeed;

        SelectSlot(0);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) SelectSlot(0);
        if (Input.GetKeyDown(KeyCode.Alpha2)) SelectSlot(1);
        if (Input.GetKeyDown(KeyCode.Alpha3)) SelectSlot(2);
        if (Input.GetKeyDown(KeyCode.Alpha4)) SelectSlot(3);
        if (Input.GetKeyDown(KeyCode.Alpha5)) SelectSlot(4);
        if (Input.GetKeyDown(KeyCode.Alpha6)) SelectSlot(5);
        if (Input.GetKeyDown(KeyCode.Alpha7)) SelectSlot(6);
        if (Input.GetKeyDown(KeyCode.Alpha8)) SelectSlot(7);
        if (Input.GetKeyDown(KeyCode.Alpha9)) SelectSlot(8);
    }

    private void SelectSlot(int index)
    {
        currentSlot = index;

        for (int i = 0; i < highlights.Length; i++)
        {
            highlights[i].SetActive(i == currentSlot);
        }
    }

    public ItemType GetCurrentItem()
    {
        return slotItems[currentSlot];
    }
}