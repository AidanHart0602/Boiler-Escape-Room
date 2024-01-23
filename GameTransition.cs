using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTransition : MonoBehaviour
{
    [SerializeField]
    private Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame()
    {
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown() 
    {
        _anim.SetTrigger("OpenDoor");
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(1);
    }
}
