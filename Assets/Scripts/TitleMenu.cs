using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{

    [SerializeField] private GameObject titlePanel;
    [SerializeField] private GameObject cat;
    [SerializeField] private GameObject slug;
    [SerializeField] private GameObject horse;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButtonClickedCallback()
    {
        titlePanel.SetActive(false);
        cat.SetActive(true);
        horse.SetActive(true);
        slug.SetActive(true);


    }
}
