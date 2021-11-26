using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    private Image HealthBar;
    public float currentHealth;
    public float maxHealth = 100f;
    PlayerController player;
    // Start is called before the first frame update
    public void Start()
    {
        HealthBar = GetComponent<Image>();
        player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    public void Update()
    {
        HealthBar.fillAmount = currentHealth / maxHealth;

    }
}
