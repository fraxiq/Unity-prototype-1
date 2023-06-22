using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FollowPlayer2 : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private Vector3 offset = new Vector3(0, 4.5f, -11);
    private Vector3 Fronwview = new Vector3(0, 2, 0.3f);
    private Vector3 Currentview;
    // Start is called before the first frame update
    void Start()
    {
        Currentview = offset;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            SwitchView();
        }
        transform.position = player.transform.position + Currentview;
    }
    private void SwitchView()
    {
        if (Currentview == offset)
        {
            Currentview = Fronwview;
            transform.SetParent(player.transform);
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
        else
        {
            Currentview = offset;
            transform.SetParent(null);
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }
}
