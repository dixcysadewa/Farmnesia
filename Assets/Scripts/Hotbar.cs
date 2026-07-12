using UnityEngine;

public class Hotbar : MonoBehaviour
{
    [SerializeField] private GameObject[] highlights;

    private int currentSlot = 0;

    private void Start()
    {
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

    public int GetCurrentSlot()
    {
        return currentSlot;
    }
}