using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Formularios : MonoBehaviour
{
    public GameObject panelAlertas;
    public string[] textoAlertas;

    public List<string> usuarios = new List<string>();
    public List<string> contrasena = new List<string>();

    public TMP_InputField nombreUsuario;
    public TMP_InputField nombreNuevoUsuario;
    public TMP_InputField ContrasenaNueva;
    public TMP_InputField Contrasena;
    public TMP_Text alertasDisplay;
    public Image PanelAcceder;
    public Image Pantallaprincipal;

    void Start()
    {
        usuarios.Add(item: "Carlo");
        usuarios.Add(item: "Bonnie");
        contrasena.Add(item: "12345");
        contrasena.Add(item: "54321");
    }

    public void AccederConUsuario()
    {
        if(usuarios.Contains(nombreUsuario.text))
        {
            panelAlertas.SetActive(true);
            PanelAcceder.gameObject.SetActive(false);
            Pantallaprincipal.gameObject.SetActive(true);

            alertasDisplay.text = textoAlertas[0];
        }
        else
        {
            panelAlertas.SetActive(true);
            alertasDisplay.text = textoAlertas[0];
        }
    }

    public void CrearUsuario()
    {
        if (usuarios.Contains(nombreNuevoUsuario.text))
        {
            panelAlertas.SetActive(true);
            alertasDisplay.text = textoAlertas[1];
        }
        else
        {
            usuarios.Add(nombreNuevoUsuario.text);
            panelAlertas.SetActive(true);
            alertasDisplay.text = textoAlertas[2];
        }
    }

    public void ContrasenaUsuario()
    {
        if (contrasena.Contains(Contrasena.text))
        {
            panelAlertas.SetActive(true); 
        }
        else
        {
            panelAlertas.SetActive(true);
            alertasDisplay.text = textoAlertas[3];
        }
    }

    public void CrearContrasena()
    {
        if (contrasena.Contains(ContrasenaNueva.text))
        {
            panelAlertas.SetActive(true);
        }
        else
        {
            contrasena.Add(ContrasenaNueva.text);
            panelAlertas.SetActive(true);
        }
    }
}
