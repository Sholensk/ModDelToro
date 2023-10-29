using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuOpciones : MonoBehaviour
{
    //Variables Volumen
    public Slider slider;
    public float ValorSlider;
    // Variables Brillo
    public Slider slider2;
    public float sliderValue;
    public Image panelBrillo;
    public float valorBlack;
    public float valorWhite;
    //Variables Pantalla Completa
    //public Toggle toggle;
    // Variables Calidad
    public TMP_Dropdown dropdown;
    public int calidad;

    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
        AudioListener.volume =slider.value;
        //
        slider2.value = PlayerPrefs.GetFloat("Brillo", 0.5f);
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, sliderValue / 3);
        //
        /*if (Screen.fullScreen)
        {
            toggle.isOn = true;
        }
        else
        {
             toggle.isOn = false;
        }*/
        //
        calidad = PlayerPrefs.GetInt("numerodecalidad", 3);
        dropdown.value = calidad;
        AjustarCalidad();
    }

    private void Update()
    {
        valorBlack = 1 - sliderValue - 0.5f;
        valorWhite = sliderValue - 0.5f;
        if (sliderValue < 0.5f)
        {
            panelBrillo.color = new Color(0, 0, 0, valorBlack);
        }
        if (sliderValue > 0.5f)
        {
            panelBrillo.color = new Color(255, 255, 255, valorWhite);
        }
    }

    public void CambiarSlider(float valor)
    {
        ValorSlider = valor;
        PlayerPrefs.SetFloat("volumenAudio", ValorSlider);
        AudioListener.volume = slider.value;
    }

    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("Brillo", sliderValue);
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, sliderValue / 3);
    }

    /*public void ActivarPantalla(bool PantallaCompleta)
    {
        Screen.fullScreen = PantallaCompleta;  
    }*/

    public void AjustarCalidad()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("numerodecalidad", dropdown.value);
        calidad = dropdown.value;
    }
}
