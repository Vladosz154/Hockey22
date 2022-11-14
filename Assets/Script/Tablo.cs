using UnityEngine;
using UnityEngine.UI;
public class Tablo : MonoBehaviour
{
    public Text protivnik, personash;
    private int[] tablo = new int[2];
    public Transform tr,tr1;
    public GameObject panel, win, loose, bttn, bttn1, prot;
    void Update()
    {
        protivnik.text = tablo[0].ToString();
        personash.text = tablo[1].ToString();
        if (protivnik.text == "5" || personash.text == "5")
        {
            bttn.gameObject.SetActive(false);
            bttn1.gameObject.SetActive(false);
            panel.SetActive(true);
            if (protivnik.text == "5")
            {
                loose.SetActive(true);
                win.SetActive(false);
            }
            else
                if (personash.text == "5")
            {
                win.SetActive(true);
                loose.SetActive(false);
            }
            
        }
        
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
   
        if (other.gameObject.tag == "personash")
        {
            tablo[0] += 1;
            prot.transform.position = tr1.transform.position;
            transform.position = tr.transform.position;
        }
        else
            if (other.gameObject.tag == "protivnik")
        {
            tablo[1] += 1;
            
            transform.position = tr.transform.position;
        }

    }

}
