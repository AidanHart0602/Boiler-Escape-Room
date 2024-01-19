using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{

    private float _timer;
    private bool _exitRoomActive = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_exitRoomActive == true)
        {
            SceneManager.LoadScene(1);
        }
    }

    void ExitRoomActive()
    {
        _exitRoomActive = true;
    }
}
