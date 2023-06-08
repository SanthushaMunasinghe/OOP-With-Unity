using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> Characters;
    [SerializeField] private Text cText;
    [SerializeField] private Button moveBtn;
    [SerializeField] private Button standBtn;
    [SerializeField] private Button actionBtn;

    private GameObject selectedC;

    void Start()
    {
        SelectCharcter(0);
    }

    public void SelectCharcter(int index)
    {
        selectedC = Characters[index];
        cText.text = selectedC.gameObject.name;

        ClearListners();

        if (index == 0)
        {
            Farmer farmer = selectedC.GetComponent<Farmer>();
            moveBtn.onClick.AddListener(farmer.MovingEvent);
            standBtn.onClick.AddListener(farmer.StandingEvent);
            actionBtn.onClick.AddListener(farmer.Farming);
        }
        else if (index == 1)
        {
            Fisherman fisherman = selectedC.GetComponent<Fisherman>();
            moveBtn.onClick.AddListener(fisherman.MovingEvent);
            standBtn.onClick.AddListener(fisherman.StandingEvent);
            actionBtn.onClick.AddListener(fisherman.Fishing);
        }
    }

    private void ClearListners()
    {
        moveBtn.onClick.RemoveAllListeners();
        standBtn.onClick.RemoveAllListeners();
        actionBtn.onClick.RemoveAllListeners();
    }
}
