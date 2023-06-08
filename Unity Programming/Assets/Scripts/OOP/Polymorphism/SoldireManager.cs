using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoldireManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> soldires;
    [SerializeField] private Text cText;
    [SerializeField] private Button moveBtn;
    [SerializeField] private Button standBtn;
    [SerializeField] private Button acttack;

    private GameObject selectedC;

    void Start()
    {
        SelectCharcter(0);
    }

    public void SelectCharcter(int index)
    {
        selectedC = soldires[index];
        cText.text = selectedC.gameObject.name;

        ClearListners();

        if (index == 0)
        {
            Swardsman swardsMan = selectedC.GetComponent<Swardsman>();
            moveBtn.onClick.AddListener(swardsMan.Walk);
            standBtn.onClick.AddListener(swardsMan.Sprint);
            acttack.onClick.AddListener(swardsMan.Attack);
        }
        else if (index == 1)
        {
            Archer archer = selectedC.GetComponent<Archer>();
            moveBtn.onClick.AddListener(archer.Walk);
            standBtn.onClick.AddListener(archer.Sprint);
            acttack.onClick.AddListener(archer.Attack);
        }
    }

    private void ClearListners()
    {
        moveBtn.onClick.RemoveAllListeners();
        standBtn.onClick.RemoveAllListeners();
        acttack.onClick.RemoveAllListeners();
    }
}
