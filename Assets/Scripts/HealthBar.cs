using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{


    public static HealthBar instance;

    [SerializeField] private Image _fuelImage;
    [SerializeField, Range(0.1f, 5f)] private float _fuelDrainSpeed = 1f;
    [SerializeField] private float _maxhealth = 100f;

    private float _currenthealth;


    public void Awake() {
        if (instance == null)
        {
            instance = this;
        }
    }

   private void Start()
    {
        _currenthealth = _maxhealth;
        UpdateUI();
    }

    private void Update()
    {
        _currenthealth -= Time.deltaTime * _fuelDrainSpeed;
        UpdateUI();
    }
   public void UpdateUI(){
        _fuelImage.fillAmount = (_currenthealth / _maxhealth);
   }

}
