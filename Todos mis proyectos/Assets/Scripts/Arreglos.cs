using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Arreglos : MonoBehaviour
{
    public GameObject panelAlertas;
    public string[] textoAlertas;

    public List<string> usuarios = new List<string>();

    public TMP_InputField nombreUsuario;
    public TMP_InputField nombreNuevoUsuario;
    public TMP_Text alertasDisplay;

    void Start() 
    {
        usuarios.Add(item:"Gerry");
        usuarios.Add(item:"Alan");
        usuarios.Add(item:"Pepe");
    }

    public void AccederConUsuario()
    {
        if(usuarios.Contains(nombreUsuario.text))
        {
            panelAlertas.SetActive(true);
            alertasDisplay.text = textoAlertas[0];
        }
        else
        {
            panelAlertas.SetActive(true);
            alertasDisplay.text = textoAlertas[1];
        }
    }

    public void CrearUsuario()
    {
        if (usuarios.Contains(nombreNuevoUsuario.text))
        {
            panelAlertas.SetActive(true);
            alertasDisplay.text = textoAlertas[2];
        }
        else
        {
            usuarios.Add(nombreNuevoUsuario.text);
            panelAlertas.SetActive(true);
            alertasDisplay.text = textoAlertas[3];
        }
    }


}
