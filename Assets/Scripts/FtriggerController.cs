<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FtriggerController : MonoBehaviour
{
    public TextMesh pressF;
    // Start is called before the first frame update
    void Start()
    {
        pressF.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(pressF.gameObject.activeSelf)
        {
            if(Input.GetKey(KeyCode.F))
            {
                Destroy(this.gameObject);
            }    
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        pressF.gameObject.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        pressF.gameObject.SetActive(false);
    }
}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FtriggerController : MonoBehaviour
{
    public TextMesh pressF;
    // Start is called before the first frame update
    void Start()
    {
        pressF.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(pressF.gameObject.activeSelf)
        {
            if(Input.GetKey(KeyCode.F))
            {
                Destroy(this.gameObject);
            }    
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        pressF.gameObject.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        pressF.gameObject.SetActive(false);
    }
}
>>>>>>> f1c7fa5... --all
