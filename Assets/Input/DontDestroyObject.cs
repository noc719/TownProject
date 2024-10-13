using UnityEngine;

public class DontDestroyObject : MonoBehaviour
{
    public static int pchar = 0;
    public static string pname = "player";

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}