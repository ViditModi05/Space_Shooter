using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageEffect : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Image damageEffect;

    [Header("Settings")]
    [SerializeField] private float damageAlpha = .2f;
    [SerializeField] private float damageFadeSpeed = .5f;

    public static DamageEffect instance;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(damageEffect.color.a != 0)
        {
            damageEffect.color = new Color(damageEffect.color.r, damageEffect.color.g, damageEffect.color.b, 
            Mathf.MoveTowards(damageEffect.color.a, 0f, damageFadeSpeed * Time.deltaTime)); //transitioning the alpha value back to 0
        }
        
    }

    public void ShowDamageEffect()
    {
        damageEffect.color = new Color(damageEffect.color.r, damageEffect.color.g, damageEffect.color.b, damageAlpha); //Changing the alpha value whenever player takes damage
    }
}
