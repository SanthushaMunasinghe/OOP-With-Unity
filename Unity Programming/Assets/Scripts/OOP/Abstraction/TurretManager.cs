using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurretManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> Turrets;
    [SerializeField] private Text tText;
    [SerializeField] private Button aimBtn;
    [SerializeField] private Button shootBtn;

    private GameObject selectedT;

    void Start()
    {
        SelectTurret(0);
    }

    public void SelectTurret(int index)
    {
        selectedT = Turrets[index];
        tText.text = selectedT.gameObject.name;

        ClearListners();

        if (index == 0)
        {
            CrossbowTurret crossbow = selectedT.GetComponent<CrossbowTurret>();
            aimBtn.onClick.AddListener(crossbow.CrossbowAim);
            shootBtn.onClick.AddListener(crossbow.Shoot);
        }
        else if (index == 1)
        {
            CatapultTurret catapult = selectedT.GetComponent<CatapultTurret>();
            aimBtn.onClick.AddListener(catapult.CatapultAim);
            shootBtn.onClick.AddListener(catapult.Shoot);
        }
    }

    private void ClearListners()
    {
        aimBtn.onClick.RemoveAllListeners();
        shootBtn.onClick.RemoveAllListeners();
    }
}
