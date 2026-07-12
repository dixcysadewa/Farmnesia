using UnityEngine;
using UnityEngine.UI;

public class HotbarUI : MonoBehaviour
{
    [Header("Slot Icons")]
    public Image[] slotIcons;

    [Header("Tool Icons")]
    public Sprite hoe;
    public Sprite axe;
    public Sprite wateringCan;

    [Header("Seed Icons")]
    public Sprite chiliSeed;
    public Sprite carrotSeed;
    public Sprite tomatoSeed;
    public Sprite cornSeed;
    public Sprite potatoSeed;
    public Sprite cabbageSeed;

    private void Start()
    {
        // Pastikan jumlah slot 9
        if (slotIcons.Length < 9)
        {
            Debug.LogError("Jumlah Slot Icons harus 9!");
            return;
        }

        // Tools
        slotIcons[0].sprite = hoe;
        slotIcons[1].sprite = axe;
        slotIcons[2].sprite = wateringCan;

        // Seeds
        slotIcons[3].sprite = chiliSeed;
        slotIcons[4].sprite = carrotSeed;
        slotIcons[5].sprite = tomatoSeed;
        slotIcons[6].sprite = cornSeed;
        slotIcons[7].sprite = potatoSeed;
        slotIcons[8].sprite = cabbageSeed;
    }
}