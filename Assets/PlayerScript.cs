using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    const int myForce = 50;
    Rigidbody rb;
    int score = 0;
    public Text countText;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()

    {
        float Zforce = Input.GetAxis("Vertical");
        
        float Xforce = Input.GetAxis("Horizontal");
        Vector3 PlayerForce = new Vector3(Xforce, 0, Zforce);

        rb.AddForce(PlayerForce * myForce);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            score += 1;
            countText.text = score.ToString();
            
        }
    }
}
