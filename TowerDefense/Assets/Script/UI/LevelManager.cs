
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;
    public GameObject startPoint;
    public GameObject[] path;
    public string direction;
    private void Awake()
    {
        main = this;
    }
}
