using UnityEngine;
using UnityEngine.UI;

public class monstersScore : MonoBehaviour
{
    public int monstersNum = 8;

    [SerializeField] GameObject openDoor;
    [SerializeField] GameObject closedDoor;
    [SerializeField] private Text monsters_Num;
    void Update()
    {
        monsters_Num.text = monstersNum.ToString();

        if(monstersNum == 0)
        {
            openDoor.SetActive(true);
            closedDoor.SetActive(false);
        }
    }
}
